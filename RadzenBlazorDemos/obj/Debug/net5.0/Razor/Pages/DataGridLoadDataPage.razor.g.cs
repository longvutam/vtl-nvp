#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ced9e99a90bda9faaf52cae9b56e97e60c14acec"
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
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-loaddata")]
    public partial class DataGridLoadDataPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid <strong>LoadData</strong></h1>\n\n");
            __builder.AddMarkupContent(1, "<p>The <code>LoadData</code> event allows you to perform custom paging, sorting and filtering.</p>\n\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Source", "DataGridLoadData");
            __builder.AddAttribute(5, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                  false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(7);
                __builder2.AddAttribute(8, "Text", "Reset");
                __builder2.AddAttribute(9, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                       Reset

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "Style", "margin-bottom: 20px;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Employee>>(12);
                __builder2.AddAttribute(13, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                        count

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Employee>>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                      employees

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                            LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                                                                                             4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ColumnWidth", "200px");
                __builder2.AddAttribute(21, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(22);
                    __builder3.AddAttribute(23, "Property", "EmployeeID");
                    __builder3.AddAttribute(24, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "Title", "ID");
                    __builder3.AddAttribute(26, "Frozen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Width", "50px");
                    __builder3.AddAttribute(28, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                                                                             TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(30);
                    __builder3.AddAttribute(31, "Title", "Photo");
                    __builder3.AddAttribute(32, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                           false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "Width", "200px");
                    __builder3.AddAttribute(35, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Employee>)((data) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(36);
                        __builder4.AddAttribute(37, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                        data.Photo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "style", "width: 40px; height: 40px; border-radius: 8px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(40);
                    __builder3.AddAttribute(41, "Property", "FirstName");
                    __builder3.AddAttribute(42, "Title", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(44);
                    __builder3.AddAttribute(45, "Property", "LastName");
                    __builder3.AddAttribute(46, "Title", "Last Name");
                    __builder3.AddAttribute(47, "Width", "150px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(49);
                    __builder3.AddAttribute(50, "Property", "Title");
                    __builder3.AddAttribute(51, "Title", "Title");
                    __builder3.AddAttribute(52, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 25 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                      typeof(IEnumerable<string>)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "FilterValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                 selectedTitles

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterOperator>(
#nullable restore
#line 25 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                                 FilterOperator.Contains

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "FilterTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.RadzenDataGridColumn<Employee>>)((context) => (__builder4) => {
                        __Blazor.RadzenBlazorDemos.Pages.DataGridLoadDataPage.TypeInference.CreateRadzenDropDown_0(__builder4, 56, 57, "width:100%", 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 28 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                OnSelectedTitlesChange

#line default
#line hidden
#nullable disable
                        ), 59, 
#nullable restore
#line 28 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                               titles

#line default
#line hidden
#nullable disable
                        , 60, 
#nullable restore
#line 28 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
                        , 61, 
#nullable restore
#line 28 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
                        , 62, 
#nullable restore
#line 27 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                                                 selectedTitles

#line default
#line hidden
#nullable disable
                        , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedTitles = __value, selectedTitles)), 64, () => selectedTitles);
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(66);
                    __builder3.AddAttribute(67, "Property", "TitleOfCourtesy");
                    __builder3.AddAttribute(68, "Title", "Title Of Courtesy");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(70);
                    __builder3.AddAttribute(71, "Property", "BirthDate");
                    __builder3.AddAttribute(72, "Title", "Birth Date");
                    __builder3.AddAttribute(73, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(75);
                    __builder3.AddAttribute(76, "Property", "HireDate");
                    __builder3.AddAttribute(77, "Title", "Hire Date");
                    __builder3.AddAttribute(78, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(80);
                    __builder3.AddAttribute(81, "Property", "Address");
                    __builder3.AddAttribute(82, "Title", "Address");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(84);
                    __builder3.AddAttribute(85, "Property", "City");
                    __builder3.AddAttribute(86, "Title", "City");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(88);
                    __builder3.AddAttribute(89, "Property", "Region");
                    __builder3.AddAttribute(90, "Title", "Region");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(92);
                    __builder3.AddAttribute(93, "Property", "PostalCode");
                    __builder3.AddAttribute(94, "Title", "Postal Code");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(96);
                    __builder3.AddAttribute(97, "Property", "Country");
                    __builder3.AddAttribute(98, "Title", "Country");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(100);
                    __builder3.AddAttribute(101, "Property", "HomePhone");
                    __builder3.AddAttribute(102, "Title", "Home Phone");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(104);
                    __builder3.AddAttribute(105, "Property", "Extension");
                    __builder3.AddAttribute(106, "Title", "Extension");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(108);
                    __builder3.AddAttribute(109, "Property", "Notes");
                    __builder3.AddAttribute(110, "Title", "Notes");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(111, (__value) => {
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
                          grid = (Radzen.Blazor.RadzenDataGrid<Employee>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(112, "\n\n");
            __builder.AddMarkupContent(113, "<h3 style=\"margin-top: 32px\">To perform custom data-binding:</h3>\n");
            __builder.AddMarkupContent(114, @"<ol><li>Set the Data and Count properties.
    <pre><code>&lt;RadzenDataGrid Count=""@count"" Data=""@employees""</code></pre></li>
    <li>
        Handle the LoadData event and update the Data and Count backing fields (<code>employees</code> and <code>count</code> in this case).
    <pre><code>
void LoadData(LoadDataArgs args)
{
    var query = dbContext.Employees.AsQueryable();

    if (!string.IsNullOrEmpty(args.Filter))
    {
        query = query.Where(args.Filter);
    }

    if (!string.IsNullOrEmpty(args.OrderBy))
    {
        query = query.OrderBy(args.OrderBy);
    }

    count = query.Count();

    employees = query.Skip(args.Skip.Value).Take(args.Top.Value).ToList();

   
} 
        </code></pre></li></ol>");
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridLoadDataPage.razor"
       
    RadzenDataGrid<Employee> grid;
    int count;
    IEnumerable<Employee> employees;

    List<string> titles = new List<string> {"Sales Representative", "Vice President, Sales", "Sales Manager", "Inside Sales Coordinator" };
    IEnumerable<string> selectedTitles;

    void OnSelectedTitlesChange(object value)
    {
        if (selectedTitles != null && !selectedTitles.Any())
        {
            selectedTitles = null;  
        }
    }

    async Task Reset()
    {
        grid.Reset(true); 
        await grid.FirstPage(true);
    }

    void LoadData(LoadDataArgs args)
    {
        // This demo is using https://dynamic-linq.net
        var query = dbContext.Employees.AsQueryable();

        if (!string.IsNullOrEmpty(args.Filter))
        {
            // Filter via the Where method
            query = query.Where(args.Filter);
        }

        if (!string.IsNullOrEmpty(args.OrderBy))
        {
            // Sort via the OrderBy method
            query = query.OrderBy(args.OrderBy);
        }

        // Important!!! Make sure the Count property of RadzenDataGrid is set.
        count = query.Count();

        // Perform paginv via Skip and Take.
        employees = query.Skip(args.Skip.Value).Take(args.Top.Value).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
namespace __Blazor.RadzenBlazorDemos.Pages.DataGridLoadDataPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object> __arg1, int __seq2, global::System.Collections.IEnumerable __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Object __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Style", __arg0);
        __builder.AddAttribute(__seq1, "Change", __arg1);
        __builder.AddAttribute(__seq2, "Data", __arg2);
        __builder.AddAttribute(__seq3, "AllowClear", __arg3);
        __builder.AddAttribute(__seq4, "Multiple", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
