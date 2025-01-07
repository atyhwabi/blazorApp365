using EC.DynamicsClient;
using ECSM.Models.DTO;
using ECSM.Services.Cases;
using Microsoft.AspNetCore.Components;
using Telerik.Blazor.Components;

namespace ECSM.Portal.Components.Cases
{
    public partial class CasesGridComponent : ComponentBase
    {
        [Inject]
        ICaseService caseService { get; set; }

        public CasesItemDTO [] myCases;

        int PageSize { get; set; } = 5;
        int CurrentPage { get; set; } = 1;
        protected List<int?> PageSizes { get; set; } = new List<int?> { 5, 10};

        AuthModel authModel = new AuthModel();

        protected override async Task OnInitializedAsync()
        {
            authModel = await authManager.GetAuthState();

            myCases = await caseService.GetCasesAllByContactID(authModel?.Contact?.ContactID.Value.ToString());
        }

        public void OnRowClickHandler(GridRowClickEventArgs args)
        {
            dynamic clickedItem = args.Item;

            navigationManager.NavigateTo($"/case/{clickedItem.CaseId}");
        }
    }
}
