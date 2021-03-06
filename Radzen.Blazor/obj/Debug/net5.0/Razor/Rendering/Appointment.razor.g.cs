#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Appointment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bfcc168dd0b427ec75d9f99a2a3d5c12203cf86"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Appointment.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Appointment.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class Appointment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "rz-event");
            __builder.AddAttribute(2, "style", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Appointment.razor"
                             Style

#line default
#line hidden
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Appointment.razor"
                                             OnClick

#line default
#line hidden
            ));
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "rz-event-content");
            __builder.AddAttribute(7, "title", 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Appointment.razor"
                                         Data?.Text

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(8, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Appointment.razor"
                                                                 Attributes

#line default
#line hidden
            ));
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddContent(10, 
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Appointment.razor"
         Scheduler.RenderAppointment(Data)

#line default
#line hidden
            );
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Appointment.razor"
       
    [Parameter]
    public double? Top { get; set; }

    [Parameter]
    public double? Left { get; set; }

    [Parameter]
    public double? Width { get; set; }

    [Parameter]
    public double? Height { get; set; }

    [Parameter]
    public EventCallback<AppointmentData> Click { get; set; }

    IDictionary<string, object> Attributes { get; set; }

    [Parameter]
    public AppointmentData Data { get; set; }

    [CascadingParameter]
    public IScheduler Scheduler { get; set; }

    string Style { get; set; }

    protected override void OnParametersSet()
    {
        Attributes = Scheduler.GetAppointmentAttributes(Data);

        var style = new List<string>();

        if (Top.HasValue)
        {
            style.Add($"top: {Top.ToInvariantString()}em");
        }

        if (Left.HasValue)
        {
            style.Add($"left: {Left.ToInvariantString()}%");
        }

        if (Width.HasValue)
        {
            style.Add($"width: {Width.ToInvariantString()}%");
        }

        if (Height.HasValue)
        {
            style.Add($"height: {Height.ToInvariantString()}em");
        }

        Style = String.Join(";", style);
    }

    async Task OnClick()
    {
        await Click.InvokeAsync(Data);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
