#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da30cba6d47b932e8df904f5221e3dacced2a85"
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
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

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
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/slider")]
    public partial class SliderPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "Slider");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.AddMarkupContent(7, "<h3>Slider from 0 to 100</h3>\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSlider<int>>(8);
                __builder2.AddAttribute(9, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 7 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                           0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 7 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                                   100

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, 
#nullable restore
#line 7 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                                                 args => OnChange(args, "Slider from 0 to 100")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 7 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                   value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value = __value, value))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => value));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.AddMarkupContent(16, "<h3 style=\"margin-top: 2rem\">Slider from -100 to 100</h3>\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSlider<int>>(17);
                __builder2.AddAttribute(18, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                                   -100

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                                              100

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, 
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                                                            args => OnChange(args, "Slider from -100 to 100")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                   negativeValue

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => negativeValue = __value, negativeValue))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => negativeValue));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.AddMarkupContent(25, "<h3 style=\"margin-top: 2rem\">Slider with Step 10</h3>\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSlider<int>>(26);
                __builder2.AddAttribute(27, "Step", "10");
                __builder2.AddAttribute(28, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, 
#nullable restore
#line 11 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                                                 args => OnChange(args, "Slider with Step 10")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 11 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                   valueWithStep

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => valueWithStep = __value, valueWithStep))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => valueWithStep));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\n        ");
                __builder2.AddMarkupContent(33, "<h3 style=\"margin-top: 2rem\">Range Slider</h3>\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSlider<IEnumerable<int>>>(34);
                __builder2.AddAttribute(35, "Range", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IEnumerable<int>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IEnumerable<int>>(this, 
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                                                          args => OnChange(args, "Range Slider")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<IEnumerable<int>>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                values

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IEnumerable<int>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IEnumerable<int>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => values = __value, values))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<IEnumerable<int>>>>(() => values));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\n        ");
                __builder2.AddMarkupContent(41, "<h3 style=\"margin-top: 2rem\">Range Slider with negative values</h3>\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSlider<IEnumerable<int>>>(42);
                __builder2.AddAttribute(43, "Range", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                                    -100

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                                               100

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IEnumerable<int>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IEnumerable<int>>(this, 
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                                                                                       args => OnChange(args, "Range Slider with negative values")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<IEnumerable<int>>(
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
                                                negativeValues

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IEnumerable<int>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IEnumerable<int>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => negativeValues = __value, negativeValues))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<IEnumerable<int>>>>(() => negativeValues));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(53);
                __builder2.AddComponentReferenceCapture(54, (__value) => {
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
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
#line 23 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\SliderPage.razor"
       
    IEnumerable<int> values = new int[] { 14, 78 };
    IEnumerable<int> negativeValues = new int[] { -100, 100 };
    int value = 67;
    int negativeValue = 0;
    int valueWithStep = 30;

    EventConsole console;

    void OnChange(dynamic value, string name)
    {
        var str = value is IEnumerable ? string.Join(", ", value) : value;
        console.Log($"{name} value changed to {str}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591