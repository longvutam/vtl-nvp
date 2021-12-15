// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Radzen.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenColumnSeries<TItem> : Radzen.Blazor.CartesianSeries<TItem>, IChartColumnSeries
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 10 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
       
    public override RenderFragment Render(ScaleBase categoryScale, ScaleBase valueScale)
    {
        var category = ComposeCategory(categoryScale);
        var value = ComposeValue(valueScale);
        var ticks = Chart.ValueScale.Ticks(Chart.ValueAxis.TickDistance);
        var y0 = Chart.ValueScale.Scale(Math.Max(0, ticks.Start));
        var style = $"clip-path: url(#{Chart.ClipPath}); -webkit-clip-path: url(#{Chart.ClipPath});";

        var columnSeries = VisibleColumnSeries;
        var index = columnSeries.IndexOf(this);
        var padding = Chart.ColumnOptions.Margin;

        var bandWidth = BandWidth;
        var width = bandWidth / columnSeries.Count() - padding + padding / columnSeries.Count();;
        var className = $"rz-column-series rz-series-{Chart.Series.IndexOf(this)}";

        return 
        

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(0, "g");
            __builder2.AddAttribute(1, "class", 
#line 28 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
                    className

#line default
#line hidden
            );
            __builder2.AddMarkupContent(2, "\r\n");
#line 29 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
             foreach(var data in Items)
            {
                var x = category(data) - bandWidth / 2 + index * width + index * padding;
                var y = value(data);
                var radius = Chart.ColumnOptions.Radius;

                if (radius > width / 2)
                {
                    radius = 0;
                }

                var path = $"M {x.ToInvariantString()} {(y+radius).ToInvariantString()} A {radius.ToInvariantString()} {radius.ToInvariantString()} 0 0 1 {(x + radius).ToInvariantString()} {y.ToInvariantString()} L {(x + width - radius).ToInvariantString()} {y.ToInvariantString()} A {radius.ToInvariantString()} {radius.ToInvariantString()} 0 0 1 {(x + width).ToInvariantString()} {(y+radius).ToInvariantString()} L {(x+width).ToInvariantString()} {y0.ToInvariantString()} L {x.ToInvariantString()} {y0.ToInvariantString()} Z";

                if (y > y0)
                {
                    path = $"M {x.ToInvariantString()} {y0.ToInvariantString()} L {(x+width).ToInvariantString()} {y0.ToInvariantString()} L {(x+width).ToInvariantString()} {(y-radius).ToInvariantString()} A {radius.ToInvariantString()} {radius.ToInvariantString()} 0 0 1 {(x + width - radius).ToInvariantString()} {y.ToInvariantString()} L {(x + radius).ToInvariantString()} {y.ToInvariantString()} A {radius.ToInvariantString()} {radius.ToInvariantString()} 0 0 1 {x.ToInvariantString()} {(y-radius).ToInvariantString()} L {x.ToInvariantString()} {y0.ToInvariantString()} Z";
                }
                var fill = PickColor(Items.IndexOf(data), Fills, Fill);
                var stroke = PickColor(Items.IndexOf(data), Strokes, Stroke);


#line default
#line hidden
            __builder2.AddContent(3, "                ");
            __builder2.OpenElement(4, "Path");
            __builder2.AddAttribute(5, "@key", 
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
                             path

#line default
#line hidden
            );
            __builder2.AddAttribute(6, "D", 
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
                                       path

#line default
#line hidden
            );
            __builder2.AddAttribute(7, "Stroke", 
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
                                                      stroke

#line default
#line hidden
            );
            __builder2.AddAttribute(8, "StrokeWidth", 
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
                                                                            StrokeWidth

#line default
#line hidden
            );
            __builder2.AddAttribute(9, "Fill", 
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
                                                                                                fill

#line default
#line hidden
            );
            __builder2.AddAttribute(10, "LineType", 
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
                                                                                                                 LineType

#line default
#line hidden
            );
            __builder2.AddAttribute(11, "Style", 
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
                                                                                                                                   style

#line default
#line hidden
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(12, "\r\n");
#line 50 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
            }

#line default
#line hidden
            __builder2.AddContent(13, "        ");
            __builder2.CloseElement();
        }
#line 51 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenColumnSeries.razor"
            ;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
