#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7baf9f0275ccdaef5b663cace73624797b99bce"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/notification")]
    public partial class NotificationPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "Notification");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-xl-6");
                __builder2.AddMarkupContent(11, "<h3>Info</h3>\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(12);
                __builder2.AddAttribute(13, "Text", "Show info notification");
                __builder2.AddAttribute(14, "Style", "margin-bottom: 20px; width: 200px");
                __builder2.AddAttribute(15, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
                                 ButtonStyle.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
                            args => ShowNotification(new NotificationMessage { Severity = NotificationSeverity.Info, Summary = "Info Summary", Detail = "Info Detail", Duration = 4000 })

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-xl-6");
                __builder2.AddMarkupContent(20, "<h3>Warning</h3>\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(21);
                __builder2.AddAttribute(22, "Text", "Show warning notification");
                __builder2.AddAttribute(23, "Style", "margin-bottom: 20px; width: 200px");
                __builder2.AddAttribute(24, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
                                 ButtonStyle.Warning

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
                            args => ShowNotification(new NotificationMessage { Severity = NotificationSeverity.Warning, Summary = "Warning Summary", Detail = "Warning Detail", Duration = 4000 })

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "row");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-xl-6");
                __builder2.AddMarkupContent(31, "<h3>Error</h3>\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(32);
                __builder2.AddAttribute(33, "Text", "Show error notification");
                __builder2.AddAttribute(34, "Style", "margin-bottom: 20px; width: 200px");
                __builder2.AddAttribute(35, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 26 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
                                 ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
                            args => ShowNotification(new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Error Summary", Detail = "Error Detail", Duration = 4000 })

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-xl-6");
                __builder2.AddMarkupContent(40, "<h3>Success</h3>\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(41);
                __builder2.AddAttribute(42, "Text", "Show success notification");
                __builder2.AddAttribute(43, "Style", "margin-bottom: 20px; width: 200px");
                __builder2.AddAttribute(44, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 32 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
                                 ButtonStyle.Success

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
                            args => ShowNotification(new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Success Summary", Detail = "Success Detail", Duration = 4000 })

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "row");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col");
                __builder2.AddMarkupContent(51, "<h3>Message with custom position</h3>\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(52);
                __builder2.AddAttribute(53, "Text", "Show notification with custom position");
                __builder2.AddAttribute(54, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(55, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
                            args => ShowNotification(new NotificationMessage { Style = "position: absolute; left: -1000px;", Severity = NotificationSeverity.Success, Summary = "Success Summary", Detail = "Success Detail", Duration = 40000 })

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(59);
                __builder2.AddComponentReferenceCapture(60, (__value) => {
#nullable restore
#line 45 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
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
#line 50 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\NotificationPage.razor"
       
    EventConsole console;

    void ShowNotification(NotificationMessage message)
    {
        NotificationService.Notify(message);

        console.Log($"{message.Severity} notification");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591
