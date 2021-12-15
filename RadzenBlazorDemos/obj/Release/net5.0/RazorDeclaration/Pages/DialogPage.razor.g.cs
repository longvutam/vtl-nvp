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
#line 2 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/dialog")]
    public partial class DialogPage : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\DialogPage.razor"
       
    EventConsole console;
    int orderID = 10248;

    protected override void OnInitialized()
    {
        DialogService.OnOpen += Open;
        DialogService.OnClose += Close;
    }

    public void Dispose()
    {
        // The DialogService is a singleton so it is advisable to unsubscribe.
        DialogService.OnOpen -= Open;
        DialogService.OnClose -= Close;
    }

    void Open(string title, Type type, Dictionary<string, object> parameters, DialogOptions options)
    {
        console.Log("Dialog opened");
    }

    void Close(dynamic result)
    {
        console.Log($"Dialog closed");
    }

    public async Task OpenOrder()
    {
        await DialogService.OpenAsync<DialogCardPage>($"Order {orderID}",
               new Dictionary<string, object>() { { "OrderID", orderID } },
               new DialogOptions() { Width = "700px", Height = "530px", Resizable = true, Draggable = true });
    }

    async Task ShowInlineDialog()
    {
     var result = await DialogService.OpenAsync("Simple Dialog", ds =>
        

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "div");
            __builder2.AddMarkupContent(1, "\r\n            ");
            __builder2.AddMarkupContent(2, "<p Style=\"margin-bottom: 1rem\">Confirm?</p>\r\n            ");
            __builder2.OpenElement(3, "div");
            __builder2.AddAttribute(4, "class", "row");
            __builder2.AddMarkupContent(5, "\r\n                ");
            __builder2.OpenElement(6, "div");
            __builder2.AddAttribute(7, "class", "col-md-12");
            __builder2.AddMarkupContent(8, @"
                    <RadzenButton Text=""Ok"" Click=""() => ds.Close(true)"" Style=""margin-bottom: 10px; width: 150px""></RadzenButton>
                    <RadzenButton Text=""Cancel"" Click=""() => ds.Close(false)"" ButtonStyle=""ButtonStyle.Secondary"" Style=""margin-bottom: 10px; width: 150px""></RadzenButton>
                    <RadzenButton Text=""Refresh"" Click=""(() => { orderID = 10249; ds.Refresh(); })"" ButtonStyle=""ButtonStyle.Info"" Style=""margin-bottom: 10px; width: 150px""></RadzenButton>
                    Order ID: ");
#nullable restore
#line 71 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\DialogPage.razor"
__builder2.AddContent(9, orderID);

#line default
#line hidden
#nullable disable
            __builder2.AddMarkupContent(10, "\r\n                ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(11, "\r\n            ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(12, "\r\n        ");
            __builder2.CloseElement();
        }
#nullable restore
#line 74 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\DialogPage.razor"
              );
    
      console.Log($"Dialog result: {result}");
    }

    async Task ShowCloseableFromOverlayDialog()
    {
     await DialogService.OpenAsync("Closeable from overlay Dialog", ds =>
        

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(13, "<div>\r\n            Click outside to close this Dialog\r\n        </div>");
        }
#nullable restore
#line 84 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\DialogPage.razor"
              , new DialogOptions() { CloseDialogOnOverlayClick = true });
    }

    async Task ShowBusyDialog(bool withMessageAsString)
    {
        InvokeAsync(async () =>
        {
            // Simulate background task
            await Task.Delay(2000);

            // Close the dialog
            DialogService.Close();
        });

        if (withMessageAsString)
        {
            await BusyDialog("Busy ...");
        }
        else
        {
            await BusyDialog();
        }
    }

    // Busy dialog from markup
    async Task BusyDialog()
    {
        await DialogService.OpenAsync("", ds =>
            

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(14, "<div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        Loading...\r\n                    </div>\r\n                </div>\r\n        </div>");
        }
#nullable restore
#line 118 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\DialogPage.razor"
              , new DialogOptions() { ShowTitle = false, Style = "min-height:auto;min-width:auto;width:auto" });
    }

    // Busy dialog from string
    async Task BusyDialog(string message)
    {
        await DialogService.OpenAsync("", ds =>
        {
            RenderFragment content = b =>
            {
                b.OpenElement(0, "div");
                b.AddAttribute(1, "class", "row");

                b.OpenElement(2, "div");
                b.AddAttribute(3, "class", "col-md-12");

                b.AddContent(4, message);

                b.CloseElement();
                b.CloseElement();
            };
            return content;
        }, new DialogOptions() { ShowTitle = false, Style = "min-height:auto;min-width:auto;width:auto" });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591