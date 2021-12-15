#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\Popup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634cc5af26f26b413443d9950acfe4f809ddd810"
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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\Popup.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class Popup : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddEventPreventDefaultAttribute(1, "onmousedown", true);
            __builder.AddMultipleAttributes(2, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\Popup.razor"
                                                            Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "style", 
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\Popup.razor"
                                                                              Style

#line default
#line hidden
            );
            __builder.AddAttribute(4, "id", 
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\Popup.razor"
                                                                                        GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(5, (__value) => {
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\Popup.razor"
           Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(6, "\r\n    ");
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\Popup.razor"
__builder.AddContent(7, ChildContent);

#line default
#line hidden
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\Popup.razor"
       
    bool open;

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public EventCallback Open { get; set; }

    [Parameter]
    public EventCallback Close { get; set; }

    public async Task ToggleAsync(ElementReference target)
    {
        open = !open;

        if (open)
        {
            await Open.InvokeAsync(null);
        }

        await JSRuntime.InvokeVoidAsync("Radzen.togglePopup", target, GetId(), false, Reference, nameof(OnClose));
    }

    [JSInvokable]
    public async Task OnClose()
    {
        open = false;

        await Close.InvokeAsync(null);
    }

    public async Task CloseAsync()
    {
        await JSRuntime.InvokeVoidAsync("Radzen.closePopup", GetId(), Reference, nameof(OnClose));
    }

    public override void Dispose()
    {
        base.Dispose();

        if (IsJSRuntimeAvailable)
        {
            JSRuntime.InvokeVoidAsync("Radzen.destroyPopup", GetId());
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
