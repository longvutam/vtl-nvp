#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7fa960bc4073500f33fa9deab549c6cf785510"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
using Radzen;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class RadzenSwitch : FormComponent<bool>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.OpenElement(0, "div");
            __builder.AddMultipleAttributes(1, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
                                  Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "class", 
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
                                                      GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(3, "id", 
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
                                                                          GetId()

#line default
#line hidden
            );
            __builder.AddAttribute(4, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
                  OnMouseUp

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
                                            async (args) => { if (args.Code == "Space") { await Toggle(); } }

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "style", "outline:" + " 0" + " none;" + (
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
                                                                                                                                        Style

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "tabindex", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
                                                                                                                                                          TabIndex

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(8, (__value) => {
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
            Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(9, "\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "rz-helper-hidden-accessible");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "checkbox");
            __builder.AddAttribute(15, "name", 
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
                                      Name

#line default
#line hidden
            );
            __builder.AddAttribute(16, "value", 
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
                                                    Value

#line default
#line hidden
            );
            __builder.AddAttribute(17, "tabindex", "-1");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n    ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "rz-switch-circle" + (
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
                                   Disabled ? " rz-disabled" : ""

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenSwitch.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
