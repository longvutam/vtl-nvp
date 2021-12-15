#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05de243e6af3726bc974d27d00538374c04269d9"
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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenRadialGauge : GaugeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", 
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                               Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                                                  Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                                                                    GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                                                                                      GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
               Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\r\n");
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
     if (Width.HasValue && Height.HasValue)
    {

#line default
#line hidden
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "svg");
            __builder.AddAttribute(10, "style", "width: 100%; height: 100%");
            __builder.AddMarkupContent(11, "\r\n            ");
            __Blazor.Radzen.Blazor.RadzenRadialGauge.TypeInference.CreateCascadingValue_0(__builder, 12, 13, 
#line 10 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                                   this

#line default
#line hidden
            , 14, (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n                ");
#line 11 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
__builder2.AddContent(16, ChildContent);

#line default
#line hidden
                __builder2.AddMarkupContent(17, "\r\n            ");
            }
            );
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#line 14 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
         if (Pointers.Any())
        {
            

#line default
#line hidden
#line 16 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
             foreach (var pointer in Pointers)
            {

#line default
#line hidden
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "rz-gauge-value");
            __builder.AddAttribute(23, "style", 
#line 18 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                                                   PointerStyle(pointer)

#line default
#line hidden
            );
            __builder.AddMarkupContent(24, "\r\n");
#line 19 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                     if (pointer.ShowValue)
                    {
                        

#line default
#line hidden
#line 21 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                         if (pointer.Template != null)
                        {
                            

#line default
#line hidden
#line 23 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
__builder.AddContent(25, pointer.Template(pointer));

#line default
#line hidden
#line 23 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                                                      
                        }
                        else if (!string.IsNullOrEmpty(pointer.FormatString))
                        {
                            

#line default
#line hidden
#line 27 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
__builder.AddContent(26, string.Format(pointer.FormatString, pointer.Value));

#line default
#line hidden
#line 27 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                                                                               
                        }
                        else
                        {
                            

#line default
#line hidden
#line 31 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
__builder.AddContent(27, pointer.Value);

#line default
#line hidden
#line 31 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                                          
                        }

#line default
#line hidden
#line 32 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
                         
                    }

#line default
#line hidden
            __builder.AddContent(28, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#line 35 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
            }

#line default
#line hidden
#line 35 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
             
        }

#line default
#line hidden
#line 36 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
         
    }

#line default
#line hidden
            __builder.AddContent(30, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#line 39 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 41 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenRadialGauge.razor"
       
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
