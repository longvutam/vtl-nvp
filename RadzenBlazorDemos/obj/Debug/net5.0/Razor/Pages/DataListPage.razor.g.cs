#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d8de4b487b1042b7fd622ce16a57c451b282c97"
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
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datalist")]
    public partial class DataListPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "DataList");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataList<Order>>(3);
                __builder2.AddAttribute(4, "WrapItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Order>>(
#nullable restore
#line 10 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                                                               orders

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(8);
                    __builder3.AddAttribute(9, "Style", "width:300px;");
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(11, "div");
                        __builder4.AddAttribute(12, "class", "d-flex flex-row align-items-center");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(13);
                        __builder4.AddAttribute(14, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                                        order.Employee?.Photo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "Class", "rounded-circle float-left mr-3");
                        __builder4.AddAttribute(16, "Style", "width: 80px; height: 80px;");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\n                    ");
                        __builder4.OpenElement(18, "div");
                        __builder4.OpenElement(19, "h4");
                        __builder4.AddAttribute(20, "class", "mb-0");
                        __builder4.AddContent(21, 
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                                           order.Employee?.FirstName + " " + order.Employee?.LastName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(22, "\n                        ");
                        __builder4.OpenElement(23, "div");
                        __builder4.AddContent(24, 
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                              order.Customer?.CompanyName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(25, "\n                        ");
                        __builder4.OpenElement(26, "div");
                        __builder4.AddAttribute(27, "style", "font-size: .8em");
                        __builder4.AddContent(28, 
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                                                       order.ShipCity

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(29, ", ");
                        __builder4.AddContent(30, 
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                                                                          order.ShipCountry

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(31, "\n                <hr style=\"border: none; background-color: rgba(0,0,0,.08); height: 1px; margin: 1rem 0;\">\n                ");
                        __builder4.OpenElement(32, "div");
                        __builder4.AddAttribute(33, "class", "row");
                        __builder4.OpenElement(34, "div");
                        __builder4.AddAttribute(35, "class", "col-md-8 text-truncate");
                        __builder4.OpenElement(36, "b");
                        __builder4.AddContent(37, 
#nullable restore
#line 24 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                             order.ShipName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(38, "\n                    ");
                        __builder4.OpenElement(39, "div");
                        __builder4.AddAttribute(40, "class", "col-md-4 text-right");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenBadge>(41);
                        __builder4.AddAttribute(42, "BadgeStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.BadgeStyle>(
#nullable restore
#line 27 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                                                 BadgeStyle.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
                                                                              $"{String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", order.Freight)}"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
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
#line 34 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataListPage.razor"
       
    IEnumerable<Order> orders;

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