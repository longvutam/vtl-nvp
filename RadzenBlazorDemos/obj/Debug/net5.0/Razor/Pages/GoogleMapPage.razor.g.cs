#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c63d820c90746a78aa0dc06a4eec10ac8bb5966"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/googlemap")]
    public partial class GoogleMapPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "GoogleMap");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-xl-6");
                __builder2.OpenElement(7, "h3");
                __builder2.AddMarkupContent(8, "Show marker for Madrid \r\n            ");
                __Blazor.RadzenBlazorDemos.Pages.GoogleMapPage.TypeInference.CreateRadzenCheckBox_0(__builder2, 9, 10, 
#nullable restore
#line 7 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                                         showMadridMarker

#line default
#line hidden
#nullable disable
                , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => showMadridMarker = __value, showMadridMarker)), 12, () => showMadridMarker);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, " \r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(14);
                __builder2.AddAttribute(15, "style", "height: 400px");
                __builder2.AddAttribute(16, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                                                     zoom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                                                                   new GoogleMapPosition() { Lat = 42.6977, Lng = 23.3219 }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "MapClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.GoogleMapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.GoogleMapClickEventArgs>(this, 
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                                                                                                                                       OnMapClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(19, "MarkerClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenGoogleMapMarker>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenGoogleMapMarker>(this, 
#nullable restore
#line 9 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                                                                                                                                                               OnMarkerClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(20, "Markers", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(21);
                    __builder3.AddAttribute(22, "Title", "London");
                    __builder3.AddAttribute(23, "Label", "London");
                    __builder3.AddAttribute(24, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 11 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                                                                                new GoogleMapPosition() { Lat = 51.5074, Lng = 0.1278 }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(26);
                    __builder3.AddAttribute(27, "Title", "Paris ");
                    __builder3.AddAttribute(28, "Label", "Paris");
                    __builder3.AddAttribute(29, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 12 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                                                                               new GoogleMapPosition() { Lat = 48.8566, Lng = 2.3522 }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 13 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                 if (showMadridMarker)
                { 

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(30);
                    __builder3.AddAttribute(31, "Title", "Madrid ");
                    __builder3.AddAttribute(32, "Label", "Madrid");
                    __builder3.AddAttribute(33, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 15 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                                                                                     new GoogleMapPosition() { Lat = 40.4168, Lng = -3.7038 }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 16 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-xl-6");
                __builder2.OpenComponent<RadzenBlazorDemos.Shared.EventConsole>(37);
                __builder2.AddComponentReferenceCapture(38, (__value) => {
#nullable restore
#line 21 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
                            console = (RadzenBlazorDemos.Shared.EventConsole)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\GoogleMapPage.razor"
       
    int zoom = 3;
    bool showMadridMarker;
    EventConsole console;

    void OnMapClick(GoogleMapClickEventArgs args)
    {
        console.Log($"Map clicked at Lat: {args.Position.Lat}, Lng: {args.Position.Lng}");
    }

    void OnMarkerClick(RadzenGoogleMapMarker marker)
    {
        console.Log($"Map {marker.Title} marker clicked. Marker position -> Lat: {marker.Position.Lat}, Lng: {marker.Position.Lng}");
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.RadzenBlazorDemos.Pages.GoogleMapPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenCheckBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
