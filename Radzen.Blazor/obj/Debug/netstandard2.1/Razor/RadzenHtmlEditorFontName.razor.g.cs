#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorFontName.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0872c65d5f21dde97c21997820c4e54004390d8"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorFontName.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenHtmlEditorFontName : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.Rendering.EditorDropDown>(0);
            __builder.AddAttribute(1, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorFontName.razor"
                       Title

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorFontName.razor"
                                    Editor.State.FontName

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorFontName.razor"
                                                                  OnChange

#line default
#line hidden
            )));
            __builder.AddAttribute(4, "Placeholder", "Font");
            __builder.AddAttribute(5, "PopupStyle", "width: 200px; max-height: 200px; overflow: auto;");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __Blazor.Radzen.Blazor.RadzenHtmlEditorFontName.TypeInference.CreateCascadingValue_0(__builder2, 8, 9, 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorFontName.razor"
                           this

#line default
#line hidden
                , 10, (__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n");
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorFontName.razor"
         if (ChildContent != null)
        {
            

#line default
#line hidden
                    __builder3.AddContent(12, 
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorFontName.razor"
             ChildContent

#line default
#line hidden
                    );
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorFontName.razor"
                         
        }
        else
        {

#line default
#line hidden
                    __builder3.AddContent(13, "            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFontNameItem>(14);
                    __builder3.AddAttribute(15, "Text", "Arial");
                    __builder3.AddAttribute(16, "Value", "Arial");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFontNameItem>(18);
                    __builder3.AddAttribute(19, "Text", "Georgia");
                    __builder3.AddAttribute(20, "Value", "Georgia");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFontNameItem>(22);
                    __builder3.AddAttribute(23, "Text", "Helvetica");
                    __builder3.AddAttribute(24, "Value", "Helvetica");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFontNameItem>(26);
                    __builder3.AddAttribute(27, "Text", "Monospace");
                    __builder3.AddAttribute(28, "Value", "monospace");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFontNameItem>(30);
                    __builder3.AddAttribute(31, "Text", "Segoe UI");
                    __builder3.AddAttribute(32, "Value", "\"Segoe UI\"");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFontNameItem>(34);
                    __builder3.AddAttribute(35, "Text", "Tahoma");
                    __builder3.AddAttribute(36, "Value", "Tahoma");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFontNameItem>(38);
                    __builder3.AddAttribute(39, "Text", "Times New Roman");
                    __builder3.AddAttribute(40, "Value", "\"Times New Roman\"");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHtmlEditorFontNameItem>(42);
                    __builder3.AddAttribute(43, "Text", "Verdana");
                    __builder3.AddAttribute(44, "Value", "Verdana");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n");
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorFontName.razor"
        }

#line default
#line hidden
                    __builder3.AddContent(46, "    ");
                }
                );
                __builder2.AddMarkupContent(47, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenHtmlEditorFontName
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
