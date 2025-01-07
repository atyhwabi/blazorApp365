using ECSM.Models.DTO;
using ECSM.Models.DTO.Category;
using ECSM.Models.DTO.Deflector;
using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Models.DTO.TreeView;
using ECSM.Services.Category;

using Microsoft.AspNetCore.Components;
using Telerik.Blazor.Components;

namespace ECSM.Portal.Pages
{
    public partial class PublicCategoryPage
    {
        [Inject]
        public ICategoryService CategoryService { get; set; }

        [Parameter]
        public string publicParameter { get; set; }

        [Parameter]
        public string ServiceCatalogueId { get; set; }

        [Parameter]
        public string? CategoryID { get; set; }

        public Guid? SelectedCategoryId { get; set; } = null;

        private AuthModel? authModel { get; set; }

        private List<ServiceCatalogueDTO> ServiceCatalogue { get; set; } = new List<ServiceCatalogueDTO>();

        private CategoryDTO Category { get; set; } = new CategoryDTO();

        private DeflectorManagerDTO deflectorManagerDTO { get; set; } = new();

        private Guid? SelectedServiceCatalogueItemId { get; set; }

        private bool loading = true;

        protected override async Task OnInitializedAsync()
        {
            GetAndSetUserInfo();
            if (CategoryID != null)
            {
                SelectedCategoryId = Guid.Parse(CategoryID!);
                Category = await CategoryService.GetCategorieById(CategoryID);

                ServiceCatalogue = new List<ServiceCatalogueDTO> { new ServiceCatalogueDTO { Categories = new List<CategoryDTO> { Category } } };

                ServiceCatalogue.FirstOrDefault().ServiceCatalogueID = Category.ServiceCatalogueId;

                SetDeflectorItems();

                deflectorManagerDTO.ServiceCatalogue = ServiceCatalogue.FirstOrDefault();

                loading = false;
                await InvokeAsync(() => StateHasChanged());
            }
        }

        private async void GetAndSetUserInfo()
        {
            authModel = await authManager.GetAuthState();
        }

        public void HandleItemClick(TreeViewItemClickEventArgs args)
        {
            SelectedServiceCatalogueItemId = null;
            var item = args.Item as TreeItem;
            if (item != null)
            {
                if (!item.IsCategory)
                {
                    SelectedCategoryId = null;
                    SelectedServiceCatalogueItemId = item.Id;
                }
                else
                {
                    SelectedCategoryId = item.Id;
                    SelectedServiceCatalogueItemId = null;
                }
            }
            StateHasChanged();
        }

        public void OnDeflectorItemClick(DeflectorItem deflectorItem)
        {
            if (deflectorItem.IsCategory)
            {
                SelectedCategoryId = deflectorItem.CategoryId;
                SelectedServiceCatalogueItemId = null;
            }
            else
            {
                SelectedCategoryId = null;
                SelectedServiceCatalogueItemId = deflectorItem.ServiceCatalogueItemId;
            }
            StateHasChanged();
        }

        public void SetDeflectorItems()
        {
            var category = Category;

            var serviceCatalogueItems = category.ServiceCatalogueItems;

            var deflectorItems = new List<DeflectorItem>();

            deflectorItems.Add(new DeflectorItem
            {
                CategoryId = category.CategoryID,
                Name = category.Name,
                Description = category.Description,
                IconCode = category.IconCode,
                ServiceCatalogueId = category.ServiceCatalogueId,
                IsCategory = true
            });

            foreach (var serviceCatalogueItem in serviceCatalogueItems)
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

            deflectorManagerDTO.DeflectorItems = deflectorItems;
            deflectorManagerDTO.SelectedCategoryId = SelectedCategoryId;
            StateHasChanged();
        }
    }
}
