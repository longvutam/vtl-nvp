#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "365137cd52606461d146c81b2a04a7d137f7d187"
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
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-odata")]
    public partial class DataGridODataPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid <strong>OData</strong></h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Use the <code>LoadData</code> event to get data from a REST service.</p>\n\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Source", "DataGridOData");
            __builder.AddAttribute(5, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                               false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "AdditionalSourceCodePages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 11 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                                   new [] {"../Services/NorthwindODataService.cs"}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Employee>>(8);
                __builder2.AddAttribute(9, "IsLoading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                            isLoading

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                               count

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Employee>>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                             employees

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                   LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                                                    FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                                                                                                       FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                                                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                                                                                                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                                                                                                                                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                                                                                                                                                                                                   4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ColumnWidth", "200px");
                __builder2.AddAttribute(20, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(21);
                    __builder3.AddAttribute(22, "Property", "EmployeeID");
                    __builder3.AddAttribute(23, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                 false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Title", "ID");
                    __builder3.AddAttribute(25, "Frozen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                                           true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "Width", "50px");
                    __builder3.AddAttribute(27, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                                                                         TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(29);
                    __builder3.AddAttribute(30, "Title", "Photo");
                    __builder3.AddAttribute(31, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                       false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                          false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Width", "200px");
                    __builder3.AddAttribute(34, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Employee>)((data) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(35);
                        __builder4.AddAttribute(36, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                    data.Photo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "style", "width: 40px; height: 40px; border-radius: 8px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(39);
                    __builder3.AddAttribute(40, "Property", "FirstName");
                    __builder3.AddAttribute(41, "Title", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(43);
                    __builder3.AddAttribute(44, "Property", "LastName");
                    __builder3.AddAttribute(45, "Title", "Last Name");
                    __builder3.AddAttribute(46, "Width", "150px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(48);
                    __builder3.AddAttribute(49, "Property", "Title");
                    __builder3.AddAttribute(50, "Title", "Title");
                    __builder3.AddAttribute(51, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 23 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                  typeof(IEnumerable<string>)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "FilterValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 23 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                             selectedTitles

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterOperator>(
#nullable restore
#line 23 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                             FilterOperator.Contains

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "FilterTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.RadzenDataGridColumn<Employee>>)((context) => (__builder4) => {
                        __Blazor.RadzenBlazorDemos.Pages.DataGridODataPage.TypeInference.CreateRadzenDropDown_0(__builder4, 55, 56, "width:100%", 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 26 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                            OnSelectedTitlesChange

#line default
#line hidden
#nullable disable
                        ), 58, 
#nullable restore
#line 26 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                           titles

#line default
#line hidden
#nullable disable
                        , 59, 
#nullable restore
#line 26 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                true

#line default
#line hidden
#nullable disable
                        , 60, 
#nullable restore
#line 26 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                        , 61, 
#nullable restore
#line 25 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
                                             selectedTitles

#line default
#line hidden
#nullable disable
                        , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedTitles = __value, selectedTitles)), 63, () => selectedTitles);
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(65);
                    __builder3.AddAttribute(66, "Property", "TitleOfCourtesy");
                    __builder3.AddAttribute(67, "Title", "Title Of Courtesy");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(69);
                    __builder3.AddAttribute(70, "Property", "BirthDate");
                    __builder3.AddAttribute(71, "Title", "Birth Date");
                    __builder3.AddAttribute(72, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(74);
                    __builder3.AddAttribute(75, "Property", "HireDate");
                    __builder3.AddAttribute(76, "Title", "Hire Date");
                    __builder3.AddAttribute(77, "FormatString", "{0:d}");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(79);
                    __builder3.AddAttribute(80, "Property", "Address");
                    __builder3.AddAttribute(81, "Title", "Address");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(83);
                    __builder3.AddAttribute(84, "Property", "City");
                    __builder3.AddAttribute(85, "Title", "City");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(87);
                    __builder3.AddAttribute(88, "Property", "Region");
                    __builder3.AddAttribute(89, "Title", "Region");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(91);
                    __builder3.AddAttribute(92, "Property", "PostalCode");
                    __builder3.AddAttribute(93, "Title", "Postal Code");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(94, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(95);
                    __builder3.AddAttribute(96, "Property", "Country");
                    __builder3.AddAttribute(97, "Title", "Country");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(99);
                    __builder3.AddAttribute(100, "Property", "HomePhone");
                    __builder3.AddAttribute(101, "Title", "Home Phone");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(103);
                    __builder3.AddAttribute(104, "Property", "Extension");
                    __builder3.AddAttribute(105, "Title", "Extension");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Employee>>(107);
                    __builder3.AddAttribute(108, "Property", "Notes");
                    __builder3.AddAttribute(109, "Title", "Notes");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(110, "\n");
            __builder.AddMarkupContent(111, "<h3 style=\"margin-top: 32px\">To data-bind to a service:</h3>\n");
            __builder.AddMarkupContent(112, @"<ol><li>Set the Data and Count properties.
    <pre><code>&lt;RadzenDataGrid Count=""@count"" Data=""@employees""</code></pre></li>
    <li>
        Handle the LoadData event and update the Data and Count backing fields (<code>employees</code> and <code>count</code> in this case).
    <pre><code>
async Task LoadData(LoadDataArgs args)
{
    var result = await service.GetEmployees(filter: args.Filter, top: args.Top, skip: args.Skip, orderby: args.OrderBy, count: true);
    employees = result.Value.AsODataEnumerable();
    count = result.Count;
}
        </code></pre></li></ol>");
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridODataPage.razor"
       
    bool isLoading;
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

    async Task LoadData(LoadDataArgs args)
    {
        isLoading = true;

        var result = await service.GetEmployees(filter: args.Filter, top: args.Top, skip: args.Skip, orderby: args.OrderBy, count: true);
        // Update the Data property
        employees = result.Value.AsODataEnumerable();
        // Update the count
        count = result.Count;

        isLoading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindODataService service { get; set; }
    }
}
namespace __Blazor.RadzenBlazorDemos.Pages.DataGridODataPage
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