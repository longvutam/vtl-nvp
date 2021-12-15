#pragma checksum "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ada763893ba953370936cfeac91cc01155ef721"
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
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
using Radzen;

#line default
#line hidden
#line 2 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
using System.Globalization;

#line default
#line hidden
#line 3 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
#line 4 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class RadzenScheduler<TItem> : RadzenComponent, IScheduler
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 10 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
 if (Visible)
{

#line default
#line hidden
            __Blazor.Radzen.Blazor.RadzenScheduler.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#line 12 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
                        this

#line default
#line hidden
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
#line 13 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
__builder2.AddContent(4, ChildContent);

#line default
#line hidden
                __builder2.AddMarkupContent(5, "\r\n");
            }
            );
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", 
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
                          Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(9, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
                                             Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "class", 
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
                                                               GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(11, "id", 
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
                                                                                 GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(12, (__value) => {
#line 15 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
          Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "rz-scheduler-nav");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "rz-scheduler-nav-prev-next");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "rz-button rz-prev");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 18 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
                                                        OnPrev

#line default
#line hidden
            ));
            __builder.OpenComponent<Radzen.Blazor.RadzenIcon>(23);
            __builder.AddAttribute(24, "Icon", "chevron_left");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "rz-button rz-next");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 19 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
                                                        OnNext

#line default
#line hidden
            ));
            __builder.OpenComponent<Radzen.Blazor.RadzenIcon>(29);
            __builder.AddAttribute(30, "Icon", "chevron_right");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "rz-button rz-today");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 20 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
                                                         OnToday

#line default
#line hidden
            ));
#line 20 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
__builder.AddContent(35, TodayText);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "rz-scheduler-nav-title");
#line 22 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
__builder.AddContent(40, SelectedView?.Title);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "rz-scheduler-nav-views");
            __builder.AddMarkupContent(44, "\r\n");
#line 24 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
         foreach (var view in Views)
        {

#line default
#line hidden
            __builder.AddContent(45, "            ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", 
#line 26 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
                             $"rz-button{(IsSelected(view)? " rz-state-active" : "")}"

#line default
#line hidden
            );
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 26 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
                                                                                                    args => OnChangeView(view)

#line default
#line hidden
            ));
#line 26 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
__builder.AddContent(49, view.Text);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#line 27 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
        }

#line default
#line hidden
            __builder.AddContent(51, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
#line 30 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
__builder.AddContent(54, SelectedView?.Render());

#line default
#line hidden
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#line 32 "C:\Users\owlsn\Source\Repos\vtl-nvp\Radzen.Blazor\RadzenScheduler.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenScheduler
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
