// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenNotificationMessage.razor"
using System.Timers;

#line default
#line hidden
    public partial class RadzenNotificationMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenNotificationMessage.razor"
       
    Tuple<string, string> GetMessageCssClasses()
    {
        if (Message.Severity == NotificationSeverity.Error)
        {
            return new Tuple<string, string>("rz-growl-message-error", "rzi-times");
        }
        else if (Message.Severity == NotificationSeverity.Info)
        {
            return new Tuple<string, string>("rz-growl-message-info", "rzi-info-circle");
        }
        else if (Message.Severity == NotificationSeverity.Success)
        {
            return new Tuple<string, string>("rz-growl-message-success", "rzi-check");
        }
        else if (Message.Severity == NotificationSeverity.Warning)
        {
            return new Tuple<string, string>("rz-growl-message-warn", "rzi-exclamation-triangle");
        }

        return new Tuple<string, string>("", "");
    }

    [Inject] private NotificationService Service { get; set; }

    public bool Visible { get; set; } = true;

    [Parameter]
    public NotificationMessage Message { get; set; }

    [Parameter]
    public string Style { get; set; }

    public void Close()
    {
        Service.Messages.Remove(Message);
        System.Threading.Tasks.Task.Delay(0).ContinueWith(r => { Visible = false; });
    }

    protected override void OnInitialized()
    {
        System.Threading.Tasks.Task.Delay(Convert.ToInt32(Message.Duration ?? 3000)).ContinueWith(r => InvokeAsync(Close));
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
