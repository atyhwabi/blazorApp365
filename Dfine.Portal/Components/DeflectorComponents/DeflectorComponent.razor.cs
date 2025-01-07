using ECSM.Models.DTO.Deflector;
using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Models.DTO;
using ECSM.Services.Cases;
using Microsoft.AspNetCore.Components;
using Telerik.Blazor.Components;
using ECSM.Models.DTO.TreeView;
using ECSM.Services.ServiceCatalogue;
using ECSM.Models.DTO.Category;
using Microsoft.AspNetCore.Components.Web;

namespace ECSM.Portal.Components.DeflectorComponents
{
    public partial class DeflectorComponent
    {
        [Inject]
        public IServiceCatalogueService ServiceCatalogueService { get; set; }

        [Parameter]
        public string publicParameter { get; set; }

        [Parameter]
        public string ServiceCatalogueId { get; set; }
        public string searchValue { get; set; }

        public Guid? SelectedServiceCatalogueId { get; set; }

        public Guid? SelectedCategoryId { get; set; }

        [Parameter]
        public string? CategoryID { get; set; }

        private AuthModel? authModel { get; set; }

        private List<ServiceCatalogueDTO> serviceCatalogues { get; set; } = new();

        private List<ServiceCatalogueDTO> filteredServiceCatalogues { get; set; } = new();

        private DeflectorManagerDTO deflectorManagerDTO { get; set; } = new();

        private Guid? SelectedServiceCatalogueItemId { get; set; }

        protected override async void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                GetAndSetUserInfo();
                await GetAndSetServiceCatalogues();
                if (ServiceCatalogueId != null)
                {

                    if (authModel != null)
                    {
                        SelectedServiceCatalogueId = Guid.Parse(ServiceCatalogueId);

                        if (CategoryID != null)
                        {
                            SelectedCategoryId = Guid.Parse(CategoryID!);
                        }
                        SetDeflectorItems((Guid)SelectedServiceCatalogueId);
                    }
                }
            }
        }

        private async void GetAndSetUserInfo()
        {
            authModel = await authManager.GetAuthState();
        }

        private async Task GetAndSetServiceCatalogues()
        {
            serviceCatalogues = await ServiceCatalogueService.GetServiceCataloguesWithCategories(authModel!.Roles);
            filteredServiceCatalogues = serviceCatalogues;
            StateHasChanged();
        }

        public void HandleItemClick(TreeViewItemClickEventArgs args)
        {
            searchValue = string.Empty;
            SelectedServiceCatalogueItemId = null;
            var item = args.Item as TreeItem;
            if (item != null)
            {
                if (!item.IsCategory)
                {
                    SelectedServiceCatalogueId = item.Id;
                    SelectedCategoryId = null;
                    SetDeflectorItems((Guid)SelectedServiceCatalogueId);
                }
                else
                {
                    SelectedCategoryId = item.Id;
                    SetDeflectorItems((Guid)SelectedServiceCatalogueId);
                }
            }
            StateHasChanged();
        }

        public void OnDeflectorItemClick(DeflectorItem deflectorItem)
        {
            if (deflectorItem.IsCategory)
            {
                SelectedCategoryId = deflectorItem.CategoryId;
                deflectorManagerDTO.SelectedCategoryId = deflectorItem.CategoryId;
                SelectedServiceCatalogueItemId = null;
                StateHasChanged();
            }
            else
            {
                SelectedCategoryId = deflectorItem.CategoryId;
                deflectorManagerDTO.SelectedCategoryId = deflectorItem.CategoryId;
                SelectedServiceCatalogueItemId = deflectorItem.ServiceCatalogueItemId;
            }
        }

        public void FilterDeflectorPage(object searchString)
        {
            var searchValue = searchString != null ? searchString.ToString()!.ToLower() : string.Empty;
            filteredServiceCatalogues = serviceCatalogues;

            if (!string.IsNullOrEmpty(searchValue))
            {
                var matchedCatalogues = new List<ServiceCatalogueDTO>();

                foreach (var catalogue in serviceCatalogues)
                {
                    var matchedCategories = new List<CategoryDTO>();

                    foreach (var category in catalogue.Categories)
                    {
                        // Check if category or any of its child categories match the search term
                        if (CategoryMatchesSearchTerm(category, searchValue))
                        {
                            matchedCategories.Add(category);
                        }
                    }

                    if (matchedCategories.Any())
                    {
                        var newCatalogue = new ServiceCatalogueDTO
                        {
                            ServiceCatalogueID = catalogue.ServiceCatalogueID,
                            Name = catalogue.Name,
                            Description = catalogue.Description,
                            IconCode = catalogue.IconCode,
                            PortalRoles = catalogue.PortalRoles,
                            Categories = matchedCategories
                        };

                        matchedCatalogues.Add(newCatalogue);
                    }
                }

                filteredServiceCatalogues = matchedCatalogues;
            }

            StateHasChanged();
        }
        private bool CategoryMatchesSearchTerm(CategoryDTO category, string searchTerm)
        {
            // Check if the current category matches the search term
            if (category.Name.ToLower().Contains(searchTerm) || category.Description.ToLower().Contains(searchTerm))
            {
                return true;
            }

            // Recursively check if any child categories match the search term
            foreach (var childCategory in category.ChildCategoryDTOs)
            {
                if (CategoryMatchesSearchTerm(childCategory, searchTerm))
                {
                    return true;
                }
            }

            // If no match is found, check if the category itself is a child of a matching category
            if (category.ParentCategory != null &&
                (category.ParentCategory.Name.ToLower().Contains(searchTerm) || category.ParentCategory.Description.ToLower().Contains(searchTerm)))
            {
                return true;
            }

            return false;
        }

        public void SetDeflectorItems(Guid serviceCatalogueId)
        {
            var categories = serviceCatalogues.Find(sc => sc.ServiceCatalogueID == serviceCatalogueId)?.Categories;

            var serviceCatalogueItems = categories.Select(c => c.ServiceCatalogueItems).ToList();

            var deflectorItems = new List<DeflectorItem>();

            foreach (var item in categories)
            {
                deflectorItems.Add(new DeflectorItem
                {
                    CategoryId = item.CategoryID,
                    Name = item.Name,
                    Description = item.Description,
                    IconCode = item.IconCode,
                    ServiceCatalogueId = item.ServiceCatalogueId,
                    IsCategory = true,
                    ParentCategoryId = item.ParentCategoryId,
                    ParentCategory = item.ParentCategory,
                    TileLayout = item.TileLayout,
                });
            }

            foreach (var item in serviceCatalogueItems)
            {
                foreach (var serviceCatalogueItem in item)
                {
                    deflectorItems.Add(new DeflectorItem
                    {
                        CategoryId = serviceCatalogueItem.CategoryId,
                        ServiceCatalogueItemId = serviceCatalogueItem.ServiceCatalogueItemId,
                        Name = serviceCatalogueItem.Name,
                        Description = serviceCatalogueItem.Description,
                        IconCode = serviceCatalogueItem.IconCode,
                        ServiceCatalogueId = serviceCatalogueItem.ServiceCatalogueId,
                        IsCategory = false,
                    });
                }
            }

            deflectorManagerDTO.DeflectorItems = deflectorItems;
            deflectorManagerDTO.ServiceCatalogue = serviceCatalogues.Find(sc => sc.ServiceCatalogueID == serviceCatalogueId)!;
            deflectorManagerDTO.SelectedCategoryId = SelectedCategoryId;
            StateHasChanged();
        }

    }
}
