#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ff363bf39f0b42af8304d058832c48806e9f8b"
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
#line 1 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c#\radzen-blazor\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-pager-api")]
    public partial class DataGridPagerApiPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid <strong>Pager API</strong></h1>\n\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(1);
            __builder.AddAttribute(2, "Name", "DataGrid");
            __builder.AddAttribute(3, "Source", "DataGridPagerApi");
            __builder.AddAttribute(4, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                                                                  false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "style", "margin-bottom: 16px");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(8);
                __builder2.AddAttribute(9, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                              FirstPage

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "Text", "First page");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(12);
                __builder2.AddAttribute(13, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                              TenthPage

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "Text", "10th page");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(16);
                __builder2.AddAttribute(17, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                              LastPage

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(18, "Text", "Last page");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __Blazor.RadzenBlazorDemos.Pages.DataGridPagerApiPage.TypeInference.CreateRadzenCheckBox_0(__builder2, 20, 21, "CheckBox1", 22, "margin-left: 5px;", 23, 
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                                     showPagerSummary

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => showPagerSummary = __value, showPagerSummary)), 25, () => showPagerSummary);
                __builder2.AddMarkupContent(26, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(27);
                __builder2.AddAttribute(28, "Text", "Show pager summary");
                __builder2.AddAttribute(29, "Component", "CheckBox1");
                __builder2.AddAttribute(30, "Style", "margin-left: 5px;");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n   ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<OrderDetail>>(32);
                __builder2.AddAttribute(33, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderDetail>>(
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                                         orderDetails

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "PageSizeOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Int32>>(
#nullable restore
#line 20 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                      pageSizeOptions

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ShowPagingSummary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                                                           showPagerSummary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "PagingSummaryFormat", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                                                                                                   pagingSummaryFormat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(40);
                    __builder3.AddAttribute(41, "Property", "OrderID");
                    __builder3.AddAttribute(42, "Title", "OrderID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(44);
                    __builder3.AddAttribute(45, "Property", "ProductID");
                    __builder3.AddAttribute(46, "Title", "ProductID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(48);
                    __builder3.AddAttribute(49, "Property", "UnitPrice");
                    __builder3.AddAttribute(50, "Title", "Unit Price");
                    __builder3.AddAttribute(51, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((detail) => (__builder4) => {
                        __builder4.AddContent(52, 
#nullable restore
#line 26 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                     String.Format(new System.Globalization.CultureInfo("en-US"), "{0:C}", detail.UnitPrice)

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(54);
                    __builder3.AddAttribute(55, "Property", "Quantity");
                    __builder3.AddAttribute(56, "Title", "Quantity");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<OrderDetail>>(58);
                    __builder3.AddAttribute(59, "Property", "Discount");
                    __builder3.AddAttribute(60, "Title", "Discount");
                    __builder3.AddAttribute(61, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderDetail>)((detail) => (__builder4) => {
                        __builder4.AddContent(62, 
#nullable restore
#line 32 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                     String.Format("{0}%", detail.Discount * 100)

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(63, (__value) => {
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
                         dataGrid = (Radzen.Blazor.RadzenDataGrid<OrderDetail>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPagerApiPage.razor"
       
    string pagingSummaryFormat = "Displaying page {0} of {1} (total {2} records)";

    RadzenDataGrid<OrderDetail> dataGrid;
    IEnumerable<int> pageSizeOptions = new int[] { 10, 20, 30 };
    IEnumerable<OrderDetail> orderDetails;
    bool showPagerSummary = true;

    async Task FirstPage()
{
        await dataGrid.FirstPage();
    }
    async Task TenthPage()
    {
        await dataGrid.GoToPage(9);
    }
    async Task LastPage()
    {
        await dataGrid.LastPage();
    }

    protected override void OnInitialized()
    {
        orderDetails = dbContext.OrderDetails;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
namespace __Blazor.RadzenBlazorDemos.Pages.DataGridPagerApiPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenCheckBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591