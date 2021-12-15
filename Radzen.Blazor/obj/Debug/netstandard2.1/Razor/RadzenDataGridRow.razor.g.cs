#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de1aee829c4ecd2c2cf4b9d14e0a1bfb53f06ca0"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class RadzenDataGridRow<TItem> : Microsoft.AspNetCore.Components.ComponentBase, IRadzenForm
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
  var rowArgs = Grid?.RowAttributes(Item); 

#line default
#line hidden
            __builder.OpenElement(0, "tr");
            __builder.AddAttribute(1, "class", 
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
             Grid.RowStyle(Item, Index)

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(2, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 5 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                                        rowArgs.Item2

#line default
#line hidden
            ));
            __builder.AddMarkupContent(3, "\n");
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
     foreach(var g in Grid.groups)
    {

#line default
#line hidden
            __builder.AddContent(4, "        ");
            __builder.AddMarkupContent(5, "<td class=\"rz-col-icon\">\n            <span class=\"rz-column-title\"></span>\n        </td>\n");
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
    }

#line default
#line hidden
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
     if (Grid.Template != null && Grid.ShowExpandColumn)
    {

#line default
#line hidden
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "td");
            __builder.AddAttribute(8, "class", "rz-col-icon");
            __builder.AddMarkupContent(9, "\n            <span class=\"rz-column-title\"></span>\n");
#line 16 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
             if (rowArgs.Item1.Expandable)
            {

#line default
#line hidden
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", "javascript:void(0)");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 18 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                                         _ => Grid.ExpandItem(Item)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", 
#line 19 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                   Grid.ExpandedItemStyle(Item)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n");
#line 21 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
            }

#line default
#line hidden
            __builder.AddContent(19, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
#line 23 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
    }

