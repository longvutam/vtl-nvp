#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f74e93bfbd66d89953618f304a147e3869b4fb4a"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
using Radzen.Blazor;

#line default
#line hidden
    public partial class WeekView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "rz-view rz-week-view");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "rz-view-header");
            __builder.AddMarkupContent(5, "\r\n        <div class=\"rz-slot-hour-header\"></div>\r\n");
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
     for (var day = StartDate; day < EndDate; day = day.AddDays(1))
    {

#line default
#line hidden
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "rz-slot-header");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddContent(10, 
#line 9 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
             day.ToString("ddd", Scheduler.Culture)

#line default
#line hidden
            );
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
    }

#line default
#line hidden
            __builder.AddContent(13, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "rz-view-content");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.Hours>(18);
            __builder.AddAttribute(19, "Start", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan>(
#line 14 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
                      StartTime

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "End", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan>(
#line 14 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
                                     EndTime

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "TimeFormat", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 14 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
                                                          TimeFormat

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "rz-week-view-content");
            __builder.AddMarkupContent(25, "\r\n");
#line 16 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
         for (var day = StartDate; day < EndDate; day = day.AddDays(1))
        {
            var start = day.Add(StartTime);
            var end = day.Add(EndTime);

#line default
#line hidden
            __builder.AddContent(26, "            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "rz-slots");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.DaySlotEvents>(30);
            __builder.AddAttribute(31, "StartDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
                                          start

#line default
#line hidden
            ));
            __builder.AddAttribute(32, "EndDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
                                                         end

#line default
#line hidden
            ));
            __builder.AddAttribute(33, "Appointments", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IList<Radzen.Blazor.AppointmentData>>(
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
                                                                           Appointments

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n");
#line 22 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
                 for (var date = start; date < end; date = date.AddMinutes(30))
                {
                    var slotDate = date;

#line default
#line hidden
            __builder.AddContent(35, "                    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 25 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
                                    args => OnSlotClick(slotDate)

#line default
#line hidden
            ));
            __builder.AddMultipleAttributes(38, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 25 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
                                                                                Attributes(date)

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#line 26 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
                }

#line default
#line hidden
            __builder.AddContent(40, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#line 28 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
        }

#line default
#line hidden
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 32 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\WeekView.razor"
       
    [Parameter]
    public DateTime StartDate { get; set; }

    [Parameter]
    public DateTime EndDate { get; set; }

    [Parameter]
    public TimeSpan StartTime { get; set; }

    [Parameter]
    public TimeSpan EndTime { get; set; }

    [Parameter]
    public string TimeFormat { get; set; }

    [Parameter]
    public IList<AppointmentData> Appointments { get; set; }

    [CascadingParameter]
    public IScheduler Scheduler { get; set; }

    async Task OnSlotClick(DateTime date)
    {
        await Scheduler.SelectSlot(date, date.AddMinutes(30));
    }

    IDictionary<string, object> Attributes(DateTime date)
    {
        var attributes = Scheduler.GetSlotAttributes(date, date.AddMinutes(30));
        attributes["class"] = ClassList.Create("rz-slot").Add("rz-slot-minor", date.Minute == 30).Add(attributes).ToString();
        return attributes;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
