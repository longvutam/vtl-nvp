#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3596767d6ac802b588693295ded23e89918123"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor"
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
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor"
           
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
            __Blazor.Radzen.Blazor.RadzenMonthView.TypeInference.CreateCascadingValue_0(__builder2, 0, 1, 
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor"
                                       Scheduler

#line default
#line hidden
            , 2, (__builder3) => {
                __builder3.AddMarkupContent(3, "\r\n            ");
                __builder3.OpenComponent<Radzen.Blazor.Rendering.MonthView>(4);
                __builder3.AddAttribute(5, "StartDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 24 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor"
                                  StartDate

#line default
#line hidden
                ));
                __builder3.AddAttribute(6, "EndDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#line 24 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor"
                                                     EndDate

#line default
#line hidden
                ));
                __builder3.AddAttribute(7, "MaxAppointmentsInSlot", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 24 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor"
                                                                                    maxAppointmentsInSlot

#line default
#line hidden
                ));
                __builder3.AddAttribute(8, "MoreText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 24 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor"
                                                                                                                    MoreText

#line default
#line hidden
                ));
                __builder3.AddAttribute(9, "Appointments", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Radzen.Blazor.AppointmentData>>(
#line 24 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor"
                                                                                                                                           appointments

#line default
#line hidden
                ));
                __builder3.CloseComponent();
                __builder3.AddMarkupContent(10, "\r\n        ");
            }
            );
        }
#line 25 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenMonthView.razor"
                         ;
    }

#line default
#line hidden
    }
}
namespace __Blazor.Radzen.Blazor.RadzenMonthView
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
