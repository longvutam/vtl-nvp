#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa49bfd91adaca3867d8affd1c9d5f389e6a3fd"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
using Radzen;

#line default
#line hidden
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenProgressBar : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", 
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
                                 Style

#line default
#line hidden
            );
            __builder.AddAttribute(3, "aria-valuemax", 
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
                                                        Max

#line default
#line hidden
            );
            __builder.AddAttribute(4, "aria-valuemin", "0");
            __builder.AddAttribute(5, "role", "progressbar");
            __builder.AddMultipleAttributes(6, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
                                                                                                               Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "class", 
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
                                                                                                                                   GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(8, "aria-valuenow", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
                         Value

#line default
#line hidden
            );
            __builder.AddAttribute(9, "id", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
                                     GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(10, (__value) => {
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
                Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(11, "\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "rz-progressbar-value rz-progressbar-value-animate");
            __builder.AddAttribute(14, "style", 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
                                                                                $"width: {Math.Min(Value / Max * 100, 100).ToInvariantString()}%;"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
         if (ShowValue)
        {

#line default
#line hidden
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "rz-progressbar-label");
            __builder.AddContent(19, 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
                                               Value

#line default
#line hidden
            );
            __builder.AddContent(20, 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
                                                     Unit

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
        }

#line default
#line hidden
            __builder.AddContent(22, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenProgressBar.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
