#pragma checksum "D:\c#\blazor\vtl-nvp\RadzenBlazorDemos\Pages\PanelMenuPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30329509bc5a2de78840e8d6ed5798e524e577ab"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/panelmenu")]
    public partial class PanelMenuPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RadzenBlazorDemos.Shared.RadzenExample>(0);
            __builder.AddAttribute(1, "Name", "PanelMenu");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(3);
                __builder2.AddAttribute(4, "Style", "min-height: 500px");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(6);
                    __builder3.AddAttribute(7, "Style", "width:300px");
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(9);
                        __builder4.AddAttribute(10, "Text", "General");
                        __builder4.AddAttribute(11, "Icon", "home");
                        __builder4.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(13);
                            __builder5.AddAttribute(14, "Text", "Buttons");
                            __builder5.AddAttribute(15, "Path", "buttons");
                            __builder5.AddAttribute(16, "Icon", "account_circle");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(17, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(18);
                            __builder5.AddAttribute(19, "Text", "Menu");
                            __builder5.AddAttribute(20, "Path", "menu");
                            __builder5.AddAttribute(21, "Icon", "line_weight");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(22, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(23);
                            __builder5.AddAttribute(24, "Text", "FileInput");
                            __builder5.AddAttribute(25, "Path", "fileinput");
                            __builder5.AddAttribute(26, "Icon", "attach_file");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(27, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(28);
                            __builder5.AddAttribute(29, "Text", "Dialog");
                            __builder5.AddAttribute(30, "Path", "dialog");
                            __builder5.AddAttribute(31, "Icon", "perm_media");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(32, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(33);
                            __builder5.AddAttribute(34, "Text", "Notification");
                            __builder5.AddAttribute(35, "Path", "notification");
                            __builder5.AddAttribute(36, "Icon", "announcement");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(38);
                        __builder4.AddAttribute(39, "Text", "Inputs");
                        __builder4.AddAttribute(40, "Icon", "payment");
                        __builder4.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(42);
                            __builder5.AddAttribute(43, "Text", "CheckBox");
                            __builder5.AddAttribute(44, "Path", "checkbox");
                            __builder5.AddAttribute(45, "Icon", "check_circle");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(46, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(47);
                            __builder5.AddAttribute(48, "Text", "TextBox");
                            __builder5.AddAttribute(49, "Path", "textbox");
                            __builder5.AddAttribute(50, "Icon", "input");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(51, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(52);
                            __builder5.AddAttribute(53, "Text", "TextArea");
                            __builder5.AddAttribute(54, "Path", "textarea");
                            __builder5.AddAttribute(55, "Icon", "description");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(56, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(57);
                            __builder5.AddAttribute(58, "Text", "Password");
                            __builder5.AddAttribute(59, "Path", "password");
                            __builder5.AddAttribute(60, "Icon", "payment");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(61, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(62);
                            __builder5.AddAttribute(63, "Text", "Numeric");
                            __builder5.AddAttribute(64, "Path", "numeric");
                            __builder5.AddAttribute(65, "Icon", "aspect_ratio");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(66, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(67);
                            __builder5.AddAttribute(68, "Text", "DatePicker");
                            __builder5.AddAttribute(69, "Path", "datepicker");
                            __builder5.AddAttribute(70, "Icon", "date_range");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(71, "\r\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(72);
                        __builder4.AddAttribute(73, "Text", "Data");
                        __builder4.AddAttribute(74, "Icon", "save");
                        __builder4.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(76);
                            __builder5.AddAttribute(77, "Text", "DataGrid");
                            __builder5.AddAttribute(78, "Path", "datagrid");
                            __builder5.AddAttribute(79, "Icon", "grid_on");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(80, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(81);
                            __builder5.AddAttribute(82, "Text", "DataList");
                            __builder5.AddAttribute(83, "Path", "datalist");
                            __builder5.AddAttribute(84, "Icon", "list");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(85, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(86);
                            __builder5.AddAttribute(87, "Text", "DropDown");
                            __builder5.AddAttribute(88, "Path", "dropdown");
                            __builder5.AddAttribute(89, "Icon", "dns");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(90, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(91);
                            __builder5.AddAttribute(92, "Text", "DropDownDataGrid");
                            __builder5.AddAttribute(93, "Path", "dropdown-datagrid");
                            __builder5.AddAttribute(94, "Icon", "receipt");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(95, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(96);
                            __builder5.AddAttribute(97, "Text", "ListBox");
                            __builder5.AddAttribute(98, "Path", "listbox");
                            __builder5.AddAttribute(99, "Icon", "view_list");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(100, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(101);
                            __builder5.AddAttribute(102, "Text", "TemplateForm");
                            __builder5.AddAttribute(103, "Path", "templateform");
                            __builder5.AddAttribute(104, "Icon", "line_style");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(105, "\r\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(106);
                        __builder4.AddAttribute(107, "Text", "Containers");
                        __builder4.AddAttribute(108, "Icon", "account_box");
                        __builder4.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(110);
                            __builder5.AddAttribute(111, "Text", "Tabs");
                            __builder5.AddAttribute(112, "Path", "tabs");
                            __builder5.AddAttribute(113, "Icon", "tab");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(114, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(115);
                            __builder5.AddAttribute(116, "Text", "Panel");
                            __builder5.AddAttribute(117, "Path", "panel");
                            __builder5.AddAttribute(118, "Icon", "content_paste");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(119, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(120);
                            __builder5.AddAttribute(121, "Text", "Fieldset");
                            __builder5.AddAttribute(122, "Path", "fieldset");
                            __builder5.AddAttribute(123, "Icon", "account_balance_wallet");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(124, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(125);
                            __builder5.AddAttribute(126, "Text", "Card");
                            __builder5.AddAttribute(127, "Path", "card");
                            __builder5.AddAttribute(128, "Icon", "line_style");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(129, "\r\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(130);
                        __builder4.AddAttribute(131, "Text", "More");
                        __builder4.AddAttribute(132, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(133);
                            __builder5.AddAttribute(134, "Text", "Item1");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(135, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(136);
                            __builder5.AddAttribute(137, "Text", "Item2");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(138, "\r\n                ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(139);
                            __builder5.AddAttribute(140, "Text", "More items");
                            __builder5.AddAttribute(141, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(142);
                                __builder6.AddAttribute(143, "Text", "More sub items");
                                __builder6.AddAttribute(144, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(145);
                                    __builder7.AddAttribute(146, "Text", "Item1");
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(147, "\r\n                        ");
                                    __builder7.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(148);
                                    __builder7.AddAttribute(149, "Text", "Item2");
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
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
    }
}
#pragma warning restore 1591
