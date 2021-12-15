#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8e9ce0dd454e9bf50b3cd7d43e27d6bbf6c04a7"
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
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/panel")]
    public partial class PanelPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "Panel");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.AddMarkupContent(7, "<h3>Panel</h3>\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanel>(8);
                __builder2.AddAttribute(9, "AllowCollapse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Style", "width:600px;margin-bottom: 20px; height:500px;");
                __builder2.AddAttribute(11, "Expand", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                 () => Change("Panel expanded")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(12, "Collapse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                                                            () => Change("Panel collapsed")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(14, "span");
                    __builder3.AddAttribute(15, "style", "float:left;");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenIcon>(16);
                    __builder3.AddAttribute(17, "Icon", "account_box");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "<b style=\"font-size:30px\">ORDER</b>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataList<Order>>(20);
                    __builder3.AddAttribute(21, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                          1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "WrapItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Order>>(
#nullable restore
#line 22 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                       orders

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCard>(26);
                        __builder4.AddAttribute(27, "Style", "width:300px;height:300px");
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(29, "div");
                            __builder5.AddAttribute(30, "class", "row");
                            __builder5.OpenElement(31, "div");
                            __builder5.AddAttribute(32, "class", "col-md-6");
                            __builder5.AddMarkupContent(33, "<div>Company:</div>\n                                    ");
                            __builder5.OpenElement(34, "b");
                            __builder5.AddContent(35, 
#nullable restore
#line 28 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                        order.Customer?.CompanyName

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(36, "\n                                    ");
                            __builder5.AddMarkupContent(37, "<div style=\"margin-top:20px\">Employee:</div>\n                                    ");
                            __builder5.OpenElement(38, "b");
                            __builder5.AddContent(39, 
#nullable restore
#line 30 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                         order.Employee?.FirstName + " " + order.Employee?.LastName

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(40, "\n                                    <br>\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenImage>(41);
                            __builder5.AddAttribute(42, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                                        order.Employee?.Photo

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(43, "Style", "width:100px;");
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(44, "\n                                ");
                            __builder5.OpenElement(45, "div");
                            __builder5.AddAttribute(46, "class", "col-md-6");
                            __builder5.AddMarkupContent(47, "<div>Freight:</div>\n                                    ");
                            __builder5.OpenElement(48, "b");
                            __builder5.AddContent(49, 
#nullable restore
#line 36 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                        String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", order.Freight)

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(50, "\n                                    ");
                            __builder5.AddMarkupContent(51, "<div style=\"margin-top:20px\">Ship country:</div>\n                                    ");
                            __builder5.OpenElement(52, "b");
                            __builder5.AddContent(53, 
#nullable restore
#line 38 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                         order.ShipCountry

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(54, "\n                                    ");
                            __builder5.AddMarkupContent(55, "<div style=\"margin-top:20px\">Ship city:</div>\n                                    ");
                            __builder5.OpenElement(56, "b");
                            __builder5.AddContent(57, 
#nullable restore
#line 40 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                         order.ShipCity

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(58, "\n                                    ");
                            __builder5.AddMarkupContent(59, "<div style=\"margin-top:20px\">Ship name:</div>\n                                    ");
                            __builder5.OpenElement(60, "b");
                            __builder5.AddContent(61, 
#nullable restore
#line 42 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                                         order.ShipName

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(62, "SummaryTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(63);
                    __builder3.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(65, 
#nullable restore
#line 52 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
                     orders.Count()

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(66, " Orders\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n    ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(70);
                __builder2.AddComponentReferenceCapture(71, (__value) => {
#nullable restore
#line 58 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
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
#line 63 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\PanelPage.razor"
       
    EventConsole console;

    IEnumerable<Order> orders;

    protected override void OnInitialized()
    {
        orders = dbContext.Orders.Include("Customer").Include("Employee").ToList();
    }

    void Change(string text)
    {
        console.Log($"{text}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591
