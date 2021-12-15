// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RadzenBlazorDemos.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\MainLayout.razor"
        RadzenSidebar sidebar0;
    RadzenBody body0;
    bool sidebarExpanded = true;
    bool bodyExpanded = false;

    dynamic themes = new[]
    {
        new { Text = "Default Theme", Value = "default"},
        new { Text = "Dark Theme", Value="dark" },
        new { Text = "Software Theme", Value = "software"},
        new { Text = "Humanistic Theme", Value = "humanistic" },
        new { Text = "Standard Theme", Value = "standard" }
    };

    IEnumerable<Example> examples;

    string Theme
    {
        get
        {
            return $"{ThemeState.CurrentTheme}.css";
        }
    }

    protected override void OnInitialized()
    {
        if (httpContextAccessor != null && httpContextAccessor.HttpContext != null &&
             httpContextAccessor.HttpContext.Request != null && httpContextAccessor.HttpContext.Request.Headers.ContainsKey("User-Agent"))
        {
            var userAgent = httpContextAccessor.HttpContext.Request.Headers["User-Agent"].FirstOrDefault();
            if (!string.IsNullOrEmpty(userAgent))
            {
                if (userAgent.Contains("iPhone") || userAgent.Contains("Android") || userAgent.Contains("Googlebot"))
                {
                    sidebarExpanded = false;
                    bodyExpanded = true;
                }
            }
        }

        examples = ExampleService.Examples;

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
        {
            var example = ExampleService.FindCurrent(UriHelper.ToAbsoluteUri(UriHelper.Uri));

            await JSRuntime.InvokeVoidAsync("setTitle", ExampleService.TitleFor(example));
        }
    }

    void FilterPanelMenu(ChangeEventArgs args)
    {
        var term = args.Value.ToString();

        examples = ExampleService.Filter(term);
    }

    void ChangeTheme(object value)
    {
        ThemeState.CurrentTheme = value.ToString();
        UriHelper.NavigateTo(UriHelper.ToAbsoluteUri(UriHelper.Uri).ToString());
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExampleService ExampleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ThemeState ThemeState { get; set; }
    }
}
#pragma warning restore 1591
