#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7394e07bf0a7e8c91dde862a38a58e6d8a2c319"
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
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid")]
    public partial class DataGridPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Display tabular data with ease. Perform paging, sorting and filtering through Entity Framework without extra code.</p>\n\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                        false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Employee>>(6);
                __builder2.AddAttribute(7, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                                               FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                                                                              5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Employee>>(
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
               employees

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ColumnWidth", "300px");
                __builder2.AddAttribute(15, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                                                      LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(17);
                    __builder3.AddAttribute(18, "Property", "EmployeeID");
                    __builder3.AddAttribute(19, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "Title", "ID");
                    __builder3.AddAttribute(21, "Frozen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Width", "70px");
                    __builder3.AddAttribute(23, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                                                                                                             TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(25);
                    __builder3.AddAttribute(26, "Title", "Photo");
                    __builder3.AddAttribute(27, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                                           false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Width", "200px");
                    __builder3.AddAttribute(30, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Employee>)((data) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(31);
                        __builder4.AddAttribute(32, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
                                        data.Photo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "style", "width: 40px; height: 40px; border-radius: 8px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(35);
                    __builder3.AddAttribute(36, "Property", "FirstName");
                    __builder3.AddAttribute(37, "Title", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(39);
                    __builder3.AddAttribute(40, "Property", "LastName");
                    __builder3.AddAttribute(41, "Title", "Last Name");
                    __builder3.AddAttribute(42, "Width", "150px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(44);
                    __builder3.AddAttribute(45, "Property", "Title");
                    __builder3.AddAttribute(46, "Title", "Title");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(48);
                    __builder3.AddAttribute(49, "Property", "TitleOfCourtesy");
                    __builder3.AddAttribute(50, "Title", "Title Of Courtesy");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(52);
                    __builder3.AddAttribute(53, "Property", "BirthDate");
                    __builder3.AddAttribute(54, "Title", "Birth Date");
                    __builder3.AddAttribute(55, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(57);
                    __builder3.AddAttribute(58, "Property", "HireDate");
                    __builder3.AddAttribute(59, "Title", "Hire Date");
                    __builder3.AddAttribute(60, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(62);
                    __builder3.AddAttribute(63, "Property", "Address");
                    __builder3.AddAttribute(64, "Title", "Address");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(66);
                    __builder3.AddAttribute(67, "Property", "City");
                    __builder3.AddAttribute(68, "Title", "City");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(70);
                    __builder3.AddAttribute(71, "Property", "Region");
                    __builder3.AddAttribute(72, "Title", "Region");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(74);
                    __builder3.AddAttribute(75, "Property", "PostalCode");
                    __builder3.AddAttribute(76, "Title", "Postal Code");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(78);
                    __builder3.AddAttribute(79, "Property", "Country");
                    __builder3.AddAttribute(80, "Title", "Country");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(82);
                    __builder3.AddAttribute(83, "Property", "HomePhone");
                    __builder3.AddAttribute(84, "Title", "Home Phone");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(86);
                    __builder3.AddAttribute(87, "Property", "Extension");
                    __builder3.AddAttribute(88, "Title", "Extension");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(90);
                    __builder3.AddAttribute(91, "Property", "Notes");
                    __builder3.AddAttribute(92, "Title", "Notes");
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
#line 40 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridPage.razor"
       
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