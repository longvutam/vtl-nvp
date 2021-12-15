#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aaf3b34b9ae772a8f84c08f82aed4a35da5c470"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
using System.Diagnostics;

#line default
#line hidden
    public partial class RadzenSplitterPane : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
              GetId()

#line default
#line hidden
            );
            __builder.AddAttribute(3, "class", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                               GetComponentCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(4, "style", "flex-basis:" + " " + (
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                                                                           Size

#line default
#line hidden
            ) + ";");
            __builder.AddAttribute(5, "data-index", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                                                                                               Index

#line default
#line hidden
            );
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddContent(7, 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
         ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(8, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
     if (!IsLast)
    {

#line default
#line hidden
            __builder.AddContent(10, "        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", 
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                     GetComponentBarCssClass()

#line default
#line hidden
            );
            __builder.AddEventPreventDefaultAttribute(13, "onclick", 
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                                      true

#line default
#line hidden
            );
            __builder.AddEventStopPropagationAttribute(14, "onclick", 
#line 16 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                                       true

#line default
#line hidden
            );
            __builder.AddAttribute(15, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 17 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                            args => Splitter.ResizeExec(args, Index)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(16, "\n\n");
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
             if (IsCollapsible)
            {

#line default
#line hidden
            __builder.AddContent(17, "                ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "rz-collapse");
            __builder.AddEventPreventDefaultAttribute(20, "onmousedown", 
#line 21 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                                                                       true

#line default
#line hidden
            );
            __builder.AddEventStopPropagationAttribute(21, "onmousedown", 
#line 21 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                                                                                                           true

#line default
#line hidden
            );
            __builder.AddAttribute(22, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 21 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                                                                                                                                args => Splitter.CollapseExec(args, Index, UniqueID)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(23, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
#line 23 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
            }

#line default
#line hidden
            __builder.AddMarkupContent(25, "\n");
#line 25 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
             if (IsResizable)
            {

#line default
#line hidden
            __builder.AddContent(26, "                ");
            __builder.AddMarkupContent(27, "<span class=\"rz-resize\">\n                </span>\n");
#line 29 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
            }

#line default
#line hidden
            __builder.AddMarkupContent(28, "\n");
#line 31 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
             if (IsExpandable)
            {

#line default
#line hidden
            __builder.AddContent(29, "                ");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "rz-expand");
            __builder.AddEventPreventDefaultAttribute(32, "onmousedown", 
#line 33 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                                                                     true

#line default
#line hidden
            );
            __builder.AddEventStopPropagationAttribute(33, "onmousedown", 
#line 33 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                                                                                                         true

#line default
#line hidden
            );
            __builder.AddAttribute(34, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 33 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
                                                                                                                              args => Splitter.ExpandExec(args, Index, UniqueID)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(35, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n");
#line 35 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
            }

#line default
#line hidden
            __builder.AddMarkupContent(37, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n");
#line 39 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
    }

#line default
#line hidden
#line 39 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSplitterPane.razor"
     
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591