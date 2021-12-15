#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5e478c22f1cf607313de02ff6cede2f682a89f8"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/dialog")]
    public partial class DialogPage : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "Dialog");
            __builder.AddAttribute(2, "AdditionalSourceCodePages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                         new [] { "DialogCardPage.razor" }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-xl-6");
                __builder2.AddMarkupContent(8, "<h3>Open page as a dialog</h3>\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(9);
                __builder2.AddAttribute(10, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                 $"Show OrderID: {orderID} details"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                                            OpenOrder

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.AddMarkupContent(13, "<h3 style=\"margin-top: 20px;\">Inline Dialog</h3>\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Text", "Show dialog with inline Blazor content");
                __builder2.AddAttribute(16, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                                               ShowInlineDialog

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\n            ");
                __builder2.AddMarkupContent(18, "<h3 style=\"margin-top: 20px;\">Busy Dialog with a string message</h3>\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(19);
                __builder2.AddAttribute(20, "Text", "Show busy dialog");
                __builder2.AddAttribute(21, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                          args => ShowBusyDialog(true)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n            ");
                __builder2.AddMarkupContent(23, "<h3 style=\"margin-top: 20px;\">Busy Dialog with markup</h3>\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(24);
                __builder2.AddAttribute(25, "Text", "Show busy dialog");
                __builder2.AddAttribute(26, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                          args => ShowBusyDialog(false)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n            ");
                __builder2.AddMarkupContent(28, "<h3 style=\"margin-top: 20px;\">Confirm Dialog</h3>\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(29);
                __builder2.AddAttribute(30, "Text", "Show confirm dialog");
                __builder2.AddAttribute(31, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                             args => DialogService.Confirm("Are you sure?", "MyTitle", new ConfirmOptions() { OkButtonText = "Yes", CancelButtonText = "No" })

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\n            ");
                __builder2.AddMarkupContent(33, "<h3 style=\"margin-top: 20px;\">Close Dialog by clicking outside</h3>\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(34);
                __builder2.AddAttribute(35, "Text", "Show dialog with clickable overlay");
                __builder2.AddAttribute(36, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                                           ShowCloseableFromOverlayDialog

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(40);
                __builder2.AddComponentReferenceCapture(41, (__value) => {
#nullable restore
#line 22 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                console = (RadzenBlazorDemos.Shared.EventConsole)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
       
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
            __builder2.OpenElement(42, "div");
            __builder2.AddMarkupContent(43, "<p Style=\"margin-bottom: 1rem\">Confirm?</p>\n            ");
            __builder2.OpenElement(44, "div");
            __builder2.AddAttribute(45, "class", "row");
            __builder2.OpenElement(46, "div");
            __builder2.AddAttribute(47, "class", "col-md-12");
            __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(48);
            __builder2.AddAttribute(49, "Text", "Ok");
            __builder2.AddAttribute(50, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                   () => ds.Close(true)

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(51, "Style", "margin-bottom: 10px; width: 150px");
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(52, "\n                    ");
            __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(53);
            __builder2.AddAttribute(54, "Text", "Cancel");
            __builder2.AddAttribute(55, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                       () => ds.Close(false)

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(56, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 69 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                                                           ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(57, "Style", "margin-bottom: 10px; width: 150px");
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(58, "\n                    ");
            __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(59);
            __builder2.AddAttribute(60, "Text", "Refresh");
            __builder2.AddAttribute(61, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                        (() => { orderID = 10249; ds.Refresh(); })

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(62, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 70 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                                                                                                                 ButtonStyle.Info

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(63, "Style", "margin-bottom: 10px; width: 150px");
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(64, "\n                    Order ID: ");
            __builder2.AddContent(65, 
#nullable restore
#line 71 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
                               orderID

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
            __builder2.CloseElement();
            __builder2.CloseElement();
        }
#nullable restore
#line 74 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
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
            __builder2.AddMarkupContent(66, "<div>\n            Click outside to close this Dialog\n        </div>");
        }
#nullable restore
#line 84 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
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
            __builder2.AddMarkupContent(67, "<div><div class=\"row\"><div class=\"col-md-12\">\n                        Loading...\n                    </div></div></div>");
        }
#nullable restore
#line 118 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DialogPage.razor"
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
