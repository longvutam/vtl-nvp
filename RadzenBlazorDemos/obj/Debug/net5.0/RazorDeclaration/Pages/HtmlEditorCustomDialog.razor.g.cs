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
#nullable restore
#line 1 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    public partial class HtmlEditorCustomDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
       
    RenderFragment<RadzenTreeItem> FileOrFolderTemplate = (context) => builder =>
    {
        string path = context.Value as string;
        bool isDirectory = Directory.Exists(path);

        builder.OpenComponent<RadzenIcon>(0);
        builder.AddAttribute(1, "Icon", isDirectory ? "folder" : "insert_drive_file");
        if (!isDirectory)
        {
            builder.AddAttribute(2, "Style", "margin-left: 24px");
        }
        builder.CloseComponent();
        builder.AddContent(3, context.Text);
    };

    void LoadFiles(TreeExpandEventArgs args)
    {
        var directory = args.Value as string;

        args.Children.Data = Directory.EnumerateFileSystemEntries(directory).Where(path => {
            if (Directory.Exists(path))
            {
                return true;
            }

            var extension = Path.GetExtension(path);

            return extension == ".png" || extension == ".jpg";
        });
        args.Children.Text = GetTextForNode;
        args.Children.HasChildren = (path) => Directory.Exists((string)path);
        args.Children.Template = FileOrFolderTemplate;
    }

    string GetTextForNode(object data)
    {
        return Path.GetFileName((string)data);
    }

    IEnumerable<string> entries;
    string selectedFile;

    protected override void OnInitialized()
    {
        entries = Directory.GetDirectories(HostEnvironment.WebRootPath)
                           .Where(entry =>
                           {
                               var name = Path.GetFileName(entry);

                               return !name.StartsWith(".") && name != "bin" && name != "obj";
                           });

    }

    void OnCancelClick()
    {
        DialogService.Close(null);
    }

    void OnOkClick()
    {
        string result = null;

        if (selectedFile != null && !string.IsNullOrEmpty(Path.GetExtension(selectedFile)))
        {
            result = ToUrl(selectedFile);
        }

        DialogService.Close(result);
    }

    string ToUrl(string file)
    {
        return file.Replace(HostEnvironment.WebRootPath, "").Replace(Path.DirectorySeparatorChar, '/');
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
