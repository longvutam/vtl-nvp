// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class EditorDropDownItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorDropDownItem.razor"
       
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
