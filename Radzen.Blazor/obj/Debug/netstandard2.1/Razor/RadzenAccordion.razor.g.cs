#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d03176ac514301bec9c9be955a9101874f264d1"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
using System.Linq;

#line default
#line hidden
    public partial class RadzenAccordion : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
 if (Items != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __Blazor.Radzen.Blazor.RadzenAccordion.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                          this

#line default
#line hidden
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "\n        ");
                __builder2.AddContent(5, 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
         Items

#line default
#line hidden
                );
                __builder2.AddMarkupContent(6, "\n    ");
            }
            );
            __builder.AddMarkupContent(7, "\n");
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
}

#line default
#line hidden
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "role", "tablist");
            __builder.AddMultipleAttributes(10, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                                                 Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "class", 
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                                                                     GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(12, "id", 
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                                                                                         GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(13, (__value) => {
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
            Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(14, "\n");
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
     for (var i = 0; i < items.Count; i++)
    {
        var item = items[i];
        if (!item.Visible)
            continue;


#line default
#line hidden
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "rz-accordion-header");
            __builder.AddMultipleAttributes(18, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 20 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                                                      item.Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(19, "style", 
#line 20 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                                                                               item.Style

#line default
#line hidden
            );
            __builder.AddMarkupContent(20, "\n            ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 21 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                           (args) => SelectItem(item)

#line default
#line hidden
            ));
            __builder.AddAttribute(23, "href", "javascript:void(0)");
            __builder.AddAttribute(24, "role", "tab");
            __builder.AddAttribute(25, "tabindex", "0");
            __builder.AddAttribute(26, "id", 
#line 22 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                     $"rz-accordiontab-{items.IndexOf(item)}"

#line default
#line hidden
            );
            __builder.AddAttribute(27, "aria-controls", 
#line 22 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                                                                                 $"rz-accordiontab-{items.IndexOf(item)}-content"

#line default
#line hidden
            );
            __builder.AddAttribute(28, "aria-expanded", "true");
            __builder.AddMarkupContent(29, "\n");
#line 23 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                 if (IsSelected(i, item))
                {

#line default
#line hidden
            __builder.AddMarkupContent(30, "                    <span class=\"rz-accordion-toggle-icon rzi rzi-chevron-down\"></span>\n");
#line 26 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                }
                else
                {

#line default
#line hidden
            __builder.AddMarkupContent(31, "                    <span class=\"rz-accordion-toggle-icon rzi rzi-chevron-right\"></span>\n");
#line 30 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                }

#line default
#line hidden
#line 31 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                 if (!string.IsNullOrEmpty(item.Icon))
                {

#line default
#line hidden
            __builder.AddContent(32, "            ");
            __builder.OpenElement(33, "i");
            __builder.AddAttribute(34, "class", "rzi");
            __builder.AddContent(35, 
#line 33 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                             (MarkupString)item.Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n");
#line 34 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                }

#line default
#line hidden
#line 35 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                 if (!string.IsNullOrEmpty(item.Text))
                {

#line default
#line hidden
            __builder.AddContent(37, "                    ");
            __builder.OpenElement(38, "span");
            __builder.AddContent(39, 
#line 37 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                           item.Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n");
#line 38 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                }

#line default
#line hidden
            __builder.AddContent(41, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
#line 41 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
         if (IsSelected(i, item))
        {

#line default
#line hidden
            __builder.AddContent(44, "            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "rz-accordion-content-wrapper");
            __builder.AddAttribute(47, "role", "tabpanel");
            __builder.AddAttribute(48, "id", 
#line 44 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                       $"rz-accordiontab-{items.IndexOf(item)}-content"

#line default
#line hidden
            );
            __builder.AddAttribute(49, "aria-hidden", "false");
            __builder.AddAttribute(50, "aria-labelledby", 
#line 44 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                                                                                                                 $"rz-accordiontab-{items.IndexOf(item)}"

#line default
#line hidden
            );
            __builder.AddMarkupContent(51, "\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "rz-accordion-content ");
            __builder.AddMarkupContent(54, "\n                    ");
            __builder.AddContent(55, 
#line 46 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
                     item.ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(56, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n");
#line 49 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
        }

#line default
#line hidden
#line 49 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
         
    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n");
#line 52 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAccordion.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenAccordion
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
