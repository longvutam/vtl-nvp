#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\TreeCheckBoxesPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2edf08471bf419e93c69136bfb10b1efe914a7e4"
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
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\TreeCheckBoxesPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\TreeCheckBoxesPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tree-checkboxes")]
    public partial class TreeCheckBoxesPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Tree checkboxes</h1>\n");
            __builder.AddMarkupContent(1, "<p>Get or set the selected items of RadzenTree</p>\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(2);
            __builder.AddAttribute(3, "Name", "Tree");
            __builder.AddAttribute(4, "Source", "TreeCheckBoxesPage");
            __builder.AddAttribute(5, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\TreeCheckBoxesPage.razor"
                                                                false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenTree>(7);
                __builder2.AddAttribute(8, "AllowCheckBoxes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\TreeCheckBoxesPage.razor"
                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Style", "width: 100%; height: 300px");
                __builder2.AddAttribute(10, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\TreeCheckBoxesPage.razor"
                                                                                                                   categories

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "CheckedValues", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 9 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\TreeCheckBoxesPage.razor"
                                                            CheckedValues

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "CheckedValuesChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<System.Object>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<System.Object>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CheckedValues = __value, CheckedValues))));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTreeLevel>(14);
                    __builder3.AddAttribute(15, "TextProperty", "CategoryName");
                    __builder3.AddAttribute(16, "ChildrenProperty", "Products");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTreeLevel>(18);
                    __builder3.AddAttribute(19, "TextProperty", "ProductName");
                    __builder3.AddAttribute(20, "HasChildren", new System.Func<System.Object, System.Boolean>(
#nullable restore
#line 11 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\TreeCheckBoxesPage.razor"
                                                                  product => false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n    ");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(22);
                __builder2.AddComponentReferenceCapture(23, (__value) => {
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\TreeCheckBoxesPage.razor"
                        console = (RadzenBlazorDemos.Shared.EventConsole)__value;

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
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\TreeCheckBoxesPage.razor"
       
    IEnumerable<Category> categories;
    IEnumerable<object> checkedValues;

    IEnumerable<object> CheckedValues
    {
        get => checkedValues;
        set
        {
            checkedValues = value;
            console.Log($"CheckedValues Changed {string.Join(Environment.NewLine, value.Select(GetText))}");
        }
    }

    string GetText(object data)
    {
        if (data is Category category)
        {
            return category.CategoryName;
        }

        if (data is Product product)
        {
            return product.ProductName;
        }

        return string.Empty;
    }

    EventConsole console;

    protected override void OnInitialized()
    {
        categories = Northwind.Categories.Include(c => c.Products);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RadzenBlazorDemos.Data.NorthwindContext Northwind { get; set; }
    }
}
#pragma warning restore 1591