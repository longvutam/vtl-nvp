#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFontNameItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a6c58270347db85c231689184d259ebe3c455dc"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFontNameItem.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenHtmlEditorFontNameItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.Rendering.EditorDropDownItem>(0);
            __builder.AddAttribute(1, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFontNameItem.razor"
                          Text

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFontNameItem.razor"
                                      Value

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "style", 
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFontNameItem.razor"
                                                    $"font-family: {Value}"

#line default
#line hidden
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
