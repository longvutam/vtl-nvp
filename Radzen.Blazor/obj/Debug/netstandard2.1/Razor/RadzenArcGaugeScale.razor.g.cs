#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce0efcbc54f58fb21556de6de62afb797dd43c44"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenArcGaugeScale : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "g");
            __builder.AddAttribute(1, "class", "rz-arc-gauge-scale");
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.Rendering.GaugeScale>(3);
            __builder.AddAttribute(4, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
            CurrentScaleRadius

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                 CurrentStrokeWidth

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
            Stroke

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.Point>(
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
            CurrentCenter

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "StartAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                StartAngle

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "EndAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
              EndAngle

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "TickPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.GaugeTickPosition>(
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                  TickPosition

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "ShowFirstTick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                   ShowFirstTick

#line default
#line hidden
            ));
            __builder.AddAttribute(12, "ShowLastTick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                  ShowLastTick

#line default
#line hidden
            ));
            __builder.AddAttribute(13, "ShowTickLabels", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 13 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                    ShowTickLabels

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "TickLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 14 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                TickLength

#line default
#line hidden
            ));
            __builder.AddAttribute(15, "TickLabelOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 15 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                     TickLabelOffset

#line default
#line hidden
            ));
            __builder.AddAttribute(16, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 16 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
         Min

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
         Max

#line default
#line hidden
            ));
            __builder.AddAttribute(18, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 18 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
          Step

#line default
#line hidden
            ));
            __builder.AddAttribute(19, "MinorStep", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 19 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
               MinorStep

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "FormatString", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                  FormatString

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "Formatter", new System.Func<System.Double, System.String>(
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
               Formatter

#line default
#line hidden
            ));
            __builder.AddAttribute(22, "MinorTickLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 22 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                     MinorTickLength

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.Rendering.GaugeBand>(24);
            __builder.AddAttribute(25, "From", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 25 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
          Min

#line default
#line hidden
            ));
            __builder.AddAttribute(26, "To", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 26 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
        Max

#line default
#line hidden
            ));
            __builder.AddAttribute(27, "Fill", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 27 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
          Fill

#line default
#line hidden
            ));
            __builder.AddAttribute(28, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
            Stroke

#line default
#line hidden
            ));
            __builder.AddAttribute(29, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 29 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                 CurrentStrokeWidth

#line default
#line hidden
            ));
            __builder.AddAttribute(30, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 30 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
            CurrentRadius

#line default
#line hidden
            ));
            __builder.AddAttribute(31, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.Point>(
#line 31 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
            CurrentCenter

#line default
#line hidden
            ));
            __builder.AddAttribute(32, "StartAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 32 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                StartAngle

#line default
#line hidden
            ));
            __builder.AddAttribute(33, "EndAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 33 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
              EndAngle

#line default
#line hidden
            ));
            __builder.AddAttribute(34, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 34 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
         Min

#line default
#line hidden
            ));
            __builder.AddAttribute(35, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 35 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
         Max

#line default
#line hidden
            ));
            __builder.AddAttribute(36, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 36 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
          CurrentSize

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __Blazor.Radzen.Blazor.RadzenArcGaugeScale.TypeInference.CreateCascadingValue_0(__builder, 39, 40, 
#line 39 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
                       this

#line default
#line hidden
            , 41, (__builder2) => {
                __builder2.AddMarkupContent(42, "\r\n    ");
                __builder2.AddContent(43, 
#line 40 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGaugeScale.razor"
     ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(44, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenArcGaugeScale
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
