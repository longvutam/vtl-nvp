#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "638514373d7eeb8a2a680cae671d30b024396d92"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenTabsItem : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "li");
            __builder.AddAttribute(2, "role", "presentation");
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                                         Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "style", 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                                                           Style

#line default
#line hidden
            );
            __builder.AddAttribute(5, "class", 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                                                                        ClassList

#line default
#line hidden
            );
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "a");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                 OnClick

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "role", "tab");
            __builder.AddAttribute(10, "href", "javascript: void(0)");
            __builder.AddAttribute(11, "id", 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                                                                     $"{Tabs.Id}-tabpanel-{Index}-label"

#line default
#line hidden
            );
            __builder.AddAttribute(12, "aria-selected", 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                        IsSelected? "true" : "false"

#line default
#line hidden
            );
            __builder.AddAttribute(13, "aria-controls", 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                                                                       $"{Tabs.Id}-tabpanel-{Index}"

#line default
#line hidden
            );
            __builder.AddMarkupContent(14, "\r\n");
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
         if (!string.IsNullOrEmpty(Icon))
            {

#line default
#line hidden
            __builder.AddContent(15, "                ");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "rz-tabview-left-icon rzi");
            __builder.AddContent(18, 
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                                                         (MarkupString)Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
            }

#line default
#line hidden
#line 12 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
             if (Template != null)
            {
                

#line default
#line hidden
            __builder.AddContent(20, 
#line 14 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                 Template(this)

#line default
#line hidden
            );
#line 14 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                               
            }
            else
            {

#line default
#line hidden
            __builder.AddContent(21, "                ");
            __builder.OpenElement(22, "span");
            __builder.AddAttribute(23, "class", "rz-tabview-title");
            __builder.AddContent(24, 
#line 18 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
                                                Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#line 19 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
            }

#line default
#line hidden
            __builder.AddContent(26, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#line 22 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTabsItem.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
