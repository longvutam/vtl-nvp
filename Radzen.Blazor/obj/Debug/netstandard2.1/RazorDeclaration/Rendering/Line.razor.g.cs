// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class Line : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Line.razor"
       
    [Parameter]
    public string Style { get; set; }
    [Parameter]
    public double X1 { get; set; }
    [Parameter]
    public double X2 { get; set; }
    [Parameter]
    public double Y1 { get; set; }
    [Parameter]
    public double Y2 { get; set; }

    [Parameter]
    public string Stroke { get; set; }

    [Parameter]
    public double StrokeWidth { get; set; }

    [Parameter]
    public LineType LineType { get; set; }

    [Parameter]
    public string Class { get; set;}

#line default
#line hidden
    }
}
#pragma warning restore 1591