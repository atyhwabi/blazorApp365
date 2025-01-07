using ECSM.Models.DTO;
using Microsoft.AspNetCore.Components;

namespace ECSM.Portal.Components.UI.InformationList
{
    public partial class MyCasesComponent
    {
        [Parameter]
        public CasesItemDTO[] Cases { get; set; } = [];

        protected override async Task OnAfterRenderAsync(bool firstReder)
        {
            if (firstReder)
            {
                var AuthModel = await authManager.GetAuthState();
                Cases = await caseService.GetCasesByContactID(AuthModel.Contact.ContactID.ToString());
                await InvokeAsync(StateHasChanged);
            }
        }

        private void navCasePage(string caseID)
        {
            navigationManager.NavigateTo($"/case/{caseID}");
        }

        private void navMyCasesPage()
        {
            navigationManager.NavigateTo("/mycases");
        }
    }
}
