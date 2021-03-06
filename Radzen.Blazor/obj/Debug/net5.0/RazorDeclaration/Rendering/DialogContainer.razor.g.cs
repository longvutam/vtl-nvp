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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\DialogContainer.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class DialogContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 55 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\DialogContainer.razor"
       
    ElementReference dialog;

    string left;
    string top;
    string height;
    string width;

    double clientX;
    double clientY;

    async Task OnDragStart(DraggableEventArgs args)
    {
        clientX = args.ClientX;
        clientY = args.ClientY;

        shouldRender = false;
        var rect = await JSRuntime.InvokeAsync<Rect>("Radzen.clientRect", dialog);
        height = $"height: {rect.Height}px;";
        width = $"width: {rect.Width}px;";

        shouldRender = true;
    }

    void OnDrag(DraggableEventArgs args)
    {
        left = $"left: {args.Rect.Left + (args.ClientX - clientX)}px;";
        top = $"top: {args.Rect.Top + (args.ClientY - clientY)}px;";
    }

    bool shouldRender = true;
    protected override bool ShouldRender()
    {
        return shouldRender;
    }

    [Parameter]
    public Dialog Dialog { get; set; }

    RenderFragment ChildContent => new RenderFragment(builder =>
        {
            builder.OpenComponent(0, Dialog.Type);

            if (Dialog.Parameters != null)
            {
                foreach (var parameter in Dialog.Parameters)
                {
                    builder.AddAttribute(1, parameter.Key, parameter.Value);
                }
            }

            builder.CloseComponent();
        });

    void Close()
    {
        Service.Close();
    }

    string Style
    {
        get
        {
            var baseStyle = "min-width: 150px; min-height: 150px; z-index: 1001; opacity: 1;position:absolute;";
            var widthStyle = !string.IsNullOrEmpty(width) ? width : string.IsNullOrEmpty(Dialog.Options.Width) ? "" : $"width: {Dialog.Options.Width};";
            var heightStyle = !string.IsNullOrEmpty(height) ? height : string.IsNullOrEmpty(Dialog.Options.Height) ? "" : $"height: {Dialog.Options.Height};";
            var topStyle = !string.IsNullOrEmpty(top) ? top : string.IsNullOrEmpty(Dialog.Options.Top) ? "" : $"top: {Dialog.Options.Top};";
            var leftStyle = !string.IsNullOrEmpty(left) ? left :string.IsNullOrEmpty(Dialog.Options.Left) ? "" : $"left: {Dialog.Options.Left};";
            var resizeStyle = Dialog.Options.Resizable ? "resize:both;" : "";

            return $"{baseStyle}{widthStyle}{heightStyle}{topStyle}{leftStyle}{resizeStyle}{Dialog.Options.Style}";
        }
    }

    [Inject] 
    DialogService Service { get; set; }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
