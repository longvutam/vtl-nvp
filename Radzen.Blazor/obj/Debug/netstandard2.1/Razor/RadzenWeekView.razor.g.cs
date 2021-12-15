#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6daadfc93f836e5bc55b30179be936d660a9e5f5"
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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenWeekView : SchedulerViewBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
       
    public override RenderFragment Render()
    {
        var appointments = Scheduler.GetAppointmentsInRange(StartDate, EndDate).ToList();

        return 

#line default
#line hidden
        (__builder2) => {
            __Blazor.Radzen.Blazor.RadzenWeekView.TypeInference.CreateCascadingValue_0(__builder2, 0, 1, 
#line 11 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
                                       Scheduler

#line default
#line hidden
            , 2, (__builder3) => {
                __builder3.AddMarkupContent(3, "\r\n                ");
                __builder3.OpenComponent<Radzen.Blazor.Rendering.WeekView>(4);
                __builder3.AddAttribute(5, "StartDate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
                                     StartDate

#line default
#line hidden
                ));
                __builder3.AddAttribute(6, "EndDate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
                                                        EndDate

#line default
#line hidden
                ));
                __builder3.AddAttribute(7, "StartTime", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan>(
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
                                                                           StartTime

#line default
#line hidden
                ));
                __builder3.AddAttribute(8, "EndTime", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan>(
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
                                                                                              EndTime

#line default
#line hidden
                ));
                __builder3.AddAttribute(9, "Appointments", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IList<Radzen.Blazor.AppointmentData>>(
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
                                                                                                                    appointments

#line default
#line hidden
                ));
                __builder3.AddAttribute(10, "TimeFormat", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
                                                                                                                                              TimeFormat

#line default
#line hidden
                ));
                __builder3.CloseComponent();
                __builder3.AddMarkupContent(11, "\r\n            ");
            }
            );
        }
#line 13 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenWeekView.razor"
                             ;
    }

#line default
#line hidden
    }
}
namespace __Blazor.Radzen.Blazor.RadzenWeekView
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
