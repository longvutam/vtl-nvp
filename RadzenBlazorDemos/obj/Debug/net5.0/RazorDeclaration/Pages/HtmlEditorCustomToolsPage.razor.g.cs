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
    [Microsoft.AspNetCore.Components.RouteAttribute("/html-editor-custom-tools")]
    public partial class HtmlEditorCustomToolsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomToolsPage.razor"
       
    async Task OnExecute(HtmlEditorExecuteEventArgs args)
    {
        if (args.CommandName == "InsertToday")
        {
            await InsertDate(args.Editor, DateTime.Now);
        }

        if (args.CommandName == "InsertImageFromList")
        {
            await InsertImageFromList(args.Editor);
        }
    }

    async Task InsertImageFromList(RadzenHtmlEditor editor)
    {
        await editor.SaveSelectionAsync();

        var result = await DialogService.OpenAsync<HtmlEditorCustomDialog>("Select image file"); 

        await editor.RestoreSelectionAsync();

        if (result != null)
        {
            await editor.ExecuteCommandAsync(HtmlEditorCommands.InsertHtml, $"<img style=\"max-width: 100%\" src=\"{result}\">");
        }
    }

    async Task OnDateChange(DateTime? date, RadzenHtmlEditor editor)
    {
        if (date != null)
        {
            await InsertDate(editor, date.Value);
        }
    }

    async Task InsertDate(RadzenHtmlEditor editor, DateTime date)
    {
        await editor.ExecuteCommandAsync(HtmlEditorCommands.InsertHtml, $"<strong>{date.ToLongDateString()}</strong>");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
