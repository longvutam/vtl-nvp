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
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Shared\CodeViewer.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class CodeViewer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Shared\CodeViewer.razor"
       
    private ElementReference pre;
    private string source;

    [Parameter]
    public string PageName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var http = new HttpClient();

        source = await http.GetStringAsync($"https://raw.githubusercontent.com/radzenhq/radzen-blazor/master/RadzenBlazorDemos/Pages/{PageName}");
        source = Regex.Replace(source, "</?RadzenExample[^>]*>\n", "");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!String.IsNullOrEmpty(source))
        {
            await JSRuntime.InvokeAsync<object>("hljs.highlightBlock", pre);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591