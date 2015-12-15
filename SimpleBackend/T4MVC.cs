﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static SimpleBackend.Controllers.DemoController Demo = new SimpleBackend.Controllers.T4MVC_DemoController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext a) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string jquery_2_1_4_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.4.intellisense.min.js") ? Url("jquery-2.1.4.intellisense.min.js") : Url("jquery-2.1.4.intellisense.js");
        public static readonly string jquery_2_1_4_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.4.min.js") ? Url("jquery-2.1.4.min.js") : Url("jquery-2.1.4.js");
        public static readonly string jquery_2_1_4_min_js = Url("jquery-2.1.4.min.js");
        public static readonly string jquery_2_1_4_min_map = Url("jquery-2.1.4.min.map");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class plugins {
            private const string URLPATH = "~/Scripts/plugins";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class dataTables {
                private const string URLPATH = "~/Scripts/plugins/dataTables";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string dataTables_bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/dataTables.bootstrap.min.js") ? Url("dataTables.bootstrap.min.js") : Url("dataTables.bootstrap.js");
                public static readonly string jquery_dataTables_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.dataTables.min.js") ? Url("jquery.dataTables.min.js") : Url("jquery.dataTables.js");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class flot {
                private const string URLPATH = "~/Scripts/plugins/flot";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string excanvas_min_js = Url("excanvas.min.js");
                public static readonly string flot_data_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/flot-data.min.js") ? Url("flot-data.min.js") : Url("flot-data.js");
                public static readonly string jquery_flot_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.flot.min.js") ? Url("jquery.flot.min.js") : Url("jquery.flot.js");
                public static readonly string jquery_flot_pie_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.flot.pie.min.js") ? Url("jquery.flot.pie.min.js") : Url("jquery.flot.pie.js");
                public static readonly string jquery_flot_resize_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.flot.resize.min.js") ? Url("jquery.flot.resize.min.js") : Url("jquery.flot.resize.js");
                public static readonly string jquery_flot_tooltip_min_js = Url("jquery.flot.tooltip.min.js");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class metisMenu {
                private const string URLPATH = "~/Scripts/plugins/metisMenu";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string metisMenu_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/metisMenu.min.js") ? Url("metisMenu.min.js") : Url("metisMenu.js");
                public static readonly string metisMenu_min_js = Url("metisMenu.min.js");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class morris {
                private const string URLPATH = "~/Scripts/plugins/morris";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string morris_data_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/morris-data.min.js") ? Url("morris-data.min.js") : Url("morris-data.js");
                public static readonly string morris_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/morris.min.js") ? Url("morris.min.js") : Url("morris.js");
                public static readonly string raphael_min_js = Url("raphael.min.js");
            }
        
        }
    
        public static readonly string sb_admin_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/sb-admin-2.min.js") ? Url("sb-admin-2.min.js") : Url("sb-admin-2.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class bootstrap {
            private const string URLPATH = "~/Content/bootstrap";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string alerts_less = Url("alerts.less");
            public static readonly string badges_less = Url("badges.less");
            public static readonly string bootstrap_less = Url("bootstrap.less");
            public static readonly string breadcrumbs_less = Url("breadcrumbs.less");
            public static readonly string button_groups_less = Url("button-groups.less");
            public static readonly string buttons_less = Url("buttons.less");
            public static readonly string carousel_less = Url("carousel.less");
            public static readonly string close_less = Url("close.less");
            public static readonly string code_less = Url("code.less");
            public static readonly string component_animations_less = Url("component-animations.less");
            public static readonly string dropdowns_less = Url("dropdowns.less");
            public static readonly string forms_less = Url("forms.less");
            public static readonly string glyphicons_less = Url("glyphicons.less");
            public static readonly string grid_less = Url("grid.less");
            public static readonly string input_groups_less = Url("input-groups.less");
            public static readonly string jumbotron_less = Url("jumbotron.less");
            public static readonly string labels_less = Url("labels.less");
            public static readonly string list_group_less = Url("list-group.less");
            public static readonly string media_less = Url("media.less");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class mixins {
                private const string URLPATH = "~/Content/bootstrap/mixins";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string alerts_less = Url("alerts.less");
                public static readonly string background_variant_less = Url("background-variant.less");
                public static readonly string border_radius_less = Url("border-radius.less");
                public static readonly string buttons_less = Url("buttons.less");
                public static readonly string center_block_less = Url("center-block.less");
                public static readonly string clearfix_less = Url("clearfix.less");
                public static readonly string forms_less = Url("forms.less");
                public static readonly string gradients_less = Url("gradients.less");
                public static readonly string grid_framework_less = Url("grid-framework.less");
                public static readonly string grid_less = Url("grid.less");
                public static readonly string hide_text_less = Url("hide-text.less");
                public static readonly string image_less = Url("image.less");
                public static readonly string labels_less = Url("labels.less");
                public static readonly string list_group_less = Url("list-group.less");
                public static readonly string nav_divider_less = Url("nav-divider.less");
                public static readonly string nav_vertical_align_less = Url("nav-vertical-align.less");
                public static readonly string opacity_less = Url("opacity.less");
                public static readonly string pagination_less = Url("pagination.less");
                public static readonly string panels_less = Url("panels.less");
                public static readonly string progress_bar_less = Url("progress-bar.less");
                public static readonly string reset_filter_less = Url("reset-filter.less");
                public static readonly string reset_text_less = Url("reset-text.less");
                public static readonly string resize_less = Url("resize.less");
                public static readonly string responsive_visibility_less = Url("responsive-visibility.less");
                public static readonly string size_less = Url("size.less");
                public static readonly string tab_focus_less = Url("tab-focus.less");
                public static readonly string table_row_less = Url("table-row.less");
                public static readonly string text_emphasis_less = Url("text-emphasis.less");
                public static readonly string text_overflow_less = Url("text-overflow.less");
                public static readonly string vendor_prefixes_less = Url("vendor-prefixes.less");
            }
        
            public static readonly string mixins_less = Url("mixins.less");
            public static readonly string modals_less = Url("modals.less");
            public static readonly string navbar_less = Url("navbar.less");
            public static readonly string navs_less = Url("navs.less");
            public static readonly string normalize_less = Url("normalize.less");
            public static readonly string pager_less = Url("pager.less");
            public static readonly string pagination_less = Url("pagination.less");
            public static readonly string panels_less = Url("panels.less");
            public static readonly string popovers_less = Url("popovers.less");
            public static readonly string print_less = Url("print.less");
            public static readonly string progress_bars_less = Url("progress-bars.less");
            public static readonly string responsive_embed_less = Url("responsive-embed.less");
            public static readonly string responsive_utilities_less = Url("responsive-utilities.less");
            public static readonly string scaffolding_less = Url("scaffolding.less");
            public static readonly string tables_less = Url("tables.less");
            public static readonly string theme_less = Url("theme.less");
            public static readonly string thumbnails_less = Url("thumbnails.less");
            public static readonly string tooltip_less = Url("tooltip.less");
            public static readonly string type_less = Url("type.less");
            public static readonly string utilities_less = Url("utilities.less");
            public static readonly string variables_less = Url("variables.less");
            public static readonly string wells_less = Url("wells.less");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class fontawesome {
            private const string URLPATH = "~/Content/fontawesome";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string animated_less = Url("animated.less");
            public static readonly string bordered_pulled_less = Url("bordered-pulled.less");
            public static readonly string core_less = Url("core.less");
            public static readonly string fixed_width_less = Url("fixed-width.less");
            public static readonly string font_awesome_less = Url("font-awesome.less");
            public static readonly string icons_less = Url("icons.less");
            public static readonly string larger_less = Url("larger.less");
            public static readonly string list_less = Url("list.less");
            public static readonly string mixins_less = Url("mixins.less");
            public static readonly string path_less = Url("path.less");
            public static readonly string rotated_flipped_less = Url("rotated-flipped.less");
            public static readonly string stacked_less = Url("stacked.less");
            public static readonly string variables_less = Url("variables.less");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class fonts {
            private const string URLPATH = "~/Content/fonts";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string fontawesome_webfont_eot = Url("fontawesome-webfont.eot");
            public static readonly string fontawesome_webfont_svg = Url("fontawesome-webfont.svg");
            public static readonly string fontawesome_webfont_ttf = Url("fontawesome-webfont.ttf");
            public static readonly string fontawesome_webfont_woff = Url("fontawesome-webfont.woff");
            public static readonly string fontawesome_webfont_woff2 = Url("fontawesome-webfont.woff2");
            public static readonly string FontAwesome_otf = Url("FontAwesome.otf");
            public static readonly string glyphicons_halflings_regular_eot = Url("glyphicons-halflings-regular.eot");
            public static readonly string glyphicons_halflings_regular_svg = Url("glyphicons-halflings-regular.svg");
            public static readonly string glyphicons_halflings_regular_ttf = Url("glyphicons-halflings-regular.ttf");
            public static readonly string glyphicons_halflings_regular_woff = Url("glyphicons-halflings-regular.woff");
            public static readonly string glyphicons_halflings_regular_woff2 = Url("glyphicons-halflings-regular.woff2");
        }
    
        public static readonly string mixins_less = Url("mixins.less");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class plugins {
            private const string URLPATH = "~/Content/plugins";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string dataTables_bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/dataTables.bootstrap.min.css") ? Url("dataTables.bootstrap.min.css") : Url("dataTables.bootstrap.css");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class metisMenu {
                private const string URLPATH = "~/Content/plugins/metisMenu";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string metisMenu_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/metisMenu.min.css") ? Url("metisMenu.min.css") : Url("metisMenu.css");
                public static readonly string metisMenu_min_css = Url("metisMenu.min.css");
            }
        
            public static readonly string morris_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/morris.min.css") ? Url("morris.min.css") : Url("morris.css");
            public static readonly string social_buttons_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/social-buttons.min.css") ? Url("social-buttons.min.css") : Url("social-buttons.css");
            public static readonly string timeline_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/timeline.min.css") ? Url("timeline.min.css") : Url("timeline.css");
        }
    
        public static readonly string sb_admin_2_less = Url("sb-admin-2.less");
        public static readonly string sb_admin_2_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/sb-admin-2.min.css") ? Url("sb-admin-2.min.css") : Url("sb-admin-2.css");
        public static readonly string sb_admin_2_css_map = Url("sb-admin-2.css.map");
        public static readonly string sb_admin_2_min_css = Url("sb-admin-2.min.css");
        public static readonly string variables_less = Url("variables.less");
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static partial class plugins 
            {
                public static partial class dataTables 
                {
                    public static class Assets
                    {
                        public const string dataTables_bootstrap_js = "~/Scripts/plugins/dataTables/dataTables.bootstrap.js"; 
                        public const string jquery_dataTables_js = "~/Scripts/plugins/dataTables/jquery.dataTables.js"; 
                    }
                }
                public static partial class flot 
                {
                    public static class Assets
                    {
                        public const string excanvas_min_js = "~/Scripts/plugins/flot/excanvas.min.js"; 
                        public const string flot_data_js = "~/Scripts/plugins/flot/flot-data.js"; 
                        public const string jquery_flot_js = "~/Scripts/plugins/flot/jquery.flot.js"; 
                        public const string jquery_flot_pie_js = "~/Scripts/plugins/flot/jquery.flot.pie.js"; 
                        public const string jquery_flot_resize_js = "~/Scripts/plugins/flot/jquery.flot.resize.js"; 
                        public const string jquery_flot_tooltip_min_js = "~/Scripts/plugins/flot/jquery.flot.tooltip.min.js"; 
                    }
                }
                public static partial class metisMenu 
                {
                    public static class Assets
                    {
                        public const string metisMenu_js = "~/Scripts/plugins/metisMenu/metisMenu.js"; 
                        public const string metisMenu_min_js = "~/Scripts/plugins/metisMenu/metisMenu.min.js"; 
                    }
                }
                public static partial class morris 
                {
                    public static class Assets
                    {
                        public const string morris_data_js = "~/Scripts/plugins/morris/morris-data.js"; 
                        public const string morris_js = "~/Scripts/plugins/morris/morris.js"; 
                        public const string raphael_min_js = "~/Scripts/plugins/morris/raphael.min.js"; 
                    }
                }
                public static class Assets
                {
                }
            }
            public static class Assets
            {
                public const string bootstrap_js = "~/Scripts/bootstrap.js"; 
                public const string bootstrap_min_js = "~/Scripts/bootstrap.min.js"; 
                public const string jquery_2_1_4_intellisense_js = "~/Scripts/jquery-2.1.4.intellisense.js"; 
                public const string jquery_2_1_4_js = "~/Scripts/jquery-2.1.4.js"; 
                public const string jquery_2_1_4_min_js = "~/Scripts/jquery-2.1.4.min.js"; 
                public const string sb_admin_2_js = "~/Scripts/sb-admin-2.js"; 
            }
        }
        public static partial class Content 
        {
            public static partial class bootstrap 
            {
                public static partial class mixins 
                {
                    public static class Assets
                    {
                    }
                }
                public static class Assets
                {
                }
            }
            public static partial class fontawesome 
            {
                public static class Assets
                {
                }
            }
            public static partial class fonts 
            {
                public static class Assets
                {
                }
            }
            public static partial class plugins 
            {
                public static partial class metisMenu 
                {
                    public static class Assets
                    {
                        public const string metisMenu_css = "~/Content/plugins/metisMenu/metisMenu.css";
                        public const string metisMenu_min_css = "~/Content/plugins/metisMenu/metisMenu.min.css";
                    }
                }
                public static class Assets
                {
                    public const string dataTables_bootstrap_css = "~/Content/plugins/dataTables.bootstrap.css";
                    public const string morris_css = "~/Content/plugins/morris.css";
                    public const string social_buttons_css = "~/Content/plugins/social-buttons.css";
                    public const string timeline_css = "~/Content/plugins/timeline.css";
                }
            }
            public static class Assets
            {
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114

