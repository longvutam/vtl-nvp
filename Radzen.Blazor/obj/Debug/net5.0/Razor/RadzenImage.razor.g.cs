#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenImage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874b76ba86752588cd0684864a977b10e0f68a5b"
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
    public partial class RadzenImage : RadzenComponentWithChildren
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenImage.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "img");
            __builder.AddAttribute(2, "src", 
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenImage.razor"
                               Path

#line default
#line hidden
            );
            __builder.AddAttribute(3, "style", 
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenImage.razor"
                                             Style

#line default
#line hidden
            );
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenImage.razor"
                                                                (args) => OnClick(args)

#line default
#line hidden
            ));
            __builder.AddMultipleAttributes(5, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenImage.razor"
                                                                                                       Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "class", 
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenImage.razor"
                                                                                                                           GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(7, "id", 
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenImage.razor"
                                                                                                                                               GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(8, (__value) => {
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenImage.razor"
                Element = __value;

#line default
#line hidden
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenImage.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
