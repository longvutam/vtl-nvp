#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aff9fb983613cb517c31687bfb0c8f084f0178a"
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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
using Radzen;

#line default
#line hidden
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
using System.Collections;

#line default
#line hidden
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenSlider<TValue> : FormComponent<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 10 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", 
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                                Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                                                    Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                                                                        GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                                                                                            GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
               Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\r\n");
#line 13 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
         if (Range)
        {

#line default
#line hidden
            __builder.AddContent(8, "            ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "rz-slider-range");
            __builder.AddAttribute(11, "style", "left:" + " " + (
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                                                         Left.ToInvariantString()

#line default
#line hidden
            ) + "%;" + " width:" + " " + (
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                                                                                              (SecondLeft - Left).ToInvariantString()

#line default
#line hidden
            ) + "%;");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "span");
            __builder.AddAttribute(14, "class", "rz-slider-handle");
            __builder.AddAttribute(15, "style", "left:" + " " + (
#line 16 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                                                                           Left.ToInvariantString()

#line default
#line hidden
            ) + "%;" + " bottom:" + " auto;");
            __builder.AddElementReferenceCapture(16, (__value) => {
#line 16 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                        minHandle = __value;

#line default
#line hidden
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "rz-slider-handle rz-slider-handle-active");
            __builder.AddAttribute(20, "style", "left:" + " " + (
#line 17 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                                                                                                  SecondLeft.ToInvariantString()

#line default
#line hidden
            ) + "%;" + " bottom:" + " auto;");
            __builder.AddElementReferenceCapture(21, (__value) => {
#line 17 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                        maxHandle = __value;

#line default
#line hidden
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#line 18 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(23, "            ");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", "rz-slider-range rz-slider-range-min");
            __builder.AddAttribute(26, "style", "width:" + " " + (
#line 21 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                                                                              Left.ToInvariantString()

#line default
#line hidden
            ) + "%;");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "span");
            __builder.AddAttribute(29, "class", "rz-slider-handle");
            __builder.AddAttribute(30, "style", "left:" + " " + (
#line 22 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                                                                        Left.ToInvariantString()

#line default
#line hidden
            ) + "%;");
            __builder.AddElementReferenceCapture(31, (__value) => {
#line 22 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
                        handle = __value;

#line default
#line hidden
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#line 23 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
        }

#line default
#line hidden
            __builder.AddContent(33, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#line 25 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenSlider.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
