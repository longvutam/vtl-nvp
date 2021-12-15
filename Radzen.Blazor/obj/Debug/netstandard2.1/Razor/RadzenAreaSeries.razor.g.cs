#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e36af66219ddab9b02790d4baf5120e454543fde"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenAreaSeries<TItem> : Radzen.Blazor.CartesianSeries<TItem>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Radzen.Blazor.RadzenAreaSeries.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                        this

#line default
#line hidden
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\n  ");
                __builder2.AddContent(4, 
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
   ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(5, "\n");
            }
            );
        }
        #pragma warning restore 1998
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
       
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
    });

    var ticks = Chart.CategoryScale.Ticks(Chart.CategoryAxis.TickDistance);
    var index = Chart.Series.IndexOf(this);
    var className = $"rz-area-series rz-series-{index}";

    return 
    

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(6, "g");
            __builder2.AddAttribute(7, "class", 
#line 39 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                className

#line default
#line hidden
            );
            __builder2.AddMarkupContent(8, "\n");
#line 40 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
       if (Items.Any())
      {
        var x1 = category(Items.First()).ToInvariantString();
        var x2 = category(Items.Last()).ToInvariantString();
        var valueTicks = Chart.ValueScale.Ticks(Chart.ValueAxis.TickDistance);
        var start = Math.Max(0, valueTicks.Start);
        var y = Chart.ValueScale.Scale(start).ToInvariantString();
        var style = $"clip-path: url(#{Chart.ClipPath}); -webkit-clip-path: url(#{Chart.ClipPath});";
        var path = pathGenerator.Path(data);
        var area = $"M {x1} {y} {path} L {x2} {y}";
        var line = $"M {path}";


#line default
#line hidden
            __builder2.AddContent(9, "        ");
            __builder2.OpenElement(10, "path");
            __builder2.AddAttribute(11, "style", 
#line 52 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                   style

#line default
#line hidden
            );
            __builder2.AddAttribute(12, "d", 
#line 52 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                              area

#line default
#line hidden
            );
            __builder2.AddAttribute(13, "fill", 
#line 52 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                                           Fill

#line default
#line hidden
            );
            __builder2.AddAttribute(14, "stroke", "none");
            __builder2.SetKey(
#line 52 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                     area

#line default
#line hidden
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(15, "\n        ");
            __builder2.OpenComponent<Radzen.Blazor.Rendering.Path>(16);
            __builder2.AddAttribute(17, "D", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                               line

#line default
#line hidden
            ));
            __builder2.AddAttribute(18, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                              Stroke

#line default
#line hidden
            ));
            __builder2.AddAttribute(19, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                                                    StrokeWidth

#line default
#line hidden
            ));
            __builder2.AddAttribute(20, "LineType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.LineType>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                                                                            LineType

#line default
#line hidden
            ));
            __builder2.AddAttribute(21, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                                                                                              style

#line default
#line hidden
            ));
            __builder2.AddAttribute(22, "Fill", "none");
            __builder2.SetKey(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                     line

#line default
#line hidden
            );
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(23, "\n");
#line 54 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
      }

#line default
#line hidden
            __builder2.AddContent(24, "      ");
            __Blazor.Radzen.Blazor.RadzenAreaSeries.TypeInference.CreateMarkers_1(__builder2, 25, 26, 
#line 55 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                      Items

#line default
#line hidden
            , 27, 
#line 55 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                        category

#line default
#line hidden
            , 28, 
#line 55 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                                          value

#line default
#line hidden
            , 29, 
#line 55 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                                                              MarkerType

#line default
#line hidden
            , 30, 
#line 55 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                                                                                   Markers.Stroke

#line default
#line hidden
            , 31, 
#line 55 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                                                                                                           Markers.Fill ?? Stroke

#line default
#line hidden
            , 32, 
#line 55 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                                                                                                                                                  Markers.StrokeWidth

#line default
#line hidden
            , 33, 
#line 55 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
                                                                                                                                                                                              Markers.Size

#line default
#line hidden
            );
            __builder2.AddMarkupContent(34, "\n    ");
            __builder2.CloseElement();
        }
#line 56 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenAreaSeries.razor"
        ;
  }

#line default
#line hidden
    }
}
namespace __Blazor.Radzen.Blazor.RadzenAreaSeries
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
        public static void CreateMarkers_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Func<TItem, global::System.Double> __arg1, int __seq2, global::System.Func<TItem, global::System.Double> __arg2, int __seq3, global::Radzen.Blazor.MarkerType __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Double __arg6, int __seq7, global::System.Double __arg7)
        {
        __builder.OpenComponent<global::Radzen.Blazor.Rendering.Markers<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Category", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "MarkerType", __arg3);
        __builder.AddAttribute(__seq4, "Stroke", __arg4);
        __builder.AddAttribute(__seq5, "Fill", __arg5);
        __builder.AddAttribute(__seq6, "StrokeWidth", __arg6);
        __builder.AddAttribute(__seq7, "Size", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591