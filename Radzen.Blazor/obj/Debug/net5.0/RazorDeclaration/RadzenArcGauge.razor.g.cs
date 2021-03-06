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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGauge.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenArcGauge : GaugeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 41 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenArcGauge.razor"
       
    IList<RadzenArcGaugeScaleValue> Values { get; set; } = new List<RadzenArcGaugeScaleValue>();

    string ValueStyle(RadzenArcGaugeScaleValue value)
    {
        return $"left: {value.Scale.CurrentCenter.X.ToInvariantString()}px; top: {value.Scale.CurrentCenter.Y.ToInvariantString()}px";
    }

    internal void AddValue(RadzenArcGaugeScaleValue value)
    {
        if (!Values.Contains(value))
        {
            Values.Add(value);

            StateHasChanged();
        }
    }

    protected override string GetComponentCssClass()
    {
        return $"rz-arc-gauge";
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
