namespace ECSM.Portal.Pages
{
  using Models.DTO.Announcement;
  using Services;
  using Microsoft.AspNetCore.Components;

  public partial class Home
  {
    [Parameter]
    public string publicParameter { get; set; }

    [Inject]
    IAnnouncementQueryService announcementQueryService { get; set; }

    AnnouncementDTO[] announcements { get; set; } = [];

    protected override async Task OnInitializedAsync()
    {
      await base.OnInitializedAsync();

      announcements = await announcementQueryService.GetAnnouncementsForHome();

    }
  }
}
