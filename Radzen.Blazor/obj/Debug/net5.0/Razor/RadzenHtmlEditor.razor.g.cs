#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8a8faf046054af43bab433618bdb6671cdf013f"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
using Radzen;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class RadzenHtmlEditor : FormComponent<string>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
 if(Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", 
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                             Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                                                Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                                                                  GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                                                                                    GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
              Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "rz-html-editor-toolbar");
            __builder.AddMarkupContent(10, "\n            ");
            __Blazor.Radzen.Blazor.RadzenHtmlEditor.TypeInference.CreateCascadingValue_0(__builder, 11, 12, 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                                   this

#line default
#line hidden
            , 13, (__builder2) => {
                __builder2.AddMarkupContent(14, "\n");
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
             if (ChildContent != null)
            {
                

#line default
#line hidden
                __builder2.AddContent(15, 
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                 ChildContent

#line default
#line hidden
                );
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                             
            }
            else
            {

#line default
#line hidden
                __builder2.AddContent(16, "                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorUndo>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorRedo>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorSeparator>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorBold>(23);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorItalic>(25);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorUnderline>(27);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorStrikeThrough>(29);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorSeparator>(31);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorAlignLeft>(33);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorAlignCenter>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorAlignRight>(37);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorJustify>(39);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorSeparator>(41);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorIndent>(43);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorOutdent>(45);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorUnorderedList>(47);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorOrderedList>(49);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorSeparator>(51);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorColor>(53);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorBackground>(55);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorRemoveFormat>(57);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorSeparator>(59);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorSubscript>(61);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorSuperscript>(63);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorSeparator>(65);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorLink>(67);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorUnlink>(69);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorImage>(71);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFontName>(73);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFontSize>(75);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFormatBlock>(77);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\n");
#line 49 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
            }

#line default
#line hidden
                __builder2.AddContent(79, "            ");
            }
            );
            __builder.AddMarkupContent(80, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "rz-html-editor-content");
            __builder.AddAttribute(84, "contenteditable", 
#line 52 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                                                                                    !Disabled

#line default
#line hidden
            );
            __builder.AddAttribute(85, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#line 52 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                                                                                                         OnFocus

#line default
#line hidden
            ));
            __builder.AddAttribute(86, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#line 52 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                                                                                                                          OnBlur

#line default
#line hidden
            ));
            __builder.AddElementReferenceCapture(87, (__value) => {
#line 52 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
                   ContentEditable = __value;

#line default
#line hidden
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\n");
#line 54 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditor.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenHtmlEditor
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
