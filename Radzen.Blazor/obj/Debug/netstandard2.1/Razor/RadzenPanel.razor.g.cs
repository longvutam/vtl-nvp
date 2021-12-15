#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d12ac1bb685ed8c22543fdd8b987c469c1362a"
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
    public partial class RadzenPanel : RadzenComponentWithChildren
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", 
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                                 Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                                                     Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                                                                         GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                                                                                             GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "rz-panel-titlebar");
            __builder.AddMarkupContent(10, "\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\n");
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                 if (!string.IsNullOrEmpty(Icon))
                {

#line default
#line hidden
            __builder.AddContent(13, "                    ");
            __builder.OpenElement(14, "i");
            __builder.AddAttribute(15, "class", "rzi");
            __builder.AddContent(16, 
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                                     (MarkupString)Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                }

#line default
#line hidden
            __builder.AddContent(18, "                ");
            __builder.OpenElement(19, "span");
            __builder.AddContent(20, 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                       Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n            ");
            __builder.AddContent(23, 
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
             HeaderTemplate

#line default
#line hidden
            );
            __builder.AddMarkupContent(24, "\n");
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
             if (AllowCollapse)
            {
                

#line default
#line hidden
#line 16 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                 if (collapsed)
                {

#line default
#line hidden
            __builder.AddContent(25, "                    ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 18 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                                 Toggle

#line default
#line hidden
            ));
            __builder.AddAttribute(28, "class", "rz-panel-titlebar-icon rz-panel-titlebar-toggler");
            __builder.AddAttribute(29, "href", "javascript:void(0)");
            __builder.AddAttribute(30, "role", "tab");
            __builder.AddAttribute(31, "id", "rz-panel-0-label");
            __builder.AddAttribute(32, "aria-controls", "rz-panel-0-content");
            __builder.AddAttribute(33, "aria-expanded", "false");
            __builder.AddMarkupContent(34, "\n                        <span class=\"rzi rzi-plus\"></span>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
#line 21 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                }
                else
                {

#line default
#line hidden
            __builder.AddContent(36, "                    ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                                 Toggle

#line default
#line hidden
            ));
            __builder.AddAttribute(39, "class", "rz-panel-titlebar-icon rz-panel-titlebar-toggler");
            __builder.AddAttribute(40, "href", "javascript:void(0)");
            __builder.AddAttribute(41, "role", "tab");
            __builder.AddAttribute(42, "id", "rz-panel-0-label");
            __builder.AddAttribute(43, "aria-controls", "rz-panel-0-content");
            __builder.AddAttribute(44, "aria-expanded", "true");
            __builder.AddMarkupContent(45, "\n                        <span class=\"rzi rzi-minus\"></span>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n");
#line 27 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                }

#line default
#line hidden
#line 27 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                 
            }

#line default
#line hidden
            __builder.AddContent(47, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "rz-panel-content-wrapper");
            __builder.AddAttribute(51, "role", "region");
            __builder.AddAttribute(52, "aria-hidden", "false");
            __builder.AddAttribute(53, "style", 
#line 30 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                                                                                        contentStyle

#line default
#line hidden
            );
            __builder.AddMarkupContent(54, "\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "rz-panel-content");
            __builder.AddMarkupContent(57, "\n                ");
            __builder.AddContent(58, 
#line 32 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                 ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(59, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n");
#line 34 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
             if (FooterTemplate != null)
            {

#line default
#line hidden
            __builder.AddContent(61, "                ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "rz-panel-footer");
            __builder.AddMarkupContent(64, "\n                    ");
            __builder.AddContent(65, 
#line 37 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                     FooterTemplate

#line default
#line hidden
            );
            __builder.AddMarkupContent(66, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n");
#line 39 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
            }

#line default
#line hidden
            __builder.AddContent(68, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n");
#line 41 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
         if (SummaryTemplate != null)
        {

#line default
#line hidden
            __builder.AddContent(70, "            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "rz-panel-content-wrapper");
            __builder.AddAttribute(73, "role", "region");
            __builder.AddAttribute(74, "aria-hidden", "false");
            __builder.AddAttribute(75, "style", 
#line 43 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                                                                                            summaryContentStyle

#line default
#line hidden
            );
            __builder.AddMarkupContent(76, "\n                ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "rz-panel-content rz-panel-content-summary");
            __builder.AddMarkupContent(79, "\n                    ");
            __builder.AddContent(80, 
#line 45 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
                     SummaryTemplate

#line default
#line hidden
            );
            __builder.AddMarkupContent(81, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\n");
#line 48 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
        }

#line default
#line hidden
            __builder.AddContent(84, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n");
#line 50 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenPanel.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
