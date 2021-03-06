#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a00883846843567d748e5f241f39ed5f15d505ca"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class EditorButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "tabindex", "-1");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorButton.razor"
                                OnClick

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "class", 
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorButton.razor"
                                               Class

#line default
#line hidden
            );
            __builder.AddAttribute(4, "disabled", 
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorButton.razor"
                                                                Editor.Disabled || Disabled

#line default
#line hidden
            );
            __builder.AddAttribute(5, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorButton.razor"
                                                                                                           Empty

#line default
#line hidden
            ));
            __builder.AddEventPreventDefaultAttribute(6, "onmousedown", true);
            __builder.AddEventPreventDefaultAttribute(7, "onclick", true);
            __builder.AddAttribute(8, "title", 
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorButton.razor"
                                                                                                                                                                            Title

#line default
#line hidden
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "i");
            __builder.AddAttribute(11, "class", "rzi");
            __builder.AddContent(12, 
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorButton.razor"
                    Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\EditorButton.razor"
       
    [CascadingParameter]
    public RadzenHtmlEditor Editor { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public bool Selected { get; set; }

    [Parameter]
    public string Icon { get; set; }

    [Parameter]
    public EventCallback Click { get; set; }

    async Task OnClick()
    {
        await Click.InvokeAsync(null);
    }

    string Class
    {
        get
        {
            var classList = new List<string>() { "rz-html-editor-button" };

            if (Selected && !Editor.Disabled)
            {
                classList.Add("rz-selected");
            }

            return string.Join(" ", classList);
        }
    }

    void Empty()
    {

    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
