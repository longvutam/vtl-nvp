#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d6b5ef2b8425f38ea69aaf485afec01b1e1b051"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
using Radzen.Blazor;

#line default
#line hidden
    public partial class Marker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "g");
            __builder.AddAttribute(1, "class", "rz-marker");
            __builder.AddMarkupContent(2, "\n");
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
 switch(Type)
{
    case MarkerType.Circle:

#line default
#line hidden
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "circle");
            __builder.AddAttribute(5, "cx", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                     X.ToInvariantString()

#line default
#line hidden
            );
            __builder.AddAttribute(6, "cy", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                 Y.ToInvariantString()

#line default
#line hidden
            );
            __builder.AddAttribute(7, "r", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                            Size.ToInvariantString()

#line default
#line hidden
            );
            __builder.AddAttribute(8, "fill", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                             Fill

#line default
#line hidden
            );
            __builder.AddAttribute(9, "stroke", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                            Stroke

#line default
#line hidden
            );
            __builder.AddAttribute(10, "stroke-width", 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                   StrokeWidth.ToInvariantString()

#line default
#line hidden
            );
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 7 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                               Click

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n");
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
    break;

    case MarkerType.Square:

#line default
#line hidden
            __builder.AddContent(13, "        ");
            __builder.OpenElement(14, "path");
            __builder.AddAttribute(15, "d", 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                   $"M {(X-Size).ToInvariantString()} {(Y-Size).ToInvariantString()} L {(X+Size).ToInvariantString()} {(Y-Size).ToInvariantString()} L {(X+Size).ToInvariantString()} {(Y+Size).ToInvariantString()} L {(X-Size).ToInvariantString()} {(Y + Size).ToInvariantString()} Z"

#line default
#line hidden
            );
            __builder.AddAttribute(16, "stroke", 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                                                                                     Stroke

#line default
#line hidden
            );
            __builder.AddAttribute(17, "fill", 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                                                                                                    Fill

#line default
#line hidden
            );
            __builder.AddAttribute(18, "stroke-width", 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                                                                                                                         StrokeWidth.ToInvariantString()

#line default
#line hidden
            );
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                                                                                                                                                                     Click

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
    break;

    case MarkerType.Triangle:

#line default
#line hidden
            __builder.AddContent(21, "        ");
            __builder.OpenElement(22, "path");
            __builder.AddAttribute(23, "d", 
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                   $"M {(X-Size).ToInvariantString()} {(Y+Size).ToInvariantString()} L {X.ToInvariantString()} {(Y-Size).ToInvariantString()} L {(X+Size).ToInvariantString()} {(Y+Size).ToInvariantString()} Z"

#line default
#line hidden
            );
            __builder.AddAttribute(24, "stroke", 
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                            Stroke

#line default
#line hidden
            );
            __builder.AddAttribute(25, "fill", 
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                           Fill

#line default
#line hidden
            );
            __builder.AddAttribute(26, "stroke-width", 
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                                                StrokeWidth.ToInvariantString()

#line default
#line hidden
            );
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                                                                                            Click

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
#line 16 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
    break;

    case MarkerType.Diamond:

#line default
#line hidden
            __builder.AddContent(29, "        ");
            __builder.OpenElement(30, "path");
            __builder.AddAttribute(31, "d", 
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                   $"M {(X-Size).ToInvariantString()} {Y.ToInvariantString()} L {X.ToInvariantString()} {(Y-Size).ToInvariantString()} L {(X+Size).ToInvariantString()} {Y.ToInvariantString()} L {X.ToInvariantString()} {(Y + Size).ToInvariantString()} Z"

#line default
#line hidden
            );
            __builder.AddAttribute(32, "stroke", 
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                                                         Stroke

#line default
#line hidden
            );
            __builder.AddAttribute(33, "fill", 
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                                                                        Fill

#line default
#line hidden
            );
            __builder.AddAttribute(34, "stroke-width", 
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                                                                                             StrokeWidth.ToInvariantString()

#line default
#line hidden
            );
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
                                                                                                                                                                                                                                                                                                                                                         Click

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n");
#line 20 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
    break;
}

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\Rendering\Marker.razor"
       
    [Parameter]
    public double X { get; set; }

    [Parameter]
    public MarkerType Type { get; set; }

    [Parameter]
    public double Y { get; set; }

    [Parameter]
    public string Stroke { get; set; }

    [Parameter]
    public double StrokeWidth { get; set; }

    [Parameter]
    public string Fill { get; set; }

    [Parameter]
    public double Size { get; set; }

    [Parameter]
    public EventCallback Click { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591