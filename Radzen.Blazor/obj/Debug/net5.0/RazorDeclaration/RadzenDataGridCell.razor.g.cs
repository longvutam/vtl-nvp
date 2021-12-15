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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class RadzenDataGridCell<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 7 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenDataGridCell.razor"
       
    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object> Attributes { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string CssClass { get; set; }

    [Parameter]
    public string Style { get; set; }

    [Parameter]
    public TItem Item { get; set; }

    [Parameter]
    public RadzenDataGridColumn<TItem> Column { get; set; }

    [Parameter]
    public RadzenDataGrid<TItem> Grid { get; set; }

    async Task OnContextMenu(MouseEventArgs args)
    {
        if (Grid != null)
        {
#if NET5
            await Grid.OnCellContextMenu(new DataGridCellMouseEventArgs<TItem>
            {
                Data = Item,
                AltKey = args.AltKey,
                Button = args.Button,
                Buttons = args.Buttons,
                ClientX = args.ClientX,
                ClientY = args.ClientY,
                CtrlKey = args.CtrlKey,
                Detail = args.Detail,
                MetaKey = args.MetaKey,
                OffsetX = args.OffsetX,
                OffsetY = args.OffsetY,
                ScreenX = args.ScreenX,
                ScreenY = args.ScreenY,
                ShiftKey = args.ShiftKey,
                Type = args.Type,
                Column = Column
            });
#else
            await Grid.OnCellContextMenu(new DataGridCellMouseEventArgs<TItem>
            {
                Data = Item,
                AltKey = args.AltKey,
                Button = args.Button,
                Buttons = args.Buttons,
                ClientX = args.ClientX,
                ClientY = args.ClientY,
                CtrlKey = args.CtrlKey,
                Detail = args.Detail,
                MetaKey = args.MetaKey,
                ScreenX = args.ScreenX,
                ScreenY = args.ScreenY,
                ShiftKey = args.ShiftKey,
                Type = args.Type,
                Column = Column
            });
#endif
        }
    }


    async Task OnClick(MouseEventArgs args)
    {
        if (Grid != null)
        {
#if NET5
            await Grid.OnRowClick(new DataGridRowMouseEventArgs<TItem>
            {
                Data = Item,
                AltKey = args.AltKey,
                Button = args.Button,
                Buttons = args.Buttons,
                ClientX = args.ClientX,
                ClientY = args.ClientY,
                CtrlKey = args.CtrlKey,
                Detail = args.Detail,
                MetaKey = args.MetaKey,
                OffsetX = args.OffsetX,
                OffsetY = args.OffsetY,
                ScreenX = args.ScreenX,
                ScreenY = args.ScreenY,
                ShiftKey = args.ShiftKey,
                Type = args.Type
            });
#else
            await Grid.OnRowClick(new DataGridRowMouseEventArgs<TItem>
            {
                Data = Item,
                AltKey = args.AltKey,
                Button = args.Button,
                Buttons = args.Buttons,
                ClientX = args.ClientX,
                ClientY = args.ClientY,
                CtrlKey = args.CtrlKey,
                Detail = args.Detail,
                MetaKey = args.MetaKey,
                ScreenX = args.ScreenX,
                ScreenY = args.ScreenY,
                ShiftKey = args.ShiftKey,
                Type = args.Type
            });
#endif
        }
    }

    async Task OnDblClick(MouseEventArgs args)
    {
        if (Grid != null)
        {
#if NET5
            await Grid.OnRowDblClick(new DataGridRowMouseEventArgs<TItem>
            {
                Data = Item,
                AltKey = args.AltKey,
                Button = args.Button,
                Buttons = args.Buttons,
                ClientX = args.ClientX,
                ClientY = args.ClientY,
                CtrlKey = args.CtrlKey,
                Detail = args.Detail,
                MetaKey = args.MetaKey,
                OffsetX = args.OffsetX,
                OffsetY = args.OffsetY,
                ScreenX = args.ScreenX,
                ScreenY = args.ScreenY,
                ShiftKey = args.ShiftKey,
                Type = args.Type
            });
#else
            await Grid.OnRowDblClick(new DataGridRowMouseEventArgs<TItem>
            {
                Data = Item,
                AltKey = args.AltKey,
                Button = args.Button,
                Buttons = args.Buttons,
                ClientX = args.ClientX,
                ClientY = args.ClientY,
                CtrlKey = args.CtrlKey,
                Detail = args.Detail,
                MetaKey = args.MetaKey,
                ScreenX = args.ScreenX,
                ScreenY = args.ScreenY,
                ShiftKey = args.ShiftKey,
                Type = args.Type
            });
#endif
        }
    }

    string GetCssClass()
    {
        if (Attributes != null && Attributes.TryGetValue("class", out var @class) && !string.IsNullOrEmpty(Convert.ToString(@class)))
        {
            return $"{CssClass} {@class}".Trim();
        }

        return String.IsNullOrWhiteSpace(CssClass) ? null : CssClass;
    }

    string GetStyle()
    {
        if (Attributes != null && Attributes.TryGetValue("style", out var style) == true && !string.IsNullOrEmpty(Convert.ToString(style)))
        {
            return String.IsNullOrEmpty(Style) ? $"{style}" : $"{Style.TrimEnd(';')};{style}";
        }

        return Style;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
