#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenGravatar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cd9616347832ecd81b8a8c576cbe340fcb584d8"
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
    public partial class RadzenGravatar : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenGravatar.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "img");
            __builder.AddAttribute(2, "style", 
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenGravatar.razor"
                                 Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenGravatar.razor"
                                                     Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenGravatar.razor"
                                                                         GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "src", 
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenGravatar.razor"
                                                                                              Url

#line default
#line hidden
            );
            __builder.AddAttribute(6, "id", 
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenGravatar.razor"
                                                                                                        GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(7, (__value) => {
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenGravatar.razor"
                Element = __value;

#line default
#line hidden
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenGravatar.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
