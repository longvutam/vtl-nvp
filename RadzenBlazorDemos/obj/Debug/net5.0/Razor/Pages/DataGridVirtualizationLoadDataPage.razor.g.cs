#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e674dbdc286d39e04981798e4fd2ca8d799344e"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenBlazorDemos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-virtualization-loaddata")]
    public partial class DataGridVirtualizationLoadDataPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid <strong>Custom Virtualization</strong></h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    RadzenDataGrid supports virtualization with custom data-binding scenarios. Handle the <code>LoadData</code> event as usual.\r\n</p>\r\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Source", "DataGridVirtualizationLoadData");
            __builder.AddAttribute(5, "Heading", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
                                                                                false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<OrderDetail>>(7);
                __builder2.AddAttribute(8, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderDetail>>(
#nullable restore
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
                           orderDetails

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Count", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
                                                 count

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "LoadData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
                                                                   LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "AllowVirtualization", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
                                                                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Style", "height:400px");
                __builder2.AddAttribute(13, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 16 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
                                                                 FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "LogicalFilterOperator", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 16 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
                                                                                                                               LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(18);
                    __builder3.AddAttribute(19, "Property", "OrderID");
                    __builder3.AddAttribute(20, "Title", "OrderID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(22);
                    __builder3.AddAttribute(23, "Property", "ProductID");
                    __builder3.AddAttribute(24, "Title", "ProductID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(26);
                    __builder3.AddAttribute(27, "Property", "UnitPrice");
                    __builder3.AddAttribute(28, "Title", "Unit Price");
                    __builder3.AddAttribute(29, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((detail) => (__builder4) => {
#nullable restore
#line 23 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
__builder4.AddContent(30, String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", detail.UnitPrice));

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(32);
                    __builder3.AddAttribute(33, "Property", "Quantity");
                    __builder3.AddAttribute(34, "Title", "Quantity");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(36);
                    __builder3.AddAttribute(37, "Property", "Discount");
                    __builder3.AddAttribute(38, "Title", "Discount");
                    __builder3.AddAttribute(39, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((detail) => (__builder4) => {
#nullable restore
#line 29 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
__builder4.AddContent(40, String.Format("{0}%", detail.Discount * 100));

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationLoadDataPage.razor"
       
    int count;
    IEnumerable<OrderDetail> orderDetails;

    void LoadData(LoadDataArgs args)
    {
        var query = dbContext.OrderDetails.AsQueryable();

        if (!string.IsNullOrEmpty(args.Filter))
        {
            query = query.Where(args.Filter);
        }

        if (!string.IsNullOrEmpty(args.OrderBy))
        {
            query = query.OrderBy(args.OrderBy);
        }

        orderDetails = query.Skip(args.Skip.Value).Take(args.Top.Value).ToList();

        count = dbContext.OrderDetails.Count();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591
