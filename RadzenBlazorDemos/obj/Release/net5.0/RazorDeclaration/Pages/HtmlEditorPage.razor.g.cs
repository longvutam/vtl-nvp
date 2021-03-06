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
    [Microsoft.AspNetCore.Components.RouteAttribute("/html-editor")]
    public partial class HtmlEditorPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorPage.razor"
       
    string value = @"
    <h1>Radzen.Blazor Getting Started Instructions</h1>
    <h2>1. Install</h2>
    <p>
        Radzen Blazor Components are distributed as the <a href=""https://www.nuget.org/packages/Radzen.Blazor/"">Radzen.Blazor</a> nuget package.
    </p>
    <p>
        You can add them to your project in one of the following ways
    </p>
    <ul>
        <li>Install the package from command line by running <code>dotnet add package Radzen.Blazor</code></li>
        <li>Add the project from the Visual Nuget Package Manager.</li>
    </ul>
    <h2>2. Import the namespace</h2>
    <p>
        Open the <code>_Imports.razor</code> file of your Blazor application and add these two lines <code>@using Radzen</code> and <code>@using Radzen.Blazor</code>.
    </p>
    <h2>3. Include a theme</h2>
    <p>
        Open the <code>_Host.cshtml</code> file (server-side Blazor) or <code>wwwroot/index.html</code> (client-side WebAssembly Blazor) and include a theme CSS file by adding this snippet 
        <code>&lt;link rel=""stylesheet"" href=""_content/Radzen.Blazor/css/default-base.css""&gt;</code>
        This version requires only the Radzen Blazor CSS. Optionally you can include Bootstrap.
    </p>
    <p>
        Alternatively you can include <code>&lt;link rel=""stylesheet"" href=""_content/Radzen.Blazor/css/default.css""&gt;</code> which embeds Bootstrap.
    </p>
    <h2>4. Include Radzen.Blazor.js</h2>
    <p>
        Open the <code>_Host.cshtml</code> file (server-side Blazor) or <code>wwwroot/index.html</code> (client-side WebAssembly Blazor) and include this snippet <code>&lt;script src=""_content/Radzen.Blazor/Radzen.Blazor.js""&gt;&lt;/script&gt;</code>
    </p>
    <h2>5. Use a component</h2>
    <p>
        Use any Radzen Blazor component by typing its tag name in a Blazor page e.g. <code>&lt;RadzenButton Text=""Hi""&gt;&lt;/RadzenButton&gt;</code>
    </p>
    <h4>Setting a property</h4>
<pre>
<code>
&lt;RadzenButton Text=""@text""&gt;&lt;/RadzenButton&gt;
@code {
  string text = ""Hi"";
}
</code>
</pre>
    <h4>Handing events</h4>
<pre>
<code>
&lt;RadzenButton Click=""@ButtonClicked"" Text=""Hi""&gt;&lt;/RadzenButton&gt;
@code {
  void ButtonClicked()
  {
    //
  }
}
</code>
</pre>
    ";

    EventConsole console;

    void OnPaste(HtmlEditorPasteEventArgs args)
    {
        console.Log($"Paste: {args.Html}");
    }

    void OnChange(string html)
    {
        console.Log($"Change: {html}");
    }

    void OnExecute(HtmlEditorExecuteEventArgs args)
    {
        console.Log($"Execute: {args.CommandName}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
