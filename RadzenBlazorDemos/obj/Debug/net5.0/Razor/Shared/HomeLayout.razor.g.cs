#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\HomeLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb33a5e223486f66220c37d5e281e7a57a40b739"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenBlazorDemos.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 7 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\HomeLayout.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\HomeLayout.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\HomeLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class HomeLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContentContainer>(8);
            __builder.AddAttribute(9, "Name", "main");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, 
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\HomeLayout.razor"
     Body

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\HomeLayout.razor"
       

    IEnumerable<Example> examples;

    protected override void OnInitialized()
    {

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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExampleService ExampleService { get; set; }
    }
}
#pragma warning restore 1591