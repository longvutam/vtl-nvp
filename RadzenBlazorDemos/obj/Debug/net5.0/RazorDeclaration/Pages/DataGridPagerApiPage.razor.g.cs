// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RadzenBlazorDemos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-pager-api")]
    public partial class DataGridPagerApiPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
       
    string pagingSummaryFormat = "Displaying page {0} of {1} (total {2} records)";

    RadzenDataGrid<OrderDetail> dataGrid;
    IEnumerable<int> pageSizeOptions = new int[] { 10, 20, 30 };
    IEnumerable<OrderDetail> orderDetails;
    bool showPagerSummary = true;

    async Task FirstPage()
{
        await dataGrid.FirstPage();
    }
    async Task TenthPage()
    {
        await dataGrid.GoToPage(9);
    }
    async Task LastPage()
    {
        await dataGrid.LastPage();
    }

    protected override void OnInitialized()
    {
        orderDetails = dbContext.OrderDetails;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591
