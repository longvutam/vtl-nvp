#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDownItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c1476241983dbb6f8ff88f2cc7f424884e89cbf"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class EditorDropDownItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDownItem.razor"
            Class

#line default
#line hidden
            );
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDownItem.razor"
                            Select

#line default
#line hidden
            ));
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDownItem.razor"
                                                Attributes

#line default
#line hidden
            ));
            __builder.AddMarkupContent(4, "\n");
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDownItem.razor"
     if (ChildContent != null)
    {
        

#line default
#line hidden
            __builder.AddContent(5, 
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDownItem.razor"
         ChildContent(this)

#line default
#line hidden
            );
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDownItem.razor"
                           
    }
    else
    {
        

#line default
#line hidden
            __builder.AddContent(6, 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDownItem.razor"
         Text

#line default
#line hidden
            );
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDownItem.razor"
             
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDownItem.razor"
       
    [Parameter]
    public RenderFragment<EditorDropDownItem> ChildContent { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> Attributes { get; set; }

    [CascadingParameter]
    public EditorDropDown DropDown { get; set; }

    [Parameter]
    public string Text { get; set; }

    [Parameter]
    public string Value { get; set; }

    async Task Select()
    {
        await DropDown.Select(this, true);
    }

    protected override async Task OnParametersSetAsync()
    {
        if (DropDown.Value == Value)
        {
            await DropDown.Select(this, false);
        }
    }

    string Class
    {
        get
        {
            var classList = new List<string>() { "rz-html-editor-dropdown-item" };
            if (DropDown.Value == Value)
            {
                classList.Add("rz-selected");
            }
            return string.Join(" ", classList);
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
