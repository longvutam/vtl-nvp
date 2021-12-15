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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class Draggable : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public EventCallback<DraggableEventArgs> DragStart { get; set; }

    [Parameter]
    public EventCallback<DraggableEventArgs> DragEnd { get; set; }

    [Parameter]
    public EventCallback<DraggableEventArgs> Drag { get; set; }

    Rect Rect { get; set; }

    bool Touch { get; set; }

    async Task OnMouseUp(MouseEventArgs args)
    {
        await JSRuntime.InvokeVoidAsync("Radzen.endDrag", Element);

        await DragEnd.InvokeAsync(new DraggableEventArgs
        {
            ClientX = args.ClientX,
            ClientY = args.ClientY,
            Rect = Rect
        });
    }

    async Task OnMouseDown(MouseEventArgs args)
    {
        if (!Touch)
        {
            Rect = await JSRuntime.InvokeAsync<Rect>("Radzen.startDrag", Element, Reference, nameof(OnMove));

            await DragStart.InvokeAsync(new DraggableEventArgs 
            {
                ClientX = args.ClientX,
                ClientY = args.ClientY,
                Rect = Rect
            });

            await OnMove(args);
        }

        Touch = false;
    }

    [JSInvokable]
    public async Task OnMove(MouseEventArgs args)
    {
        await Drag.InvokeAsync(new DraggableEventArgs 
        {
            ClientX = args.ClientX,
            ClientY = args.ClientY,
            Rect = Rect
        });
    }

    async Task OnTouchStart(TouchEventArgs args)
    {
        if (args.TargetTouches.Any())
        {
            await OnMouseDown(new MouseEventArgs { ClientX = args.TargetTouches[0].ClientX, ClientY = args.TargetTouches[0].ClientY});
            Touch = true;
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
