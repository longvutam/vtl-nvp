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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\DaySlotEvents.razor"
using Radzen.Blazor;

#line default
#line hidden
    public partial class DaySlotEvents : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 45 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\DaySlotEvents.razor"
       
    [CascadingParameter]
    public IScheduler Scheduler { get; set; }

    [Parameter]
    public DateTime StartDate { get; set; }

    [Parameter]
    public DateTime EndDate { get; set; }

    [Parameter]
    public IList<AppointmentData> Appointments { get; set; }

    async Task OnAppointmentSelect(AppointmentData data)
    {
        await Scheduler.SelectAppointment(data);
    }

    private AppointmentData[] AppointmentsInSlot(DateTime start, DateTime end)
    {
        if (Appointments == null)
        {
            return Array.Empty<AppointmentData>();
        }

        return Appointments.Where(item => Scheduler.IsAppointmentInRange(item, start, end)).OrderBy(item => item.Start).ThenByDescending(item => item.End).ToArray();
    }

    double DetermineLeft(HashSet<double> existingLefts, double width)
    {
        double left = 0;

        while (existingLefts.Contains(left))
        {
            left += width;
        }

        return left;
    }

    HashSet<double> ExistingLefts(IDictionary<AppointmentData, double> lefts, IEnumerable<AppointmentData> appointments)
    {
        var existingLefts = new HashSet<double>();

        foreach (var appointment in appointments)
        {
            if (lefts.TryGetValue(appointment, out var existingLeft))
            {
                existingLefts.Add(existingLeft);
            }
        }

        return existingLefts;
    }
    private IDictionary<int, int> AppointmentGroups()
    {
        var groups = new Dictionary<int, int>();

        for (var index = 0; index < Appointments.Count(); index++)
        {
            groups[index] = 0;
        }

        for (var date = StartDate; date < EndDate; date = date.AddMinutes(30))
        {
            var start = date;
            var end = start.AddMinutes(30);

            var appointments = AppointmentsInSlot(start, end);

            foreach (var item in appointments)
            {
                var index = Appointments.IndexOf(item);

                var count = groups[index];

                groups[index] = Math.Max(appointments.Length, count);
            }
        }

        return groups;
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
