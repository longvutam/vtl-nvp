#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "617912e5bf73ebdbf63e7980f164397f7086a456"
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
#line 1 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/master-detail-hierarchy")]
    public partial class MasterDetailHierarchyPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid Master Detail Hierarchy</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This page demonstrates how to use templates to create a Radzen Blazor DataGrid hierarchy.</p>\r\n\r\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Source", "MasterDetailHierarchy");
            __builder.AddAttribute(5, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                       false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Order>>(7);
                __builder2.AddAttribute(8, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                                   3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "RowRender", new System.Action<Radzen.RowRenderEventArgs<Order>>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                                                                      RowRender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ExpandMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridExpandMode>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                                                                                             DataGridExpandMode.Single

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Order>>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                       orders

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(16);
                    __builder3.AddAttribute(17, "Style", "margin-bottom:20px");
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(19, "\r\n                Company:\r\n                ");
                        __builder4.OpenElement(20, "b");
                        __builder4.AddContent(21, 
#nullable restore
#line 19 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                    order.Customer?.CompanyName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabs>(23);
                    __builder3.AddAttribute(24, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTabsItem>(25);
                        __builder4.AddAttribute(26, "Text", "Order Details");
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGrid<OrderDetail>>(28);
                            __builder5.AddAttribute(29, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                        true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(30, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(31, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(32, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderDetail>>(
#nullable restore
#line 24 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                                                            order.OrderDetails

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(33, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(34);
                                __builder6.AddAttribute(35, "Property", "Order.CustomerID");
                                __builder6.AddAttribute(36, "Title", "Order");
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(37, "\r\n                                ");
                                __builder6.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(38);
                                __builder6.AddAttribute(39, "Property", "Product.ProductName");
                                __builder6.AddAttribute(40, "Title", "Product");
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(41, "\r\n                                ");
                                __builder6.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(42);
                                __builder6.AddAttribute(43, "Property", "UnitPrice");
                                __builder6.AddAttribute(44, "Title", "Unit Price");
                                __builder6.AddAttribute(45, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((detail) => (__builder7) => {
                                    __builder7.AddContent(46, 
#nullable restore
#line 30 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                         String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", detail.UnitPrice)

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(47, "\r\n                                ");
                                __builder6.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(48);
                                __builder6.AddAttribute(49, "Property", "Quantity");
                                __builder6.AddAttribute(50, "Title", "Quantity");
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(51, "\r\n                                ");
                                __builder6.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(52);
                                __builder6.AddAttribute(53, "Property", "Discount");
                                __builder6.AddAttribute(54, "Title", "Discount");
                                __builder6.AddAttribute(55, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((detail) => (__builder7) => {
                                    __builder7.AddContent(56, 
#nullable restore
#line 36 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                         String.Format("{0}%", detail.Discount * 100)

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(57, "\r\n                    ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTabsItem>(58);
                        __builder4.AddAttribute(59, "Text", "Products");
                        __builder4.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataList<OrderDetail>>(61);
                            __builder5.AddAttribute(62, "WrapItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(63, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                      true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(64, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderDetail>>(
#nullable restore
#line 43 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                                   order.OrderDetails

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(65, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 43 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                                                                                                     10

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(66, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((detail) => (__builder6) => {
                                __builder6.OpenComponent<Radzen.Blazor.RadzenCard>(67);
                                __builder6.AddAttribute(68, "Style", "width:100px;height:100px");
                                __builder6.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(70, "\r\n                                    Product:\r\n                                    ");
                                    __builder7.OpenElement(71, "b");
                                    __builder7.AddContent(72, 
#nullable restore
#line 47 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                        detail?.Product?.ProductName

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.CloseElement();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(73, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(74);
                    __builder3.AddAttribute(75, "Width", "100px");
                    __builder3.AddAttribute(76, "Property", "OrderID");
                    __builder3.AddAttribute(77, "Title", "Order ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(79);
                    __builder3.AddAttribute(80, "Width", "200px");
                    __builder3.AddAttribute(81, "Property", "Customer.CompanyName");
                    __builder3.AddAttribute(82, "Title", "Customer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(84);
                    __builder3.AddAttribute(85, "Width", "150px");
                    __builder3.AddAttribute(86, "Property", "Employee.LastName");
                    __builder3.AddAttribute(87, "Title", "Employee");
                    __builder3.AddAttribute(88, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(89);
                        __builder4.AddAttribute(90, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                        order.Employee?.Photo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(91, "style", "width: 40px; height: 40px; border-radius: 8px;");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(92, "\r\n                    ");
                        __builder4.AddContent(93, 
#nullable restore
#line 61 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                     order.Employee?.FirstName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(94, " ");
                        __builder4.AddContent(95, 
#nullable restore
#line 61 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                                                order.Employee?.LastName

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(97);
                    __builder3.AddAttribute(98, "Property", "OrderDate");
                    __builder3.AddAttribute(99, "Title", "Order Date");
                    __builder3.AddAttribute(100, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(102);
                    __builder3.AddAttribute(103, "Property", "RequiredDate");
                    __builder3.AddAttribute(104, "Title", "Required Date");
                    __builder3.AddAttribute(105, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(107);
                    __builder3.AddAttribute(108, "Property", "ShippedDate");
                    __builder3.AddAttribute(109, "Title", "Shipped Date");
                    __builder3.AddAttribute(110, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(112);
                    __builder3.AddAttribute(113, "Property", "ShipName");
                    __builder3.AddAttribute(114, "Title", "Ship Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(116);
                    __builder3.AddAttribute(117, "Property", "ShipCountry");
                    __builder3.AddAttribute(118, "Title", "Ship Country");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(119, (__value) => {
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
                          grid = (Radzen.Blazor.RadzenDataGrid<Order>)__value;

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
#line 72 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\MasterDetailHierarchyPage.razor"
       
    IEnumerable<Order> orders;
    RadzenDataGrid<Order> grid;

    protected override void OnInitialized()
    {
        orders = dbContext.Orders.Include("Customer").Include("Employee").Include("OrderDetails").Include("OrderDetails.Product").ToList();
    }

    void RowRender(RowRenderEventArgs<Order> args)
    {
        args.Expandable = args.Data.ShipCountry == "France" || args.Data.ShipCountry == "Brazil";
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            grid.ExpandRow(orders.FirstOrDefault());
            StateHasChanged();
        }

        base.OnAfterRender(firstRender);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591
