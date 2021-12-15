#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\ProfileMenuPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a1a0ed4ba0ec9cd7ea3982ebad3b104eba78494"
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
#line 1 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile-menu")]
    public partial class ProfileMenuPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "ProfileMenu");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(3);
                __builder2.AddAttribute(4, "Style", "height: 500px");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenu>(6);
                    __builder3.AddAttribute(7, "Template", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenGravatar>(8);
                        __builder4.AddAttribute(9, "Email", "user@example.com");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(11);
                        __builder4.AddAttribute(12, "Text", "Buttons");
                        __builder4.AddAttribute(13, "Path", "buttons");
                        __builder4.AddAttribute(14, "Icon", "account_circle");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(15, "\r\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(16);
                        __builder4.AddAttribute(17, "Text", "Menu");
                        __builder4.AddAttribute(18, "Path", "menu");
                        __builder4.AddAttribute(19, "Icon", "line_weight");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(20, "\r\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(21);
                        __builder4.AddAttribute(22, "Text", "FileInput");
                        __builder4.AddAttribute(23, "Path", "fileinput");
                        __builder4.AddAttribute(24, "Icon", "attach_file");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(25, "\r\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(26);
                        __builder4.AddAttribute(27, "Text", "Dialog");
                        __builder4.AddAttribute(28, "Path", "dialog");
                        __builder4.AddAttribute(29, "Icon", "perm_media");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(31);
                        __builder4.AddAttribute(32, "Text", "Notification");
                        __builder4.AddAttribute(33, "Path", "notification");
                        __builder4.AddAttribute(34, "Icon", "announcement");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
