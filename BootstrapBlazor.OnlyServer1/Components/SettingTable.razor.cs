using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace BootstrapBlazor.OnlyServer1.Components;

[CascadingTypeParameter(nameof(TItem))]
public partial class SettingTable<TItem> where TItem : class, new()
{
    [Parameter]
    public IEnumerable<int>? PageItemsSource { get; set; } 

    [Parameter]
    public bool IsPagination { get; set; } = true;

    [Parameter]
    public bool IsBordered { get; set; } = true;

    [Parameter]
    public bool IsStriped { get; set; } = true;

    [Parameter]
    public bool IsMultipleSelect { get; set; } = true;

    [Parameter]
    public bool IsFixedHeader { get; set; } = true;

    [Parameter]
    public bool ShowToolbar { get; set; } = true;

    [Parameter]
    public bool ShowCardView { get; set; } = false;    

    [Parameter]
    public bool ShowEmpty { get; set; } = true;

    [Parameter]
    public bool ShowSkeleton { get; set; } = true;
    
    [Parameter]
    public bool EditDialogIsDraggable { get; set; } = true;

    [Parameter]
    public bool AutoGenerateColumns { get; set; } = true;

    [Parameter]
    public bool ShowLoading { get; set; } = true;

    [Parameter]
    public bool ShowRefresh { get; set; } = true;    

    [Parameter]
    public bool ShowSearch { get; set; } = true;

    [Parameter]
    public bool ShowSearchText { get; set; } = true;

    [Parameter]
    public bool AllowResizing { get; set; } = true;    

    [Parameter]
    public bool ShowAdvancedSearch { get; set; } = true;

    [Parameter]
    public bool ShowLineNo { get; set; } = true;    
 
    [Parameter]
    public bool ShowDefaultButtons { get; set; } = true;

    [Parameter]
    public bool ShowExtendButtons { get; set; } = true;

    [Parameter]
    public bool IsExtendButtonsInRowHeader { get; set; } = false;    

    [Parameter]
    public bool ShowExtendEditButton { get; set; } = true;

    [Parameter]
    public bool ShowExtendDeleteButton { get; set; } = true;

    [Parameter]
    public bool ShowColumnList { get; set; } = true;

    [Parameter]
    public bool ShowLoadingInFirstRender { get; set; } = true;

    [Parameter]
    public bool ShowAddButton { get; set; } = true;

    [Parameter]
    public bool ShowEditButton { get; set; } = true;

    [Parameter]
    public bool ShowDeleteButton { get; set; } = true;

    [Parameter]
    public string? SortString { get; set; }

    [Parameter]
    public Func<QueryPageOptions, Task<QueryData<TItem>>>? OnQueryAsync { get; set; }

    [Parameter]
    public Func<TItem, ItemChangedType, Task<bool>>? OnSaveAsync { get; set; }

    [Parameter]
    public Func<IEnumerable<TItem>, Task<bool>>? OnDeleteAsync { get; set; }

    [NotNull]
    [Parameter]
    public RenderFragment<TItem>? TableColumns { get; set; }

    [Parameter]
    public List<TItem>? SelectedRows { get; set; } = new List<TItem>();

    [Parameter]
    public Func<TItem, bool>? ShowEditButtonCallback { get; set; }

    [Parameter]
    public Func<TItem, bool>? ShowDeleteButtonCallback { get; set; }

    [Parameter]
    public RenderFragment<ITableSearchModel>? CustomerSearchTemplate { get; set; }

    [Parameter]
    public RenderFragment<TItem>? EditTemplate { get; set; }

    [Parameter]
    public RenderFragment<TItem>? EditFooterTemplate { get; set; }    

    [Parameter]
    public RenderFragment<TItem>? RowButtonTemplate { get; set; }

    [Parameter]
    public RenderFragment? TableToolbarTemplate { get; set; }    

    [Parameter]
    public Func<TItem, TItem, bool>? ModelEqualityComparer { get; set; }

    [NotNull]
    private Table<TItem>? Instance { get; set; }

    public Task QueryAsync() => Instance.QueryAsync();
}
