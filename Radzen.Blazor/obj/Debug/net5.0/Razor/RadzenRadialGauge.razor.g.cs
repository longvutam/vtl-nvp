#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "439811463de8a3159594e4a5e9371f7e5d2e8819"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenRadialGauge : GaugeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", 
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                               Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                                                  Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                                                                    GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                                                                                      GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
               Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\n");
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
     if (Width.HasValue && Height.HasValue)
    {

#line default
#line hidden
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "svg");
            __builder.AddAttribute(10, "style", "width: 100%; height: 100%");
            __builder.AddMarkupContent(11, "\n            ");
            __Blazor.Radzen.Blazor.RadzenRadialGauge.TypeInference.CreateCascadingValue_0(__builder, 12, 13, 
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                                   this

#line default
#line hidden
            , 14, (__builder2) => {
                __builder2.AddMarkupContent(15, "\n                ");
                __builder2.AddContent(16, 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                 ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(17, "\n            ");
            }
            );
            __builder.AddMarkupContent(18, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
         if (Pointers.Any())
        {
            

#line default
#line hidden
#line 16 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
             foreach (var pointer in Pointers)
            {

#line default
#line hidden
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "rz-gauge-value");
            __builder.AddAttribute(23, "style", 
#line 18 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                                                   PointerStyle(pointer)

#line default
#line hidden
            );
            __builder.AddMarkupContent(24, "\n");
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                     if (pointer.ShowValue)
                    {
                        

#line default
#line hidden
#line 21 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                         if (pointer.Template != null)
                        {
                            

#line default
#line hidden
            __builder.AddContent(25, 
#line 23 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                             pointer.Template(pointer)

#line default
#line hidden
            );
#line 23 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                                                      
                        }
                        else if (!string.IsNullOrEmpty(pointer.FormatString))
                        {
                            

#line default
#line hidden
            __builder.AddContent(26, 
#line 27 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                             string.Format(pointer.FormatString, pointer.Value)

#line default
#line hidden
            );
#line 27 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                                                                               
                        }
                        else
                        {
                            

#line default
#line hidden
            __builder.AddContent(27, 
#line 31 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                             pointer.Value

#line default
#line hidden
            );
#line 31 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                                          
                        }

#line default
#line hidden
#line 32 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
                         
                    }

#line default
#line hidden
            __builder.AddContent(28, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#line 35 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
            }

#line default
#line hidden
#line 35 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
             
        }

#line default
#line hidden
#line 36 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
         
    }

#line default
#line hidden
            __builder.AddContent(30, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
#line 39 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 41 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenRadialGauge.razor"
       
    IList<RadzenRadialGaugeScalePointer> Pointers { get; set; } = new List<RadzenRadialGaugeScalePointer>();

    string PointerStyle(RadzenRadialGaugeScalePointer pointer)
    {
        return $"left: {pointer.Scale.CurrentCenter.X.ToInvariantString()}px; top: {pointer.Scale.CurrentCenter.Y.ToInvariantString()}px";
    }

    internal void AddPointer(RadzenRadialGaugeScalePointer pointer)
    {
        if (!Pointers.Contains(pointer))
        {
            Pointers.Add(pointer);

            StateHasChanged();
        }
    }

    protected override string GetComponentCssClass()
    {
        return $"rz-gauge";
    }

#line default
#line hidden
    }
}
namespace __Blazor.Radzen.Blazor.RadzenRadialGauge
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