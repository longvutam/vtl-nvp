#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1389756ccb2462fd4c2dcb559539f625a541250a"
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
    public partial class RadzenPanelMenuItem : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "li");
            __builder.AddAttribute(2, "style", 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                    Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                        GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                                  OnClick

#line default
#line hidden
            ));
            __builder.AddEventStopPropagationAttribute(6, "onclick", true);
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                     Selected ? "rz-navigation-item-wrapper rz-navigation-item-wrapper-active" : "rz-navigation-item-wrapper"

#line default
#line hidden
            );
            __builder.AddMarkupContent(10, "\r\n");
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
             if (!string.IsNullOrEmpty(Path))
            {

#line default
#line hidden
            __builder.AddContent(11, "                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(12);
            __builder.AddAttribute(13, "target", 
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                          Target

#line default
#line hidden
            );
            __builder.AddAttribute(14, "class", 
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                                          Selected ? "rz-navigation-item-link rz-navigation-item-link-active" : "rz-navigation-item-link"

#line default
#line hidden
            );
            __builder.AddAttribute(15, "href", 
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                                                                                                                                                  Path

#line default
#line hidden
            );
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n");
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                     if (!string.IsNullOrEmpty(Icon))
                    {

#line default
#line hidden
                __builder2.AddContent(18, "                        ");
                __builder2.OpenElement(19, "i");
                __builder2.AddAttribute(20, "class", "rzi rz-navigation-item-icon");
                __builder2.AddContent(21, 
#line 12 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                 (MarkupString)Icon

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n");
#line 13 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                    }

#line default
#line hidden
#line 14 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                     if (!string.IsNullOrEmpty(Image))
                    {

#line default
#line hidden
                __builder2.AddContent(23, "                        ");
                __builder2.OpenElement(24, "img");
                __builder2.AddAttribute(25, "class", "rz-navigation-item-icon");
                __builder2.AddAttribute(26, "src", 
#line 16 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                   Image

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n");
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                    }

#line default
#line hidden
#line 18 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                     if(Template != null)
                    {
                        

#line default
#line hidden
                __builder2.AddContent(28, 
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                         Template

#line default
#line hidden
                );
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                 
                    }
                    else
                    {

#line default
#line hidden
                __builder2.AddContent(29, "                        ");
                __builder2.OpenElement(30, "span");
                __builder2.AddAttribute(31, "class", "rz-navigation-item-text");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 24 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                         Toggle

#line default
#line hidden
                ));
                __builder2.AddContent(33, 
#line 24 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                                  Text

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n");
#line 25 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                    }

#line default
#line hidden
#line 26 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                     if (items.Any())
                    {

#line default
#line hidden
                __builder2.AddContent(35, "                        ");
                __builder2.OpenElement(36, "i");
                __builder2.AddAttribute(37, "class", "rzi rz-navigation-item-icon-children");
                __builder2.AddAttribute(38, "style", 
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                                getStyle()

#line default
#line hidden
                );
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                                                       Toggle

#line default
#line hidden
                ));
                __builder2.AddEventPreventDefaultAttribute(40, "onclick", true);
                __builder2.AddContent(41, "keyboard_arrow_down");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n");
#line 29 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                    }

#line default
#line hidden
                __builder2.AddContent(43, "                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n");
#line 31 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
            }
            else
            {

#line default
#line hidden
            __builder.AddContent(45, "                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "rz-navigation-item-link");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 34 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                Toggle

#line default
#line hidden
            ));
            __builder.AddMarkupContent(49, "\r\n");
#line 35 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                     if (!string.IsNullOrEmpty(Icon))
                    {

#line default
#line hidden
            __builder.AddContent(50, "                        ");
            __builder.OpenElement(51, "i");
            __builder.AddAttribute(52, "class", "rzi rz-navigation-item-icon");
            __builder.AddContent(53, 
#line 37 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                 (MarkupString)Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#line 38 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                    }

#line default
#line hidden
#line 39 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                     if (!string.IsNullOrEmpty(Image))
                    {

#line default
#line hidden
            __builder.AddContent(55, "                        ");
            __builder.OpenElement(56, "img");
            __builder.AddAttribute(57, "class", "rz-navigation-item-icon");
            __builder.AddAttribute(58, "src", 
#line 41 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                   Image

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#line 42 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                    }

#line default
#line hidden
#line 43 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                     if(Template != null)
                    {
                        

#line default
#line hidden
            __builder.AddContent(60, 
#line 45 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                         Template

#line default
#line hidden
            );
#line 45 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                 
                    }
                    else
                    {

#line default
#line hidden
            __builder.AddContent(61, "                        ");
            __builder.OpenElement(62, "span");
            __builder.AddAttribute(63, "class", "rz-navigation-item-text");
            __builder.AddContent(64, 
#line 49 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                               Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#line 50 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                    }

#line default
#line hidden
#line 51 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                     if (items.Any())
                    {

#line default
#line hidden
            __builder.AddContent(66, "                        ");
            __builder.OpenElement(67, "i");
            __builder.AddAttribute(68, "class", "rzi rz-navigation-item-icon-children");
            __builder.AddAttribute(69, "style", 
#line 53 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                                                getStyle()

#line default
#line hidden
            );
            __builder.AddContent(70, "keyboard_arrow_down");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#line 54 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                    }

#line default
#line hidden
            __builder.AddContent(72, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#line 56 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
            }

#line default
#line hidden
            __builder.AddContent(74, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
#line 58 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
         if (ChildContent != null)
        {

#line default
#line hidden
            __builder.AddContent(76, "            ");
            __builder.OpenElement(77, "ul");
            __builder.AddAttribute(78, "class", "rz-navigation-menu");
            __builder.AddAttribute(79, "style", 
#line 60 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                                   getItemStyle()

#line default
#line hidden
            );
            __builder.AddMarkupContent(80, "\r\n                ");
            __Blazor.Radzen.Blazor.RadzenPanelMenuItem.TypeInference.CreateCascadingValue_0(__builder, 81, 82, 
#line 61 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                                      this

#line default
#line hidden
            , 83, (__builder2) => {
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.AddContent(85, 
#line 62 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
                     ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(86, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
#line 65 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
        }

#line default
#line hidden
            __builder.AddContent(89, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#line 67 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPanelMenuItem.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
namespace __Blazor.Radzen.Blazor.RadzenPanelMenuItem
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
