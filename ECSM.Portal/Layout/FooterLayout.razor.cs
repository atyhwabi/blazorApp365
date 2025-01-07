namespace ECSM.Portal.Layout
{
  using Models.DTO;
  using Services.SettingsService;
  using Microsoft.AspNetCore.Components;

  public partial class FooterLayout : ComponentBase
  {
    [Inject]
    public ISettingsService SettingsService { get; set; } = default!;
    public SettingsDTO Settings { get; set; } = new();
    public string Logo { get; set; } = string.Empty;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
      if (firstRender)
      {
        Settings = await this.SettingsService.GetSettingByNameForLogoAsync("LogoSecondary");
        Logo = $"data:{Settings.FileData?.MimeType};base64,{Settings.FileData?.Base64String}";
        StateHasChanged();
      }
      await base.OnAfterRenderAsync(firstRender);
    }
  }
}
