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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenMonthView.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenMonthView.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenMonthView : SchedulerViewBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenMonthView.razor"
           
    public override RenderFragment Render()
    {
        var appointments = Scheduler.GetAppointmentsInRange(StartDate, EndDate);

        var maxAppointmentsInSlot = 0;

        if (MaxAppointmentsInSlot != null)
        {
            maxAppointmentsInSlot = MaxAppointmentsInSlot.Value;
        }
        else
        {
            var slotHeight = (Scheduler.Height - 60) / 6;
            maxAppointmentsInSlot = Convert.ToInt32(Math.Floor(slotHeight / 24)) - 1;
        }

        return 

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(0, "CascadingValue");
            __builder2.AddAttribute(1, "Value", 
#line 23 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenMonthView.razor"
                                       Scheduler

#line default
#line hidden
            );
            __builder2.AddMarkupContent(2, "\n            ");
            __builder2.OpenElement(3, "MonthView");
            __builder2.AddAttribute(4, "StartDate", 
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenMonthView.razor"
                                  StartDate

#line default
#line hidden
            );
            __builder2.AddAttribute(5, "EndDate", 
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenMonthView.razor"
                                                     EndDate

#line default
#line hidden
            );
            __builder2.AddAttribute(6, "MaxAppointmentsInSlot", 
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenMonthView.razor"
                                                                                    maxAppointmentsInSlot

#line default
#line hidden
            );
            __builder2.AddAttribute(7, "MoreText", 
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenMonthView.razor"
                                                                                                                    MoreText

#line default
#line hidden
            );
            __builder2.AddAttribute(8, "Appointments", 
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenMonthView.razor"
                                                                                                                                           appointments

#line default
#line hidden
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(9, "\n        ");
            __builder2.CloseElement();
        }
#line 25 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenMonthView.razor"
                         ;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
