using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBackend
{
    public struct StyleName
    {
        public struct Bundle
        {
            //此目錄階層會影響~/Content/font
            private const string css = "~/Content/css/";
            public const string SbAdmin2 = css + "SbAdmin2";
            public const string SocialButtons = css + "SocialButtons";
            public const string Morris = css + "Morris";
            public const string FontAwesome = css + "FontAwesome";
            public const string Bootstrap = css + "Bootstrap";
            public const string Summernote = css + "Summernote";
            public const string DateTimePicker = css + "DateTimePicker";
            //public const string DataTable = css + "DataTable";
            public const string DataTableBootstrap = css + "DataTableBootstrap";
        }

        public const string Summernote = Bundle.Summernote;
        public const string DataTable = Bundle.DataTableBootstrap;
        public const string DateTimePicker = Bundle.DateTimePicker;
    }

    public struct ScriptName
    {
        public struct Bundle
        {
            private const string js = "~/Script/";
            public const string Flot = js + "Flot";
            public const string Morris = js + "Morris";
            public const string JQuery = js + "JQuery";
            public const string Bootstrap = js + "Bootstrap";
            public const string SbAdmin2 = js + "SbAdmin2";
            public const string Summernote = js + "Summernote";
            public const string DateTimePicker = js + "DateTimePicker";
            public const string ETdea = js + "ETdea";
            public const string DataTableBootstrap = js + "DataTableBootstrap";
            //public const string DataTable = js + "DataTable";
            public const string ETdeaDataTable = js + "ETdeaDataTable";
            public const string AJASUnobtrusive = js + "AJASUnobtrusive";
            public const string Validate = js + "Validate";
        }

        public const string Summernote = Bundle.Summernote;
        public const string DateTimePicker = Bundle.DateTimePicker;
        public static string[] DataTable = { Bundle.DataTableBootstrap, Bundle.ETdeaDataTable };
    }
}
