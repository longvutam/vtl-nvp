// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class RadzenGridRow : Microsoft.AspNetCore.Components.ComponentBase, IRadzenForm
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenGridRow.razor"
       
    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object> Attributes { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string CssClass { get; set; }

    [Parameter]
    public bool InEditMode { get; set; }

    List<IRadzenFormComponent> components;

    public void AddComponent(IRadzenFormComponent component)
    {
        if (components != null)
        {
            if (components.IndexOf(component) == -1)
            {
                components.Add(component);
            }
        }
    }
    public void RemoveComponent(IRadzenFormComponent component)
    {
        components?.Remove(component);
    }

    public override Task SetParametersAsync(ParameterView parameters)
    {
        if (InEditMode != parameters.GetValueOrDefault<bool>("InEditMode"))
        {
            components = new List<IRadzenFormComponent>();
        }

        return base.SetParametersAsync(parameters);
    }

    public IRadzenFormComponent FindComponent(string name)
    {
        return components.Where(component => component.Name == name).FirstOrDefault();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
