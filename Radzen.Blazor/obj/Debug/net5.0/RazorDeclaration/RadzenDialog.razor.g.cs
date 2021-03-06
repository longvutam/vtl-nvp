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
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenDialog.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 3 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenDialog.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenDialog : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenDialog.razor"
       
    [Inject] 
    DialogService Service { get; set; }

    List<Dialog> dialogs = new List<Dialog>();

    public async Task Open(string title, Type type, Dictionary<string, object> parameters, DialogOptions options)
    {
        dialogs.Add(new Dialog() { Title = title, Type = type, Parameters = parameters, Options = options });

        await InvokeAsync(() => { StateHasChanged(); });

        await JSRuntime.InvokeAsync<string>("Radzen.openDialog", options);
    }

    public async Task Close(dynamic result)
    {
        var lastDialog = dialogs.LastOrDefault();
        if (lastDialog != null)
        {
            dialogs.Remove(lastDialog);
            await JSRuntime.InvokeAsync<string>("Radzen.closeDialog");
        }

        await InvokeAsync(() => 
        { 
            StateHasChanged(); 
        });
    }

    public void Dispose()
    {
        Service.OnOpen -= OnOpen;
        Service.OnClose -= OnClose;
        Service.OnRefresh -= OnRefresh;
    }

    protected override void OnInitialized()
    {
        Service.OnOpen += OnOpen;
        Service.OnClose += OnClose;
        Service.OnRefresh += OnRefresh;
    }

    void OnOpen(string title, Type type, Dictionary<string, object> parameters, DialogOptions options)
    {
        Open(title, type, parameters, options).ConfigureAwait(false);
    }

    void OnClose(dynamic result)
    {
        Close(result).ConfigureAwait(false);
    }

    void OnRefresh()
    {
        InvokeAsync(StateHasChanged).ConfigureAwait(false);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
