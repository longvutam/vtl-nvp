#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edefdbfa083f0f2270e0e1b4e8ae2c382ec341d6"
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
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-sort-api")]
    public partial class DataGridSortApiPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid <strong>Sort API</strong></h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Set the initial sort order of your RadzenDataGrid via the <code>SortOrder</code> column property.</p>\r\n\r\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Source", "DataGridSortApi");
            __builder.AddAttribute(5, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
                                                                 false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Employee>>(7);
                __builder2.AddAttribute(8, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
                                                       5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Employee>>(
#nullable restore
#line 14 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
                                                                                                        employees

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ColumnWidth", "300px");
                __builder2.AddAttribute(14, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(15);
                    __builder3.AddAttribute(16, "Property", "FirstName");
                    __builder3.AddAttribute(17, "Title", "First Name");
                    __builder3.AddAttribute(18, "SortOrder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.SortOrder?>(
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
                                                                                                      SortOrder.Descending

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(20);
                    __builder3.AddAttribute(21, "Property", "LastName");
                    __builder3.AddAttribute(22, "Title", "Last Name");
                    __builder3.AddAttribute(23, "Width", "150px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(25);
                    __builder3.AddAttribute(26, "Property", "BirthDate");
                    __builder3.AddAttribute(27, "Title", "Birth Date");
                    __builder3.AddAttribute(28, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(30);
                    __builder3.AddAttribute(31, "Property", "Country");
                    __builder3.AddAttribute(32, "Title", "Country");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(34);
                    __builder3.AddAttribute(35, "Property", "Notes");
                    __builder3.AddAttribute(36, "Title", "Notes");
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
#line 24 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortApiPage.razor"
       
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
