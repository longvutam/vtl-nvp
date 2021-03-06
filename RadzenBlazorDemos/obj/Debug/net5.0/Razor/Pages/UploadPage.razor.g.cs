#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b475b70f43445b9f93a0e3c158ad9ce5eb61743d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/example-upload")]
    public partial class UploadPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "Upload");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.AddMarkupContent(7, "<h3>Single file upload</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenUpload>(8);
                __builder2.AddAttribute(9, "Url", "upload/single");
                __builder2.AddAttribute(10, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(11, "Progress", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.UploadProgressArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.UploadProgressArgs>(this, 
#nullable restore
#line 8 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                 args => OnProgress(args, "Single file upload")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<h3 style=\"margin-top: 1rem\">Custom HTTP headers</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenUpload>(14);
                __builder2.AddAttribute(15, "Url", "upload/single");
                __builder2.AddAttribute(16, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(17, "Progress", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.UploadProgressArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.UploadProgressArgs>(this, 
#nullable restore
#line 12 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                 args => OnProgress(args, "Single file upload")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenUploadHeader>(19);
                    __builder3.AddAttribute(20, "Name", "Authorization");
                    __builder3.AddAttribute(21, "Value", "Bearer <token>");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenUploadHeader>(23);
                    __builder3.AddAttribute(24, "Name", "X-Uploaded-By");
                    __builder3.AddAttribute(25, "Value", "Radzen");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddMarkupContent(27, "<h3 style=\"margin-top: 1rem\">Multiple files upload</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenUpload>(28);
                __builder2.AddAttribute(29, "Multiple", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Url", "upload/multiple");
                __builder2.AddAttribute(31, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(32, "Progress", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.UploadProgressArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.UploadProgressArgs>(this, 
#nullable restore
#line 18 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                 args => OnProgress(args, "Multiple files upload")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.AddMarkupContent(34, "<h3 style=\"margin-top: 1rem\">Upload images only</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenUpload>(35);
                __builder2.AddAttribute(36, "Multiple", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Accept", "image/*");
                __builder2.AddAttribute(38, "Url", "upload/multiple");
                __builder2.AddAttribute(39, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(40, "Progress", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.UploadProgressArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.UploadProgressArgs>(this, 
#nullable restore
#line 21 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                 args => OnProgress(args, "Images only upload")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.AddMarkupContent(42, "<h3 style=\"margin-top: 1rem\">Upload with additional parameter</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenUpload>(43);
                __builder2.AddAttribute(44, "Multiple", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "Accept", "image/*");
                __builder2.AddAttribute(46, "Url", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                                             $"upload/{customParameter}"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(48, "Progress", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.UploadProgressArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.UploadProgressArgs>(this, 
#nullable restore
#line 24 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                 args => OnProgress(args, "Upload with additional parameter")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.AddMarkupContent(50, "<h3 style=\"margin-top: 1rem\">Manual Upload</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenUpload>(51);
                __builder2.AddAttribute(52, "Auto", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                          false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "Multiple", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "Url", "upload/multiple");
                __builder2.AddAttribute(55, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(56, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.UploadChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.UploadChangeEventArgs>(this, 
#nullable restore
#line 26 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                                                                                                             args => OnChange(args, "Manual Upload")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(57, "Progress", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.UploadProgressArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.UploadProgressArgs>(this, 
#nullable restore
#line 27 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                 args => OnProgress(args, "Manual Upload")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(58, (__value) => {
#nullable restore
#line 26 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                            upload = (Radzen.Blazor.RadzenUpload)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(60);
                __builder2.AddAttribute(61, "Text", "Upload");
                __builder2.AddAttribute(62, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                            args => upload.Upload()

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(63, "Style", "margin-bottom: 20px;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.AddMarkupContent(65, "<h3 style=\"margin-top: 1rem\">Upload completed</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenUpload>(66);
                __builder2.AddAttribute(67, "Url", "upload/single");
                __builder2.AddAttribute(68, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(69, "Complete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.UploadCompleteEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.UploadCompleteEventArgs>(this, 
#nullable restore
#line 31 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
                                OnComplete

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n        <br>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(74);
                __builder2.AddComponentReferenceCapture(75, (__value) => {
#nullable restore
#line 35 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\UploadPage.razor"
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
