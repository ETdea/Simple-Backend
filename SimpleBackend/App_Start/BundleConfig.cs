﻿using System.Web.Optimization;

namespace SimpleBackend
{
    public class BundleConfig
    {
        private const string CSS_PATH = "~/Content/";
        private const string JS_PATH = "~/Scripts/";
        private const string ALL_JS = "*.js";

        #region source
        public struct Bootstrap
        {
            private const string CSS_PATH = BundleConfig.CSS_PATH + "bootstrap/";
            private const string JS_PATH = BundleConfig.JS_PATH;

            public struct Css
            {
                public const string VirtualPath = CSS_PATH + "bootstrap.css";
                public const string CDN = "//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css";
            }
            public struct Js
            {
                public const string VirtualPath = JS_PATH + "bootstrap.js";
                public const string CDN = "//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js";
            }
        }
        public struct SbAdmin2
        {
            private const string CSS_PATH = BundleConfig.CSS_PATH;
            private const string JS_PATH = BundleConfig.JS_PATH;

            public struct Css
            {
                public const string VirtualPath = CSS_PATH + "sb-admin-2.css";
            }

            public struct Js
            {
                public const string VirtualPath = JS_PATH + "sb-admin-2.js";
            }

            public struct Plugin
            {
                private const string CSS_PATH = SbAdmin2.CSS_PATH + "plugins/";
                private const string JS_PATH = SbAdmin2.JS_PATH + "plugins/";

                public struct MetisMenu
                {
                    private const string CSS_PATH = Plugin.CSS_PATH + "metisMenu/";
                    private const string JS_PATH = Plugin.JS_PATH + "metisMenu/";

                    public struct Css
                    {
                        public const string VirtualPath = CSS_PATH + "metisMenu.min.css";
                    }
                    public struct Js
                    {
                        public const string VirtualPath = JS_PATH + "metisMenu.min.js";
                    }
                }
                public struct TimeLine
                {
                    public struct Css
                    {
                        public const string VirtualPath = CSS_PATH + "timeline.css";
                    }
                }
                public struct Morris
                {
                    private const string JS_PATH = Plugin.JS_PATH + "morris/";

                    public struct Css
                    {
                        public const string VirtualPath = CSS_PATH + "morris.css";
                    }
                    public struct Js
                    {
                        public const string VirtualPath = JS_PATH + "morris.js";

