#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca602d28c6ecb6e6d771fd5f89136f56d7ba535c"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenBlazorDemos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-conditional-template")]
    public partial class DataGridConditionalTemplatePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid conditional styles and templates</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This page demonstrates <b>DataGrid</b> with conditional rows and cells template/styles.</p>\r\n\r\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Source", "DataGridConditionalTemplate");
            __builder.AddAttribute(5, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                                                                             false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "<h3>Order Details</h3>\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<OrderDetail>>(8);
                __builder2.AddAttribute(9, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                                                                                                        FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderDetail>>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                       orderDetails

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ColumnWidth", "200px");
                __builder2.AddAttribute(15, "RowRender", new System.Action<Radzen.RowRenderEventArgs<OrderDetail>>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                                                                                         RowRender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "CellRender", new System.Action<Radzen.DataGridCellRenderEventArgs<OrderDetail>>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                                                                                                                 CellRender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(18);
                    __builder3.AddAttribute(19, "Property", "OrderID");
                    __builder3.AddAttribute(20, "Title", "OrderID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(22);
                    __builder3.AddAttribute(23, "Property", "ProductID");
                    __builder3.AddAttribute(24, "Title", "ProductID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(26);
                    __builder3.AddAttribute(27, "Property", "Product.ProductName");
                    __builder3.AddAttribute(28, "Title", "Product");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(30);
                    __builder3.AddAttribute(31, "Property", "Quantity");
                    __builder3.AddAttribute(32, "Title", "Quantity");
                    __builder3.AddAttribute(33, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((data) => (__builder4) => {
#nullable restore
#line 23 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                     if (data.Quantity > 20)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(34, "span");
                        __builder4.AddAttribute(35, "style", "color:white");
                        __builder4.AddContent(36, 
#nullable restore
#line 25 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                                                   data.Quantity

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 26 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(37, "span");
                        __builder4.AddAttribute(38, "style", "color:black");
                        __builder4.AddContent(39, 
#nullable restore
#line 29 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                                                   data.Quantity

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 30 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(41);
                    __builder3.AddAttribute(42, "Property", "Discount");
                    __builder3.AddAttribute(43, "Title", "Discount");
                    __builder3.AddAttribute(44, "FormatString", "{0:P}");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridConditionalTemplatePage.razor"
       
    IEnumerable<OrderDetail> orderDetails;

    protected override void OnInitialized()
    {
        orderDetails = dbContext.OrderDetails.Include("Product").ToList();
    }

    void RowRender(RowRenderEventArgs<OrderDetail> args)
    {
        args.Attributes.Add("style", $"font-weight: {(args.Data.Quantity > 20 ? "bold" : "normal")};");
    }

    void CellRender(DataGridCellRenderEventArgs<OrderDetail> args)
    {
        if (args.Column.Property == "Quantity")
        {
            args.Attributes.Add("style", $"background-color: {(args.Data.Quantity > 20 ? "#ff6d41" : "white")};");

            if (args.Data.Discount == 0)
            {
                args.Attributes.Add("colspan", 2);
            }
        }

        if (args.Column.Property == "OrderID")
        {
            if (args.Data.OrderID == 10248 && args.Data.ProductID == 11 || args.Data.OrderID == 10250 && args.Data.ProductID == 41)
            {
                args.Attributes.Add("rowspan", 3);
            }

            if (args.Data.OrderID == 10249 && args.Data.ProductID == 14 || args.Data.OrderID == 10251 && args.Data.ProductID == 22)
            {
                args.Attributes.Add("rowspan", 2);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591
