#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04682d404658911fd879d34d033a19463faedc9d"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
using System.Linq;

#line default
#line hidden
    public partial class RadzenSteps : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
 if (Steps != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __Blazor.Radzen.Blazor.RadzenSteps.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                          this

#line default
#line hidden
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "\n        ");
                __builder2.AddContent(5, 
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
         Steps

#line default
#line hidden
                );
                __builder2.AddMarkupContent(6, "\n    ");
            }
            );
            __builder.AddMarkupContent(7, "\n");
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
}

#line default
#line hidden
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", 
#line 17 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                             Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(10, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 17 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                 Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "class", 
#line 17 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                     GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(12, "id", 
#line 17 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                         GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(13, (__value) => {
#line 17 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
            Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "role", "tablist");
            __builder.AddMarkupContent(17, "\n");
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
         for (var i = 0; i < steps.Count; i++)
        {
            var step = steps[i];
            

#line default
#line hidden
#line 22 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
             if (step.Visible)
            {

#line default
#line hidden
            __builder.AddContent(18, "                ");
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "class", 
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                             $"rz-steps-item {(IsSelected(i, step) ? "rz-state-highlight rz-steps-current" : step.Disabled ? "rz-state-disabled" : "")}"

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(21, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                                                                                                        step.Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(22, "style", 
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                                                                                                                                 step.Style

#line default
#line hidden
            );
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 25 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                   async (args) => { if (!step.Disabled) { await SelectStep(step, true); } }

#line default
#line hidden
            ));
            __builder.AddAttribute(26, "href", "javascript:void(0)");
            __builder.AddAttribute(27, "class", "rz-menuitem-link");
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "rz-steps-number");
            __builder.AddContent(31, 
#line 26 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                        steps.Where(s => s.Visible).ToList().IndexOf(step) + 1

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                        ");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "class", "rz-steps-title");
            __builder.AddContent(35, 
#line 27 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                      step.Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n");
#line 30 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
            }

#line default
#line hidden
#line 30 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(39, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n\n");
#line 34 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
     for (var i = 0; i < steps.Count; i++)
    {
        var step = steps[i];
        

#line default
#line hidden
#line 37 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
         if (step.Visible)
        {
            

#line default
#line hidden
#line 39 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
             if (IsSelected(i, step))
            {

#line default
#line hidden
            __builder.AddContent(41, "                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "rz-widget-content");
            __builder.AddMarkupContent(44, "\n");
#line 42 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                     if (step.ChildContent != null)
                    {
                        

#line default
#line hidden
            __builder.AddContent(45, 
#line 44 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                         step.ChildContent

#line default
#line hidden
            );
#line 44 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                          
                    }

#line default
#line hidden
            __builder.AddContent(46, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n");
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
            }

#line default
#line hidden
#line 47 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
             
        }

#line default
#line hidden
#line 48 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
         
    }

#line default
#line hidden
#line 50 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
     if(ShowStepsButtons)
    {

#line default
#line hidden
            __builder.AddContent(48, "    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "rz-steps-buttons");
            __builder.AddMarkupContent(51, "\n        ");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "class", 
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                    $"rz-steps-prev {(IsFirstVisibleStep() ?  "rz-state-disabled" : "")}"

#line default
#line hidden
            );
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                                       PrevStep

#line default
#line hidden
            ));
            __builder.AddAttribute(55, "href", "javascript:void(0)");
            __builder.AddMarkupContent(56, "<i class=\"rzi\">navigate_before</i>");
            __builder.AddContent(57, 
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                                                                                                              PreviousText

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n        ");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "class", 
#line 54 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                    $"rz-steps-next {(IsLastVisibleStep() ?  "rz-state-disabled" : "")}"

#line default
#line hidden
            );
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 54 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                                      NextStep

#line default
#line hidden
            ));
            __builder.AddAttribute(62, "href", "javascript:void(0)");
            __builder.AddContent(63, 
#line 54 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                                                                           NextText

#line default
#line hidden
            );
            __builder.AddMarkupContent(64, "<i class=\"rzi\">navigate_next</i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n");
#line 56 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n");
#line 58 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenSteps
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
