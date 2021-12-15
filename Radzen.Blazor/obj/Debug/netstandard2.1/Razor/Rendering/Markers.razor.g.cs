#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09f0a44d91de50a60c024edb05289901c4090f7a"
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
    public partial class Markers<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
 foreach(var data in Data)
{
    var x = Category(data);
    var y = Value(data);

    

#line default
#line hidden
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
     if (InPlotArea(x, y))
    {

#line default
#line hidden
            __builder.AddContent(0, "        ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.Marker>(1);
            __builder.AddAttribute(2, "X", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
                    x

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "Y", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
                           y

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.MarkerType>(
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
                                     MarkerType

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "Fill", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
                                                        Fill

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
                                                                       Stroke

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
                                                                                             StrokeWidth

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
                                                                                                                 Size

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\n");
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
    }

#line default
#line hidden
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
     
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
       
    [CascadingParameter]
    public RadzenChart Chart { get; set;}

    [Parameter]
    public IEnumerable<TItem> Data { get; set; }

    [Parameter]
    public Func<TItem, double> Category { get; set; }
    
    [Parameter]
    public Func<TItem, double> Value { get; set; }

    [Parameter]
    public MarkerType MarkerType { get; set; }

    [Parameter]
    public string Stroke { get; set; }

    [Parameter]
    public string Fill { get; set; }

    [Parameter]
    public double StrokeWidth { get; set; }

    [Parameter]
    public double Size { get; set; }

    private double x1;
    private double x2;

    private double y1;
    private double y2;

    private bool InPlotArea(double x, double y)
    {
        return x >= x1 && x <= x2 && y >= y1 && y <= y2;
    }

    protected override void OnParametersSet()
    {
        var categoryTicks = Chart.CategoryScale.Ticks(Chart.CategoryAxis.TickDistance);

        x1 = Chart.CategoryScale.Scale(categoryTicks.Start);
        x2 = Chart.CategoryScale.Scale(categoryTicks.End);

        var valueTicks = Chart.ValueScale.Ticks(Chart.ValueAxis.TickDistance);

        y1 = Chart.ValueScale.Scale(valueTicks.End);
        y2 = Chart.ValueScale.Scale(valueTicks.Start);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
