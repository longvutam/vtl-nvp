#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4016321a8e3ad5019415c4786974b0f3938cd4d4"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenChart : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
 if (Visible)
{

#line default
#line hidden
            __Blazor.Radzen.Blazor.RadzenChart.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                        this

#line default
#line hidden
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\n");
                __builder2.AddContent(4, 
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
 ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(5, "\n");
            }
            );
            __builder.AddMarkupContent(6, "\n");
            __builder.OpenElement(7, "div");
            __builder.AddMultipleAttributes(8, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                                  Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "class", 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                                                      GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(10, "style", 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                                                                             Style

#line default
#line hidden
            );
            __builder.AddAttribute(11, "id", 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                                                                                         GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(12, (__value) => {
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
           Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(13, "\n");
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
 if (Width.HasValue && Height.HasValue)
{

#line default
#line hidden
            __builder.AddContent(14, "    ");
            __Blazor.Radzen.Blazor.RadzenChart.TypeInference.CreateCascadingValue_1(__builder, 15, 16, 
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                            this

#line default
#line hidden
            , 17, (__builder2) => {
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.Legend>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.OpenElement(21, "svg");
                __builder2.AddAttribute(22, "style", "width: 100%; height: 100%");
                __builder2.AddMarkupContent(23, "\n            ");
                __builder2.OpenElement(24, "g");
                __builder2.AddAttribute(25, "transform", 
#line 17 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                            $"translate({MarginLeft.ToInvariantString()}, {MarginTop.ToInvariantString()})"

#line default
#line hidden
                );
                __builder2.AddMarkupContent(26, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.ClipPath>(27);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n");
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                 if(ShouldRenderAxes())
                {

#line default
#line hidden
                __builder2.AddContent(29, "                    ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.ValueAxis>(30);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.CategoryAxis>(32);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n");
#line 23 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                }

#line default
#line hidden
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                 foreach (var series in Series.OrderBy(s => s.RenderingOrder))
                {
                    

#line default
#line hidden
#line 26 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                     if (series.Visible)
                    {
                        

#line default
#line hidden
                __builder2.AddContent(34, 
#line 28 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                         series.Render(CategoryScale, ValueScale)

#line default
#line hidden
                );
#line 28 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                                                                 ;
                    }

#line default
#line hidden
#line 29 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                     
                }

#line default
#line hidden
                __builder2.AddContent(35, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n");
#line 33 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
         foreach (var series in Series.OrderBy(s => s.RenderingOrder))
        {
            

#line default
#line hidden
#line 35 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
             if (series.Visible && series is IChartDonutSeries donut)
            {
                

#line default
#line hidden
                __builder2.AddContent(38, 
#line 37 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                 donut.RenderTitle(MarginLeft, MarginTop)

#line default
#line hidden
                );
#line 37 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                                                         
            }

#line default
#line hidden
#line 38 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
             
        }

#line default
#line hidden
#line 40 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
     if (tooltip != null)
    {
        

#line default
#line hidden
                __builder2.AddContent(39, 
#line 42 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
         tooltip

#line default
#line hidden
                );
#line 42 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
                
    }

#line default
#line hidden
                __builder2.AddContent(40, "    ");
            }
            );
            __builder.AddMarkupContent(41, "\n");
#line 45 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
}

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n");
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenChart.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenChart
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
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
