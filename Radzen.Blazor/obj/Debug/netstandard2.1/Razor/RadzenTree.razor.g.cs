#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faa886b95bdad1f1d13020ec60ceea485b3df7af"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
using Microsoft.AspNetCore.Components.Rendering;

#line default
#line hidden
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
using System.Collections;

#line default
#line hidden
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
using System.Linq;

#line default
#line hidden
    public partial class RadzenTree : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddMultipleAttributes(2, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
                                      Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "class", 
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
                                                          GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(4, "style", 
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
                                                                                 Style

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
                                                                                             GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
                Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "rz-tree-container");
            __builder.AddMarkupContent(10, "\r\n        ");
            __Blazor.Radzen.Blazor.RadzenTree.TypeInference.CreateCascadingValue_0(__builder, 11, 12, 
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
                              this

#line default
#line hidden
            , 13, (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.AddContent(15, 
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
             ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(16, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(17, "\r\n");
#line 13 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
         if (Data != null && Levels.Any())
            {

#line default
#line hidden
            __builder.AddContent(18, "                ");
            __Blazor.Radzen.Blazor.RadzenTree.TypeInference.CreateCascadingValue_1(__builder, 19, 20, 
#line 15 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
                                      this

#line default
#line hidden
            , 21, (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.AddContent(23, 
#line 16 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
                     RenderChildren(Data, 0)

#line default
#line hidden
                );
                __builder2.AddMarkupContent(24, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(25, "\r\n");
#line 18 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
            }

#line default
#line hidden
            __builder.AddContent(26, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTree.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenTree
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
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
