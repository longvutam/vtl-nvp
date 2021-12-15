#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\GaugeBand.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ed0494c7b7260b98c4a2157916c9c7418170118"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\GaugeBand.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class GaugeBand : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.Rendering.Path>(0);
            __builder.AddAttribute(1, "D", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\GaugeBand.razor"
         Path

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\GaugeBand.razor"
                      Stroke

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "Fill", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\GaugeBand.razor"
                                   Fill

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\GaugeBand.razor"
                                                     StrokeWidth

#line default
#line hidden
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\GaugeBand.razor"
       
    [Parameter]
    public double StartAngle { get; set; }

    [Parameter]
    public double StrokeWidth { get; set; }

    [Parameter]
    public double EndAngle { get; set; }

    [Parameter]
    public double Min { get; set; }

    [Parameter]
    public double Max { get; set; }

    [Parameter]
    public double From { get; set; }

    [Parameter]
    public double To { get; set; }

    [Parameter]
    public double Radius { get; set; } = 0;

    private string Path { get; set; }

    [Parameter]
    public Point Center { get; set; }

    [Parameter]
    public string Stroke { get; set; } = "none";

    [Parameter]
    public string Fill { get; set; }

    [Parameter]
    public double Size { get; set; }

    double Clip(double v) => Math.Max(Min, Math.Min(v, Max));

    protected override void OnParametersSet()
    {
        var startRatio = (Clip(From) - Min) / (Max - Min);
        var startAngle = StartAngle + startRatio * (EndAngle - StartAngle);

        var outerStart = Center.ToCartesian(Radius, Polar.ToRadian(startAngle - 90));
        var innerStart = Center.ToCartesian(Radius - Size, Polar.ToRadian(startAngle - 90));

        var endRatio = (Clip(To) - Min) / (Max - Min);
        var endAngle = StartAngle + endRatio * (EndAngle - StartAngle);

        var outerEnd = Center.ToCartesian(Radius, Polar.ToRadian(endAngle - 90));
        var innerEnd = Center.ToCartesian(Radius - Size, Polar.ToRadian(endAngle - 90));

        var sweep = endAngle - startAngle <= 180 ? 0 : 1;

        var innerRadius = (Radius - Size).ToInvariantString();
        var radius = Radius.ToInvariantString();

        if (Math.Abs(outerEnd.X - outerStart.X) < 0.01 && Math.Abs(outerEnd.Y - outerEnd.Y) < 0.01)
        {
            // Full circle - SVG can't render a full circle arc 
            outerEnd.X = outerEnd.X - 0.01;
        }

        if (Math.Abs(innerEnd.X - innerStart.X) < 0.01 && Math.Abs(innerEnd.Y - innerEnd.Y) < 0.01)
        {
            // Full circle - SVG can't render a full circle arc 
            innerEnd.X = innerEnd.X - 0.01;
        }

        Path = $"M {outerStart.Render()} A {radius} {radius} 0 {sweep} 1 {outerEnd.Render()} L {innerEnd.Render()} A {innerRadius} {innerRadius} 0 {sweep} 0 {innerStart.Render()} Z";
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
