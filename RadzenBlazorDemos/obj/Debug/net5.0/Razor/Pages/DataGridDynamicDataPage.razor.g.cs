#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6daeac90ccef4339dbfa433d911451fd2f4af7c9"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-dynamic")]
    public partial class DataGridDynamicDataPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DataGrid <strong>dynamic</strong> data support</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>\n    Sometimes your data comes from external API and you don\'t have a C# model for it. This demo shows how to implement such a scenario.\n</p>\n\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "DataGrid");
            __builder.AddAttribute(4, "Source", "DataGridDynamicData");
            __builder.AddAttribute(5, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                                                     false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<IDictionary<string, object>>>(7);
                __builder2.AddAttribute(8, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                                                 FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                                                                                                    FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                         5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<IDictionary<string, object>>>(
#nullable restore
#line 10 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                                                       data

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "IsLoading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                        isLoading

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                    count

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 12 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                      LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(18, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<IDictionary<string, object>>>(19);
                    __builder3.AddAttribute(20, "Property", "EmployeeID");
                    __builder3.AddAttribute(21, "Title", "EmployeeID");
                    __builder3.AddAttribute(22, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                                                                                                     typeof(int)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Template", (Microsoft.AspNetCore.Components.RenderFragment<IDictionary<string, object>>)((context) => (__builder4) => {
                        __builder4.AddContent(24, 
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                     context["EmployeeID"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<IDictionary<string, object>>>(26);
                    __builder3.AddAttribute(27, "Property", "FirstName");
                    __builder3.AddAttribute(28, "Title", "FirstName");
                    __builder3.AddAttribute(29, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                                                                                                   typeof(string)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "Template", (Microsoft.AspNetCore.Components.RenderFragment<IDictionary<string, object>>)((context) => (__builder4) => {
                        __builder4.AddContent(31, 
#nullable restore
#line 21 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                     context["FirstName"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<IDictionary<string, object>>>(33);
                    __builder3.AddAttribute(34, "Property", "LastName");
                    __builder3.AddAttribute(35, "Title", "LastName");
                    __builder3.AddAttribute(36, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 24 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                                                                                                                 typeof(string)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Template", (Microsoft.AspNetCore.Components.RenderFragment<IDictionary<string, object>>)((context) => (__builder4) => {
                        __builder4.AddContent(38, 
#nullable restore
#line 26 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
                     context["LastName"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
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
#line 32 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\DataGridDynamicDataPage.razor"
       
    IEnumerable<IDictionary<string, object>> data;
    int count;
    bool isLoading;

    async Task LoadData(LoadDataArgs args)
    {
        isLoading = true;
        var uri = new Uri("https://services.radzen.com/odata/Northwind/Employees")
            .GetODataUri(filter: args.Filter, top: args.Top, skip: args.Skip, orderby: args.OrderBy, count: true);

        var response = await new HttpClient().SendAsync(new HttpRequestMessage(HttpMethod.Get, uri));

        var result = await response.ReadAsync<ODataServiceResult<IDictionary<string, object>>>();

        data = result.Value.AsODataEnumerable();
        count = result.Count;
        isLoading = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
