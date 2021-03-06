#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6cb165f5a0de6a7976e63fc0c4bbf2cebf213be"
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
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class Draggable : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "ontouchstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.TouchEventArgs>(this, 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
                                  OnTouchStart

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
                                                           OnMouseUp

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
                                                                                   OnMouseDown

#line default
#line hidden
            ));
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
                                                                                                            Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "style", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
                                                                                                                              Style

#line default
#line hidden
            );
            __builder.AddAttribute(6, "id", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
                                                                                                                                        GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(7, (__value) => {
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
           Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddContent(9, 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
     ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Draggable.razor"
       
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
