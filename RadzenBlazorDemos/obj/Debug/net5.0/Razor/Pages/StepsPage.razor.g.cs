#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbca89cd9a8b1c50894c3d0b7e6a8813c8ff0404"
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
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/steps")]
    public partial class StepsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "Steps");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSteps>(7);
                __builder2.AddAttribute(8, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 12 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                             OnChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "Steps", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenStepsItem>(10);
                    __builder3.AddAttribute(11, "Text", "Customers");
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "<h3>Select Customer</h3>\r\n                    ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<Customer>>(14);
                        __builder4.AddAttribute(15, "ColumnWidth", "200px");
                        __builder4.AddAttribute(16, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Customer>>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                                                                            customers

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IList<Customer>>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                                                                                                                      selectedCustomers

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IList<Customer>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IList<Customer>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedCustomers = __value, selectedCustomers))));
                        __builder4.AddAttribute(22, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(23);
                            __builder5.AddAttribute(24, "Property", "CustomerID");
                            __builder5.AddAttribute(25, "Title", "Customer ID");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(26, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(27);
                            __builder5.AddAttribute(28, "Property", "CompanyName");
                            __builder5.AddAttribute(29, "Title", "Company Name");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(30, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(31);
                            __builder5.AddAttribute(32, "Property", "ContactName");
                            __builder5.AddAttribute(33, "Title", "Contact Name");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(34, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(35);
                            __builder5.AddAttribute(36, "Property", "ContactTitle");
                            __builder5.AddAttribute(37, "Title", "Contact Title");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(38, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(39);
                            __builder5.AddAttribute(40, "Property", "Address");
                            __builder5.AddAttribute(41, "Title", "Address");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(42, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(43);
                            __builder5.AddAttribute(44, "Property", "City");
                            __builder5.AddAttribute(45, "Title", "City");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(46, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(47);
                            __builder5.AddAttribute(48, "Property", "Region");
                            __builder5.AddAttribute(49, "Title", "Region");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(50, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(51);
                            __builder5.AddAttribute(52, "Property", "PostalCode");
                            __builder5.AddAttribute(53, "Title", "Postal Code");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(54, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(55);
                            __builder5.AddAttribute(56, "Property", "Country");
                            __builder5.AddAttribute(57, "Title", "Country");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(58, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(59);
                            __builder5.AddAttribute(60, "Property", "Phone");
                            __builder5.AddAttribute(61, "Title", "Phone");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(62, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Customer>>(63);
                            __builder5.AddAttribute(64, "Property", "Fax");
                            __builder5.AddAttribute(65, "Title", "Fax");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenStepsItem>(67);
                    __builder3.AddAttribute(68, "Text", "Orders");
                    __builder3.AddAttribute(69, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                           selectedCustomers == null || selectedCustomers != null && !selectedCustomers.Any()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(71, "<h3>Select Order</h3>\r\n                    ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<Order>>(72);
                        __builder4.AddAttribute(73, "ColumnWidth", "200px");
                        __builder4.AddAttribute(74, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                  2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(75, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(76, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(77, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(78, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Order>>(
#nullable restore
#line 35 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                        selectedCustomers != null && selectedCustomers.Any() ? orders.Where(o => o.CustomerID == selectedCustomers[0].CustomerID) : Enumerable.Empty<Order>()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IList<Order>>(
#nullable restore
#line 35 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                                                                                                                                                                            selectedOrders

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IList<Order>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IList<Order>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedOrders = __value, selectedOrders))));
                        __builder4.AddAttribute(81, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(82);
                            __builder5.AddAttribute(83, "Width", "100px");
                            __builder5.AddAttribute(84, "Property", "OrderID");
                            __builder5.AddAttribute(85, "Title", "Order ID");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(86, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(87);
                            __builder5.AddAttribute(88, "Width", "200px");
                            __builder5.AddAttribute(89, "Property", "Customer.CompanyName");
                            __builder5.AddAttribute(90, "Title", "Customer");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(91, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(92);
                            __builder5.AddAttribute(93, "Width", "150px");
                            __builder5.AddAttribute(94, "Property", "Employee.LastName");
                            __builder5.AddAttribute(95, "Title", "Employee");
                            __builder5.AddAttribute(96, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder6) => {
                                __builder6.OpenElement(97, "div");
                                __builder6.AddContent(98, 
#nullable restore
#line 41 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                          order.Employee?.LastName

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(99, "\r\n                                    ");
                                __builder6.OpenComponent<Radzen.Blazor.RadzenImage>(100);
                                __builder6.AddAttribute(101, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                        order.Employee?.Photo

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(102, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(103);
                            __builder5.AddAttribute(104, "Property", "OrderDate");
                            __builder5.AddAttribute(105, "Title", "Order Date");
                            __builder5.AddAttribute(106, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder6) => {
                                __builder6.AddContent(107, 
#nullable restore
#line 47 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                     String.Format("{0:d}", order.OrderDate)

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(108, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(109);
                            __builder5.AddAttribute(110, "Property", "RequiredDate");
                            __builder5.AddAttribute(111, "Title", "Required Date");
                            __builder5.AddAttribute(112, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder6) => {
                                __builder6.AddContent(113, 
#nullable restore
#line 52 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                     String.Format("{0:d}", order.RequiredDate)

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(114, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(115);
                            __builder5.AddAttribute(116, "Property", "ShippedDate");
                            __builder5.AddAttribute(117, "Title", "Shipped Date");
                            __builder5.AddAttribute(118, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder6) => {
                                __builder6.AddContent(119, 
#nullable restore
#line 57 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                     String.Format("{0:d}", order.ShippedDate)

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(120, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(121);
                            __builder5.AddAttribute(122, "Property", "Freight");
                            __builder5.AddAttribute(123, "Title", "Freight");
                            __builder5.AddAttribute(124, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder6) => {
                                __builder6.AddContent(125, 
#nullable restore
#line 62 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                     String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", order.Freight)

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(126, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(127);
                            __builder5.AddAttribute(128, "Property", "ShipName");
                            __builder5.AddAttribute(129, "Title", "Ship Name");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(130, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(131);
                            __builder5.AddAttribute(132, "Property", "ShipAddress");
                            __builder5.AddAttribute(133, "Title", "Ship Address");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(134, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(135);
                            __builder5.AddAttribute(136, "Property", "ShipCity");
                            __builder5.AddAttribute(137, "Title", "Ship City");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(138, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(139);
                            __builder5.AddAttribute(140, "Property", "ShipRegion");
                            __builder5.AddAttribute(141, "Title", "Ship Region");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(142, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(143);
                            __builder5.AddAttribute(144, "Property", "ShipPostalCode");
                            __builder5.AddAttribute(145, "Title", "Ship Postal Code");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(146, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Order>>(147);
                            __builder5.AddAttribute(148, "Property", "ShipCountry");
                            __builder5.AddAttribute(149, "Title", "Ship Country");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(150, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenStepsItem>(151);
                    __builder3.AddAttribute(152, "Text", "Order Details");
                    __builder3.AddAttribute(153, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 74 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                  selectedOrders == null || selectedOrders != null && !selectedOrders.Any()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(154, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<OrderDetail>>(155);
                        __builder4.AddAttribute(156, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 75 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                    true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(157, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 75 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                       true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(158, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 75 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(159, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderDetail>>(
#nullable restore
#line 76 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                                        selectedOrders != null && selectedOrders.Any() ? orderDetails.Where(o => o.OrderID == selectedOrders[0].OrderID) : Enumerable.Empty<OrderDetail>()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(160, "ColumnWidth", "200px");
                        __builder4.AddAttribute(161, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(162);
                            __builder5.AddAttribute(163, "Property", "Product.ProductName");
                            __builder5.AddAttribute(164, "Title", "Product");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(165, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(166);
                            __builder5.AddAttribute(167, "Property", "Quantity");
                            __builder5.AddAttribute(168, "Title", "Quantity");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(169, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(170);
                            __builder5.AddAttribute(171, "Property", "Discount");
                            __builder5.AddAttribute(172, "Title", "Discount");
                            __builder5.AddAttribute(173, "FormatString", "{0:P}");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n    ");
                __builder2.OpenElement(175, "div");
                __builder2.AddAttribute(176, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(177);
                __builder2.AddComponentReferenceCapture(178, (__value) => {
#nullable restore
#line 88 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
                            console = (RadzenBlazorDemos.Shared.EventConsole)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\StepsPage.razor"
       
    EventConsole console;
    IEnumerable<Customer> customers;
    IEnumerable<Order> orders;
    IEnumerable<OrderDetail> orderDetails;

    IList<Customer> selectedCustomers;
    IList<Order> selectedOrders;

    protected override void OnInitialized()
    {
        customers = dbContext.Customers.ToList();
        orders = dbContext.Orders.Include("Customer").Include("Employee").ToList();
        orderDetails = dbContext.OrderDetails.Include("Product").ToList();
    }
    void OnChange(int index)
    {
        console.Log($"Step with index {index} was selected.");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591
