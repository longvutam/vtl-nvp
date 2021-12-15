#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af53522758206e1997d575ef3604e2939766d46d"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor
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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenDayView : SchedulerViewBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
       
    public override RenderFragment Render()
    {
        var date = Scheduler.CurrentDate.Date;

        var appointments = Scheduler.GetAppointmentsInRange(date, date.AddDays(1)).ToList();

        return 
    

#line default
#line hidden
        (__builder2) => {
            __Blazor.Radzen.Blazor.RadzenDayView.TypeInference.CreateCascadingValue_0(__builder2, 0, 1, 
#line 14 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
                            Scheduler

#line default
#line hidden
            , 2, (__builder3) => {
                __builder3.AddMarkupContent(3, "\r\n        ");
                __builder3.OpenComponent<Radzen.Blazor.Rendering.DayView>(4);
                __builder3.AddAttribute(5, "StartDate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
                            StartDate

#line default
#line hidden
                ));
                __builder3.AddAttribute(6, "EndDate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
                                               EndDate

#line default
#line hidden
                ));
                __builder3.AddAttribute(7, "StartTime", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan>(
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
                                                                  StartTime

#line default
#line hidden
                ));
                __builder3.AddAttribute(8, "EndTime", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan>(
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
                                                                                     EndTime

#line default
#line hidden
                ));
                __builder3.AddAttribute(9, "Appointments", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IList<Radzen.Blazor.AppointmentData>>(
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
                                                                                                           appointments

#line default
#line hidden
                ));
                __builder3.AddAttribute(10, "TimeFormat", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 16 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
                     TimeFormat

#line default
#line hidden
                ));
                __builder3.CloseComponent();
                __builder3.AddMarkupContent(11, "\r\n    ");
            }
            );
            __builder2.AddMarkupContent(12, "\r\n");
        }
#line 18 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDayView.razor"
    ;
    }

#line default
#line hidden
    }
}
namespace __Blazor.Radzen.Blazor.RadzenDayView
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
