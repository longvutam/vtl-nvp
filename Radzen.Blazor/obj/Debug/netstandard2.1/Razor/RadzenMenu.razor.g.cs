#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d1400d805d38c0809f1fd472066c55c6dc536b0"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class RadzenMenu : RadzenComponentWithChildren
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "style", 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
                             Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
                                                Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
                                                                  GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
                                                                                    GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
              Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\r\n");
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
         if (Responsive)
        {

#line default
#line hidden
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "class", "rz-menu-toggle-item");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "rz-menu-toggle");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
                                                     OnToggle

#line default
#line hidden
            ));
            __builder.AddMarkupContent(15, "\r\n");
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
                 if (IsOpen)
                {

#line default
#line hidden
            __builder.AddContent(16, "                    ");
            __builder.AddMarkupContent(17, "<i class=\"rzi\">close</i>\r\n");
#line 13 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
                } else
                {


#line default
#line hidden
            __builder.AddContent(18, "                    ");
            __builder.AddMarkupContent(19, "<i class=\"rzi\">menu</i>\r\n");
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
                }

#line default
#line hidden
            __builder.AddContent(20, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
        }

#line default
#line hidden
            __builder.AddContent(23, "        ");
            __Blazor.Radzen.Blazor.RadzenMenu.TypeInference.CreateCascadingValue_0(__builder, 24, 25, 
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
                              this

#line default
#line hidden
            , 26, (__builder2) => {
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.AddContent(28, 
#line 22 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
             ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(29, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#line 25 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMenu.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenMenu
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
