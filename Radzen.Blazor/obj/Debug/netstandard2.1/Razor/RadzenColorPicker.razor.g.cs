#pragma checksum "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05d1aea87206f04f07f62c637f7915a21bae9468"
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
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
#line 2 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#line 3 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class RadzenColorPicker : FormComponent<string>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 6 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                              Style

#line default
#line hidden
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                              Toggle

#line default
#line hidden
            ));
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                  Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "class", 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                                    GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(6, "id", 
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                                                      GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(7, (__value) => {
#line 8 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
               Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(8, "\n");
#line 9 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
         if(Icon != null)
        {

#line default
#line hidden
            __builder.AddContent(9, "            ");
            __builder.OpenElement(10, "i");
            __builder.AddAttribute(11, "class", "rzi");
            __builder.AddContent(12, 
#line 11 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                            Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
#line 12 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
        }

#line default
#line hidden
            __builder.AddContent(14, "        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "rz-colorpicker-value");
            __builder.AddAttribute(17, "style", "background-color:" + " " + (
#line 13 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                    Color

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "tabindex", "-1");
            __builder.AddAttribute(22, "class", "rz-colorpicker-trigger");
            __builder.AddAttribute(23, "disabled", 
#line 14 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                                     Disabled

#line default
#line hidden
            );
            __builder.AddEventPreventDefaultAttribute(24, "onclick", true);
            __builder.AddMarkupContent(25, "<i class=\"rzi\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.Popup>(27);
            __builder.AddAttribute(28, "class", "rz-colorpicker-popup");
            __builder.AddAttribute(29, "Close", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                               Close

#line default
#line hidden
            )));
            __builder.AddAttribute(30, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                           Open

#line default
#line hidden
            )));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "\n");
#line 16 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
             if (ShowHSV)
            {

#line default
#line hidden
                __builder2.AddContent(33, "                ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.Draggable>(34);
                __builder2.AddAttribute(35, "class", "rz-saturation-picker rz-colorpicker-section");
                __builder2.AddAttribute(36, "style", 
#line 18 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                                       $"background-color: {HSV.ToRGB().ToCSS()}"

#line default
#line hidden
                );
                __builder2.AddAttribute(37, "Drag", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.Rendering.DraggableEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.Rendering.DraggableEventArgs>(this, 
#line 18 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                                                                                         OnSaturationMove

#line default
#line hidden
                )));
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(39, "\n                    ");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "class", "rz-saturation-white");
                    __builder3.AddMarkupContent(42, "\n                        <div class=\"rz-saturation-black\"></div>\n                        ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "rz-saturation-handle");
                    __builder3.AddAttribute(45, "style", 
#line 21 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                  $"top: {(SaturationHandleTop*100).ToInvariantString()}%; left: {(SaturationHandleLeft * 100).ToInvariantString()}%"

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "rz-colorpicker-preview-area rz-colorpicker-section");
                __builder2.AddMarkupContent(51, "\n                    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "rz-hue-and-alpha");
                __builder2.AddMarkupContent(54, "\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.Draggable>(55);
                __builder2.AddAttribute(56, "class", "rz-hue-picker");
                __builder2.AddAttribute(57, "Drag", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.Rendering.DraggableEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.Rendering.DraggableEventArgs>(this, 
#line 26 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                               OnHueMove

#line default
#line hidden
                )));
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "\n                            ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "rz-hue-handle");
                    __builder3.AddAttribute(62, "style", 
#line 27 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                               $"top: 0; left: {(HueHandleLeft * 100).ToInvariantString()}%"

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.Draggable>(65);
                __builder2.AddAttribute(66, "style", 
#line 29 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                           $"background-image: linear-gradient(to right, {AlphaGradientStart} 0%, {AlphaGradientEnd} 100%)"

#line default
#line hidden
                );
                __builder2.AddAttribute(67, "class", "rz-alpha-picker");
                __builder2.AddAttribute(68, "Drag", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.Rendering.DraggableEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.Rendering.DraggableEventArgs>(this, 
#line 29 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                                                                                                                           OnAlphaMove

#line default
#line hidden
                )));
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(70, "\n                            ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "class", "rz-alpha-handle");
                    __builder3.AddAttribute(73, "style", 
#line 30 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                 $"top: 0; left: {(AlphaHandleLeft * 100).ToInvariantString()}%"

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n                    ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "rz-colorpicker-preview");
                __builder2.AddAttribute(79, "style", 
#line 33 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                $"background-color: {Color}"

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\n");
#line 35 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
            }

#line default
#line hidden
#line 36 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
             if (ShowRGBA)
            {

#line default
#line hidden
                __builder2.AddContent(82, "                ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "rz-colorpicker-rgba rz-colorpicker-section");
                __builder2.AddEventStopPropagationAttribute(85, "onmousedown", true);
                __builder2.AddMarkupContent(86, " \n                    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "rz-color-box");
                __builder2.AddMarkupContent(89, "\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(90);
                __builder2.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 40 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                              Hex

#line default
#line hidden
                ));
                __builder2.AddAttribute(92, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 40 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                             args => ChangeRGB(args.Value)

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\n                        ");
                __builder2.AddContent(94, 
#line 41 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                         HexText

#line default
#line hidden
                );
                __builder2.AddMarkupContent(95, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\n                    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "rz-color-box");
                __builder2.AddMarkupContent(99, "\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<double>>(100);
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double>(
#line 44 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                              Red

#line default
#line hidden
                ));
                __builder2.AddAttribute(102, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal?>(
#line 44 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                       0

#line default
#line hidden
                ));
                __builder2.AddAttribute(103, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal?>(
#line 44 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                               255

#line default
#line hidden
                ));
                __builder2.AddAttribute(104, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 45 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                       args => ChangeColor(args.Value, (color, value) => color.Red = value)

#line default
#line hidden
                ));
                __builder2.AddAttribute(105, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, 
#line 46 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                     red => ChangeColor(red, (color, value) => color.Red = value)

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\n                        ");
                __builder2.AddContent(107, 
#line 48 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                         RedText

#line default
#line hidden
                );
                __builder2.AddMarkupContent(108, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\n                    ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "rz-color-box");
                __builder2.AddMarkupContent(112, "\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<double>>(113);
                __builder2.AddAttribute(114, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double>(
#line 51 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                              Green

#line default
#line hidden
                ));
                __builder2.AddAttribute(115, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal?>(
#line 51 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                         0

#line default
#line hidden
                ));
                __builder2.AddAttribute(116, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal?>(
#line 51 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                                 255

#line default
#line hidden
                ));
                __builder2.AddAttribute(117, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 52 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                       args => ChangeColor(args.Value, (color, value) => color.Green = value)

#line default
#line hidden
                ));
                __builder2.AddAttribute(118, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, 
#line 53 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                     green => ChangeColor(green, (color, value) => color.Green = value)

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\n                        ");
                __builder2.AddContent(120, 
#line 55 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                         GreenText

#line default
#line hidden
                );
                __builder2.AddMarkupContent(121, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\n                    ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "rz-color-box");
                __builder2.AddMarkupContent(125, "\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<double>>(126);
                __builder2.AddAttribute(127, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double>(
#line 58 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                              Blue

#line default
#line hidden
                ));
                __builder2.AddAttribute(128, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal?>(
#line 58 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                        0

#line default
#line hidden
                ));
                __builder2.AddAttribute(129, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal?>(
#line 58 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                                255

#line default
#line hidden
                ));
                __builder2.AddAttribute(130, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 59 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                       args => ChangeColor(args.Value, (color, value) => color.Blue = value)

#line default
#line hidden
                ));
                __builder2.AddAttribute(131, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, 
#line 60 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                     blue => ChangeColor(blue, (color, value) => color.Blue = value)

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "\n                        ");
                __builder2.AddContent(133, 
#line 62 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                         BlueText

#line default
#line hidden
                );
                __builder2.AddMarkupContent(134, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\n                    ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "rz-color-box");
                __builder2.AddMarkupContent(138, "\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<double>>(139);
                __builder2.AddAttribute(140, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double>(
#line 65 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                              Alpha

#line default
#line hidden
                ));
                __builder2.AddAttribute(141, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal?>(
#line 65 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                         0

#line default
#line hidden
                ));
                __builder2.AddAttribute(142, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal?>(
#line 65 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                                 100

#line default
#line hidden
                ));
                __builder2.AddAttribute(143, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 66 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                       args => ChangeAlpha(args.Value)

#line default
#line hidden
                ));
                __builder2.AddAttribute(144, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, 
#line 67 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                     alpha => ChangeAlpha(alpha)

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(145, "\n                        ");
                __builder2.AddContent(146, 
#line 69 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                         AlphaText

#line default
#line hidden
                );
                __builder2.AddMarkupContent(147, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\n");
#line 72 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
            }

#line default
#line hidden
#line 73 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
             if (ShowColors)
            {

#line default
#line hidden
                __builder2.AddContent(150, "                ");
                __builder2.OpenElement(151, "div");
                __builder2.AddAttribute(152, "class", "rz-colorpicker-colors rz-colorpicker-section");
                __builder2.AddMarkupContent(153, "\n                    ");
                __Blazor.Radzen.Blazor.RadzenColorPicker.TypeInference.CreateCascadingValue_0(__builder2, 154, 155, 
#line 76 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                           this

#line default
#line hidden
                , 156, (__builder3) => {
                    __builder3.AddMarkupContent(157, "\n");
#line 77 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                     if (ChildContent != null)
                    {
                        

#line default
#line hidden
                    __builder3.AddContent(158, 
#line 79 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                         ChildContent

#line default
#line hidden
                    );
#line 79 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                     
                    }
                    else
                    {

#line default
#line hidden
                    __builder3.AddContent(159, "                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(160);
                    __builder3.AddAttribute(161, "Value", "ff2800");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(162, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(163);
                    __builder3.AddAttribute(164, "Value", "fe9300");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(165, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(166);
                    __builder3.AddAttribute(167, "Value", "fefb00");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(168, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(169);
                    __builder3.AddAttribute(170, "Value", "02f900");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(171, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(172);
                    __builder3.AddAttribute(173, "Value", "00fdff");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(174, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(175);
                    __builder3.AddAttribute(176, "Value", "0433ff");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(177, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(178);
                    __builder3.AddAttribute(179, "Value", "ff40ff");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(180, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(181);
                    __builder3.AddAttribute(182, "Value", "942292");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(183, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(184);
                    __builder3.AddAttribute(185, "Value", "aa7942");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(186, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(187);
                    __builder3.AddAttribute(188, "Value", "ffffff");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(189, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(190);
                    __builder3.AddAttribute(191, "Value", "000000");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(192, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(193);
                    __builder3.AddAttribute(194, "Value", "53d5fd");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(195, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(196);
                    __builder3.AddAttribute(197, "Value", "73a7fe");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(198, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(199);
                    __builder3.AddAttribute(200, "Value", "874efe");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(201, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(202);
                    __builder3.AddAttribute(203, "Value", "d357fe");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(204, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(205);
                    __builder3.AddAttribute(206, "Value", "ed719e");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(207, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(208);
                    __builder3.AddAttribute(209, "Value", "ff8c82");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(210, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(211);
                    __builder3.AddAttribute(212, "Value", "ffa57d");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(213, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(214);
                    __builder3.AddAttribute(215, "Value", "ffc677");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(216, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(217);
                    __builder3.AddAttribute(218, "Value", "fff995");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(219, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(220);
                    __builder3.AddAttribute(221, "Value", "ebf38f");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(222, "\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColorPickerItem>(223);
                    __builder3.AddAttribute(224, "Value", "b1dd8c");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(225, "\n");
#line 105 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                    }

#line default
#line hidden
                    __builder3.AddContent(226, "                    ");
                }
                );
                __builder2.AddMarkupContent(227, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(228, "\n");
#line 108 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"

            }

#line default
#line hidden
#line 110 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
             if(ShowButton)
            {

#line default
#line hidden
                __builder2.AddContent(229, "                ");
                __builder2.OpenElement(230, "div");
                __builder2.AddAttribute(231, "class", "rz-colorpicker-button rz-colorpicker-section");
                __builder2.AddMarkupContent(232, "\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(233);
                __builder2.AddAttribute(234, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 113 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                               ButtonStyle.Primary

#line default
#line hidden
                ));
                __builder2.AddAttribute(235, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 113 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                           OnClick

#line default
#line hidden
                )));
                __builder2.AddAttribute(236, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 113 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                                                                                         ButtonText

#line default
#line hidden
                ));
                __builder2.AddEventPreventDefaultAttribute(237, "onclick", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(238, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(239, "\n");
#line 115 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
            }

#line default
#line hidden
                __builder2.AddContent(240, "        ");
            }
            ));
            __builder.AddComponentReferenceCapture(241, (__value) => {
#line 15 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
                     Popup = (Radzen.Blazor.Rendering.Popup)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(242, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(243, "\n");
#line 118 "D:\c#\radzen-blazor\Radzen.Blazor\RadzenColorPicker.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenColorPicker
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