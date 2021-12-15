#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cac931280216c784d71775089478a9625a6f5de6"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
using Radzen;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenBarSeries<TItem> : Radzen.Blazor.CartesianSeries<TItem>, IChartBarSeries
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Radzen.Blazor.RadzenBarSeries.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
                        this

#line default
#line hidden
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\n  ");
                __builder2.AddContent(4, 
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
   ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(5, "\n");
            }
            );
        }
        #pragma warning restore 1998
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
       
   public override RenderFragment Render(ScaleBase categoryScale, ScaleBase valueScale)
   {
        var value = ComposeValue(categoryScale);
        var category = ComposeCategory(valueScale);
        var ticks = Chart.CategoryScale.Ticks(Chart.ValueAxis.TickDistance);
        var x0 = Chart.CategoryScale.Scale(Math.Max(0, ticks.Start));
        var style = $"clip-path: url(#{Chart.ClipPath}); -webkit-clip-path: url(#{Chart.ClipPath});";

        var barSeries = VisibleBarSeries;
        var index = barSeries.IndexOf(this);
        var padding = Chart.BarOptions.Margin;

        var barHeight = BandHeight;
        var height = barHeight / barSeries.Count() - padding + padding / barSeries.Count();;
        var className = $"rz-bar-series rz-series-{Chart.Series.IndexOf(this)}";

        return 
        

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(6, "g");
            __builder2.AddAttribute(7, "class", 
#line 30 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
                    className

#line default
#line hidden
            );
            __builder2.AddMarkupContent(8, "\n");
#line 31 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
             foreach(var data in Items)
            {
                var y = category(data) - barHeight / 2 + index * height + index * padding;
                var x = value(data);
                var radius = Chart.BarOptions.Radius;

                if (radius > height / 2)
                {
                    radius = 0;
                }

                var r = radius.ToInvariantString();

                var path = $"M {x0.ToInvariantString()} {y.ToInvariantString()} L {(x-radius).ToInvariantString()} {y.ToInvariantString()} A {r} {r} 0 0 1 {x.ToInvariantString()} {(y+radius).ToInvariantString()} L {x.ToInvariantString()} {(y+height-radius).ToInvariantString()} A {r} {r} 0 0 1 {(x-radius).ToInvariantString()} {(y + height).ToInvariantString()} L {x0.ToInvariantString()} {(y+height).ToInvariantString()} Z";

                if (x < x0)
                {
                    path = $"M {x0.ToInvariantString()} {y.ToInvariantString()} L {(x+radius).ToInvariantString()} {y.ToInvariantString()} A {r} {r} 0 0 0 {x.ToInvariantString()} {(y+radius).ToInvariantString()} L {x.ToInvariantString()} {(y+height-radius).ToInvariantString()} A {r} {r} 0 0 0 {(x+radius).ToInvariantString()} {(y + height).ToInvariantString()} L {x0.ToInvariantString()} {(y+height).ToInvariantString()} Z";
                }
                var fill = PickColor(Items.IndexOf(data), Fills, Fill);
                var stroke = PickColor(Items.IndexOf(data), Strokes, Stroke);


#line default
#line hidden
            __builder2.AddContent(9, "                ");
            __builder2.OpenComponent<Radzen.Blazor.Rendering.Path>(10);
            __builder2.AddAttribute(11, "D", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
                                       path

#line default
#line hidden
            ));
            __builder2.AddAttribute(12, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
                                                      stroke

#line default
#line hidden
            ));
            __builder2.AddAttribute(13, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
                                                                            StrokeWidth

#line default
#line hidden
            ));
            __builder2.AddAttribute(14, "Fill", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
                                                                                                fill

#line default
#line hidden
            ));
            __builder2.AddAttribute(15, "LineType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.LineType>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
                                                                                                                 LineType

#line default
#line hidden
            ));
            __builder2.AddAttribute(16, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
                                                                                                                                   style

#line default
#line hidden
            ));
            __builder2.SetKey(
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
                             path

#line default
#line hidden
            );
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(17, "\n");
#line 54 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
            }

#line default
#line hidden
            __builder2.AddContent(18, "        ");
            __builder2.CloseElement();
        }
#line 55 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenBarSeries.razor"
            ;
    }

#line default
#line hidden
    }
}
namespace __Blazor.Radzen.Blazor.RadzenBarSeries
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
    }
}
#pragma warning restore 1591