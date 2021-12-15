#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48eb651b250b5f04db58fb242838a8c7cad91b1f"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenDonutSeries<TItem> : Radzen.Blazor.RadzenPieSeries<TItem>, Radzen.Blazor.IChartDonutSeries
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Radzen.Blazor.RadzenDonutSeries.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                        this

#line default
#line hidden
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\n  ");
                __builder2.AddContent(4, 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
   ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(5, "\n");
            }
            );
        }
        #pragma warning restore 1998
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
       
    public RenderFragment RenderTitle(double x, double y)
    {
      if (TitleTemplate == null)
      {
        return null;
      }

        var radius = CurrentRadius;
        var innerRadius = InnerRadius ?? radius / 2;

        var left = (x + CenterX - innerRadius).ToInvariantString();
        var top = (y + CenterY - innerRadius).ToInvariantString();
        var width = innerRadius * 2;
        var height = innerRadius * 2;

      return 

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(6, "div");
            __builder2.AddAttribute(7, "style", "position:" + " absolute;left:" + " " + (
#line 26 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                                     left

#line default
#line hidden
            ) + "px;top:" + " " + (
#line 26 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                                                    top

#line default
#line hidden
            ) + "px;width:" + " " + (
#line 26 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                                                                    width

#line default
#line hidden
            ) + "px;" + " height:" + " " + (
#line 26 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                                                                                        height

#line default
#line hidden
            ) + "px;");
            __builder2.AddMarkupContent(8, "\n                ");
            __builder2.AddContent(9, 
#line 27 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                 TitleTemplate

#line default
#line hidden
            );
            __builder2.AddMarkupContent(10, "\n            ");
            __builder2.CloseElement();
        }
#line 28 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                  ;
      }

   public override RenderFragment Render(ScaleBase categoryScale, ScaleBase valueScale)
   {
        var className = $"rz-donut-series rz-series-{Chart.Series.IndexOf(this)}";
        var x = CenterX;
        var y = CenterY;
        var radius = CurrentRadius;
        var innerRadius = InnerRadius ?? radius / 2;

        return 
        

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(11, "g");
            __builder2.AddMarkupContent(12, "\n            ");
            __builder2.OpenElement(13, "g");
            __builder2.AddAttribute(14, "class", 
#line 41 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                       className

#line default
#line hidden
            );
            __builder2.AddMarkupContent(15, "\n");
#line 42 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                 if (Items.Any())
                {
                    var sum = Items.Sum(Value);
                    double startAngle = -90;

                    

#line default
#line hidden
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                     foreach(var data in Items)
                    {
                        var value = Value(data);
                        var angle = (value / sum) * 360;
                        var endAngle = startAngle + angle;

                        var d = Segment(x, y, radius, innerRadius, startAngle, endAngle);

                        startAngle = endAngle;
                        
                        var index = Items.IndexOf(data);
                        var arcClassName = $"rz-series-item-{index}";
                        var fill = PickColor(index, Fills);
                        var stroke = PickColor(index, Strokes);


#line default
#line hidden
            __builder2.AddContent(16, "                        ");
            __builder2.OpenElement(17, "g");
            __builder2.AddAttribute(18, "class", 
#line 62 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                   arcClassName

#line default
#line hidden
            );
            __builder2.AddMarkupContent(19, "\n                            ");
            __builder2.OpenComponent<Radzen.Blazor.Rendering.Path>(20);
            __builder2.AddAttribute(21, "D", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 63 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                      d

#line default
#line hidden
            ));
            __builder2.AddAttribute(22, "Fill", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 63 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                                fill

#line default
#line hidden
            ));
            __builder2.AddAttribute(23, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 63 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                                                    StrokeWidth

#line default
#line hidden
            ));
            __builder2.AddAttribute(24, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 63 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                                                                          stroke

#line default
#line hidden
            ));
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(25, "\n                        ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(26, "\n");
#line 65 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                    }

#line default
#line hidden
#line 65 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                     
                }

#line default
#line hidden
            __builder2.AddContent(27, "            ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(28, "\n       \n");
#line 69 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
         if (!string.IsNullOrEmpty(Title) && TitleTemplate == null)
        {

#line default
#line hidden
            __builder2.AddContent(29, "            ");
            __builder2.OpenElement(30, "g");
            __builder2.AddAttribute(31, "class", "rz-donut-title");
            __builder2.AddMarkupContent(32, "\n                ");
            __builder2.OpenElement(33, "text");
            __builder2.AddAttribute(34, "class", "rz-donut-title");
            __builder2.AddAttribute(35, "x", 
#line 72 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                                 CenterX.ToInvariantString()

#line default
#line hidden
            );
            __builder2.AddAttribute(36, "y", 
#line 72 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                                                                                  CenterY.ToInvariantString()

#line default
#line hidden
            );
            __builder2.AddMarkupContent(37, "\n                    ");
            __builder2.AddContent(38, 
#line 73 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
                     Title

#line default
#line hidden
            );
            __builder2.AddMarkupContent(39, "\n                ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(40, "\n            ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(41, "\n");
#line 76 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
        }

#line default
#line hidden
            __builder2.AddContent(42, "        ");
            __builder2.CloseElement();
        }
#line 77 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDonutSeries.razor"
            ;
    }

#line default
#line hidden
    }
}
namespace __Blazor.Radzen.Blazor.RadzenDonutSeries
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
