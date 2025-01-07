using Microsoft.AspNetCore.Components;

namespace ECSM.Portal.Managers
{
    public class NavManager : ComponentBase
    {
        public NavManager(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        protected NavigationManager navigationManager { get; }

        public void NavigateTo(string uri, bool forceReload = false, bool ispublic = false)
        {
            if (!ispublic)
                navigationManager.NavigateTo(uri, forceReload);
            else if(uri.Equals("/"))
                navigationManager.NavigateTo($"/public/Home", forceReload);
            else if(uri.StartsWith('/'))
                navigationManager.NavigateTo($"/public{uri}", forceReload);
            else
                navigationManager.NavigateTo($"/public/{uri}", forceReload);
        }

        public string GetUri()
        {
            return navigationManager.Uri;
        }

        public bool UriEndsWith(string value)
        {
            return navigationManager.Uri.ToLower().EndsWith(value.ToLower());
        }

        public bool UriContains(string value)
        {
            return navigationManager.Uri.ToLower().Contains(value.ToLower());
        }
    }
}
