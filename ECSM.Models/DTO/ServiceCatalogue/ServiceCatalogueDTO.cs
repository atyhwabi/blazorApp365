namespace ECSM.Models.DTO.ServiceCatalogue
{
  using ECSM.Models.DTO.Category;
  using Newtonsoft.Json;

  public class ServiceCatalogueDTO
  {
    [JsonProperty("ecsm_service_catalogue_itemid")]
    public Guid ServiceCatalogueID { get; set; }

    [JsonProperty("ecsm_name")]
    public string Name { get; set; } = string.Empty;

    public int TileLayout { get; set; }

    public string Description { get; set; } = string.Empty;

    public string IconCode { get; set; } = string.Empty;

    public List<UserRoleDTO> PortalRoles { get; set; } = new List<UserRoleDTO>();

    public List<CategoryDTO> Categories { get; set; } = new List<CategoryDTO>();
  }
}
