namespace ECSM.Services.SettingsService
{
  using EC.DynamicsClient;
  using Models.DTO;
  using Models.Dynamics;
  using Microsoft.Extensions.Configuration;
  using System.Net;
  using System.Text.Json;

  public class SettingsService(IDynamicsCachedQueryClient queryClient, IConfiguration configuration) : ISettingsService
  {
    private readonly IDynamicsCachedQueryClient _queryClient = queryClient.ThrowIfNull();
    readonly IConfiguration _configuration = configuration.ThrowIfNull();

    /// <summary>
    /// Gets a Setting by name
    /// </summary>
    /// <returns>Setting</returns>
    /// <exception cref="FailedStatusCodeException"></exception>
    public async Task<SettingsDTO?> GetSettingByName(string name)
    {
      try
      {
        var entityCollection = await _queryClient.Get<ecsm_setting>(ecsm_settingField.LogicalCollectionName
            .Query()
            .Where([
                ecsm_settingField.ecsm_Name.Equal(name),
                        ecsm_portal_roleField.statecode.Equal(ecsm_portal_role_statecode.Active)
            ])
            .Select([
                ecsm_settingField.ecsm_value,
                        ecsm_settingField.ecsm_Name
            ])
            .Build()).ConfigureAwait(false);

        if (entityCollection is null or { Entities: null or { Length: < 1 } })
        {
          return null;
        }

        return entityCollection.Entities
                .Select(e => new SettingsDTO
                {
                  Name = e.ecsm_Name,
                  Value = e.ecsm_value
                }).FirstOrDefault();
      }
      catch (FailedStatusCodeException exception)
      when (exception.Response.StatusCode is HttpStatusCode.InternalServerError)
      {
        throw new Exception(exception.Message);
      }
    }

    public async Task<List<SettingsDTO>> GetAllSetting()
    {
      try
      {
        var entityCollection = await _queryClient.Get<ecsm_setting>(ecsm_settingField.LogicalCollectionName
          .Query()
          .Where([
            ecsm_portal_roleField.statecode.Equal(ecsm_portal_role_statecode.Active)
          ])
          .Select([
            ecsm_settingField.ecsm_value,
            ecsm_settingField.ecsm_Name
          ])
          .Build()).ConfigureAwait(false);

        if (entityCollection is null or { Entities: null or { Length: < 1 } })
        {
          return [];
        }

        return entityCollection.Entities
          .Select(e => new SettingsDTO
          {
            Name = e.ecsm_Name,
            Value = e.ecsm_value
          }).ToList();
      }
      catch (FailedStatusCodeException exception)
        when (exception.Response.StatusCode is HttpStatusCode.InternalServerError)
      {
        throw new Exception(exception.Message);
      }
    }

    public async Task<SettingsDTO> GetSettingByNameForLogoAsync(string name)
    {
      try
      {
        var entityCollection = await FetchEntityCollectionAsync(name).ConfigureAwait(false);

        if (entityCollection?.Entities == null || entityCollection.Entities.Length < 1)
        {
          return new SettingsDTO();
        }

        var dbSetting = entityCollection.Entities.FirstOrDefault();
        var setting = new SettingsDTO
        {
          Name = dbSetting?.ecsm_Name ?? string.Empty,
          Value = "Image File",
        };

        return await PopulateSettingWithFileDataAsync(dbSetting?.ecsm_settingId, setting).ConfigureAwait(false);
      }
      catch (FailedStatusCodeException exception) when (exception.Response.StatusCode == HttpStatusCode.InternalServerError)
      {
        throw new Exception(exception.Message, exception);
      }
    }

    private async Task<IEntityCollection<ecsm_setting>> FetchEntityCollectionAsync(string name)
    {
      return await _queryClient.Get<ecsm_setting>(ecsm_settingField.LogicalCollectionName
          .Query()
          .Where(
          [
            ecsm_settingField.ecsm_Name.Equal(name),
            ecsm_portal_roleField.statecode.Equal(ecsm_portal_role_statecode.Active)
          ])
          .Select(
          [
            ecsm_settingField.ecsm_LogoValue,
            ecsm_settingField.ecsm_Name,
            ecsm_settingField.ecsm_settingId
          ])
          .Build()).ConfigureAwait(false) ?? new EntityCollection<ecsm_setting>();
    }

    private async Task<string> GetContentBlockFileBase64Async(Guid? contentBlockId)
    {
      var url = new Uri($"{_configuration["DynamicsServiceEndpoint"]}{ecsm_settingField.EntitySetName}({contentBlockId})/{ecsm_settingField.ecsm_LogoValue}");
      var response = await _queryClient.Get<Dictionary<string, object>>(new EntityUrlQuery(url)).ConfigureAwait(false);

      return response?["value"].ToString() ?? string.Empty;
    }

    private async Task<SettingsDTO> PopulateSettingWithFileDataAsync(Guid? contentBlockId, SettingsDTO settingsDto)
    {
      var fileDetails = await FetchFileDetailsAsync(contentBlockId).ConfigureAwait(false);

      settingsDto.FileData = new File
      {
        Base64String = await GetContentBlockFileBase64Async(contentBlockId).ConfigureAwait(false),
        FileName = fileDetails.FirstOrDefault()?.FileName ?? string.Empty,
        MimeType = fileDetails.FirstOrDefault()?.MimeType ?? string.Empty
      };

      return settingsDto;
    }

    private async Task<List<FileData>> FetchFileDetailsAsync(Guid? contentBlockId)
    {
      var url = new Uri($"{_configuration["DynamicsServiceEndpoint"]}{ecsm_settingField.EntitySetName}({contentBlockId})?$filter={ecsm_settingField.ecsm_LogoValue} ne null&$expand={ecsm_settingField.LogicalName}_FileAttachments($select=createdon,mimetype,filesizeinbytes,filename,regardingfieldname)&$select={ecsm_settingField.ecsm_LogoValue}");
      var response = await _queryClient.Get<Dictionary<string, object>>(new EntityUrlQuery(url)).ConfigureAwait(false);

      var jsonString = response?["ecsm_setting_FileAttachments"]?.ToString();
      if (string.IsNullOrEmpty(jsonString))
      {
        return [];
      }

      var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
      return JsonSerializer.Deserialize<List<FileData>>(jsonString, options) ?? [];
    }

  }
}
