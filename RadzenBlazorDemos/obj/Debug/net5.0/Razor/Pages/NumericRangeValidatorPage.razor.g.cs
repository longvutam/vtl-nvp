#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d43d3bde11a25b5d8a122bb4f4725154d5b3ad4"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenBlazorDemos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/numericrangevalidator")]
    public partial class NumericRangeValidatorPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "NumericRangeValidator");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Model>>(11);
                __builder2.AddAttribute(12, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Model>(
#nullable restore
#line 10 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                                                        model

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Model>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Model>(this, 
#nullable restore
#line 10 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                                                                      OnSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "InvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.FormInvalidSubmitEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.FormInvalidSubmitEventArgs>(this, 
#nullable restore
#line 10 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                                                                                              OnInvalidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenFieldset>(16);
                    __builder3.AddAttribute(17, "Text", "Bid info");
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(19, "div");
                        __builder4.AddAttribute(20, "class", "row");
                        __builder4.AddAttribute(21, "style", "margin-bottom: 48px");
                        __builder4.OpenElement(22, "div");
                        __builder4.AddAttribute(23, "class", "col-md-4 align-right");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenLabel>(24);
                        __builder4.AddAttribute(25, "Text", "Quantity");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(26, "\r\n                                ");
                        __builder4.AddMarkupContent(27, "<small style=\"display: block\">(1-10 items)</small>");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(28, "\r\n                            ");
                        __builder4.OpenElement(29, "div");
                        __builder4.AddAttribute(30, "class", "col");
                        __Blazor.RadzenBlazorDemos.Pages.NumericRangeValidatorPage.TypeInference.CreateRadzenNumeric_0(__builder4, 31, 32, "display: block", 33, "Quantity", 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                                                                                                                            OnInput

#line default
#line hidden
#nullable disable
                        ), 35, 
#nullable restore
#line 18 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                                                                                                   model.Quantity

#line default
#line hidden
#nullable disable
                        , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Quantity = __value, model.Quantity)), 37, () => model.Quantity);
                        __builder4.AddMarkupContent(38, "\r\n                                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumericRangeValidator>(39);
                        __builder4.AddAttribute(40, "Component", "Quantity");
                        __builder4.AddAttribute(41, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<dynamic>(
#nullable restore
#line 19 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                                                                                       1

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(42, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<dynamic>(
#nullable restore
#line 19 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                                                                                               10

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "Text", "Quantity should be between 1 and 10");
                        __builder4.AddAttribute(44, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                                                                                                                                                     popup

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(45, "Style", "position: absolute");
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(46, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(47);
                        __builder4.AddAttribute(48, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 22 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                                                  ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(49, "Text", "Submit");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col");
                __builder2.OpenElement(53, "label");
                __builder2.AddMarkupContent(54, "\r\n                    Display validators as popup\r\n                    ");
                __Blazor.RadzenBlazorDemos.Pages.NumericRangeValidatorPage.TypeInference.CreateRadzenCheckBox_1(__builder2, 55, 56, 
#nullable restore
#line 29 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                                                 popup

#line default
#line hidden
#nullable disable
                , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => popup = __value, popup)), 58, () => popup);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(62);
                __builder2.AddComponentReferenceCapture(63, (__value) => {
#nullable restore
#line 35 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
                            console = (RadzenBlazorDemos.Shared.EventConsole)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\NumericRangeValidatorPage.razor"
       
    class Model
    {
        public decimal Quantity { get; set; }
    }

    bool popup;

    Model model = new Model();
    EventConsole console;

    void OnInput(ChangeEventArgs args)
    {
        Log("oninput", args.Value.ToString());
    }

    void Log(string eventName, string value)
    {
        console.Log($"{eventName}: {value}");
    }

    void OnSubmit(Model model)
    {
        Log("Submit", JsonSerializer.Serialize(model, new JsonSerializerOptions() { WriteIndented = true }));
    }

    void OnInvalidSubmit(FormInvalidSubmitEventArgs args)
    {
        Log("InvalidSubmit", JsonSerializer.Serialize(args, new JsonSerializerOptions() { WriteIndented = true }));
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.RadzenBlazorDemos.Pages.NumericRangeValidatorPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "oninput", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenCheckBox_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
