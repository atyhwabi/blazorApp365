using ECSM.Models.DTO.Deflector;
using Microsoft.AspNetCore.Components;
using ECSM.Portal.Components.CardLayouts;
namespace ECSM.Portal.Components.DeflectorComponents
{
  public partial class DeflectorManager
  {
    [Parameter]
    public DeflectorManagerDTO DeflectorManagerDTO { get; set; }

    [Parameter]
    public EventCallback<DeflectorItem> OnDeflectorItemClick { get; set; }
    [Parameter]
    public string SearchText { get; set; } = string.Empty;

    private string HeadingText { get; set; } = string.Empty;

    private List<DeflectorItem> FilterItems { get; set; } = new List<DeflectorItem>();

    protected override void OnParametersSet()
    {
      if (DeflectorManagerDTO.DeflectorItems.Count != 0)
      {
        SetDefctorItems(SearchText);
      }
      base.OnParametersSet();
    }

    private void SetDefctorItems(string searchText = null)
    {
      FilterItems = new();
      if (DeflectorManagerDTO.SelectedCategoryId == null)
      {
        HeadingText = DeflectorManagerDTO.ServiceCatalogue.Name;
        FilterItems = DeflectorManagerDTO.DeflectorItems.Where(x => x.IsCategory && x.ParentCategoryId == null).ToList();
      }

      if (DeflectorManagerDTO.SelectedCategoryId != null)
      {

        HeadingText = DeflectorManagerDTO.DeflectorItems.FirstOrDefault(x => x.CategoryId == DeflectorManagerDTO.SelectedCategoryId)?.Name;
        var categoryItems = DeflectorManagerDTO.DeflectorItems.Where(x => x.ParentCategoryId == DeflectorManagerDTO.SelectedCategoryId).ToList();

        var serviceCatalogueItems = DeflectorManagerDTO.DeflectorItems.Where(x => x.IsCategory == false && x.CategoryId == DeflectorManagerDTO.SelectedCategoryId).ToList();

        FilterItems.AddRange(categoryItems);
        FilterItems.AddRange(serviceCatalogueItems);
      }
      if (!string.IsNullOrEmpty(searchText))
      {
        HeadingText = DeflectorManagerDTO.DeflectorItems.FirstOrDefault(x => x.CategoryId == DeflectorManagerDTO.SelectedCategoryId)?.Name;
        var categoryItems = DeflectorManagerDTO.DeflectorItems.Where(x => x.ParentCategoryId != null).ToList();
        var serviceCatalogueItems = DeflectorManagerDTO.DeflectorItems.Where(x => x.IsCategory == false).ToList();
        FilterItems.AddRange(categoryItems);
        FilterItems.AddRange(serviceCatalogueItems);
        FilterItems = FilterItems.Where(x => x.Name.ToLower().Contains(searchText.ToLower()) || x.Description.ToLower().Contains(searchText.ToLower())).ToList();
        FilterItems = FilterItems.GroupBy(p => p.CategoryId).Select(group => group.First()).ToList();
      }
      StateHasChanged();
    }

    private void HandleDeflectorItemClick(DeflectorItem deflectorItem)
    {
      if (deflectorItem.IsCategory)
      {
        HeadingText = deflectorItem.Name;
        FilterItems = DeflectorManagerDTO.DeflectorItems.Where(x => x.IsCategory && x.ParentCategoryId == deflectorItem.CategoryId).ToList();
        FilterItems.AddRange(DeflectorManagerDTO.DeflectorItems.Where(x => x.IsCategory == false && x.CategoryId == deflectorItem.CategoryId).ToList());
      }
      else
      {
        // Handle Service Catalogue Item Click
      }
      OnDeflectorItemClick.InvokeAsync(deflectorItem);
      StateHasChanged();
    }

    private MarkupString GetHighlightedText(string text)
    {
      if (string.IsNullOrEmpty(SearchText))
      {
        return (MarkupString)$"<span>{text}</span>";
      }

      var highlightedText = text.Replace(SearchText, $"<strong style='color: darkblue'>{SearchText}</strong>", StringComparison.OrdinalIgnoreCase);
      return (MarkupString)$"<span>{highlightedText}</span>";
    }
  }
}
