#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62d488e3b6b266863d13dc748a99a44d7d159ca"
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
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-simple-filter")]
    public partial class DataGridSimpleFilterPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid <strong>Simple Filter Mode</strong></h1>\n\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(1);
            __builder.AddAttribute(2, "Name", "DataGrid");
            __builder.AddAttribute(3, "Source", "DataGridSimpleFilter");
            __builder.AddAttribute(4, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                                      false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Employee>>(6);
                __builder2.AddAttribute(7, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                    FilterMode.Simple

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                 5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Employee>>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                                                                  employees

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ColumnWidth", "300px");
                __builder2.AddAttribute(15, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                               FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                               LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(18);
                    __builder3.AddAttribute(19, "Property", "EmployeeID");
                    __builder3.AddAttribute(20, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Title", "ID");
                    __builder3.AddAttribute(22, "Frozen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Width", "50px");
                    __builder3.AddAttribute(24, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                                                                                                             TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(26);
                    __builder3.AddAttribute(27, "Title", "Photo");
                    __builder3.AddAttribute(28, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                                           false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "Width", "200px");
                    __builder3.AddAttribute(31, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Employee>)((data) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(32);
                        __builder4.AddAttribute(33, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
                                        data.Photo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(34, "style", "width: 40px; height: 40px; border-radius: 8px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(36);
                    __builder3.AddAttribute(37, "Property", "FirstName");
                    __builder3.AddAttribute(38, "Title", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(40);
                    __builder3.AddAttribute(41, "Property", "LastName");
                    __builder3.AddAttribute(42, "Title", "Last Name");
                    __builder3.AddAttribute(43, "Width", "150px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(45);
                    __builder3.AddAttribute(46, "Property", "BirthDate");
                    __builder3.AddAttribute(47, "Title", "Birth Date");
                    __builder3.AddAttribute(48, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(50);
                    __builder3.AddAttribute(51, "Property", "Country");
                    __builder3.AddAttribute(52, "Title", "Country");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(54);
                    __builder3.AddAttribute(55, "Property", "Notes");
                    __builder3.AddAttribute(56, "Title", "Notes");
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
#line 31 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridSimpleFilterPage.razor"
       
    IEnumerable<Employee> employees;

    protected override void OnInitialized()
    {
        employees = dbContext.Employees;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591