#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043570d4074cb77b4214b93857d2d15ced790d42"
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
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fieldset")]
    public partial class FieldsetPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "Fieldset");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.AddMarkupContent(7, "<h3>Fieldset</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenFieldset>(8);
                __builder2.AddAttribute(9, "AllowCollapse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Style", "width:600px;margin-bottom: 20px; height:500px;");
                __builder2.AddAttribute(11, "Expand", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                 () => Change("Fieldset expanded")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(12, "Collapse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                                                               () => Change("Fieldset collapsed")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(14, "span");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenIcon>(15);
                    __builder3.AddAttribute(16, "Icon", "account_box");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "<b style=\"font-size:30px\">ORDER</b>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataList<Order>>(19);
                    __builder3.AddAttribute(20, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                          1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "WrapItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Order>>(
#nullable restore
#line 22 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                       orders

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCard>(25);
                        __builder4.AddAttribute(26, "Style", "width:300px;height:300px");
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(28, "div");
                            __builder5.AddAttribute(29, "class", "row");
                            __builder5.OpenElement(30, "div");
                            __builder5.AddAttribute(31, "class", "col-md-6");
                            __builder5.AddMarkupContent(32, "<div>Company:</div>\r\n                                    ");
                            __builder5.OpenElement(33, "b");
                            __builder5.AddContent(34, 
#nullable restore
#line 28 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                        order.Customer?.CompanyName

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(35, "\r\n                                    ");
                            __builder5.AddMarkupContent(36, "<div style=\"margin-top:20px\">Employee:</div>\r\n                                    ");
                            __builder5.OpenElement(37, "b");
                            __builder5.AddContent(38, 
#nullable restore
#line 30 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                         order.Employee?.FirstName + " " + order.Employee?.LastName

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(39, "\r\n                                    <br>\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenImage>(40);
                            __builder5.AddAttribute(41, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                                        order.Employee?.Photo

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(42, "Style", "width:100px;");
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(43, "\r\n                                ");
                            __builder5.OpenElement(44, "div");
                            __builder5.AddAttribute(45, "class", "col-md-6");
                            __builder5.AddMarkupContent(46, "<div>Freight:</div>\r\n                                    ");
                            __builder5.OpenElement(47, "b");
                            __builder5.AddContent(48, 
#nullable restore
#line 36 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                        String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", order.Freight)

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(49, "\r\n                                    ");
                            __builder5.AddMarkupContent(50, "<div style=\"margin-top:20px\">Ship country:</div>\r\n                                    ");
                            __builder5.OpenElement(51, "b");
                            __builder5.AddContent(52, 
#nullable restore
#line 38 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                         order.ShipCountry

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(53, "\r\n                                    ");
                            __builder5.AddMarkupContent(54, "<div style=\"margin-top:20px\">Ship city:</div>\r\n                                    ");
                            __builder5.OpenElement(55, "b");
                            __builder5.AddContent(56, 
#nullable restore
#line 40 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                                         order.ShipCity

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(57, "\r\n                                    ");
                            __builder5.AddMarkupContent(58, "<div style=\"margin-top:20px\">Ship name:</div>\r\n                                    ");
                            __builder5.OpenElement(59, "b");
                            __builder5.AddContent(60, 
#nullable restore
#line 42 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
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
                __builder2.AddAttribute(61, "SummaryTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(62, "span");
                    __builder3.AddContent(63, 
#nullable restore
#line 52 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
                     orders.Count()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(64, " Orders\r\n                ");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(68);
                __builder2.AddComponentReferenceCapture(69, (__value) => {
#nullable restore
#line 58 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
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
#line 63 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\FieldsetPage.razor"
       
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
