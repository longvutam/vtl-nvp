#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f38223f32eb5c103a46ae71a9a13c26c1bfeca9f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/textarea")]
    public partial class TextAreaPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "TextArea");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.AddMarkupContent(7, "<h3>TextArea</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextArea>(8);
                __builder2.AddAttribute(9, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 7 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                 args => OnChange(args, "TextArea")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<h3 style=\"margin-top: 2rem\">TextArea with placeholder</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextArea>(12);
                __builder2.AddAttribute(13, "Placeholder", "Enter here...");
                __builder2.AddAttribute(14, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                                             args => OnChange(args, "TextArea with placeholder")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.AddMarkupContent(16, "<h3 style=\"margin-top: 2rem\">TextArea with 5 maximum characters</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextArea>(17);
                __builder2.AddAttribute(18, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 11 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                   5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 11 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                               args => OnChange(args, "TextArea with 5 maximum characters")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.AddMarkupContent(21, "<h3 style=\"margin-top: 2rem\">TextArea with 3 rows and 30 columns</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextArea>(22);
                __builder2.AddAttribute(23, "Cols", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                                 30

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Rows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                                           3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                                                       args => OnChange(args, "TextArea with 3 rows and 30 columns")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                     value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value = __value, value))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => value));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.AddMarkupContent(30, "<h3 style=\"margin-top: 2rem\">Disabled TextArea with 3 rows and 30 columns</h3>\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextArea>(31);
                __builder2.AddAttribute(32, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Cols", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                                                 30

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Rows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                                                           3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
                                                     value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value = __value, value))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => value));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(41);
                __builder2.AddComponentReferenceCapture(42, (__value) => {
#nullable restore
#line 18 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
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
#line 23 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\TextAreaPage.razor"
       
    string value;

    EventConsole console;

    void OnChange(string value, string name)
    {
        console.Log($"{name} value changed to {value}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
