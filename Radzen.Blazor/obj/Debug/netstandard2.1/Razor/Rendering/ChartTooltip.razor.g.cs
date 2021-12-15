#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a2e1d2bfcc82cb7930ae941609be7c0cc365fb7"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor.Rendering
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
    public partial class ChartTooltip : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "rz-chart-tooltip" + " " + (
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
                              Class

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "style", "left:" + " " + (
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
                                                    X.ToInvariantString()

#line default
#line hidden
            ) + "px;" + " top:" + " " + (
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
                                                                                     Y.ToInvariantString()

#line default
#line hidden
            ) + "px");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "rz-chart-tooltip-content");
            __builder.AddAttribute(6, "style", 
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
                                                  Style

#line default
#line hidden
            );
            __builder.AddMarkupContent(7, "\n");
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
     if (ChildContent != null)
    {
        

#line default
#line hidden
            __builder.AddContent(8, 
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
         ChildContent

#line default
#line hidden
            );
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
                     
    }
    else
    {

#line default
#line hidden
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "div");
            __builder.AddContent(11, 
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
              Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "label");
            __builder.AddContent(14, 
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
                 $"{Label}:"

#line default
#line hidden
            );
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "strong");
            __builder.AddContent(17, 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
                     Value

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
    }

#line default
#line hidden
            __builder.AddContent(20, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 17 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ChartTooltip.razor"
       
    [Parameter]
    public string Style { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public double X { get; set; }

    [Parameter]
    public double Y { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Value { get; set; }

    [Parameter]
    public string Label { get; set; }

    [Parameter]
    public string Class { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
