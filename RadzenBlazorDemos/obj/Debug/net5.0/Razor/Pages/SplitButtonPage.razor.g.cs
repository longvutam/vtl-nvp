#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SplitButtonPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adfbafa6361a9a3c1a0d96999b0c55d3c1ada228"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/splitbutton")]
    public partial class SplitButtonPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "SplitButton");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-xl-6");
                __builder2.AddMarkupContent(11, "<h4>SplitButton with text</h4>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(12);
                __builder2.AddAttribute(13, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SplitButtonPage.razor"
                                           args => OnClick(args, "SplitButton with text")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "Text", "SplitButton");
                __builder2.AddAttribute(15, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(17);
                    __builder3.AddAttribute(18, "Text", "Item1");
                    __builder3.AddAttribute(19, "Value", "1");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(21);
                    __builder3.AddAttribute(22, "Text", "Item2");
                    __builder3.AddAttribute(23, "Value", "2");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-xl-6");
                __builder2.AddMarkupContent(27, "<h4>SplitButton with text and icon</h4>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(28);
                __builder2.AddAttribute(29, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#nullable restore
#line 18 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SplitButtonPage.razor"
                                           args => OnClick(args, "SplitButton with text and icon")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(30, "Text", "SplitButton");
                __builder2.AddAttribute(31, "Icon", "account_circle");
                __builder2.AddAttribute(32, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(34);
                    __builder3.AddAttribute(35, "Text", "Item1");
                    __builder3.AddAttribute(36, "Value", "1");
                    __builder3.AddAttribute(37, "Icon", "account_box");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(39);
                    __builder3.AddAttribute(40, "Text", "Item2");
                    __builder3.AddAttribute(41, "Value", "2");
                    __builder3.AddAttribute(42, "Icon", "account_balance_wallet");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "row");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-xl-6");
                __builder2.AddMarkupContent(48, "<h4>SplitButton with icon</h4>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(49);
                __builder2.AddAttribute(50, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#nullable restore
#line 29 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SplitButtonPage.razor"
                                           args => OnClick(args, "SplitButton with icon")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(51, "Icon", "account_circle");
                __builder2.AddAttribute(52, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(54);
                    __builder3.AddAttribute(55, "Text", "Item1");
                    __builder3.AddAttribute(56, "Value", "1");
                    __builder3.AddAttribute(57, "Icon", "account_box");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(59);
                    __builder3.AddAttribute(60, "Text", "Item2");
                    __builder3.AddAttribute(61, "Value", "2");
                    __builder3.AddAttribute(62, "Icon", "account_balance_wallet");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-xl-6");
                __builder2.AddMarkupContent(66, "<h4>Disabled SplitButton</h4>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(67);
                __builder2.AddAttribute(68, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SplitButtonPage.razor"
                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#nullable restore
#line 38 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SplitButtonPage.razor"
                                                           args => OnClick(args, "Disabled SplitButton")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(70, "Text", "SplitButton");
                __builder2.AddAttribute(71, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(73);
                    __builder3.AddAttribute(74, "Text", "Item1");
                    __builder3.AddAttribute(75, "Value", "1");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(77);
                    __builder3.AddAttribute(78, "Text", "Item2");
                    __builder3.AddAttribute(79, "Value", "2");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(83);
                __builder2.AddComponentReferenceCapture(84, (__value) => {
#nullable restore
#line 48 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SplitButtonPage.razor"
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
#line 53 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SplitButtonPage.razor"
       
    EventConsole console;

    void OnClick(RadzenSplitButtonItem item, string buttonName)
    {
        if(item != null)
        {
            console.Log($"{buttonName}, item with value {item.Value} clicked");
        }
        else
        {
            console.Log($"{buttonName} clicked");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
