#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "778d60c02c94475129b708c60c7270c5929e30ab"
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
    public partial class RadzenLink : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "style", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
                                                             Style

#line default
#line hidden
            );
            __builder.AddAttribute(3, "href", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
                                                                           Path

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
                                                                                              Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "class", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
                                                                                                                  GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(6, "target", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
                                                                                                                                          Target

#line default
#line hidden
            );
            __builder.AddAttribute(7, "id", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
                                                                                                                                                       GetId()

#line default
#line hidden
            );
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n");
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
         if (!string.IsNullOrEmpty(Icon))
        {

#line default
#line hidden
                __builder2.AddContent(10, "            ");
                __builder2.OpenElement(11, "i");
                __builder2.AddAttribute(12, "class", "rzi");
                __builder2.AddContent(13, 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
                             (MarkupString)Icon

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n");
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
        }

#line default
#line hidden
                __builder2.AddContent(15, "        ");
                __builder2.OpenElement(16, "span");
                __builder2.AddAttribute(17, "class", "rz-link-text");
                __builder2.AddElementReferenceCapture(18, (__value) => {
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
                     Element = __value;

#line default
#line hidden
                }
                );
                __builder2.AddContent(19, 
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
                                                    Text

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n");
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenLink.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
