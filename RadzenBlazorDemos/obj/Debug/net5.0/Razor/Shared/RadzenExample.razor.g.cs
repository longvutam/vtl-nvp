#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e80b36072e6abf89c0263ac1022176c72454beeb"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenBlazorDemos.Shared
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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class RadzenExample : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
 if (Heading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h1");
#nullable restore
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
__builder.AddContent(1, Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "Demonstration and configuration of the Radzen Blazor ");
            __builder.OpenElement(5, "strong");
#nullable restore
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
__builder.AddContent(6, Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddContent(7, " component.");
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
 if (Documentation)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "class", "documentation-link");
            __builder.AddAttribute(10, "target", "blank");
            __builder.AddAttribute(11, "href", 
#nullable restore
#line 11 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
                                                        DocumentationHref

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<Radzen.Blazor.RadzenIcon>(12);
            __builder.AddAttribute(13, "Icon", "help_outline");
            __builder.AddAttribute(14, "style", "font-size: 1rem; margin-right: 4px;");
            __builder.CloseComponent();
            __builder.AddContent(15, " Documentation");
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenTabs>(16);
            __builder.AddAttribute(17, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabsItem>(18);
                __builder2.AddAttribute(19, "Text", "Example");
                __builder2.AddAttribute(20, "Icon", "apps");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 16 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
__builder3.AddContent(22, ChildContent);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabsItem>(24);
                __builder2.AddAttribute(25, "Text", "Source");
                __builder2.AddAttribute(26, "Icon", "code");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<RadzenBlazorDemos.Shared.CodeViewer>(28);
                    __builder3.AddAttribute(29, "PageName", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
                                    $"{Source ?? Name}Page.razor"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 21 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
         foreach (var p in AdditionalSourceCodePages)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabsItem>(30);
                __builder2.AddAttribute(31, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
                               Path.GetFileName(p)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Icon", "code");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<RadzenBlazorDemos.Shared.CodeViewer>(34);
                    __builder3.AddAttribute(35, "PageName", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
                                   p

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 26 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Shared\RadzenExample.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string Name { get; set; }

    [Parameter]
    public string Source { get; set; }

    [Parameter]
    public bool Heading { get; set; } = true;

    [Parameter]
    public bool Documentation { get; set; } = true;

    string DocumentationHref => $"/docs/guides/components/{Name.ToLower()}.html";

    [Parameter]
    public IEnumerable<string> AdditionalSourceCodePages { get; set; } = Enumerable.Empty<string>();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
