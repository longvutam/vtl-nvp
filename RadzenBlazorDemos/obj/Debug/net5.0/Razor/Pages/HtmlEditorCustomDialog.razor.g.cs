#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3bf2502f77ba564c5fdf92fd939e286a59d2063"
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
#nullable restore
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "display: flex");
            __builder.OpenComponent<Radzen.Blazor.RadzenTree>(2);
            __builder.AddAttribute(3, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
                      entries

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Change", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.TreeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.TreeEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
                                       args => selectedFile = args.Value.ToString()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Expand", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.TreeExpandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.TreeExpandEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
                                                                                             LoadFiles

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "Style", "width: 50%; height: 300px");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenTreeLevel>(8);
                __builder2.AddAttribute(9, "Text", (System.Func<System.Object, System.String>)(
#nullable restore
#line 8 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
                               GetTextForNode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.RadzenTreeItem>)(
#nullable restore
#line 8 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
                                                        FileOrFolderTemplate

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "style", "width: 50%; padding: 16px; text-align: center;");
#nullable restore
#line 11 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
     if (!string.IsNullOrEmpty(Path.GetExtension(selectedFile)))
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<h4>Preview</h4>\r\n        ");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "style", "max-width: 100%");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 14 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
                                           ToUrl(selectedFile)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "text-align: right");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(21);
            __builder.AddAttribute(22, "Text", "OK");
            __builder.AddAttribute(23, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
                                   OnOkClick

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(25);
            __builder.AddAttribute(26, "Text", "Cancel");
            __builder.AddAttribute(27, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
                                       OnCancelClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 21 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
                                                                  ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\HtmlEditorCustomDialog.razor"
       
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
