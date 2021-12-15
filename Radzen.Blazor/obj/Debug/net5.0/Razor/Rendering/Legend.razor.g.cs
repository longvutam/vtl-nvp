#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "369d18a0ced679a52b658eea478058417b588220"
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
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor"
using Radzen.Blazor;

#line default
#line hidden
    public partial class Legend : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor"
 if (Chart.Legend.Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor"
                 Class

#line default
#line hidden
            );
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "rz-legend-items");
            __builder.AddMarkupContent(6, "\r\n");
#line 6 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor"
         foreach (var series in Chart.Series)
        {
            

#line default
#line hidden
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor"
             if (series.ShowInLegend)
            {
                

#line default
#line hidden
            __builder.AddContent(7, 
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor"
                 series.RenderLegendItem()

#line default
#line hidden
            );
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor"
                                          
            }

#line default
#line hidden
#line 11 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(8, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#line 15 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 16 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\Rendering\Legend.razor"
       
    [CascadingParameter]
    public RadzenChart Chart { get; set; }

    string Class
    {
        get
        {
            var classList = new List<string>();

            classList.Add("rz-legend");
            classList.Add($"rz-legend-{Chart.Legend.Position}".ToLower());

            return String.Join(" ", classList);
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
