using ECSM.Models.DTO.ServiceCatalogue;
using ECSM.Models.DTO.TreeView;
using Microsoft.AspNetCore.Components;
using Telerik.Blazor.Components;
using System.Linq;

namespace ECSM.Portal.Components.TreeView
{
    public partial class TreeViewComponent
    {
        [Parameter]
        public bool CategoryRoot { get; set; } = false;

        [Parameter]
        public TreeViewDTO treeViewDTO { get; set; }

        [Parameter]
        public EventCallback<TreeViewItemClickEventArgs> OnItemClick { get; set; }

        public IEnumerable<TreeItem> catalogueData { get; set; } = new List<TreeItem>();

        public IEnumerable<object> ExpandedItems { get; set; } = new List<object>();

        protected override void OnParametersSet()
        {
            if (treeViewDTO.ServiceCatalogues != null && treeViewDTO.ServiceCatalogues.Any())
            {
                LoadData();
            }
            base.OnParametersSet();
        }

        private void LoadData()
        {
            var treeItems = new List<TreeItem>();
            var expandedItemIds = new HashSet<Guid>();
            var parentChildMap = new Dictionary<Guid, Guid?>();

            foreach (var catalogue in treeViewDTO.ServiceCatalogues)
            {
                var rootItem = new TreeItem();

                if (CategoryRoot)
                {
                    var category = catalogue.Categories.FirstOrDefault();

                    rootItem = new TreeItem
                    {
                        Id = category.CategoryID,
                        Text = category.Name,
                        ParentIdValue = null,
                        HasChildren = category.ServiceCatalogueItems.Any(),
                        Expanded = true,
                        IsCategory = true
                    };
                    treeItems.Add(rootItem);
                }
                else
                {
                    // Add the service catalogue as the root item
                    rootItem = new TreeItem
                    {
                        Id = catalogue.ServiceCatalogueID,
                        Text = catalogue.Name,
                        ParentIdValue = null,
                        HasChildren = catalogue.Categories.Any(c => c.ParentCategoryId == null),
                        Expanded = treeViewDTO.SelectedServiceCatalogue != null && treeViewDTO.SelectedServiceCatalogue == catalogue.ServiceCatalogueID
                    };
                    treeItems.Add(rootItem);
                }

                // Track parent relationships
                parentChildMap[rootItem.Id] = rootItem.ParentIdValue;

                if (rootItem.Expanded)
                {
                    expandedItemIds.Add(rootItem.Id);
                }

                if (CategoryRoot)
                {
                    var category = catalogue.Categories.FirstOrDefault();

                    if (category != null)
                    {
                        //Process all categories under this catalogue
                        foreach (var item in category.ServiceCatalogueItems)
                        {
                            var treeItem = new TreeItem
                            {
                                Id = item.ServiceCatalogueItemId,
                                Text = item.Name,
                                ParentIdValue = category.CategoryID,
                                HasChildren = false,
                                IsCategory = false,
                                Expanded = false
                            };

                            treeItems.Add(treeItem);

                            // Track parent relationships
                            parentChildMap[treeItem.Id] = treeItem.ParentIdValue;
                        }
                    }
                }
                else
                {
                    //Process all categories under this catalogue
                    foreach (var category in catalogue.Categories)
                    {
                        var treeItem = new TreeItem
                        {
                            Id = category.CategoryID,
                            Text = category.Name,
                            ParentIdValue = category.ParentCategoryId ?? catalogue.ServiceCatalogueID,
                            HasChildren = catalogue.Categories.Any(c => c.ParentCategoryId == category.CategoryID),
                            IsCategory = true,
                            Expanded = treeViewDTO.SelectedCategory != null && treeViewDTO.SelectedCategory == category.CategoryID
                        };

                        treeItems.Add(treeItem);

                        // Track parent relationships
                        parentChildMap[treeItem.Id] = treeItem.ParentIdValue;

                        // Track expanded state
                        if (treeItem.Expanded)
                        {
                            expandedItemIds.Add(treeItem.Id);
                        }
                    }
                }
            }

            // Ensure all parent items of expanded items are also expanded
            ExpandParents(expandedItemIds, parentChildMap);

            // Assign the populated treeItems to catalogueData
            catalogueData = treeItems;
            ExpandedItems = treeItems.Where(i => expandedItemIds.Contains(i.Id)).ToList();
        }

            private void ExpandParents(HashSet<Guid> expandedItemIds, Dictionary<Guid, Guid?> parentChildMap)
            {
                var itemsToExpand = new List<Guid>(expandedItemIds);

                while (itemsToExpand.Any())
                {
                    var itemId = itemsToExpand.First();
                    itemsToExpand.RemoveAt(0);

                    if (parentChildMap.TryGetValue(itemId, out var parentId) && parentId.HasValue)
                    {
                        if (expandedItemIds.Add(parentId.Value))
                        {
                            itemsToExpand.Add(parentId.Value);
                        }
                    }
                }
            }
    }
}