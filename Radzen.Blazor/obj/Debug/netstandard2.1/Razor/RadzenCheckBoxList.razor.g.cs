#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ad8550ff1a54f41188fafcfde0bab730dc6642d"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
using System.Linq;

#line default
#line hidden
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
using System.Collections;

#line default
#line hidden
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
using Radzen;

#line default
#line hidden
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class RadzenCheckBoxList<TValue> : FormComponent<IEnumerable<TValue>>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
 if (Items != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __Blazor.Radzen.Blazor.RadzenCheckBoxList.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                          this

#line default
#line hidden
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.AddContent(5, 
#line 12 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
         Items

#line default
#line hidden
                );
                __builder2.AddMarkupContent(6, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(7, "\r\n");
#line 14 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
}

#line default
#line hidden
#line 15 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "style", 
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                 Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(11, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                     Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(12, "class", 
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                                         GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(13, "id", 
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                                                             GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(14, (__value) => {
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(15, "\r\n");
#line 18 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
         foreach (var item in allItems.Where(i => i.Visible))
        {

#line default
#line hidden
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "rz-checkbox");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                 args => SelectItem(item)

#line default
#line hidden
            ));
            __builder.AddMultipleAttributes(20, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                                                         item.Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "style", 
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                                                                                  item.Style

#line default
#line hidden
            );
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "rz-chkbox ");
            __builder.AddAttribute(25, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                       async args => { if (args.Code == "Space") { await SelectItem(item); } }

#line default
#line hidden
            ));
            __builder.AddAttribute(26, "tabindex", 
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                                                                                                             TabIndex

#line default
#line hidden
            );
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "rz-helper-hidden-accessible");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "checkbox");
            __builder.AddAttribute(33, "name", 
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                      Name

#line default
#line hidden
            );
            __builder.AddAttribute(34, "value", 
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                                    item.Value

#line default
#line hidden
            );
            __builder.AddAttribute(35, "disabled", 
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                                                           Disabled

#line default
#line hidden
            );
            __builder.AddAttribute(36, "tabindex", "-1");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", 
#line 25 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                ItemClassList(item)

#line default
#line hidden
            );
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "span");
            __builder.AddAttribute(43, "class", 
#line 26 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                     IconClassList(item)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "label");
            __builder.AddAttribute(48, "class", "rz-chkbox-label");
            __builder.AddContent(49, 
#line 29 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
                                                item.Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#line 31 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
        }

#line default
#line hidden
            __builder.AddContent(52, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#line 33 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCheckBoxList.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenCheckBoxList
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
