#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "107dcabcd1933b776e7f5133ca6f0f969cab36d7"
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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class RadzenBadge : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.OpenElement(0, "span");
            __builder.AddAttribute(1, "style", 
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
                              Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(2, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
                                                  Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "class", 
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
                                                                      GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(4, "id", 
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
                                                                                          GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(5, (__value) => {
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
             Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(6, "\r\n");
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
     if (ChildContent != null)
    {
        

#line default
#line hidden
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
__builder.AddContent(7, ChildContent);

#line default
#line hidden
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
                     
    }
    else
    {
        

#line default
#line hidden
#line 11 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
__builder.AddContent(8, Text);

#line default
#line hidden
#line 11 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
             
    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#line 14 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenBadge.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
