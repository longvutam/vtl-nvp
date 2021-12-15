#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\SupportPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fcbafce163826f5e792e4cdf88ccb08080c030d"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/support")]
    public partial class SupportPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Support</h1>\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(1);
            __builder.AddAttribute(2, "class", "docu px-lg-5 pb-5");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<div class=\"row\"><div class=\"col-lg-12 col-xl-4 offset-xl-1\"><a name=\"#community\"></a>\r\n            <img class=\"illustration\" src=\"images/community.svg\">\r\n            <h2 class=\"mt-4 text-center\"><a href=\"#community\">Community Support</a></h2>\r\n            <p>\r\n                Everybody is welcome to visit the <a href=\"https://forum.radzen.com\" target=\"_blank\">Radzen Community forum</a>. Join the growing community and participate in the discussions!\r\n            </p>\r\n            <p>\r\n                The Radzen team monitors the forum threads but does not guarantee a response to every question. For guaranteed responses\r\n                you may consider the <a href=\"#dedicated\">Dedicated support</a> option.\r\n            </p></div>\r\n        <div class=\"col-lg-12 col-xl-4 offset-xl-2\"><a name=\"#dedicated\"></a><img class=\"illustration\" src=\"images/premium.svg\">\r\n            <h2 class=\"mt-4 text-center\"><a href=\"#dedicated\">Dedicated Support</a></h2>\r\n\r\n            <p>\r\n                Radzen Ltd. offers dedicated support with the Radzen Professional and Enterprise subscriptions. \r\n            </p>\r\n            <p class=\"text-center\"><a class=\"cta-button primary ml-0 mb-4\" href=\"https://www.radzen.com/pricing/\">See Pricing</a></p>\r\n            <p class=\"text-center\">\r\n                A Radzen subscription provides:\r\n            </p>\r\n            <ul style=\"font-size: .875rem\"><li>Dedicated support over email with guaranteed response time (24 hours for Radzen Professional and 16 hours for Radzen Enterprise).</li>\r\n                <li>Full access to Radzen - the first WYSIWYG Blazor development environment on the market.</li>\r\n                <li><a href=\"https://www.radzen.com/documentation/premium-themes/\" target=\"_blank\">Premium themes</a> and visual <a href=\"https://www.radzen.com/documentation/theme-customization/\" target=\"_blank\">theme customization</a>.</li>\r\n                <li>Complete Blazor application scaffolding from the most commonly used databases - MSSQL, Oracle, MySQL and PostgreSQL.</li>\r\n                <li>Built-in deploy to IIS, FTP, Zip and Azure.</li>\r\n                <li>Multi-tenancy support</li></ul></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
