#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d8227c55ad249cc5f3ba18ad71f30fe71748bf2"
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
#line 1 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/requiredvalidator")]
    public partial class RequiredValidatorPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "RequiredValidator");
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
#line 10 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
                                                        model

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Model>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Model>(this, 
#nullable restore
#line 10 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
                                                                      OnSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "InvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.FormInvalidSubmitEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.FormInvalidSubmitEventArgs>(this, 
#nullable restore
#line 10 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
                                                                                              OnInvalidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenFieldset>(16);
                    __builder3.AddAttribute(17, "Text", "Personal information");
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(19, "div");
                        __builder4.AddAttribute(20, "class", "row");
                        __builder4.AddAttribute(21, "style", "margin-bottom: 48px");
                        __builder4.OpenElement(22, "div");
                        __builder4.AddAttribute(23, "class", "col-md-4 align-right");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenLabel>(24);
                        __builder4.AddAttribute(25, "Text", "First Name");
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(26, "\n                            ");
                        __builder4.OpenElement(27, "div");
                        __builder4.AddAttribute(28, "class", "col");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(29);
                        __builder4.AddAttribute(30, "style", "display: block");
                        __builder4.AddAttribute(31, "Name", "FirstName");
                        __builder4.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
                                                                                                    model.FirstName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.FirstName = __value, model.FirstName))));
                        __builder4.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.FirstName));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\n                                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(36);
                        __builder4.AddAttribute(37, "Component", "FirstName");
                        __builder4.AddAttribute(38, "Text", "First name is required");
                        __builder4.AddAttribute(39, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
                                                                                                                    popup

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "Style", "position: absolute");
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(41, "\n                        ");
                        __builder4.OpenElement(42, "div");
                        __builder4.AddAttribute(43, "class", "row");
                        __builder4.AddAttribute(44, "style", "margin-bottom: 48px");
                        __builder4.OpenElement(45, "div");
                        __builder4.AddAttribute(46, "class", "col-md-4");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenLabel>(47);
                        __builder4.AddAttribute(48, "Text", "Last Name");
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(49, "\n                            ");
                        __builder4.OpenElement(50, "div");
                        __builder4.AddAttribute(51, "class", "col");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(52);
                        __builder4.AddAttribute(53, "style", "display: block");
                        __builder4.AddAttribute(54, "Name", "LastName");
                        __builder4.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
                                                                                                   model.LastName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.LastName = __value, model.LastName))));
                        __builder4.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.LastName));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(58, "\n                                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(59);
                        __builder4.AddAttribute(60, "Component", "LastName");
                        __builder4.AddAttribute(61, "Text", "Last name is required");
                        __builder4.AddAttribute(62, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
                                                                                                                  popup

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(63, "Style", "position: absolute");
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(64, "\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(65);
                        __builder4.AddAttribute(66, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 30 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
                                                  ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(67, "Text", "Submit");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\n            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col");
                __builder2.OpenElement(71, "label");
                __builder2.AddMarkupContent(72, "\n                    Display validators as popup\n                    ");
                __Blazor.RadzenBlazorDemos.Pages.RequiredValidatorPage.TypeInference.CreateRadzenCheckBox_0(__builder2, 73, 74, 
#nullable restore
#line 37 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
                                                 popup

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => popup = __value, popup)), 76, () => popup);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(80);
                __builder2.AddComponentReferenceCapture(81, (__value) => {
#nullable restore
#line 43 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
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
#line 48 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\RequiredValidatorPage.razor"
       
    class Model
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    bool popup;

    Model model = new Model();
    EventConsole console;

    void OnSubmit(Model model)
    {
        console.Log($"Submit: {JsonSerializer.Serialize(model, new JsonSerializerOptions() {  WriteIndented = true })}");
    }

    void OnInvalidSubmit(FormInvalidSubmitEventArgs args)
    {
        console.Log($"InvalidSubmit: {JsonSerializer.Serialize(args, new JsonSerializerOptions() {  WriteIndented = true })}");
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.RadzenBlazorDemos.Pages.RequiredValidatorPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenCheckBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
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
