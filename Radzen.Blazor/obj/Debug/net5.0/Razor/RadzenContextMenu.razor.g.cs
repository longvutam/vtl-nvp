#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9817846b38b2202633b7053e1454ea5022570032"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class RadzenContextMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
 foreach (var menu in menus)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
              UniqueID

#line default
#line hidden
            );
            __builder.AddAttribute(3, "class", "rz-tooltip");
            __builder.AddAttribute(4, "style", "display: none; top: 0px; left: 0px; z-index: 1001; position: absolute;");
            __builder.AddMarkupContent(5, "\r\n");
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
         if (menu.Options.ChildContent != null)
        {

#line default
#line hidden
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "rz-context-menu");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddContent(10, 
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
                 menu.Options.ChildContent(Service)

#line default
#line hidden
            );
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#line 13 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
        }
        else if (menu.Options.Items != null && menu.Options.Items.Any())
        {

#line default
#line hidden
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "rz-context-menu");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenMenu>(17);
            __builder.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.MenuItemEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.MenuItemEventArgs>(this, 
#line 17 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
                                     args => { if (menu.Options.Click != null) { menu.Options.Click(args); } }

#line default
#line hidden
            )));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n");
#line 18 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
                     foreach (var item in menu.Options.Items)
                    {

#line default
#line hidden
                __builder2.AddContent(21, "                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenMenuItem>(22);
                __builder2.AddAttribute(23, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
                                               item.Text

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
                                                                  item.Value

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n");
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
                    }

#line default
#line hidden
                __builder2.AddContent(26, "                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#line 24 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
        }

#line default
#line hidden
            __builder.AddContent(29, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#line 26 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenContextMenu.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
