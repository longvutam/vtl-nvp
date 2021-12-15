// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RadzenBlazorDemos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\LineChartPage.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/line-chart")]
    public partial class LineChartPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\LineChartPage.razor"
       
    bool smooth = false;
    class DataItem
    {
        public DateTime Date { get; set; }
        public double Revenue { get; set; }
    }

    string FormatAsUSD(object value)
    {
        return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
    }

    DataItem[] revenue2019 = new DataItem[] {
        new DataItem
        {
            Date = DateTime.Parse("2019-01-01"),
            Revenue = 234000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-02-01"),
            Revenue = 269000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-03-01"),
            Revenue = 233000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-04-01"),
            Revenue = 244000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-05-01"),
            Revenue = 214000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-06-01"),
            Revenue = 253000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-07-01"),
            Revenue = 274000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-08-01"),
            Revenue = 284000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-09-01"),
            Revenue = 273000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-10-01"),
            Revenue = 282000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-11-01"),
            Revenue = 289000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-12-01"),
            Revenue = 294000
        }
    };

    DataItem[] revenue2020 = new DataItem[] {
        new DataItem
        {
            Date = DateTime.Parse("2019-01-01"),
            Revenue = 334000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-02-01"),
            Revenue = 369000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-03-01"),
            Revenue = 333000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-04-01"),
            Revenue = 344000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-05-01"),
            Revenue = 314000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-06-01"),
            Revenue = 353000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-07-01"),
            Revenue = 374000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-08-01"),
            Revenue = 384000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-09-01"),
            Revenue = 373000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-10-01"),
            Revenue = 382000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-11-01"),
            Revenue = 389000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-12-01"),
            Revenue = 394000
        }
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
