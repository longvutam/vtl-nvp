#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea5b13085319f4f9cc9053fee2d53cb53223ded"
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
    public partial class RadzenProfileMenuItem : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "li");
            __builder.AddMultipleAttributes(2, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                     Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "class", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                                         GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(4, "style", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                                                                Style

#line default
#line hidden
            );
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                                                                                  OnClick

#line default
#line hidden
            ));
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "rz-navigation-item-wrapper");
            __builder.AddMarkupContent(9, "\r\n");
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
             if (!string.IsNullOrEmpty(Path))
            {

#line default
#line hidden
            __builder.AddContent(10, "                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "target", 
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                                                                          Target

#line default
#line hidden
            );
            __builder.AddAttribute(13, "class", "rz-navigation-item-link");
            __builder.AddAttribute(14, "href", 
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                                                                                                                         Path

#line default
#line hidden
            );
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n");
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                     if (!string.IsNullOrEmpty(Icon))
                    {

#line default
#line hidden
                __builder2.AddContent(17, "                        ");
                __builder2.OpenElement(18, "i");
                __builder2.AddAttribute(19, "class", "rzi rz-navigation-item-icon");
                __builder2.AddContent(20, 
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                                                                 (MarkupString)Icon

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n");
#line 12 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                    }

#line default
#line hidden
                __builder2.AddContent(22, "                    ");
                __builder2.OpenElement(23, "span");
                __builder2.AddAttribute(24, "class", "rz-navigation-item-text");
                __builder2.AddContent(25, 
#line 13 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                                                           Text

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n");
#line 15 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
            }
            else
            {
                

#line default
#line hidden
#line 18 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                 if (!string.IsNullOrEmpty(Icon))
                {

#line default
#line hidden
            __builder.AddContent(28, "                    ");
            __builder.OpenElement(29, "i");
            __builder.AddAttribute(30, "class", "rzi rz-navigation-item-icon");
            __builder.AddContent(31, 
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                                                             (MarkupString)Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                }

#line default
#line hidden
            __builder.AddContent(33, "                ");
            __builder.OpenElement(34, "span");
            __builder.AddAttribute(35, "class", "rz-navigation-item-text");
            __builder.AddContent(36, 
#line 22 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
                                                       Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
            }

#line default
#line hidden
            __builder.AddContent(38, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#line 26 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenProfileMenuItem.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
