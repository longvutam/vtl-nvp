#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe31df17fcb4f05eef69f38dda0eb1dcb51660d4"
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
    public partial class RadzenFieldset : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "fieldset");
            __builder.AddMultipleAttributes(2, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                           Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "class", 
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                                               GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(4, "style", 
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                                                                      Style

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                                                                                  GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                     Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "legend");
            __builder.AddAttribute(9, "class", "rz-fieldset-legend");
            __builder.AddAttribute(10, "style", "white-space:nowrap");
            __builder.AddMarkupContent(11, "\n\n");
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
             if (AllowCollapse)
            {

#line default
#line hidden
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", "javascript:void(0)");
            __builder.AddAttribute(15, "aria-controls", "rz-fieldset-0-content");
            __builder.AddAttribute(16, "aria-expanded", "false");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                                                                                                   Toggle

#line default
#line hidden
            ));
            __builder.AddMarkupContent(18, "\n");
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                 if (collapsed)
                {

#line default
#line hidden
            __builder.AddMarkupContent(19, "                    <span class=\"rz-fieldset-toggler rzi rzi-w rzi-plus\"></span>\n");
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                }
                else
                {

#line default
#line hidden
            __builder.AddMarkupContent(20, "                    <span class=\"rz-fieldset-toggler rzi rzi-w rzi-minus\"></span>\n");
#line 18 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                }

#line default
#line hidden
            __builder.AddMarkupContent(21, "\n");
#line 20 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                 if (!string.IsNullOrEmpty(Icon))
                {

#line default
#line hidden
            __builder.AddContent(22, "                    ");
            __builder.OpenElement(23, "i");
            __builder.AddAttribute(24, "class", "rzi");
            __builder.AddContent(25, 
#line 22 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                     (MarkupString)Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.OpenElement(26, "span");
            __builder.AddContent(27, 
#line 22 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                                                   Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
#line 23 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                }
                else
                {

#line default
#line hidden
            __builder.AddContent(29, "                    ");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "rz-fieldset-legend-text");
            __builder.AddContent(32, 
#line 26 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                                           Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
#line 27 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                }

#line default
#line hidden
            __builder.AddContent(34, "                ");
            __builder.AddContent(35, 
#line 28 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                 HeaderTemplate

#line default
#line hidden
            );
            __builder.AddMarkupContent(36, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
#line 30 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
            } 
            else
            {
                

#line default
#line hidden
#line 33 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                 if (!string.IsNullOrEmpty(Icon))
                {

#line default
#line hidden
            __builder.AddContent(38, "                    ");
            __builder.OpenElement(39, "i");
            __builder.AddAttribute(40, "class", "rzi");
            __builder.AddContent(41, 
#line 35 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                     (MarkupString)Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.OpenElement(42, "span");
            __builder.AddContent(43, 
#line 35 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                                                   Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n");
#line 36 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                }
                else
                {

#line default
#line hidden
            __builder.AddContent(45, "                    ");
            __builder.OpenElement(46, "span");
            __builder.AddAttribute(47, "class", "rz-fieldset-legend-text");
            __builder.AddContent(48, 
#line 39 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                                           Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
#line 40 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                }

#line default
#line hidden
            __builder.AddContent(50, 
#line 41 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                 HeaderTemplate

#line default
#line hidden
            );
#line 41 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                               
            }

#line default
#line hidden
            __builder.AddContent(51, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "rz-fieldset-content-wrapper");
            __builder.AddAttribute(55, "role", "region");
            __builder.AddAttribute(56, "id", "rz-fieldset-0-content");
            __builder.AddAttribute(57, "aria-hidden", "false");
            __builder.AddAttribute(58, "style", 
#line 44 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                                                                                                      contentStyle

#line default
#line hidden
            );
            __builder.AddMarkupContent(59, "\n            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "rz-fieldset-content");
            __builder.AddMarkupContent(62, "\n                ");
            __builder.AddContent(63, 
#line 46 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                 ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(64, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n");
#line 49 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
         if (SummaryTemplate != null)
        {

#line default
#line hidden
            __builder.AddContent(67, "            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "rz-fieldset-content-wrapper");
            __builder.AddAttribute(70, "role", "region");
            __builder.AddAttribute(71, "aria-hidden", "false");
            __builder.AddAttribute(72, "style", 
#line 51 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                                                                                               summaryContentStyle

#line default
#line hidden
            );
            __builder.AddMarkupContent(73, "\n                ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "rz-fieldset-content rz-fieldset-content-summary");
            __builder.AddMarkupContent(76, "\n                    ");
            __builder.AddContent(77, 
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
                     SummaryTemplate

#line default
#line hidden
            );
            __builder.AddMarkupContent(78, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n");
#line 56 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
        }

#line default
#line hidden
            __builder.AddContent(81, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n");
#line 58 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenFieldset.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
