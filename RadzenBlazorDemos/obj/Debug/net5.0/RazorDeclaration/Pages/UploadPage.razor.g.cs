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
    [Microsoft.AspNetCore.Components.RouteAttribute("/example-upload")]
    public partial class UploadPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
       
    EventConsole console;

    RadzenUpload upload;

    int progress;
    string info;

    int customParameter = 1;

    void OnChange(UploadChangeEventArgs args, string name)
    {
        foreach (var file in args.Files)
        {
            console.Log($"File: {file.Name} / {file.Size} bytes");
        }

        console.Log($"{name} changed");
    }

    void OnProgress(UploadProgressArgs args, string name)
    {
        this.info = $"% '{name}' / {args.Loaded} of {args.Total} bytes.";
        this.progress = args.Progress;

        if (args.Progress == 100)
        {
            console.Clear();

            foreach (var file in args.Files)
            {
                console.Log($"Uploaded: {file.Name} / {file.Size} bytes");
            }
        }
    }

    void OnComplete(UploadCompleteEventArgs args)
    {
        console.Log($"Server response: {args.RawResponse}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
