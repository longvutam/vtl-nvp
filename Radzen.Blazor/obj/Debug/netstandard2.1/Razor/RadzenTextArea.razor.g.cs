#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cefbefecac37709d289ec093c06a761f840cf16"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
using Radzen;

#line default
#line hidden
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class RadzenTextArea : FormComponent<string>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "textarea");
            __builder.AddAttribute(2, "disabled", 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                         Disabled

#line default
#line hidden
            );
            __builder.AddAttribute(3, "readonly", 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                              ReadOnly

#line default
#line hidden
            );
            __builder.AddAttribute(4, "name", 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                                               Name

#line default
#line hidden
            );
            __builder.AddAttribute(5, "rows", 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                                                            Rows

#line default
#line hidden
            );
            __builder.AddAttribute(6, "cols", 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                                                                         Cols

#line default
#line hidden
            );
            __builder.AddAttribute(7, "style", 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                                                                                       Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(8, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                                                                                                           Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "class", 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                                                                                                                               GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(10, "placeholder", 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                      Placeholder

#line default
#line hidden
            );
            __builder.AddAttribute(11, "maxlength", 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                               MaxLength

#line default
#line hidden
            );
            __builder.AddAttribute(12, "value", 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                                  Value

#line default
#line hidden
            );
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                                                     OnChange

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "tabindex", 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                                                                          TabIndex

#line default
#line hidden
            );
            __builder.AddAttribute(15, "id", 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                                                                                                                         GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(16, (__value) => {
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
                     Element = __value;

#line default
#line hidden
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenTextArea.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
