#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71008dce07c97b9847bdf189a2bd9ed0ebdec922"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenBlazorDemos.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 7 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700\">\n<link href=\"_content/Radzen.Blazor/css/custom1.css\" rel=\"stylesheet\">\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(9);
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row justify-content-start align-items-center");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-5 d-flex align-items-center");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(15);
                __builder2.AddAttribute(16, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 22 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                              args => { sidebarExpanded = !sidebarExpanded; bodyExpanded = !bodyExpanded; }

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(18);
                __builder2.AddAttribute(19, "Text", "Radzen Blazor Components");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-7 d-flex align-items-center justify-content-end");
                __builder2.AddMarkupContent(23, @"<div class=""d-none d-md-inline-flex align-items-center""><a href=""/docs/"" title=""Radzen Blazor Components Documentation"" class=""mx-2 mx-lg-3"" target=""_blank"">Documentation</a>
                    <a href=""https://www.radzen.com/"" title=""Create .NET Core web applications fast & easy"" class=""text-nowrap mx-2 mx-lg-3"" target=""_blank"">About Radzen</a></div>
                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(24);
                __builder2.AddAttribute(25, "class", "mx-0 mx-lg-3");
                __builder2.AddAttribute(26, "TextProperty", "Text");
                __builder2.AddAttribute(27, "ValueProperty", "Value");
                __builder2.AddAttribute(28, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 32 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                                                                                      themes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 32 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                                                                                                      ThemeState.CurrentTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 32 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                                                                                                                                        ChangeTheme

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\n                ");
                __builder2.AddMarkupContent(32, @"<a href=""https://github.com/radzenhq/radzen-blazor"" title=""GitHub"" target=""_blank"" class=""mx-3""><svg width=""24"" height=""24"" viewBox=""0 0 512 499.36"" xmlns=""http://www.w3.org/2000/svg""><title>GitHub</title>
                        <path fill=""black"" fill-rule=""evenodd"" d=""M256 0C114.64 0 0 114.61 0 256c0 113.09 73.34 209 175.08 242.9 12.8 2.35 17.47-5.56 17.47-12.34 0-6.08-.22-22.18-.35-43.54-71.2 15.49-86.2-34.34-86.2-34.34-11.64-29.57-28.42-37.45-28.42-37.45-23.27-15.84 1.73-15.55 1.73-15.55 25.69 1.81 39.21 26.38 39.21 26.38 22.84 39.12 59.92 27.82 74.5 21.27 2.33-16.54 8.94-27.82 16.25-34.22-56.84-6.43-116.6-28.43-116.6-126.49 0-27.95 10-50.8 26.35-68.69-2.63-6.48-11.42-32.5 2.51-67.75 0 0 21.49-6.88 70.4 26.24a242.65 242.65 0 0 1 128.18 0c48.87-33.13 70.33-26.24 70.33-26.24 14 35.25 5.18 61.27 2.55 67.75 16.41 17.9 26.31 40.75 26.31 68.69 0 98.35-59.85 120-116.88 126.32 9.19 7.9 17.38 23.53 17.38 47.41 0 34.22-.31 61.83-.31 70.23 0 6.85 4.61 14.81 17.6 12.31C438.72 464.97 512 369.08 512 256.02 512 114.62 397.37 0 256 0z""></path></svg></a>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\n");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "style", "width:100%");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(36);
            __builder.AddAttribute(37, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                               bodyExpanded

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "ExpandedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => bodyExpanded = __value, bodyExpanded))));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(40);
                __builder2.AddAttribute(41, "Name", "main");
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "container-fluid");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "row");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col-12 pt-4 pb-5 px-3 px-lg-5");
                    __builder3.AddContent(49, 
#nullable restore
#line 50 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                             Body

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(50, "\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(51);
                    __builder3.AddAttribute(52, "class", "mt-5 content-footer");
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(54, "div");
                        __builder4.AddAttribute(55, "class", "row align-items-center");
                        __builder4.AddMarkupContent(56, @"<div class=""col-12 col-lg-7 px-5 py-3 text-center text-lg-left""><h2 class=""mb-3"">Boost your Blazor development with Radzen</h2>
                                        <p class=""mb-2"">Radzen is a desktop tool that gives you the power to create line of business applications. Build and launch Blazor apps visually, while we generate clean code for you.</p></div>
                                    ");
                        __builder4.OpenElement(57, "div");
                        __builder4.AddAttribute(58, "class", "col-12 col-lg-5 px-5 text-center text-lg-right");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(59);
                        __builder4.AddAttribute(60, "class", "cta-button primary ml-0 my-2");
                        __builder4.AddAttribute(61, "href", "https://www.radzen.com/download/");
                        __builder4.AddAttribute(62, "target", "_blank");
                        __builder4.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(64, "Download Radzen");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(65, "\n                                        ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(66);
                        __builder4.AddAttribute(67, "class", "cta-button my-2");
                        __builder4.AddAttribute(68, "href", "https://www.radzen.com/features/");
                        __builder4.AddAttribute(69, "target", "_blank");
                        __builder4.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(71, "Learn More");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n                            ");
                    __builder3.OpenElement(73, "p");
                    __builder3.AddAttribute(74, "class", "mt-5 md-3 text-center");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(75);
                    __builder3.AddAttribute(76, "Text", "Radzen Blazor Components, © 2021 Radzen.");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n                                ");
                    __builder3.AddMarkupContent(78, "<a href=\"https://github.com/radzenhq/radzen-blazor\" target=\"_blank\">Source Code</a> licensed under\n                                ");
                    __builder3.AddMarkupContent(79, "<a href=\"https://github.com/radzenhq/radzen-blazor/blob/master/LICENSE\" target=\"_blank\">MIT</a>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\n                            ");
                    __builder3.OpenElement(81, "p");
                    __builder3.AddAttribute(82, "class", "text-center");
                    __builder3.OpenComponent<RadzenBlazorDemos.Shared.Social>(83);
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(84, (__value) => {
#nullable restore
#line 44 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                       body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(86);
            __builder.AddAttribute(87, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 78 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                 sidebarExpanded

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "ExpandedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sidebarExpanded = __value, sidebarExpanded))));
            __builder.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "style", "padding: 1rem");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(92);
                __builder2.AddAttribute(93, "Placeholder", "Find component ...");
                __builder2.AddAttribute(94, "type", "search");
                __builder2.AddAttribute(95, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 81 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                                                     FilterPanelMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "style", "width: 100%");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(98);
                __builder2.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 84 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
             foreach (var category in examples)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(100);
                    __builder3.AddAttribute(101, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 86 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                                category.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 86 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                                                      category.Path

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(103, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 86 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                                                                            category.Icon

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 86 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                      category.Expanded

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(105, "ExpandedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category.Expanded = __value, category.Expanded))));
                    __builder3.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 87 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
     if (category.Children != null)
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
 foreach (var example in category.Children)
{
    if (example.Children != null)
    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(107);
                        __builder4.AddAttribute(108, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 93 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                            example.Name

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(109, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 93 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                                                    example.Icon

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(110, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 93 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                           example.Expanded

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(111, "ExpandedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => example.Expanded = __value, example.Expanded))));
                        __builder4.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 94 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
     foreach (var child in example.Children)
    {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(113);
                            __builder5.AddAttribute(114, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 96 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                            child.Name

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(115, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 96 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                               child.Path

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 96 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                             }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 97 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                       }
else
{

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(116);
                        __builder4.AddAttribute(117, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 100 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                            example.Name

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(118, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 100 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                 example.Path

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(119, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 100 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                                      example.Icon

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 100 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                                                                                      }
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
 }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 102 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                      }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(120, (__value) => {
#nullable restore
#line 78 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
                      sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "D:\c#\radzen-blazor\RadzenBlazorDemos\Shared\MainLayout.razor"
        RadzenSidebar sidebar0;
    RadzenBody body0;
    bool sidebarExpanded = true;
    bool bodyExpanded = false;

    dynamic themes = new[]
    {
        new { Text = "Default Theme", Value = "default"},
        new { Text = "Dark Theme", Value="dark" },
        new { Text = "Software Theme", Value = "software"},
        new { Text = "Humanistic Theme", Value = "humanistic" },
        new { Text = "Standard Theme", Value = "standard" }
    };

    IEnumerable<Example> examples;

    string Theme
    {
        get
        {
            return $"{ThemeState.CurrentTheme}.css";
        }
    }

    protected override void OnInitialized()
    {
        if (httpContextAccessor != null && httpContextAccessor.HttpContext != null &&
             httpContextAccessor.HttpContext.Request != null && httpContextAccessor.HttpContext.Request.Headers.ContainsKey("User-Agent"))
        {
            var userAgent = httpContextAccessor.HttpContext.Request.Headers["User-Agent"].FirstOrDefault();
            if (!string.IsNullOrEmpty(userAgent))
            {
                if (userAgent.Contains("iPhone") || userAgent.Contains("Android") || userAgent.Contains("Googlebot"))
                {
                    sidebarExpanded = false;
                    bodyExpanded = true;
                }
            }
        }

        examples = ExampleService.Examples;

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
        {
            var example = ExampleService.FindCurrent(UriHelper.ToAbsoluteUri(UriHelper.Uri));

            await JSRuntime.InvokeVoidAsync("setTitle", ExampleService.TitleFor(example));
        }
    }

    void FilterPanelMenu(ChangeEventArgs args)
    {
        var term = args.Value.ToString();

        examples = ExampleService.Filter(term);
    }

    void ChangeTheme(object value)
    {
        ThemeState.CurrentTheme = value.ToString();
        UriHelper.NavigateTo(UriHelper.ToAbsoluteUri(UriHelper.Uri).ToString());
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExampleService ExampleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ThemeState ThemeState { get; set; }
    }
}
#pragma warning restore 1591
