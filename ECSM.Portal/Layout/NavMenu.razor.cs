namespace ECSM.Portal.Layout
{
  using Models.DTO;
  using Models.DTO.PortalLink;
  using Services.PortalLink;
  using Microsoft.AspNetCore.Components;
  using System.Threading.Tasks;
  using Services.SettingsService;

  public partial class NavMenu : ComponentBase
  {
    [Inject]
    private IPortalLinkService PortalLinkService { get; set; } = default!;
    [Inject]
    public ISettingsService SettingsService { get; set; } = default!;

    public SettingsDTO Settings { get; set; } = new();
    public string Logo { get; set; } = string.Empty;

    private AuthModel AuthModel { get; set; } = new ();
    private List<PortalLinkDTO> portalLinkDtOs = [];
    private bool isAuthenticated = false;
    private bool isCollapsed = true;
    private bool isDropdownCollapsed = false;
    private bool isLogoutCollapsed = false;

    protected override async Task OnInitializedAsync()
    {
      await base.OnInitializedAsync();
      AuthModel = await authManager.GetAuthState();
      portalLinkDtOs = await PortalLinkService.GetPortalLinks();

      this.isAuthenticated = AuthModel.IsAuthenticated;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
      if (firstRender)
      {
        Settings = await this.SettingsService.GetSettingByNameForLogoAsync("LogoPrimary");
        Logo = $"data:{Settings.FileData?.MimeType};base64,{Settings.FileData?.Base64String}";
        StateHasChanged();
      }
      await base.OnAfterRenderAsync(firstRender);
    }


    private void ToggleNavMenu()
    {
      isCollapsed = !isCollapsed;
    }

    private void ToggleDropdownMenu()
    {
      isDropdownCollapsed = !isDropdownCollapsed;
      if (isDropdownCollapsed)
      {
        isLogoutCollapsed = false;
      }
    }

    private void ToggleLogoutMenu()
    {
      isLogoutCollapsed = !isLogoutCollapsed;
      if (isLogoutCollapsed)
      {
        isDropdownCollapsed = false;
      }
    }

    public async Task LogOut()
    {
      await authManager.RemoveFromCache();
      navigationManager.NavigateTo($"/Authentication/SignOut?scheme={AuthModel.IDP}", forceReload: true);
    }

    public void NavigateTo(string uri)
    {
      navigationManager.NavigateTo(uri, ispublic: navigationManager.GetUri().Contains("public"));
    }
  }
}