#line default
#line hidden
            __builder.AddContent(21, "    ");
            __Blazor.Radzen.Blazor.RadzenDataGridRow.TypeInference.CreateCascadingValue_0(__builder, 22, 23, 
#line 24 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                           EditContext

#line default
#line hidden
            , 24, (__builder2) => {
                __builder2.AddMarkupContent(25, "\n    ");
                __Blazor.Radzen.Blazor.RadzenDataGridRow.TypeInference.CreateCascadingValue_1(__builder2, 26, 27, 
#line 25 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                          this

#line default
#line hidden
                , 28, (__builder3) => {
                    __builder3.AddMarkupContent(29, "\n");
#line 26 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
         for (var j = 0; j < Columns.Count; j++)
        {
            if (Grid.rowSpans.ContainsKey(j))
            {
                Grid.rowSpans[j] = Grid.rowSpans[j] - 1;

                if (Grid.rowSpans[j] <= 0)
                {
                    Grid.rowSpans.Remove(j);
                }
                else
                {
                    continue;
                }
            }

            var column = Columns[j];
            var cellAttr = Grid.CellAttributes(Item, column);

            object colspan;
            cellAttr.TryGetValue("colspan", out colspan);

            if (colspan != null)
            {
                j = j + (int)Convert.ChangeType(colspan, TypeCode.Int32) - 1;
            }

            object rowspan;
            cellAttr.TryGetValue("rowspan", out rowspan);

            if (rowspan != null)
            {
                Grid.rowSpans.Add(j, (int)Convert.ChangeType(rowspan, TypeCode.Int32));
            }


#line default
#line hidden
                    __builder3.AddContent(30, "            ");
                    __Blazor.Radzen.Blazor.RadzenDataGridRow.TypeInference.CreateRadzenDataGridCell_2(__builder3, 31, 32, 
#line 61 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                       this.Grid

#line default
#line hidden
                    , 33, 
#line 61 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                                         Item

#line default
#line hidden
                    , 34, 
#line 61 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                                                        column

#line default
#line hidden
                    , 35, 
#line 62 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                        column.GetStyle(true)

#line default
#line hidden
                    , 36, 
#line 62 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                                                           column.CssClass + " " + Grid.getFrozenColumnClass(column, Columns)

#line default
#line hidden
                    , 37, 
#line 62 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                                                                                                                                              cellAttr

#line default
#line hidden
                    , 38, (__builder4) => {
                        __builder4.AddMarkupContent(39, "\n                ");
                        __builder4.OpenElement(40, "span");
                        __builder4.AddAttribute(41, "class", "rz-cell-data");
                        __builder4.AddAttribute(42, "title", 
#line 63 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                                    column.Template == null ? column.GetValue(Item) : ""

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(43, "\n");
#line 64 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                     if (Item != null)
                    {
                        

#line default
#line hidden
#line 66 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                         if (Grid.IsRowInEditMode(Item) && column.EditTemplate != null)
                        {
                            

#line default
#line hidden
                        __builder4.AddContent(44, 
#line 68 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                             column.EditTemplate(Item)

#line default
#line hidden
                        );
#line 68 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                                      
                        } 
                        else if (column.Template != null)
                        {
                            

#line default
#line hidden
                        __builder4.AddContent(45, 
#line 72 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                             column.Template(Item)

#line default
#line hidden
                        );
#line 72 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                                  
                        }
                        else
                        {
                            

#line default
#line hidden
                        __builder4.AddContent(46, 
#line 76 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                             column.GetValue(Item)

#line default
#line hidden
                        );
#line 76 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                                                  
                        }

#line default
#line hidden
#line 77 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                         
                    }

#line default
#line hidden
                        __builder4.AddContent(47, "                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(48, "\n            ");
                    }
                    );
                    __builder3.AddMarkupContent(49, "\n");
#line 81 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
        }

#line default
#line hidden
                    __builder3.AddContent(50, "    ");
                }
                );
                __builder2.AddMarkupContent(51, "\n    ");
            }
            );
            __builder.AddMarkupContent(52, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n");
#line 85 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
 if (Grid.Template != null && Grid.expandedItems.Keys.Contains(Item))
{

#line default
#line hidden
            __builder.AddContent(54, "    ");
            __builder.OpenElement(55, "tr");
            __builder.AddAttribute(56, "class", "rz-expanded-row-content");
            __builder.AddMarkupContent(57, "\n        ");
            __builder.OpenElement(58, "td");
            __builder.AddAttribute(59, "colspan", 
#line 88 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                       Columns.Count + (Grid.ShowExpandColumn ? 1 : 0) + + Grid.groups.Count

#line default
#line hidden
            );
            __builder.AddMarkupContent(60, "\n            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "rz-expanded-row-template");
            __builder.AddAttribute(63, "style", "position:sticky");
            __builder.AddMarkupContent(64, "\n                ");
            __builder.AddContent(65, 
#line 90 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
                 Grid.Template(Item)

#line default
#line hidden
            );
            __builder.AddMarkupContent(66, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n");
#line 94 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 95 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenDataGridRow.razor"
       
        [Parameter]
        public IList<RadzenDataGridColumn<TItem>> Columns { get; set; }

        [Parameter]
        public TItem Item { get; set; }

        [Parameter]
        public int Index { get; set; }

        [Parameter]
        public RadzenDataGrid<TItem> Grid { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, object> Attributes { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string CssClass { get; set; }

        [Parameter]
        public bool InEditMode { get; set; }

        [Parameter]
        public EditContext EditContext { get; set; }

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
namespace __Blazor.Radzen.Blazor.RadzenDataGridRow
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
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDataGridCell_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Radzen.Blazor.RadzenDataGrid<TItem> __arg0, int __seq1, TItem __arg1, int __seq2, global::Radzen.Blazor.RadzenDataGridColumn<TItem> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDataGridCell<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Grid", __arg0);
        __builder.AddAttribute(__seq1, "Item", __arg1);
        __builder.AddAttribute(__seq2, "Column", __arg2);
        __builder.AddAttribute(__seq3, "Style", __arg3);
        __builder.AddAttribute(__seq4, "CssClass", __arg4);
        __builder.AddAttribute(__seq5, "Attributes", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
