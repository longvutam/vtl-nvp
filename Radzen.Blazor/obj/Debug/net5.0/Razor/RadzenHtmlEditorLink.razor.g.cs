#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d35fe6db0da8e6818b2931b3404222591ab65ccd"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
using System.Text;

#line default
#line hidden
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class RadzenHtmlEditorLink : RadzenHtmlEditorButtonBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.Rendering.EditorButton>(0);
            __builder.AddAttribute(1, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                     Title

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                  OnClick

#line default
#line hidden
            )));
            __builder.AddAttribute(3, "Icon", "insert_link");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
       
    protected override async Task OnClick()
    {
        await Editor.SaveSelectionAsync();

        bool blank = false;

        var attributes = await JSRuntime.InvokeAsync<LinkAttributes>("Radzen.selectionAttributes", "a", new[] {"innerText",
"href", "target" });

        if (attributes.Target == "_blank")
        {
            blank = true;
        }

        var result = await DialogService.OpenAsync(Title, ds =>
    

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(4, "div");
            __builder2.AddAttribute(5, "class", "rz-html-editor-dialog");
            __builder2.AddMarkupContent(6, "\r\n        ");
            __builder2.OpenElement(7, "div");
            __builder2.AddAttribute(8, "class", "rz-html-editor-dialog-item");
            __builder2.AddMarkupContent(9, "\r\n            ");
            __builder2.OpenElement(10, "label");
            __builder2.AddContent(11, 
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                    UrlText

#line default
#line hidden
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(12, "\r\n            ");
            __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(13);
            __builder2.AddAttribute(14, "style", "width: 100%");
            __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 29 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                        attributes.Href

#line default
#line hidden
            ));
            __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => attributes.Href = __value, attributes.Href))));
            __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => attributes.Href));
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(18, "\r\n        ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(19, "\r\n");
#line 31 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
         if (string.IsNullOrEmpty(attributes.InnerHtml))
            {

#line default
#line hidden
            __builder2.AddContent(20, "                ");
            __builder2.OpenElement(21, "div");
            __builder2.AddAttribute(22, "class", "rz-html-editor-dialog-item");
            __builder2.AddMarkupContent(23, "\r\n                    ");
            __builder2.OpenElement(24, "label");
            __builder2.AddContent(25, 
#line 34 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                            LinkText

#line default
#line hidden
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(26, "\r\n                    ");
            __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(27);
            __builder2.AddAttribute(28, "style", "width: 100%");
            __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 35 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                                attributes.InnerText

#line default
#line hidden
            ));
            __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => attributes.InnerText = __value, attributes.InnerText))));
            __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => attributes.InnerText));
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(32, "\r\n                ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(33, "\r\n");
#line 37 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
            }

#line default
#line hidden
            __builder2.AddContent(34, "            ");
            __builder2.OpenElement(35, "div");
            __builder2.AddAttribute(36, "class", "rz-html-editor-dialog-item");
            __builder2.AddMarkupContent(37, "\r\n                ");
            __Blazor.Radzen.Blazor.RadzenHtmlEditorLink.TypeInference.CreateRadzenCheckBox_0(__builder2, 38, 39, 
#line 39 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                             blank

#line default
#line hidden
            , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => blank = __value, blank)), 41, () => blank);
            __builder2.AddMarkupContent(42, "\r\n                ");
            __builder2.OpenElement(43, "label");
            __builder2.AddContent(44, 
#line 40 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                        OpenInNewWindowText

#line default
#line hidden
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(45, "\r\n            ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(46, "\r\n            ");
            __builder2.OpenElement(47, "div");
            __builder2.AddAttribute(48, "class", "rz-html-editor-dialog-buttons");
            __builder2.AddMarkupContent(49, "\r\n                ");
            __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(50);
            __builder2.AddAttribute(51, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 43 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                    OkText

#line default
#line hidden
            ));
            __builder2.AddAttribute(52, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 43 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                                  ()=> ds.Close(true)

#line default
#line hidden
            )));
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(53, "\r\n                ");
            __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(54);
            __builder2.AddAttribute(55, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 44 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                    CancelText

#line default
#line hidden
            ));
            __builder2.AddAttribute(56, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 44 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                                      ()=> ds.Close(false)

#line default
#line hidden
            )));
            __builder2.AddAttribute(57, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 44 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                                                                         ButtonStyle.Secondary

#line default
#line hidden
            ));
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(58, "\r\n            ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(59, "\r\n        ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(60, "\r\n");
        }
#line 47 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenHtmlEditorLink.razor"
    );

        await Editor.RestoreSelectionAsync();

        if (result == true && !String.IsNullOrEmpty(attributes.Href))
        {
            var html = new StringBuilder();
            html.AppendFormat("<a href=\"{0}\"", attributes.Href);
            if (blank)
            {
                html.Append(" target=\"_blank\"");
            }

            html.AppendFormat(">{0}</a>", string.IsNullOrEmpty(attributes.InnerText) ? attributes.InnerHtml : attributes.InnerText);

            await Editor.ExecuteCommandAsync("insertHTML", html.ToString());
        }

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
namespace __Blazor.Radzen.Blazor.RadzenHtmlEditorLink
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
