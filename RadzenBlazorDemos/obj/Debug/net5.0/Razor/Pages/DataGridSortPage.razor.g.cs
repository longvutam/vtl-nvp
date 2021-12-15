#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1d6087aa457a3b66d3d7f0b2ea99c1dc58b559c"
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
#line 3 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-sort")]
    public partial class DataGridSortPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid <strong>Sorting</strong></h1>\r\n\r\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(1);
            __builder.AddAttribute(2, "Name", "DataGrid");
            __builder.AddAttribute(3, "Source", "DataGridSort");
            __builder.AddAttribute(4, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortPage.razor"
                                                              false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Employee>>(6);
                __builder2.AddAttribute(7, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortPage.razor"
                              5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortPage.razor"
                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortPage.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Employee>>(
#nullable restore
#line 12 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortPage.razor"
                                                                               employees

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ColumnWidth", "300px");
                __builder2.AddAttribute(12, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(13);
                    __builder3.AddAttribute(14, "Property", "FirstName");
                    __builder3.AddAttribute(15, "Title", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(17);
                    __builder3.AddAttribute(18, "Property", "LastName");
                    __builder3.AddAttribute(19, "Title", "Last Name");
                    __builder3.AddAttribute(20, "Width", "150px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(22);
                    __builder3.AddAttribute(23, "Property", "BirthDate");
                    __builder3.AddAttribute(24, "Title", "Birth Date");
                    __builder3.AddAttribute(25, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(27);
                    __builder3.AddAttribute(28, "Property", "Country");
                    __builder3.AddAttribute(29, "Title", "Country");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(31);
                    __builder3.AddAttribute(32, "Property", "Notes");
                    __builder3.AddAttribute(33, "Title", "Notes");
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
#line 22 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\DataGridSortPage.razor"
       
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
