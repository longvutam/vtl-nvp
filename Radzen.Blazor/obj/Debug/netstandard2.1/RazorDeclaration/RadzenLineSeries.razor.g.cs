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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
using System.Text;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenLineSeries<TItem> : Radzen.Blazor.CartesianSeries<TItem>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
       
  public override RenderFragment Render(ScaleBase categoryScale, ScaleBase valueScale)
  {
    var category = ComposeCategory(categoryScale);

    var value = ComposeValue(valueScale);

    IPathGenerator pathGenerator;
      
    if (Smooth)
    {
      pathGenerator = new SplineGenerator();
    }
    else
    {
      pathGenerator = new LineGenerator();
    }

    var data = Items.Select(item => 
    {
      var x = category(item);
      var y = value(item);

      return new Point { X = x, Y = y };
    }).ToList();

    var style = $"clip-path: url(#{Chart.ClipPath}); -webkit-clip-path: url(#{Chart.ClipPath});";
    var index = Chart.Series.IndexOf(this);
    var className = $"rz-line-series rz-series-{index}";

    return 
    

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(0, "g");
            __builder2.AddAttribute(1, "class", 
#line 40 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                className

#line default
#line hidden
            );
            __builder2.AddMarkupContent(2, "\n");
#line 41 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
       if (Items.Any())
      {
        var path = $"M {pathGenerator.Path(data)}";
        var key = $"{path}-{LineType}";

#line default
#line hidden
            __builder2.AddContent(3, "        ");
            __builder2.OpenElement(4, "Path");
            __builder2.AddAttribute(5, "@key", 
#line 45 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                    key

#line default
#line hidden
            );
            __builder2.AddAttribute(6, "Style", 
#line 45 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                style

#line default
#line hidden
            );
            __builder2.AddAttribute(7, "D", 
#line 45 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                           path

#line default
#line hidden
            );
            __builder2.AddAttribute(8, "StrokeWidth", 
#line 45 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                                               StrokeWidth

#line default
#line hidden
            );
            __builder2.AddAttribute(9, "Stroke", 
#line 45 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                                                                     Stroke

#line default
#line hidden
            );
            __builder2.AddAttribute(10, "LineType", 
#line 45 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                                                                                        LineType

#line default
#line hidden
            );
            __builder2.AddAttribute(11, "Fill", "none");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(12, "\n");
#line 46 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
      }

#line default
#line hidden
            __builder2.AddContent(13, "      ");
            __builder2.OpenElement(14, "Markers");
            __builder2.AddAttribute(15, "Data", 
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                      Items

#line default
#line hidden
            );
            __builder2.AddAttribute(16, "Category", 
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                        category

#line default
#line hidden
            );
            __builder2.AddAttribute(17, "Value", 
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                                          value

#line default
#line hidden
            );
            __builder2.AddAttribute(18, "MarkerType", 
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                                                              MarkerType

#line default
#line hidden
            );
            __builder2.AddAttribute(19, "Stroke", 
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                                                                                   Markers.Stroke

#line default
#line hidden
            );
            __builder2.AddAttribute(20, "Fill", 
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                                                                                                           Markers.Fill ?? Stroke

#line default
#line hidden
            );
            __builder2.AddAttribute(21, "StrokeWidth", 
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                                                                                                                                                  Markers.StrokeWidth

#line default
#line hidden
            );
            __builder2.AddAttribute(22, "Size", 
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
                                                                                                                                                                                              Markers.Size

#line default
#line hidden
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(23, "\n    ");
            __builder2.CloseElement();
        }
#line 48 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenLineSeries.razor"
        ;
  }

#line default
#line hidden
    }
}
#pragma warning restore 1591