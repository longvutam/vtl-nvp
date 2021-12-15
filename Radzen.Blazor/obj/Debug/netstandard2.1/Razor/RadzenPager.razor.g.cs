#pragma checksum "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3ad4895c33f7f1a8a1ed64f0ebcf19b98714278"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class RadzenPager : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 2 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
 if (GetVisible())
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddMultipleAttributes(2, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                      Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "class", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                          GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(4, "style", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                 Style

#line default
#line hidden
            );
            __builder.AddAttribute(5, "id", 
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                             GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 4 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\r\n");
#line 5 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
         if(ShowPagingSummary)
        {

#line default
#line hidden
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "label");
            __builder.AddAttribute(10, "class", "rz-paginator-summary");
            __builder.AddContent(11, 
#line 7 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                              string.Format(PagingSummaryFormat, CurrentPage + 1, numberOfPages, Count)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "        \r\n");
#line 8 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
        }

#line default
#line hidden
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "class", "rz-paginator-first" + " rz-paginator-element" + " " + (
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                            (skip > 0) ? "": "rz-state-disabled"

#line default
#line hidden
            ));
            __builder.AddAttribute(16, "href", "javascript:void(0)");
            __builder.AddAttribute(17, "tabindex", "-1");
            __builder.AddEventPreventDefaultAttribute(18, "onclick", 
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                    true

#line default
#line hidden
            );
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 10 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                                      () => FirstPage()

#line default
#line hidden
            ));
            __builder.AddMarkupContent(20, "\r\n            <span class=\"rz-paginator-icon rzi rzi-step-backward\"></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "rz-paginator-prev" + " rz-paginator-element" + " " + (
#line 13 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                           (skip > 0) ? "": "rz-state-disabled"

#line default
#line hidden
            ));
            __builder.AddAttribute(24, "href", "javascript:void(0)");
            __builder.AddAttribute(25, "tabindex", "-1");
            __builder.AddEventPreventDefaultAttribute(26, "onclick", 
#line 13 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                   true

#line default
#line hidden
            );
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 13 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                                     () => PrevPage()

#line default
#line hidden
            ));
            __builder.AddMarkupContent(28, "\r\n            <span class=\"rz-paginator-icon rzi rzi-caret-left\"></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n        ");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "rz-paginator-pages");
            __builder.AddMarkupContent(32, "\r\n");
#line 18 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
             foreach (var i in Enumerable.Range(startPage, Math.Min(endPage + 1, PageNumbersCount)))
            {

#line default
#line hidden
            __builder.AddContent(33, "                ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "class", "rz-paginator-page" + " rz-paginator-element" + " " + (
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                   (i == CurrentPage) ? "rz-state-active" : ""

#line default
#line hidden
            ));
            __builder.AddAttribute(36, "href", "javascript:void(0)");
            __builder.AddEventPreventDefaultAttribute(37, "onclick", 
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                    true

#line default
#line hidden
            );
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                                      () => GoToPage(i)

#line default
#line hidden
            ));
            __builder.AddContent(39, 
#line 20 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                                                            i + 1

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#line 21 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
            }

#line default
#line hidden
            __builder.AddContent(41, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "class", "rz-paginator-next" + " rz-paginator-element" + " " + (
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                           (CurrentPage != numberOfPages - 1) ? "": "rz-state-disabled"

#line default
#line hidden
            ));
            __builder.AddAttribute(45, "href", "javascript:void(0)");
            __builder.AddAttribute(46, "tabindex", "0");
            __builder.AddEventPreventDefaultAttribute(47, "onclick", 
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                                          true

#line default
#line hidden
            );
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 23 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                                                            () => NextPage()

#line default
#line hidden
            ));
            __builder.AddMarkupContent(49, "\r\n            <span class=\"rz-paginator-icon rzi rzi-caret-right\"></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "a");
            __builder.AddAttribute(52, "class", "rz-paginator-last" + " rz-paginator-element" + "  " + (
#line 26 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                            (CurrentPage != numberOfPages - 1) ? "": "rz-state-disabled"

#line default
#line hidden
            ));
            __builder.AddAttribute(53, "href", "javascript:void(0)");
            __builder.AddAttribute(54, "tabindex", "0");
            __builder.AddEventPreventDefaultAttribute(55, "onclick", 
#line 26 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                                           true

#line default
#line hidden
            );
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 26 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                                                                                                                                             () => LastPage()

#line default
#line hidden
            ));
            __builder.AddMarkupContent(57, "\r\n            <span class=\"rz-paginator-icon rzi rzi-step-forward\"></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n");
#line 30 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
         if(PageSizeOptions != null && PageSizeOptions.Any())
        {

#line default
#line hidden
            __builder.AddContent(59, "            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(60);
            __builder.AddAttribute(61, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#line 32 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                PageSizeOptions

#line default
#line hidden
            ));
            __builder.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 32 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                         PageSize

#line default
#line hidden
            ));
            __builder.AddAttribute(63, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#line 32 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
                                                                                            OnPageSizeChanged

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n");
#line 33 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
        }

#line default
#line hidden
            __builder.AddContent(65, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#line 35 "D:\c#\blazor\vtl-nvp\Radzen.Blazor\RadzenPager.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
