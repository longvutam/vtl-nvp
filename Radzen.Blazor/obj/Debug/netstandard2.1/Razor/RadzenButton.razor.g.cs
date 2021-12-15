#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "525f219fbadf7a4582052d1af75f201e589f3b89"
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
    public partial class RadzenButton : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "style", 
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                                    Style

#line default
#line hidden
            );
            __builder.AddAttribute(3, "disabled", 
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                                                      IsDisabled

#line default
#line hidden
            );
            __builder.AddAttribute(4, "type", 
#line 6 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                   Enum.GetName(typeof(ButtonType), ButtonType).ToLower()

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(5, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                         Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "class", 
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                                             GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(7, "id", 
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                                                                 GetId()

#line default
#line hidden
            );
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 8 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                       OnClick

#line default
#line hidden
            ));
            __builder.AddElementReferenceCapture(9, (__value) => {
#line 5 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                   Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(10, "\r\n");
#line 9 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
         if (ChildContent != null)
        {
            

#line default
#line hidden
#line 11 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
__builder.AddContent(11, ChildContent);

#line default
#line hidden
#line 11 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                         
        }
        else
        {
            

#line default
#line hidden
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
             if (IsBusy)
            {

#line default
#line hidden
            __builder.AddContent(12, "                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenIcon>(13);
            __builder.AddAttribute(14, "Icon", "refresh");
            __builder.AddAttribute(15, "Style", "animation: rotation 700ms linear infinite");
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
#line 18 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                 if (!string.IsNullOrEmpty(BusyText))
                {

#line default
#line hidden
            __builder.AddContent(17, "                    ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "rz-button-text");
#line 20 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
__builder.AddContent(20, BusyText);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#line 21 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                }

#line default
#line hidden
#line 21 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                 
            }
            else
            {
                

#line default
#line hidden
#line 25 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                 if (!string.IsNullOrEmpty(@Icon))
                {

#line default
#line hidden
            __builder.AddContent(22, "                    ");
            __builder.OpenElement(23, "i");
            __builder.AddAttribute(24, "class", "rz-button-icon-left rzi");
#line 27 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
__builder.AddContent(25, (MarkupString)Icon);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#line 28 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                }

#line default
#line hidden
#line 29 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                 if (!string.IsNullOrEmpty(Image))
                {

#line default
#line hidden
            __builder.AddContent(27, "                    ");
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "class", "rz-button-icon-left rzi");
            __builder.AddAttribute(30, "src", 
#line 31 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                                                               Image

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#line 32 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                }

#line default
#line hidden
#line 33 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                 if (!string.IsNullOrEmpty(Text))
                {

#line default
#line hidden
            __builder.AddContent(32, "                    ");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "class", "rz-button-text");
#line 35 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
__builder.AddContent(35, Text);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#line 36 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                }

#line default
#line hidden
#line 36 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
                 
            }

#line default
#line hidden
#line 37 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(37, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#line 40 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenButton.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
