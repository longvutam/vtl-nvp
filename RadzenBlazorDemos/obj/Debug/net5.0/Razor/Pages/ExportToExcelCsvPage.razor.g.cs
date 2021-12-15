#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0154b4b61fb7d3433e2aac91075942fbb6e02ac0"
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
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/export-excel-csv")]
    public partial class ExportToExcelCsvPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Export to Excel and CSV</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>This page demonstrates how to export a Radzen Blazor DataGrid to Excel and CSV.</p>\n\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Source", "ExportToExcelCsv");
            __builder.AddAttribute(5, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
                                                                  false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(7);
                __builder2.AddAttribute(8, "Text", "Excel");
                __builder2.AddAttribute(9, "Icon", "grid_on");
                __builder2.AddAttribute(10, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
                                                       args => Export("excel")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "Style", "margin-bottom:20px");
                __builder2.CloseComponent();
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(12);
                __builder2.AddAttribute(13, "Text", "CSV");
                __builder2.AddAttribute(14, "Icon", "wrap_text");
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
                                                                                                                                                                 args => Export("csv")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "Style", "margin-left:20px;margin-bottom:20px;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<OrderDetail>>(18);
                __builder2.AddAttribute(19, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderDetail>>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
                                                                                                    orderDetails

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(24);
                    __builder3.AddAttribute(25, "Property", "OrderID");
                    __builder3.AddAttribute(26, "Title", "OrderID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(28);
                    __builder3.AddAttribute(29, "Property", "ProductID");
                    __builder3.AddAttribute(30, "Title", "ProductID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(32);
                    __builder3.AddAttribute(33, "Property", "UnitPrice");
                    __builder3.AddAttribute(34, "Title", "Unit Price");
                    __builder3.AddAttribute(35, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((detail) => (__builder4) => {
                        __builder4.AddContent(36, 
#nullable restore
#line 22 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
                     String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", detail.UnitPrice)

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(38);
                    __builder3.AddAttribute(39, "Property", "Quantity");
                    __builder3.AddAttribute(40, "Title", "Quantity");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(42);
                    __builder3.AddAttribute(43, "Property", "Discount");
                    __builder3.AddAttribute(44, "Title", "Discount");
                    __builder3.AddAttribute(45, "FormatString", "{0:P}");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(46, (__value) => {
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
                          grid = (Radzen.Blazor.RadzenDataGrid<OrderDetail>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\ExportToExcelCsvPage.razor"
       
    RadzenDataGrid<OrderDetail> grid;

    IEnumerable<OrderDetail> orderDetails;

    protected override void OnInitialized()
    {
        orderDetails = dbContext.OrderDetails.ToList();
    }

    public void Export(string type)
    {
        service.Export("OrderDetails", type, new Query() { OrderBy = grid.Query.OrderBy, Filter = grid.Query.Filter });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindService service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591