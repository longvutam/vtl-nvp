#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffa8259a84dc1e41a92d81db960f38e56b3b4de2"
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
    public partial class EditorColorPicker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "title", 
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
            Title

#line default
#line hidden
            );
            __builder.AddAttribute(2, "class", "rz-html-editor-colorpicker");
            __builder.AddEventPreventDefaultAttribute(3, "onmousedown", true);
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "tabindex", "-1");
            __builder.AddAttribute(7, "class", "rz-html-editor-color");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                                                 OnClick

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "disabled", 
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                                                                   Editor.Disabled

#line default
#line hidden
            );
            __builder.AddEventPreventDefaultAttribute(10, "onclick", true);
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "i");
            __builder.AddAttribute(13, "class", "rzi");
            __builder.AddContent(14, 
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                        Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "rz-html-editor-color-value");
            __builder.AddAttribute(18, "style", "background-color:" + (
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                                                         Value

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenColorPicker>(21);
            __builder.AddAttribute(22, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                   OnChange

#line default
#line hidden
            )));
            __builder.AddEventStopPropagationAttribute(23, "onclick", true);
            __builder.AddAttribute(24, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
              OnOpen

#line default
#line hidden
            )));
            __builder.AddAttribute(25, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                               Editor.Disabled

#line default
#line hidden
            ));
            __builder.AddAttribute(26, "ShowHSV", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                                        ShowHSV

#line default
#line hidden
            ));
            __builder.AddAttribute(27, "ShowRGBA", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                  ShowRGBA

#line default
#line hidden
            ));
            __builder.AddAttribute(28, "ShowColors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                       ShowColors

#line default
#line hidden
            ));
            __builder.AddAttribute(29, "ShowButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                                              ShowButton

#line default
#line hidden
            ));
            __builder.AddAttribute(30, "HexText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                 HexText

#line default
#line hidden
            ));
            __builder.AddAttribute(31, "RedText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                  RedText

#line default
#line hidden
            ));
            __builder.AddAttribute(32, "GreenText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                                     GreenText

#line default
#line hidden
            ));
            __builder.AddAttribute(33, "BlueText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                                                         BlueText

#line default
#line hidden
            ));
            __builder.AddAttribute(34, "AlphaText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                                                                                             AlphaText

#line default
#line hidden
            ));
            __builder.AddAttribute(35, "ButtonText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                    ButtonText

#line default
#line hidden
            ));
            __builder.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
                     Value

#line default
#line hidden
            ));
            __builder.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Value = __value, Value))));
            __builder.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Value));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.AddContent(41, 
#line 13 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
     ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(42, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorColorPicker.razor"
       
    [CascadingParameter]
    public RadzenHtmlEditor Editor { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Icon { get; set; }

    [Parameter]
    public string Value { get; set; }

    [Parameter]
    public bool ShowHSV { get; set; } = true;

    [Parameter]
    public bool ShowRGBA { get; set; } = true;

    [Parameter]
    public bool ShowColors { get; set; } = true;

    [Parameter]
    public bool ShowButton { get; set; } = true;

    [Parameter]
    public string HexText { get; set; } = "Hex";

    [Parameter]
    public string RedText { get; set; } = "R";

    [Parameter]
    public string GreenText { get; set; } = "G";

    [Parameter]
    public string BlueText { get; set; } = "B";

    [Parameter]
    public string AlphaText { get; set; } = "A";

    [Parameter]
    public string ButtonText { get; set; } = "OK";

    [Parameter]
    public EventCallback<string> Change { get; set; }

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    async Task OnChange(string value)
    {
        await Editor.RestoreSelectionAsync();
        await ValueChanged.InvokeAsync(value);
        await Change.InvokeAsync(value);
    }

    async Task OnOpen()
    {
        await Editor.SaveSelectionAsync();
    }

    async Task OnClick()
    {
        await Change.InvokeAsync(Value);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
