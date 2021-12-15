#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3177ea3c74d16f4dc5bc3b5d4b8304287897883"
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
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
    public partial class RadzenDataGridGroupRow<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\n");
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
     for(var i = 0; i < GetLevel(); i++)
    {

#line default
#line hidden
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<td class=\"rz-col-icon\">\n            <span class=\"rz-column-title\"></span>\n        </td>\n");
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
    }

#line default
#line hidden
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "td");
            __builder.AddAttribute(6, "class", "rz-col-icon");
            __builder.AddMarkupContent(7, "\n        <span class=\"rz-column-title\"></span>\n        ");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "href", "javascript:void(0)");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
                                                 _ => Grid.ExpandGroupItem(this)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(11, "\n            ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", 
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
                           Grid.ExpandedGroupItemStyle(this)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n    ");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "colspan", 
#line 16 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
                   Columns.Count + Grid.groups.Count - 1 - Group.Level

#line default
#line hidden
            );
            __builder.AddMarkupContent(19, "\n        ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "rz-cell-data");
            __builder.AddMarkupContent(22, "\n");
#line 18 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
             if (Grid.GroupHeaderTemplate != null)
            {
                

#line default
#line hidden
            __builder.AddContent(23, 
#line 20 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
                 Grid.GroupHeaderTemplate(Group)

#line default
#line hidden
            );
#line 20 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
                                                
            }
            else
            {
                

#line default
#line hidden
            __builder.AddContent(24, 
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
                  Group.GroupDescriptor.GetTitle() + ": " + Group.Data.Key

#line default
#line hidden
            );
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
                                                                           
            }

#line default
#line hidden
            __builder.AddContent(25, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
#line 29 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
 if(Grid != null)
{
    if (Grid.IsGroupItemExpanded(this))
    {
        

#line default
#line hidden
            __builder.AddContent(29, 
#line 33 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
         DrawDataRows()

#line default
#line hidden
            );
#line 33 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
                       
    }
    else if(Grid.GroupFootersAlwaysVisible)
    {
        

#line default
#line hidden
            __builder.AddContent(30, 
#line 37 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
         DrawDataRows(true)

#line default
#line hidden
            );
#line 37 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
                           
    }
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 40 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridGroupRow.razor"
       
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

                    var level = GetLevel();
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

        RenderFragment DrawDataRows(bool groupFootersOnly = false)
        {
            return new RenderFragment(builder =>
            {
                if(GroupResult.Subgroups != null)
                {
                    foreach(var g in GroupResult.Subgroups)
                    {
                        builder.OpenComponent(0, typeof(RadzenDataGridGroupRow<TItem>));
                        builder.AddAttribute(1, "Columns", Columns);
                        builder.AddAttribute(3, "Grid", Grid);
                        builder.AddAttribute(3, "Parent", this);
                        builder.AddAttribute(5, "GroupResult", g);
                        builder.AddAttribute(6, "Builder", builder);
                        builder.CloseComponent();
                    }
                }
                else
                {
                    if(!groupFootersOnly)
                    {
                        int i = 0;
                        foreach(var item in GroupResult.Items)
                        {
                            builder.OpenComponent(0, typeof(RadzenDataGridRow<TItem>));
                            builder.AddAttribute(1, "Columns", Columns);
                            builder.AddAttribute(2, "Index", i);
                            builder.AddAttribute(3, "Grid", Grid);
                            builder.AddAttribute(4, "TItem", typeof(TItem));
                            builder.AddAttribute(5, "Item", item);
                            builder.AddAttribute(6, "InEditMode", Grid.IsRowInEditMode((TItem)item));
                            builder.CloseComponent();
                            i++;
                        }
                    }

                    if (Columns.Where(c => c.GroupFooterTemplate != null).Any())
                    {
                        builder.OpenComponent(7, typeof(RadzenDataGridGroupFooterRow<TItem>));
                        builder.AddAttribute(8, "Columns", Columns);
                        builder.AddAttribute(9, "Grid", Grid);
                        builder.AddAttribute(10, "GroupResult", GroupResult);
                        builder.AddAttribute(11, "Builder", builder);
                        builder.AddAttribute(12, "Parent", this);
                        builder.CloseComponent();
                    }
                }
            });
        }

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