#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenSidebarToggle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dc059b4e2ee22b4219d72796ac0170b998a3373"
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
    public partial class RadzenSidebarToggle : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenSidebarToggle.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "style", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenSidebarToggle.razor"
                                    Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenSidebarToggle.razor"
                                                        Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenSidebarToggle.razor"
                                                                            GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenSidebarToggle.razor"
                                                                                                      OnClick

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "id", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenSidebarToggle.razor"
                                                                                                                    GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(7, (__value) => {
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenSidebarToggle.razor"
                   Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<i class=\"rzi d-flex align-items-center\">menu</i>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenSidebarToggle.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
