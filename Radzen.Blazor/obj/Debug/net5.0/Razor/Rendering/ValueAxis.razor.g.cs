#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2f06efd91621b03b7fa5159048fc9554b12cc00"
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
    public partial class ValueAxis : RadzenChartComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
 if (YAxis.Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "g");
            __builder.AddAttribute(2, "class", "rz-axis rz-value-axis");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.Line>(4);
            __builder.AddAttribute(5, "Class", "rz-line");
            __builder.AddAttribute(6, "X1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                               x1

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "Y1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                        y1

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "X2", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                 x1

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "Y2", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                          y2

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                       YAxis.Stroke

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                                   YAxis.StrokeWidth

#line default
#line hidden
            ));
            __builder.AddAttribute(12, "LineType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.LineType>(
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                                                                 YAxis.LineType

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
     for (var idx = start; idx <= end; idx += step)
    {
        var value = Chart.ValueScale.Value(idx);
        var y = Chart.ValueScale.Scale(idx);
        var text = YAxis.Format(Chart.ValueScale, value);

        if (YAxis.Ticks.Template != null)
        {
            var context = new TickTemplateContext { Value = value, X = x1, Y = y } ;


#line default
#line hidden
            __builder.AddContent(14, "            ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.ValueAxisTick>(15);
            __builder.AddAttribute(16, "X", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                               x1

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "Y", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                       y

#line default
#line hidden
            ));
            __builder.AddAttribute(18, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                 text

#line default
#line hidden
            ));
            __builder.AddAttribute(19, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                 YAxis.Ticks.Stroke ?? YAxis.Stroke

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                                                    YAxis.Ticks.StrokeWidth

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "LineType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.LineType>(
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                                                                                        YAxis.Ticks.LineType

#line default
#line hidden
            ));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.AddContent(24, 
#line 18 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                 YAxis.Ticks.Template(context)

#line default
#line hidden
                );
                __builder2.AddMarkupContent(25, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n");
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
        } 
        else
        {

#line default
#line hidden
            __builder.AddContent(27, "            ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.ValueAxisTick>(28);
            __builder.AddAttribute(29, "X", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                               x1

#line default
#line hidden
            ));
            __builder.AddAttribute(30, "Y", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                       y

#line default
#line hidden
            ));
            __builder.AddAttribute(31, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                 text

#line default
#line hidden
            ));
            __builder.AddAttribute(32, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                 YAxis.Ticks.Stroke ?? YAxis.Stroke

#line default
#line hidden
            ));
            __builder.AddAttribute(33, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                                                    YAxis.Ticks.StrokeWidth

#line default
#line hidden
            ));
            __builder.AddAttribute(34, "LineType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.LineType>(
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                                                                                        YAxis.Ticks.LineType

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n");
#line 24 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
        }

        if (YAxis.GridLines.Visible && idx > start)
        {

#line default
#line hidden
            __builder.AddContent(36, "            ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.Line>(37);
            __builder.AddAttribute(38, "Class", "rz-grid-line");
            __builder.AddAttribute(39, "X1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                            x1

#line default
#line hidden
            ));
            __builder.AddAttribute(40, "Y1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                     y

#line default
#line hidden
            ));
            __builder.AddAttribute(41, "X2", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                             x2

#line default
#line hidden
            ));
            __builder.AddAttribute(42, "Y2", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                      y

#line default
#line hidden
            ));
            __builder.AddAttribute(43, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                  YAxis.GridLines.Stroke

#line default
#line hidden
            ));
            __builder.AddAttribute(44, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                                                        YAxis.GridLines.StrokeWidth

#line default
#line hidden
            ));
            __builder.AddAttribute(45, "LineType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.LineType>(
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                                                                                                YAxis.GridLines.LineType

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n");
#line 29 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
        }
    }

#line default
#line hidden
#line 31 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
     if (!String.IsNullOrEmpty(YAxis.Title.Text))
    {

#line default
#line hidden
            __builder.AddContent(47, "        ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.ValueAxisTitle>(48);
            __builder.AddAttribute(49, "X", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 33 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                             x1 - Chart.ValueAxis.Size + YAxis.Title.Size

#line default
#line hidden
            ));
            __builder.AddAttribute(50, "Y", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 33 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                 (y1 - y2)/2

#line default
#line hidden
            ));
            __builder.AddAttribute(51, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 33 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
                                                                                                      YAxis.Title.Text

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n");
#line 34 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
    }

#line default
#line hidden
            __builder.AddContent(53, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#line 36 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 37 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\ValueAxis.razor"
       
    double start;
    double end;
    double step;
    double x1;
    double x2;
    double y1;
    double y2;
    private AxisBase XAxis { get; set; }
    private AxisBase YAxis { get; set; }

    protected override void OnParametersSet()
    {
        YAxis = Chart.ValueAxis;
        XAxis = Chart.CategoryAxis;

        if (Chart.ShouldInvertAxes())
        {
            YAxis = Chart.CategoryAxis;
            XAxis = Chart.ValueAxis;
        }

        var ticks = Chart.ValueScale.Ticks(YAxis.TickDistance);
        start = ticks.Start;
        end = ticks.End;
        step = ticks.Step;

        var categoryTicks = Chart.CategoryScale.Ticks(XAxis.TickDistance);
        x1 = Chart.CategoryScale.Scale(categoryTicks.Start);
        x2 = Chart.CategoryScale.Scale(categoryTicks.End);
        y1 = Chart.ValueScale.Scale(start);
        y2 = Chart.ValueScale.Scale(end);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
