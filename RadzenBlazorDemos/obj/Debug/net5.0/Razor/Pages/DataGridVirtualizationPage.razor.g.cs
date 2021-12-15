#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc4c81a5639545fd4e02ec882a6fae3d37de917d"
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
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-virtualization")]
    public partial class DataGridVirtualizationPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid <strong>Virtualization</strong></h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>\r\nVirtualization allows you to render large amounts of data on demand. The RadzenDataGrid component uses Entity Framework to query the visible data.\r\n</p>\r\n");
            __builder.AddMarkupContent(2, "<p>\r\n    Just set the <code>AllowVirtualization</code> property to <code>true</code>. Requires .NET Core 5.0+.\r\n</p>\r\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(3);
            __builder.AddAttribute(4, "Name", "DataGrid");
            __builder.AddAttribute(5, "Source", "DataGridVirtualization");
            __builder.AddAttribute(6, "Heading", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
                                                                        false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<OrderDetail>>(8);
                __builder2.AddAttribute(9, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderDetail>>(
#nullable restore
#line 18 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
                           orderDetails

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "AllowVirtualization", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Style", "height:400px");
                __builder2.AddAttribute(12, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 19 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
                                                                 FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "LogicalFilterOperator", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 19 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
                                                                                                                               LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(17);
                    __builder3.AddAttribute(18, "Property", "OrderID");
                    __builder3.AddAttribute(19, "Title", "OrderID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(21);
                    __builder3.AddAttribute(22, "Property", "ProductID");
                    __builder3.AddAttribute(23, "Title", "ProductID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(25);
                    __builder3.AddAttribute(26, "Property", "UnitPrice");
                    __builder3.AddAttribute(27, "Title", "Unit Price");
                    __builder3.AddAttribute(28, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((detail) => (__builder4) => {
#nullable restore
#line 26 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
__builder4.AddContent(29, String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", detail.UnitPrice));

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(31);
                    __builder3.AddAttribute(32, "Property", "Quantity");
                    __builder3.AddAttribute(33, "Title", "Quantity");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(35);
                    __builder3.AddAttribute(36, "Property", "Discount");
                    __builder3.AddAttribute(37, "Title", "Discount");
                    __builder3.AddAttribute(38, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((detail) => (__builder4) => {
#nullable restore
#line 32 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
__builder4.AddContent(39, String.Format("{0}%", detail.Discount * 100));

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
#line 38 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridVirtualizationPage.razor"
       
    IEnumerable<OrderDetail> orderDetails;

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
