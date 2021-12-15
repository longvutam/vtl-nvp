#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378fee145bf33a2d1789fde86f508f9218241432"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/rating")]
    public partial class RatingPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "Rating");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.AddMarkupContent(7, "<h3>Rating with 5 stars</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRating>(8);
                __builder2.AddAttribute(9, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 7 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor"
                               args => OnChange(args, "Rating with 5 stars")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<h3 style=\"margin-top: 2rem\">Rating with 10 stars</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRating>(12);
                __builder2.AddAttribute(13, "Stars", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor"
                             10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor"
                                          args => OnChange(args, "Rating with 10 stars")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.AddMarkupContent(16, "<h3 style=\"margin-top: 2rem\">Disabled Rating with 10 stars</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRating>(17);
                __builder2.AddAttribute(18, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor"
                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Stars", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor"
                                             10

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.AddMarkupContent(21, "<h3 style=\"margin-top: 2rem\">ReadOnly Rating</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRating>(22);
                __builder2.AddAttribute(23, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor"
                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Stars", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor"
                                             5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor"
                                                       4

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(29);
                __builder2.AddComponentReferenceCapture(30, (__value) => {
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor"
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
#line 21 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\RatingPage.razor"
       
    EventConsole console;

    void OnChange(int value, string name)
    {
        console.Log($"{name} value changed to {value}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
