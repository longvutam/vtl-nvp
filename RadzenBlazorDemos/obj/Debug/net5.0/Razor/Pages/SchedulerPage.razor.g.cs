#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cc509fd3635cca117a13991594a099f66504628"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenBlazorDemos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/scheduler")]
    public partial class SchedulerPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "Scheduler");
            __builder.AddAttribute(2, "AdditionalSourceCodePages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor"
                                                            new List<string>() { "AddAppointmentPage.razor", "EditAppointmentPage.razor" }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-xl-6");
                __builder2.OpenComponent<Radzen.Blazor.RadzenScheduler<Appointment>>(8);
                __builder2.AddAttribute(9, "SlotRender", new System.Action<Radzen.SchedulerSlotRenderEventArgs>(
#nullable restore
#line 7 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor"
                                                 OnSlotRender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "style", "height: 768px;");
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Appointment>>(
#nullable restore
#line 7 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor"
                                                                                                               appointments

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "StartProperty", "Start");
                __builder2.AddAttribute(13, "EndProperty", "End");
                __builder2.AddAttribute(14, "TextProperty", "Text");
                __builder2.AddAttribute(15, "SelectedIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor"
                                           2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "SlotSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.SchedulerSlotSelectEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.SchedulerSlotSelectEventArgs>(this, 
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor"
                    OnSlotSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "AppointmentSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.SchedulerAppointmentSelectEventArgs<Appointment>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.SchedulerAppointmentSelectEventArgs<Appointment>>(this, 
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor"
                                                    OnAppointmentSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(18, "AppointmentRender", new System.Action<Radzen.SchedulerAppointmentRenderEventArgs<Appointment>>(
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor"
                                                                                           OnAppointmentRender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDayView>(20);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenWeekView>(22);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMonthView>(24);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(25, (__value) => {
#nullable restore
#line 7 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor"
                           scheduler = (Radzen.Blazor.RadzenScheduler<Appointment>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(29);
                __builder2.AddComponentReferenceCapture(30, (__value) => {
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor"
                            console = (RadzenBlazorDemos.Shared.EventConsole)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\SchedulerPage.razor"
       
    RadzenScheduler<Appointment> scheduler;
    EventConsole console;
    Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();

    IList<Appointment> appointments = new List<Appointment>
    {
        new Appointment { Start = DateTime.Today.AddDays(-2), End = DateTime.Today.AddDays(-2), Text = "Birthday" },
        new Appointment { Start = DateTime.Today.AddDays(-11), End = DateTime.Today.AddDays(-10), Text = "Day off" },
        new Appointment { Start = DateTime.Today.AddDays(-10), End = DateTime.Today.AddDays(-8), Text = "Work from home" },
        new Appointment { Start = DateTime.Today.AddHours(10), End = DateTime.Today.AddHours(12), Text = "Online meeting" },
        new Appointment { Start = DateTime.Today.AddHours(10), End = DateTime.Today.AddHours(13), Text = "Skype call" },
        new Appointment { Start = DateTime.Today.AddHours(14), End = DateTime.Today.AddHours(14).AddMinutes(30), Text = "Dentist appointment" },
        new Appointment { Start = DateTime.Today.AddDays(1), End = DateTime.Today.AddDays(12), Text = "Vacation" },
    };

    void OnSlotRender(SchedulerSlotRenderEventArgs args) 
    {
        // Highlight today in month view
        if (args.View.Text == "Month" && args.Start.Date == DateTime.Today)
        {
            args.Attributes["style"] = "background: rgba(255,220,40,.2);";
        }

        // Highlight working hours (9-18)
        if ((args.View.Text == "Week" || args.View.Text == "Day") && args.Start.Hour > 8 && args.Start.Hour < 19)
        {
            args.Attributes["style"] = "background: rgba(255,220,40,.2);";
        }
    }

    async Task OnSlotSelect(SchedulerSlotSelectEventArgs args)
    {
        console.Log($"SlotSelect: Start={args.Start} End={args.End}");

        Appointment data = await DialogService.OpenAsync<AddAppointmentPage>("Add Appointment",
            new Dictionary<string, object> { { "Start", args.Start }, { "End", args.End } });

        if (data != null)
        {
            appointments.Add(data);
            // Either call the Reload method or reassign the Data property of the Scheduler
            await scheduler.Reload();
        }
    }

    async Task OnAppointmentSelect(SchedulerAppointmentSelectEventArgs<Appointment> args)
    {
        console.Log($"AppointmentSelect: Appointment={args.Data.Text}");

        await DialogService.OpenAsync<EditAppointmentPage>("Edit Appointment", new Dictionary<string, object> { { "Appointment", args.Data } });

        await scheduler.Reload();
    }

    void OnAppointmentRender(SchedulerAppointmentRenderEventArgs<Appointment> args)
    {
        // Never call StateHasChanged in AppointmentRender - would lead to infinite loop

        if (args.Data.Text == "Birthday")
        {
            args.Attributes["style"] = "background: red";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
