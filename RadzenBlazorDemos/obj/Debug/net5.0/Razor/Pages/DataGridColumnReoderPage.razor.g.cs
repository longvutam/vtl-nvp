#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d85322d6d0670c51df548aa5ece216ce90e59059"
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
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-column-reorder")]
    public partial class DataGridColumnReoderPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Enable column reorder by setting the AllowColumnReorder property to true.</p>\r\n\r\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Source", "DataGridColumnReoder");
            __builder.AddAttribute(5, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                      false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(7);
                __builder2.AddAttribute(8, "Text", "Change page state");
                __builder2.AddAttribute(9, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                    (args) => { StateHasChanged(); }

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "Style", "margin-bottom:20px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Employee>>(12);
                __builder2.AddAttribute(13, "AllowColumnReorder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ColumnReordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.DataGridColumnReorderedEventArgs<Employee>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.DataGridColumnReorderedEventArgs<Employee>>(this, 
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                OnColumnReordered

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(15, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                                  5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Employee>>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                                                                                   employees

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ColumnWidth", "300px");
                __builder2.AddAttribute(23, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                                                                                                                                                          LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(25);
                    __builder3.AddAttribute(26, "Property", "EmployeeID");
                    __builder3.AddAttribute(27, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "Title", "ID");
                    __builder3.AddAttribute(29, "Frozen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "Width", "50px");
                    __builder3.AddAttribute(31, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 18 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                                                                             TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Reorderable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                                                                                                            false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Resizable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                                                                                                                              false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(35);
                    __builder3.AddAttribute(36, "Title", "Photo");
                    __builder3.AddAttribute(37, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                           false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Width", "200px");
                    __builder3.AddAttribute(40, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Employee>)((data) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(41);
                        __builder4.AddAttribute(42, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                                        data.Photo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "style", "width: 40px; height: 40px; border-radius: 8px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(45);
                    __builder3.AddAttribute(46, "Property", "FirstName");
                    __builder3.AddAttribute(47, "Title", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(49);
                    __builder3.AddAttribute(50, "Property", "LastName");
                    __builder3.AddAttribute(51, "Title", "Last Name");
                    __builder3.AddAttribute(52, "Width", "150px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(54);
                    __builder3.AddAttribute(55, "Property", "Title");
                    __builder3.AddAttribute(56, "Title", "Title");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(58);
                    __builder3.AddAttribute(59, "Property", "TitleOfCourtesy");
                    __builder3.AddAttribute(60, "Title", "Title Of Courtesy");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(62);
                    __builder3.AddAttribute(63, "Property", "BirthDate");
                    __builder3.AddAttribute(64, "Title", "Birth Date");
                    __builder3.AddAttribute(65, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(67);
                    __builder3.AddAttribute(68, "Property", "HireDate");
                    __builder3.AddAttribute(69, "Title", "Hire Date");
                    __builder3.AddAttribute(70, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(72);
                    __builder3.AddAttribute(73, "Property", "Address");
                    __builder3.AddAttribute(74, "Title", "Address");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(76);
                    __builder3.AddAttribute(77, "Property", "City");
                    __builder3.AddAttribute(78, "Title", "City");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(80);
                    __builder3.AddAttribute(81, "Property", "Region");
                    __builder3.AddAttribute(82, "Title", "Region");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(84);
                    __builder3.AddAttribute(85, "Property", "PostalCode");
                    __builder3.AddAttribute(86, "Title", "Postal Code");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(88);
                    __builder3.AddAttribute(89, "Property", "Country");
                    __builder3.AddAttribute(90, "Title", "Country");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(92);
                    __builder3.AddAttribute(93, "Property", "HomePhone");
                    __builder3.AddAttribute(94, "Title", "Home Phone");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(96);
                    __builder3.AddAttribute(97, "Property", "Extension");
                    __builder3.AddAttribute(98, "Title", "Extension");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(100);
                    __builder3.AddAttribute(101, "Property", "Notes");
                    __builder3.AddAttribute(102, "Title", "Notes");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(103, "\r\n\r\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(104);
            __builder.AddComponentReferenceCapture(105, (__value) => {
#nullable restore
#line 42 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
                    console = (RadzenBlazorDemos.Shared.EventConsole)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridColumnReoderPage.razor"
       
    EventConsole console;

    IEnumerable<Employee> employees;

    protected override void OnInitialized()
    {
        employees = dbContext.Employees;
    }

    void OnColumnReordered(DataGridColumnReorderedEventArgs<Employee> args)
    {
        console.Log($"Reordered {args.Column.Title}. Old index: {args.OldIndex}, New index: {args.NewIndex}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591
