#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc3a86274d7d30553aa11cd4d23ed27f9e621ec"
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
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
    public partial class RadzenDataGridGroupFooterRow<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\n");
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
     for(var i = 0; i < GetLevel(); i++)
    {

#line default
#line hidden
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<td class=\"rz-col-icon\">\n            <span class=\"rz-column-title\"></span>\n        </td>\n");
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
    }

#line default
#line hidden
#line 10 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
     foreach (var column in Columns)
    {

#line default
#line hidden
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "td");
            __builder.AddAttribute(6, "class", 
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
                     $" {column.GroupFooterCssClass} {Grid.getFrozenColumnClass(column, Columns)}".Trim()

#line default
#line hidden
            );
            __builder.AddAttribute(7, "style", 
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
                                                                                                                    column.GetStyle(true, true)

#line default
#line hidden
            );
            __builder.AddMarkupContent(8, "\n            ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "rz-column-footer");
            __builder.AddMarkupContent(11, "\n");
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
                 if (column.GroupFooterTemplate != null)
                {
                    

#line default
#line hidden
            __builder.AddContent(12, 
#line 16 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
                     column.GroupFooterTemplate(Group)

#line default
#line hidden
            );
#line 16 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
                                                      
                }

#line default
#line hidden
            __builder.AddContent(13, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
#line 20 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 22 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
       
        [Parameter]
        public IList<RadzenDataGridColumn<TItem>> Columns { get; set; }

        GroupResult _groupResult;
        [Parameter]
        public GroupResult GroupResult 
        { 
            get
            {
                return _groupResult;
            }
            set
            {
                if(_groupResult != value)
                {
                    _groupResult = value;

                    var l = GetLevel();
                    var level = l > 0 ? l - 1 : l;

                    Group = new Group()
                    {
                        Level = level,
                        GroupDescriptor = Grid.groups[level],
                        Data = _groupResult
                    };
                }
            }
        }

        [Parameter]
        public RadzenDataGrid<TItem> Grid { get; set; }

        [Parameter]
        public RadzenDataGridGroupRow<TItem> Parent { get; set; }

        [Parameter]
        public Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder Builder { get; set; }

        public Group Group { get; set; }

        int GetLevel()
        {
            int i = 0;
            var p = Parent;
            while(p != null)
            {
                p = p.Parent;
                i++;
            }

            return i;
        }

#line default
#line hidden
    }
}
#pragma warning restore 1591
