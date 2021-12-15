#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c320b20f562785ac3a2cb4751579c8f6ad8e7b"
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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
using Radzen;

#line default
#line hidden
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class MonthView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "rz-view rz-month-view");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "rz-view-header");
            __builder.AddMarkupContent(5, "\r\n");
#line 8 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
             for(var date = StartDate; date <= StartDate.EndOfWeek(); date = date.AddDays(1))
            {

#line default
#line hidden
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "rz-slot-header");
            __builder.AddMarkupContent(9, "\r\n                    ");
#line 11 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
__builder.AddContent(10, date.ToString("ddd", Scheduler.Culture));

#line default
#line hidden
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#line 13 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
            }

#line default
#line hidden
            __builder.AddContent(13, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
       
        var days = 0;
        var points = new Dictionary<AppointmentData, double>();
    

#line default
#line hidden
            __builder.AddContent(15, "    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "rz-view-content");
            __builder.AddMarkupContent(18, "\r\n");
#line 20 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
     for (var date = StartDate; date < EndDate; date = date.AddDays(7))
    {

#line default
#line hidden
            __builder.AddContent(19, "        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "rz-week");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "rz-events");
            __builder.AddMarkupContent(25, "\r\n");
#line 24 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                 for (var start = date; start < date.AddDays(7); start = start.AddDays(1))
                {
                    var end = start.AddDays(1);
                    var appointments = AppointmentsInSlot(start, end);
                    var excessCount = appointments.Count() - MaxAppointmentsInSlot;
                    var existingTops = ExistingTops(points, appointments.Take(MaxAppointmentsInSlot));

                    

#line default
#line hidden
#line 31 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                     foreach(var item in appointments.Take(MaxAppointmentsInSlot))
                    {
                        var slotIndex = item.Start.Date.Subtract(date).Days;
                        var slotWidth = 100 / 7.0;
                        var left = slotIndex * slotWidth;
                        var length = Math.Max(1, Math.Ceiling(item.End.Subtract(date).TotalDays) - slotIndex);
                        var width = item.End <= date.AddDays(7) ? (length) * slotWidth : (7 - slotIndex) * slotWidth;
                        if (!points.TryGetValue(item, out var top))
                        {
                            top = DetermineTop(existingTops);
                            points.Add(item, top);
                            existingTops.Add(top);
                        }
                        var height = 1.5;
                        var data = item;

                        

#line default
#line hidden
#line 47 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                         if (item.Start >= start && item.Start <= end)
                        {

#line default
#line hidden
            __builder.AddContent(26, "                            ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.Appointment>(27);
            __builder.AddAttribute(28, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.AppointmentData>(
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                               item

#line default
#line hidden
            ));
            __builder.AddAttribute(29, "Top", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                         top

#line default
#line hidden
            ));
            __builder.AddAttribute(30, "Left", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                   left

#line default
#line hidden
            ));
            __builder.AddAttribute(31, "Width", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                               width

#line default
#line hidden
            ));
            __builder.AddAttribute(32, "Height", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                                             height

#line default
#line hidden
            ));
            __builder.AddAttribute(33, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.AppointmentData>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.AppointmentData>(this, 
#line 49 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                                                           OnAppointmentClick

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n");
#line 50 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                        }
                        else if (start == date)
                        {
                            left = 0;
                            length = Math.Max(1, Math.Min(7, Math.Ceiling(item.End.Subtract(date).TotalDays)));
                            width = length * slotWidth;


#line default
#line hidden
            __builder.AddContent(35, "                            ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.Appointment>(36);
            __builder.AddAttribute(37, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.AppointmentData>(
#line 57 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                               item

#line default
#line hidden
            ));
            __builder.AddAttribute(38, "Top", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#line 57 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                         top

#line default
#line hidden
            ));
            __builder.AddAttribute(39, "Left", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#line 57 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                   left

#line default
#line hidden
            ));
            __builder.AddAttribute(40, "Width", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#line 57 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                               width

#line default
#line hidden
            ));
            __builder.AddAttribute(41, "Height", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#line 57 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                                             height

#line default
#line hidden
            ));
            __builder.AddAttribute(42, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.AppointmentData>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.AppointmentData>(this, 
#line 57 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                                                           OnAppointmentClick

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n");
#line 58 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                        }

#line default
#line hidden
#line 58 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                         
                    }

#line default
#line hidden
#line 61 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                     if (excessCount > 0)
                    {
                        var slotIndex = start.Subtract(date).Days;
                        var slotWidth = 100 / 7.0;
                        var left = slotIndex * slotWidth;
                        var top = 1.5 * (MaxAppointmentsInSlot + 1);
                        var listDate = start;

#line default
#line hidden
            __builder.AddContent(44, "                        ");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "class", "rz-event-list-btn");
            __builder.AddAttribute(47, "style", "top:" + " " + (
#line 68 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                   top.ToInvariantString()

#line default
#line hidden
            ) + "em;" + " left:" + " " + (
#line 68 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                                                       left.ToInvariantString()

#line default
#line hidden
            ) + "%");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 68 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                                                                                              args => OnListClick(listDate, appointments)

#line default
#line hidden
            ));
#line 68 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
__builder.AddContent(49, String.Format(MoreText, excessCount));

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#line 69 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                    }

#line default
#line hidden
#line 69 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                     
                }

#line default
#line hidden
            __builder.AddContent(51, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "rz-slots");
            __builder.AddMarkupContent(55, "\r\n");
#line 73 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
             for (var day = 0; day < 7; day ++)
            {
                var dayOfWeek = StartDate.AddDays(days++);

#line default
#line hidden
            __builder.AddContent(56, "                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 76 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                 args => OnSlotClick(dayOfWeek)

#line default
#line hidden
            ));
            __builder.AddMultipleAttributes(59, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 76 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                                                               Attributes(dayOfWeek)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "rz-slot-title");
            __builder.AddMarkupContent(63, "\r\n                        ");
#line 78 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
__builder.AddContent(64, dayOfWeek.Day);

#line default
#line hidden
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#line 81 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
            }

#line default
#line hidden
            __builder.AddContent(68, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#line 84 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
    }

#line default
#line hidden
            __builder.AddContent(71, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 88 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
       
    [Parameter]
    public DateTime StartDate { get; set; }

    [Parameter]
    public DateTime EndDate { get; set; }

    [Parameter]
    public int MaxAppointmentsInSlot { get; set; }

    [Parameter]
    public string MoreText { get; set; }

    [CascadingParameter]
    public IScheduler Scheduler { get; set; }

    [Parameter]
    public IEnumerable<AppointmentData> Appointments { get; set; }

    IDictionary<string, object> Attributes(DateTime start)
    {
        var attributes = Scheduler.GetSlotAttributes(start, start.AddDays(1));
        attributes["class"] = ClassList.Create("rz-slot").Add(attributes).ToString();
        return attributes;
    }
    
    async Task OnSlotClick(DateTime date)
    {
        await Scheduler.SelectSlot(date, date.AddDays(1));
    }

    double DetermineTop(HashSet<double> existingTops)
    {
        var top = 1.5;

        while (existingTops.Contains(top))
        {
            top += 1.5;
        }

        return top;
    }

    HashSet<double> ExistingTops(IDictionary<AppointmentData, double> tops, IEnumerable<AppointmentData> appointments)
    {
        var existingTops = new HashSet<double>();

        foreach (var appointment in appointments)
        {
            if (tops.TryGetValue(appointment, out var existingTop))
            {
                existingTops.Add(existingTop);
            }
        }

        return existingTops;
    }

    async Task OnAppointmentClick(AppointmentData data)
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

    async Task OnListClick(DateTime date, IEnumerable<AppointmentData> appointments)
    {
     await DialogService.OpenAsync(date.ToShortDateString(), ds =>
        

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(73, "div");
            __builder2.AddAttribute(74, "class", "rz-event-list");
            __builder2.AddMarkupContent(75, "\r\n        ");
            __Blazor.Radzen.Blazor.Rendering.MonthView.TypeInference.CreateCascadingValue_0(__builder2, 76, 77, 
#line 165 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                               Scheduler

#line default
#line hidden
            , 78, (__builder3) => {
                __builder3.AddMarkupContent(79, "\r\n");
#line 166 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
         foreach(var item in appointments)
        {

#line default
#line hidden
                __builder3.AddContent(80, "            ");
                __builder3.OpenComponent<Radzen.Blazor.Rendering.Appointment>(81);
                __builder3.AddAttribute(82, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.AppointmentData>(
#line 168 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                               item

#line default
#line hidden
                ));
                __builder3.AddAttribute(83, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.AppointmentData>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.AppointmentData>(this, 
#line 168 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
                                           OnListEventClick

#line default
#line hidden
                )));
                __builder3.CloseComponent();
                __builder3.AddMarkupContent(84, "\r\n");
#line 169 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
        }

#line default
#line hidden
                __builder3.AddContent(85, "        ");
            }
            );
            __builder2.AddMarkupContent(86, "\r\n        ");
            __builder2.CloseElement();
        }
#line 171 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\Rendering\MonthView.razor"
              );
    }

    async Task OnListEventClick(AppointmentData data)
    {
        DialogService.Close();

        await OnAppointmentClick(data);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
namespace __Blazor.Radzen.Blazor.Rendering.MonthView
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
