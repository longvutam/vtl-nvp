#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fa788dc07418b836a9f575da74f27e155335269"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenPieSeries<TItem> : Radzen.Blazor.CartesianSeries<TItem>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Radzen.Blazor.RadzenPieSeries.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                        this

#line default
#line hidden
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n  ");
                __builder2.AddContent(4, 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
   ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(5, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
       
   public override RenderFragment Render(ScaleBase categoryScale, ScaleBase valueScale)
   {
        var className = $"rz-pie-series rz-series-{Chart.Series.IndexOf(this)}";
        var x = CenterX;
        var y = CenterY;
        var radius = CurrentRadius;

        return 
        

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(6, "g");
            __builder2.AddAttribute(7, "class", 
#line 18 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                    className

#line default
#line hidden
            );
            __builder2.AddMarkupContent(8, "\r\n");
#line 19 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
             if (Items.Any())
            {
                var sum = Items.Sum(Value);

                double startAngle = -90;

                

#line default
#line hidden
#line 25 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                 foreach(var data in Items)
                {
                    var value = Value(data);
                    var angle = sum == 0 ? 0 : (value / sum) * 360;
                    var endAngle = startAngle + angle;

                    var d = Segment(x, y, radius, 0, startAngle, endAngle);

                    startAngle = endAngle;
                    
                    var index = Items.IndexOf(data);
                    var arcClassName = $"rz-series-item-{index}";
                    var fill = PickColor(index, Fills);
                    var stroke = PickColor(index, Strokes);


#line default
#line hidden
            __builder2.AddContent(9, "                    ");
            __builder2.OpenElement(10, "g");
            __builder2.AddAttribute(11, "class", 
#line 40 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                               arcClassName

#line default
#line hidden
            );
            __builder2.AddMarkupContent(12, "\r\n");
#line 41 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                         if (angle > 0)
                        {

#line default
#line hidden
            __builder2.AddContent(13, "                            ");
            __builder2.OpenComponent<Radzen.Blazor.Rendering.Path>(14);
            __builder2.AddAttribute(15, "D", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 43 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                                      d

#line default
#line hidden
            ));
            __builder2.AddAttribute(16, "Fill", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 43 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                                                fill

#line default
#line hidden
            ));
            __builder2.AddAttribute(17, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 43 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                                                                    StrokeWidth

#line default
#line hidden
            ));
            __builder2.AddAttribute(18, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 43 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                                                                                          stroke

#line default
#line hidden
            ));
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(19, "\r\n");
#line 44 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                        }

#line default
#line hidden
            __builder2.AddContent(20, "                    ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(21, "\r\n");
#line 46 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                }

#line default
#line hidden
#line 46 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
                 
            }

#line default
#line hidden
            __builder2.AddContent(22, "        ");
            __builder2.CloseElement();
        }
#line 48 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPieSeries.razor"
            ;
    }

#line default
#line hidden
    }
}
namespace __Blazor.Radzen.Blazor.RadzenPieSeries
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
