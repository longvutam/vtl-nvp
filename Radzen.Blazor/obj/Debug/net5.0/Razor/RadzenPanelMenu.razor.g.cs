#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenPanelMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e856f726ae74a793fdaf56bd5d7fc70403574a81"
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
    public partial class RadzenPanelMenu : RadzenComponentWithChildren
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenPanelMenu.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "style", 
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenPanelMenu.razor"
                                Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenPanelMenu.razor"
                                                    Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenPanelMenu.razor"
                                                                        GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenPanelMenu.razor"
                                                                                            GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenPanelMenu.razor"
               Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\r\n        ");
            __Blazor.Radzen.Blazor.RadzenPanelMenu.TypeInference.CreateCascadingValue_0(__builder, 8, 9, 
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenPanelMenu.razor"
                              this

#line default
#line hidden
            , 10, (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
#line 8 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenPanelMenu.razor"
__builder2.AddContent(12, ChildContent);

#line default
#line hidden
                __builder2.AddMarkupContent(13, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#line 11 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenPanelMenu.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
namespace __Blazor.Radzen.Blazor.RadzenPanelMenu
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
