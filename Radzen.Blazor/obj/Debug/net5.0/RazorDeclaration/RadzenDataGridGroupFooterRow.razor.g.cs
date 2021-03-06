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
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
    public partial class RadzenDataGridGroupFooterRow<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 22 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
       
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
