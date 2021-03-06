#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCategoryAxis.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea5b56a64d5340b9e6b4de0780b43a36af752276"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCategoryAxis.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCategoryAxis.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenCategoryAxis : AxisBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Radzen.Blazor.RadzenCategoryAxis.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCategoryAxis.razor"
                        this

#line default
#line hidden
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n  ");
                __builder2.AddContent(4, 
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCategoryAxis.razor"
   ChildContent

#line default
#line hidden
                );
                __builder2.AddMarkupContent(5, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenCategoryAxis.razor"
       
  internal double Measure(RadzenChart chart)
      {
          if (Visible == false)
          {
              return 0;
          }

          if (chart.ShouldInvertAxes())
          {
              return AxisMeasurer.XAxis(chart.ValueAxis.Title);
          }
          else
          {
              return AxisMeasurer.XAxis(Title);
          }
      }

      [Parameter]
      public double Padding { get; set; }

      internal override double Size
      {
          get
          {
              return Measure(Chart);
          }
      }

      protected override void Initialize()
      {
          Chart.CategoryAxis = this;
      }

#line default
#line hidden
    }
}
namespace __Blazor.Radzen.Blazor.RadzenCategoryAxis
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
