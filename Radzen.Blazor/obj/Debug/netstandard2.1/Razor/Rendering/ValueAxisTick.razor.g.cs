#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bcead548c85c063b26e9e8962fd0338df95cc8b"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor.Rendering
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
    public partial class ValueAxisTick : Tick
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "g");
            __builder.AddAttribute(1, "class", "rz-tick");
            __builder.AddMarkupContent(2, "\n");
            __builder.OpenComponent<Radzen.Blazor.Rendering.Line>(3);
            __builder.AddAttribute(4, "Class", "rz-tick-line");
            __builder.AddAttribute(5, "Stroke", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
                                    Stroke

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
                                                          StrokeWidth

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "LineType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.LineType>(
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
                                                                                  LineType

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "X1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
                                                                                                 X

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "Y1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
                                                                                                         Y

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "X2", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
                                                                                                                  X-6

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "Y2", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
                                                                                                                             Y

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n");
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
 if (ChildContent == null)
{

#line default
#line hidden
            __builder.AddContent(13, "  ");
            __builder.OpenElement(14, "g");
            __builder.AddMarkupContent(15, "\n    ");
            __builder.OpenElement(16, "text");
            __builder.AddAttribute(17, "class", "rz-tick-text");
            __builder.AddAttribute(18, "x", 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
                                    (X-9).ToInvariantString()

#line default
#line hidden
            );
            __builder.AddAttribute(19, "dy", ".3em");
            __builder.AddAttribute(20, "y", 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
                                                                              Y.ToInvariantString()

#line default
#line hidden
            );
            __builder.AddContent(21, 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
                                                                                                      Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
}
else
{
  

#line default
#line hidden
            __builder.AddContent(24, 
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
   ChildContent

#line default
#line hidden
            );
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\ValueAxisTick.razor"
               
}

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
