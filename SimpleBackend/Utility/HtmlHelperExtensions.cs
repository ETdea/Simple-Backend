
namespace System.Web.Mvc
{
    public class PageParam
    {
        static string _actionNameForCreate = "Create";
        static string _actionNameForEdit = "Edit";
        //const string NAME = "ViewPageParam";
        public static string ActionNameForCreate
        {
            set
            {
                _actionNameForCreate = value;
            }
        }
        public static string ActionNameForEdit
        {
            set
            {
                _actionNameForEdit = value;
            }
        }
        //public string Name { get { return NAME; } }

        private string _actionNameForCustom;
        public string Title { get; set; }
        public bool IsCreate { get; set; }
        public bool IsEdit { get; set; }
        public string ActionName
        {
            get
            {
                if (IsCreate) return _actionNameForCreate;
                else if (IsEdit) return _actionNameForEdit;
                else return _actionNameForCustom;
            }
            set
            {
                _actionNameForCustom = value;
            }
        }
    }

    static public class HtmlHelperExtensions
    {
        public static PageParam PageParam(this HtmlHelper self)
        {
            const string NAME = "PageParam";

            if (self.ViewData[NAME] == null)
            {
                self.ViewData[NAME] = new PageParam();
            }

            return self.ViewData[NAME] as PageParam;
        }
    }
}
