#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DonutChartPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe6bb1d7b1dc6a274642694600380331bf0deb16"
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
#line 1 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/donut-chart")]
    public partial class DonutChartPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Radzen Blazor Chart donut series</h1>\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(1);
            __builder.AddAttribute(2, "Name", "Chart");
            __builder.AddAttribute(3, "Source", "DonutChart");
            __builder.AddAttribute(4, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DonutChartPage.razor"
                                                         false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-sm-12 col-lg-6 offset-lg-3 my-5");
                __builder2.OpenComponent<Radzen.Blazor.RadzenChart>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.RadzenBlazorDemos.Pages.DonutChartPage.TypeInference.CreateRadzenDonutSeries_0(__builder3, 14, 15, 
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DonutChartPage.razor"
                                              revenue

#line default
#line hidden
#nullable disable
                    , 16, "Quarter", 17, "Revenue", 18, (__builder4) => {
                        __builder4.AddMarkupContent(19, "<div class=\"rz-donut-content\"><div>Revenue</div> \n                                <div>for 2020</div></div>");
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DonutChartPage.razor"
       
    class DataItem
    {
        public string Quarter { get; set; }
        public double Revenue { get; set; }
    }

    DataItem[] revenue = new DataItem[] {
    new DataItem
    {
    Quarter = "Q1",
    Revenue = 30000
    },
    new DataItem
    {
    Quarter = "Q2",
    Revenue = 40000
    },
    new DataItem
    {
    Quarter = "Q3",
    Revenue = 50000
    },
    new DataItem
    {
    Quarter = "Q4",
    Revenue = 80000
    },
    };

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.RadzenBlazorDemos.Pages.DonutChartPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDonutSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDonutSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "TitleTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
