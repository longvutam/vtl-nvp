#pragma checksum "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c93d73c7b70f4b5a70d4bff4befd919f06786d37"
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
#line 2 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/styling-gauge")]
    public partial class StylingGaugePage : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Radzen Blazor Gauge Styling</h1>\n");
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(1);
            __builder.AddAttribute(2, "Name", "Gauge");
            __builder.AddAttribute(3, "Source", "StylingGauge");
            __builder.AddAttribute(4, "Heading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                           false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-6 col-sm-12 p-4");
                __builder2.AddMarkupContent(10, "<h3>Clock</h3>\n            ");
                __builder2.AddMarkupContent(11, "<p>\n                Demonstrates using multiple pointers with RadzenRadialGauge.\n            </p>\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRadialGauge>(12);
                __builder2.AddAttribute(13, "Style", "width: 100%; height: 500px;");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRadialGaugeScale>(15);
                    __builder3.AddAttribute(16, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                              1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                      0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                              12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "StartAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                              0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "EndAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                           360

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "ShowFirstTick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                                               false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "MinorStep", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 14 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                               minorStep

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "TickLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 15 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                20

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "MinorTickLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                     10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "TickLabelOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 17 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                     40

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "TickPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.GaugeTickPosition>(
#nullable restore
#line 18 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                  GaugeTickPosition.Inside

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenRadialGaugeScalePointer>(28);
                        __builder4.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                          hours

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                        0.6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "ShowValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                        false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\n                    ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenRadialGaugeScalePointer>(33);
                        __builder4.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 20 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                          seconds

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(35, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 20 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                          0.9

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "Fill", "red");
                        __builder4.AddAttribute(37, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#nullable restore
#line 20 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "ShowValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                                               false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(39, "\n                    ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenRadialGaugeScalePointer>(40);
                        __builder4.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 21 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                          minutes

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(42, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 21 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                          0.8

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "ShowValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                          false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "col-md-6 col-sm-12 p-4");
                __builder2.AddMarkupContent(47, "<h3>Activity</h3>\n            ");
                __builder2.AddMarkupContent(48, "<p>\n                Shows how to use multiple scales with RadzenArcGauge\n            </p>\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenArcGauge>(49);
                __builder2.AddAttribute(50, "Style", "width: 100%; height: 500px; background: #000");
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenArcGaugeScale>(52);
                    __builder3.AddAttribute(53, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 31 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                          0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 31 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                  520

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "StartAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 31 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                   0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "EndAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 31 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                360

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Fill", "rgba(249, 32, 99, 0.5)");
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenArcGaugeScaleValue>(59);
                        __builder4.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 32 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                     move

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(61, "Fill", "rgb(249, 32, 99)");
                        __builder4.AddAttribute(62, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.RadzenArcGaugeScaleValue>)((context) => (__builder5) => {
                            __builder5.OpenElement(63, "svg");
                            __builder5.AddAttribute(64, "width", "100%");
                            __builder5.AddAttribute(65, "viewBox", "0 0 240 120");
                            __builder5.OpenElement(66, "text");
                            __builder5.AddAttribute(67, "x", "90");
                            __builder5.AddAttribute(68, "y", "10");
                            __builder5.AddAttribute(69, "fill", "#fff");
                            __builder5.AddMarkupContent(70, "\n                                    Move ");
                            __builder5.OpenElement(71, "tspan");
                            __builder5.AddAttribute(72, "fill", "rgb(249, 32, 99)");
                            __builder5.AddContent(73, 
#nullable restore
#line 36 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                          Math.Round(move/520 * 100)

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(74, "%");
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(75, "\n                                ");
                            __builder5.OpenElement(76, "text");
                            __builder5.AddAttribute(77, "x", "90");
                            __builder5.AddAttribute(78, "y", "28");
                            __builder5.AddAttribute(79, "fill", "rgb(249, 32, 99)");
                            __builder5.AddContent(80, 
#nullable restore
#line 39 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                     move

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddMarkupContent(81, "/520 cal \n                                ");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(82, "\n                                ");
                            __builder5.OpenElement(83, "text");
                            __builder5.AddAttribute(84, "x", "90");
                            __builder5.AddAttribute(85, "y", "50");
                            __builder5.AddAttribute(86, "fill", "#fff");
                            __builder5.AddMarkupContent(87, "\n                                    Exercise ");
                            __builder5.OpenElement(88, "tspan");
                            __builder5.AddAttribute(89, "fill", "rgb(203, 255, 0)");
                            __builder5.AddContent(90, 
#nullable restore
#line 42 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                              Math.Round(exercise/30 * 100)

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(91, "%");
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(92, "\n                                ");
                            __builder5.OpenElement(93, "text");
                            __builder5.AddAttribute(94, "x", "90");
                            __builder5.AddAttribute(95, "y", "68");
                            __builder5.AddAttribute(96, "fill", "rgb(203, 255, 0)");
                            __builder5.AddContent(97, 
#nullable restore
#line 45 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                     exercise

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddMarkupContent(98, "/30 min \n                                ");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(99, "\n                                ");
                            __builder5.OpenElement(100, "text");
                            __builder5.AddAttribute(101, "x", "90");
                            __builder5.AddAttribute(102, "y", "88");
                            __builder5.AddAttribute(103, "fill", "#fff");
                            __builder5.AddMarkupContent(104, "\n                                    Stand ");
                            __builder5.OpenElement(105, "tspan");
                            __builder5.AddAttribute(106, "fill", "rgb(0, 253, 234)");
                            __builder5.AddContent(107, 
#nullable restore
#line 48 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                           Math.Round(stand/12 * 100)

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(108, "%");
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(109, "\n                                ");
                            __builder5.OpenElement(110, "text");
                            __builder5.AddAttribute(111, "x", "90");
                            __builder5.AddAttribute(112, "y", "106");
                            __builder5.AddAttribute(113, "fill", "rgb(0, 253, 234)");
                            __builder5.AddContent(114, 
#nullable restore
#line 51 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                     stand

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddMarkupContent(115, "/12 hr \n                                ");
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(116, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenArcGaugeScale>(117);
                    __builder3.AddAttribute(118, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 57 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                          0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 57 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                  30

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(120, "StartAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 57 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                  0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(121, "EndAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 57 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                               360

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(122, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 57 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                            0.8

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(123, "Fill", "rgba(203, 255, 0, 0.5)");
                    __builder3.AddAttribute(124, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenArcGaugeScaleValue>(125);
                        __builder4.AddAttribute(126, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 58 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                     exercise

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(127, "Fill", "rgb(203, 255, 0)");
                        __builder4.AddAttribute(128, "ShowValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                                 false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(129, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenArcGaugeScale>(130);
                    __builder3.AddAttribute(131, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 60 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                          0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(132, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 60 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                  12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(133, "StartAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 60 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                  0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(134, "EndAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 60 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                               360

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(135, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 60 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                            0.6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(136, "Fill", "rgb(0, 253, 234, 0.5)");
                    __builder3.AddAttribute(137, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenArcGaugeScaleValue>(138);
                        __builder4.AddAttribute(139, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 61 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                     stand

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(140, "Fill", "rgb(0, 253, 234)");
                        __builder4.AddAttribute(141, "ShowValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 61 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "D:\c#\radzen-blazor\RadzenBlazorDemos\Pages\StylingGaugePage.razor"
       
    Timer timer;
    double hours;
    double minutes;
    double seconds;

    double minorStep = 12 / 60.0;

    double move = 338;
    double exercise = 2;
    double stand = 8;

    protected override void OnInitialized()
    {
        timer = new Timer(state =>
        {
            var now = DateTime.Now;

            hours = now.Hour % 12 + now.Minute / 60.0;

            minutes = now.Minute * minorStep + now.Second * 12 / 3600.0;
            seconds = now.Second * minorStep;

            InvokeAsync(StateHasChanged);
        }, null, 0, 1000);
    }

    public void Dispose()
    {
        timer.Dispose();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
