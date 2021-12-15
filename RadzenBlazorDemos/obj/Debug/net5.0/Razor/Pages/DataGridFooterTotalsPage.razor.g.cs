#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a45e75d8e5dee8b3caf464bba26ad7ad13829ca"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenBlazorDemos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-footer-totals")]
    public partial class DataGridFooterTotalsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid <strong>Footer Totals</strong></h1>\n\n");
            __builder.AddMarkupContent(1, "<p>The <strong>FooterTemplate</strong> column property allows you to display aggregated data in the column footer.</p>\n\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Source", "DataGridFooterTotals");
            __builder.AddAttribute(5, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                                                      false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Order>>(7);
                __builder2.AddAttribute(8, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                                                                     3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Order>>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                   orders

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(14);
                    __builder3.AddAttribute(15, "Width", "50px");
                    __builder3.AddAttribute(16, "Title", "#");
                    __builder3.AddAttribute(17, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                                                               false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                                                                                false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                                                                                                  TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((context) => (__builder4) => {
                        __builder4.AddContent(21, 
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                  orders.IndexOf(context) + 1

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(23);
                    __builder3.AddAttribute(24, "Width", "200px");
                    __builder3.AddAttribute(25, "Property", "OrderID");
                    __builder3.AddAttribute(26, "Title", "Order ID");
                    __builder3.AddAttribute(27, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(28, "\n                Displayed orders: ");
                        __builder4.OpenElement(29, "b");
                        __builder4.AddContent(30, 
#nullable restore
#line 23 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                      ordersGrid.View.Count()

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddContent(31, " of ");
                        __builder4.OpenElement(32, "b");
                        __builder4.AddContent(33, 
#nullable restore
#line 23 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                                                         orders.Count()

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(35);
                    __builder3.AddAttribute(36, "Width", "200px");
                    __builder3.AddAttribute(37, "Property", "Customer.CompanyName");
                    __builder3.AddAttribute(38, "Title", "Customer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(40);
                    __builder3.AddAttribute(41, "Property", "Employee.LastName");
                    __builder3.AddAttribute(42, "Title", "Employee");
                    __builder3.AddAttribute(43, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder4) => {
                        __builder4.AddContent(44, 
#nullable restore
#line 29 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                 order.Employee?.FirstName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(45, " ");
                        __builder4.AddContent(46, 
#nullable restore
#line 29 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                            order.Employee?.LastName

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(48);
                    __builder3.AddAttribute(49, "Property", "OrderDate");
                    __builder3.AddAttribute(50, "Title", "Order Date");
                    __builder3.AddAttribute(51, "FormatString", "{0:d}");
                    __builder3.AddAttribute(52, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(53, "\n                Last order date: ");
                        __builder4.OpenElement(54, "b");
                        __builder4.AddContent(55, 
#nullable restore
#line 34 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                     String.Format("{0:d}", orders.OrderByDescending(o => o.OrderDate).Last().OrderDate)

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(57);
                    __builder3.AddAttribute(58, "Property", "Freight");
                    __builder3.AddAttribute(59, "Title", "Freight");
                    __builder3.AddAttribute(60, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder4) => {
                        __builder4.AddContent(61, 
#nullable restore
#line 39 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                 String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", order.Freight)

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.AddAttribute(62, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(63, "\n                Total amount: ");
                        __builder4.OpenElement(64, "b");
                        __builder4.AddContent(65, 
#nullable restore
#line 42 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                                  String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", orders.Sum(o => o.Freight))

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(67);
                    __builder3.AddAttribute(68, "Property", "ShipName");
                    __builder3.AddAttribute(69, "Title", "Ship Name");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(70, (__value) => {
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
                      ordersGrid = (Radzen.Blazor.RadzenDataGrid<Order>)__value;

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
#line 50 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridFooterTotalsPage.razor"
       
    RadzenDataGrid<Order> ordersGrid;
    IList<Order> orders;

    protected override void OnInitialized()
    {
        orders = dbContext.Orders.Include("Customer").Include("Employee").ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591