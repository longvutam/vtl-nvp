#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a3ecb62c3218c772aefd2a3716a0cd116c6e49f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Examples), @"mvc.1.0.razor-page", @"/Pages/Examples.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/examples.xml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a3ecb62c3218c772aefd2a3716a0cd116c6e49f", @"/Pages/Examples.cshtml")]
    public class Pages_Examples : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
  
    Layout = null;
    Response.ContentType = "text/xml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<urlset xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\" xsi:schemaLocation=\"http://www.sitemaps.org/schemas/sitemap/0.9 http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd\">\r\n");
#nullable restore
#line 8 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
 foreach (var category in ExampleService.Examples)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
     if (category.Path != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <url>\r\n        <loc>");
#nullable restore
#line 13 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
        Write(Location(category.Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("</loc>\r\n        <lastmod>");
#nullable restore
#line 14 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
            Write(lastmod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</lastmod>\r\n        <priority>1</priority>\r\n    </url>\r\n");
#nullable restore
#line 17 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
     if (category.Children != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
         foreach (var example in category.Children)
        {
            if (example.Children != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
                 foreach (var child in example.Children)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <url>\r\n        <loc>");
#nullable restore
#line 27 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
        Write(Location(child.Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("</loc>\r\n        <lastmod>");
#nullable restore
#line 28 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
            Write(lastmod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</lastmod>\r\n        <priority>1</priority>\r\n    </url>\r\n");
#nullable restore
#line 31 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <url>\r\n        <loc>");
#nullable restore
#line 36 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
        Write(Location(example.Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("</loc>\r\n        <lastmod>");
#nullable restore
#line 37 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
            Write(lastmod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</lastmod>\r\n        <priority>1</priority>\r\n    </url>\r\n");
#nullable restore
#line 40 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</urlset>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\owlsn\Source\Repos\vtl-nvp\RadzenBlazorDemos\Pages\Examples.cshtml"
            
    string lastmod = DateTime.Today.ToString("yyyy-MM-dd");

    string Location(string path)
    {
        if (!path.StartsWith("/"))
        {
            path = $"/{path}";
        }

        return $"https://blazor.radzen.com{path}";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RadzenBlazorDemos.ExampleService ExampleService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Examples> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Examples> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Examples>)PageContext?.ViewData;
        public Pages_Examples Model => ViewData.Model;
    }
}
#pragma warning restore 1591
