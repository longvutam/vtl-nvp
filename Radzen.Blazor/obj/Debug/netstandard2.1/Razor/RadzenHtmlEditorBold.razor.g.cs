#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorBold.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "920528d24e21d0dcbad58155f3af0ae224a038e2"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorBold.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenHtmlEditorBold : RadzenHtmlEditorButtonBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.Rendering.EditorButton>(0);
            __builder.AddAttribute(1, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorBold.razor"
                     Title

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorBold.razor"
                                  OnClick

#line default
#line hidden
            )));
            __builder.AddAttribute(3, "Icon", "format_bold");
            __builder.AddAttribute(4, "Selected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorBold.razor"
                                                                       Editor.State.Bold

#line default
#line hidden
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591