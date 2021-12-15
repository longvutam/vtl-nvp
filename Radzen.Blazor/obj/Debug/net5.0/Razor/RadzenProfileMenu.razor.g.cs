#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a2bee215f83bd710ee1dbbab00a58fbe602819"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class RadzenProfileMenu : RadzenComponentWithChildren
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "style", 
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                                Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                                                    Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                                                                        GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                                                                                            GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
               Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "class", "rz-navigation-item");
            __builder.AddMarkupContent(10, "\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "rz-navigation-item-wrapper");
            __builder.AddAttribute(13, "onclick", "Radzen.toggleMenuItem(this)");
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "rz-navigation-item-link");
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "item-text");
            __builder.AddMarkupContent(20, "\n");
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                         if (Template != null)
                        {
                            

#line default
#line hidden
            __builder.AddContent(21, 
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                             Template

#line default
#line hidden
            );
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                                     
                        }

#line default
#line hidden
            __builder.AddContent(22, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "i");
            __builder.AddAttribute(25, "class", "rzi rz-navigation-item-icon-children");
            __builder.AddAttribute(26, "style", 
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                                                                            iconStyle

#line default
#line hidden
            );
            __builder.AddContent(27, "keyboard_arrow_down");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n            ");
            __builder.OpenElement(31, "ul");
            __builder.AddAttribute(32, "class", "rz-navigation-menu");
            __builder.AddAttribute(33, "style", 
#line 18 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                                                   contentStyle

#line default
#line hidden
            );
            __builder.AddMarkupContent(34, "\n                ");
            __Blazor.Radzen.Blazor.RadzenProfileMenu.TypeInference.CreateCascadingValue_0(__builder, 35, 36, 
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                                      this

#line default
#line hidden
            , 37, (__builder2) => {
                __builder2.AddMarkupContent(38, "\n                    ");
                __builder2.AddContent(39, 
#line 20 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
                     ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(40, "\n                ");
            }
            );
            __builder.AddMarkupContent(41, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n");
#line 25 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProfileMenu.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenProfileMenu
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591