                        static public string[] All
                        {
                            get
                            {
                                return new string[]{
                                        Rapheal.Js.VirtualPath,
                                        Js.VirtualPath,
                                        Data.Js.VirtualPath
                                    };
                            }
                        }
                    }
                    public struct Data
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "morris-data.js";
                        }
                    }
                    public struct Rapheal
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "raphael.min.js";
                        }
                    }
                }
                public struct SocialButtons
                {
                    public struct Css
                    {
                        public const string VirtualPath = CSS_PATH + "social-buttons.css";
                    }
                }
                public struct Flot
                {
                    private const string JS_PATH = Plugin.JS_PATH + "flot/";

                    public struct Js
                    {
                        public const string VirtualPath = JS_PATH + "jquery.flot.js";

                        static public string[] All
                        {
                            get
                            {
                                return new string[]{
                                        EXCANVAS.Js.VirtualPath,
                                        Js.VirtualPath,
                                        Pie.Js.VirtualPath,
                                        Resize.Js.VirtualPath,
                                        ToolTip.Js.VirtualPath,
                                        Data.Js.VirtualPath
                                    };
                            }
                        }
                    }
                    public struct EXCANVAS
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "excanvas.min.js";
                        }
                    }
                    public struct Data
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "flot-data.js";
                        }
                    }
                    public struct Pie
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "jquery.flot.pie.js";
                        }
                    }
                    public struct Resize
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "jquery.flot.resize.js";
                        }
                    }
                    public struct ToolTip
                    {
                        public struct Js
                        {
                            public const string VirtualPath = JS_PATH + "jquery.flot.tooltip.js";
                        }
                    }
                }
            }
        }
        public struct FontAwesome
        {
            const string CSS_PATH = BundleConfig.CSS_PATH + "fontawesome/";

            public struct Css
            {
                public const string VirtualPath = CSS_PATH + "font-awesome.min.css";
                public const string CDN = "//cdnjs.cloudflare.com/ajax/libs/font-awesome/4.4.0/css/font-awesome.min.css";
            }

        }
        public struct JQuery
        {
            private const string JS_PATH = BundleConfig.JS_PATH;

            public struct Js
            {
                public const string VirtualPath = JS_PATH + "jquery-{version}.js";
                public const string CDN = "//ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js";
            }

        }
        public struct Summernote
        {
            private const string CSS_PATH = BundleConfig.CSS_PATH;
            private const string JS_PATH = BundleConfig.JS_PATH + "summernote/";

            public struct Css
            {
                public const string VirtualPath = CSS_PATH + "summernote.css";
            }
            public struct Js
            {
                public const string VirtualPath = JS_PATH + "summernote.js";
            }
        }
        public struct ETdea
        {
            public const string JSDirectory = BundleConfig.JS_PATH + "ETdea/";

            public struct Js
            {
                public struct Plugins
                {
                    public const string Directory = ETdea.JSDirectory + "plugins/";

                    public struct Datatabel
                    {
                        public const string VirtualPath = Directory + "AutoDatatable.js";
                    }

                    public struct Summernote
                    {
                        public const string VirtualPath = Directory + "AutoSummernote.js";
                    }

                    public struct DateTimePicker
                    {
                        public const string VirtualPath = Directory + "AutoDateTimePicker.js";
                    }
                }
            }

        }
        public struct DataTable
        {
            private const string CSS_PATH = BundleConfig.CSS_PATH;
            private const string JS_PATH = BundleConfig.JS_PATH;

            public struct Css
            {
                public const string CDN = "//cdn.datatables.net/r/dt/dt-1.10.9/datatables.min.css";

                public struct Bootstrap
                {
                    public const string CDN = "//cdn.datatables.net/r/bs/dt-1.10.9/datatables.min.css";
                }
            }
            public struct Js
            {
                public const string CDN = "//cdn.datatables.net/r/dt/dt-1.10.9/datatables.min.js";

                public struct Bootstrap
                {
                    public const string CDN = "//cdn.datatables.net/r/bs/dt-1.10.9/datatables.min.js";
                }
            }
        }
        public struct AJASUnobtrusive
        {
            private const string JS_PATH = BundleConfig.JS_PATH;

            public struct Js
            {
                public const string VirtualPath = JS_PATH + "jquery.unobtrusive*";
                public const string CDN = "//ajax.aspnetcdn.com/ajax/mvc/5.2.3/jquery.validate.unobtrusive.min.js";
            }

        }
        public struct Validate
        {
            private const string JS_PATH = BundleConfig.JS_PATH;

            public struct Js
            {
                public const string VirtualPath = JS_PATH + "jquery.validate*";
                //public const string CDN = "//ajax.aspnetcdn.com/ajax/mvc/5.2.3/jquery.validate.unobtrusive.min.js";
            }

        }
        public struct DateTimePicker
        {
            private const string JSDirectory = BundleConfig.JS_PATH + "smalot-datetimepicker/";
            private const string CSSDirectory = BundleConfig.CSS_PATH + "smalot-datetimepicker/";

            public struct Js
            {
                public const string VirtualPath = JSDirectory + "bootstrap-datetimepicker.js";
            }
            public struct Css
            {
                public const string VirtualPath = CSSDirectory + "bootstrap-datetimepicker.css";
            }

        }
        #endregion

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;

            #region DataTable
            //bundles.Add(new ScriptBundle(ScriptName.Bundle.DataTable, DataTable.Js.CDN).Include(ScriptName.Bundle.ETdeaDataTable));
            bundles.Add(new ScriptBundle(ScriptName.Bundle.DataTableBootstrap, DataTable.Js.Bootstrap.CDN).Include(ETdea.Js.Plugins.Datatabel.VirtualPath));
            bundles.Add(new ScriptBundle(ScriptName.Bundle.ETdeaDataTable).Include(ETdea.Js.Plugins.Datatabel.VirtualPath));

            //bundles.Add(new StyleBundle(StyleName.Bundle.DataTable, DataTable.Css.CDN));
            bundles.Add(new StyleBundle(StyleName.Bundle.DataTableBootstrap, DataTable.Css.Bootstrap.CDN));
            #endregion

            #region Summernote
            bundles.Add(new ScriptBundle(ScriptName.Bundle.Summernote).Include(
                                Summernote.Js.VirtualPath,
                                ETdea.Js.Plugins.Summernote.VirtualPath
                                ));

            bundles.Add(new StyleBundle(StyleName.Bundle.Summernote).Include(Summernote.Css.VirtualPath));
            #endregion

            #region DateTimePicker
            bundles.Add(new ScriptBundle(ScriptName.Bundle.DateTimePicker).Include(
                                DateTimePicker.Js.VirtualPath,
                                ETdea.Js.Plugins.DateTimePicker.VirtualPath
                                ));

            bundles.Add(new StyleBundle(StyleName.Bundle.DateTimePicker).Include(DateTimePicker.Css.VirtualPath));
            #endregion


            bundles.Add(new ScriptBundle(ScriptName.Bundle.Validate).Include(Validate.Js.VirtualPath));
            bundles.Add(new ScriptBundle(ScriptName.Bundle.AJASUnobtrusive).Include(AJASUnobtrusive.Js.VirtualPath));

            bundles.Add(new ScriptBundle(ScriptName.Bundle.ETdea).IncludeDirectory(ETdea.JSDirectory, ALL_JS));
            bundles.Add(new ScriptBundle(ScriptName.Bundle.JQuery, JQuery.Js.CDN).Include(JQuery.Js.VirtualPath));
            bundles.Add(new ScriptBundle(ScriptName.Bundle.Bootstrap, Bootstrap.Js.CDN).Include(Bootstrap.Js.VirtualPath));
            bundles.Add(new ScriptBundle(ScriptName.Bundle.Flot).Include(SbAdmin2.Plugin.Flot.Js.All));
            bundles.Add(new ScriptBundle(ScriptName.Bundle.Morris).Include(SbAdmin2.Plugin.Morris.Js.All));
            bundles.Add(new ScriptBundle(ScriptName.Bundle.SbAdmin2).Include(
                                SbAdmin2.Plugin.MetisMenu.Js.VirtualPath,
                                SbAdmin2.Js.VirtualPath
                                ));

            bundles.Add(new StyleBundle(StyleName.Bundle.Morris).Include(SbAdmin2.Plugin.Morris.Css.VirtualPath));
            bundles.Add(new StyleBundle(StyleName.Bundle.SocialButtons).Include(SbAdmin2.Plugin.SocialButtons.Css.VirtualPath));
            bundles.Add(new StyleBundle(StyleName.Bundle.Bootstrap, Bootstrap.Css.CDN).Include(Bootstrap.Css.VirtualPath));
            bundles.Add(new StyleBundle(StyleName.Bundle.FontAwesome, FontAwesome.Css.CDN).Include(FontAwesome.Css.VirtualPath));
            bundles.Add(new StyleBundle(StyleName.Bundle.SbAdmin2).Include(
                        SbAdmin2.Plugin.MetisMenu.Css.VirtualPath,
                        SbAdmin2.Plugin.TimeLine.Css.VirtualPath,
                        SbAdmin2.Css.VirtualPath
                ));
        }
    }
}