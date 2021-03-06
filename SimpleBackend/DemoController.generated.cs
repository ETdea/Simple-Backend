// <auto-generated />
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
namespace SimpleBackend.Controllers
{
    public partial class DemoController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public DemoController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected DemoController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }


        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public DemoController Actions { get { return MVC.Demo; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Demo";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Demo";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Dashboard = "Dashboard";
            public readonly string Blank = "Blank";
            public readonly string Buttons = "Buttons";
            public readonly string Flot = "Flot";
            public readonly string Forms = "Forms";
            public readonly string Icons = "Icons";
            public readonly string Grid = "Grid";
            public readonly string Login = "Login";
            public readonly string Morris = "Morris";
            public readonly string Notifications = "Notifications";
            public readonly string PanelsWells = "PanelsWells";
            public readonly string Tables = "Tables";
            public readonly string Typography = "Typography";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Dashboard = "Dashboard";
            public const string Blank = "Blank";
            public const string Buttons = "Buttons";
            public const string Flot = "Flot";
            public const string Forms = "Forms";
            public const string Icons = "Icons";
            public const string Grid = "Grid";
            public const string Login = "Login";
            public const string Morris = "Morris";
            public const string Notifications = "Notifications";
            public const string PanelsWells = "PanelsWells";
            public const string Tables = "Tables";
            public const string Typography = "Typography";
        }


        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Blank = "Blank";
                public readonly string Buttons = "Buttons";
                public readonly string Dashboard = "Dashboard";
                public readonly string Flot = "Flot";
                public readonly string Forms = "Forms";
                public readonly string Grid = "Grid";
                public readonly string Icons = "Icons";
                public readonly string Login = "Login";
                public readonly string Morris = "Morris";
                public readonly string Notifications = "Notifications";
                public readonly string PanelsWells = "PanelsWells";
                public readonly string Tables = "Tables";
                public readonly string Typography = "Typography";
            }
            public readonly string Blank = "~/Views/Demo/Blank.cshtml";
            public readonly string Buttons = "~/Views/Demo/Buttons.cshtml";
            public readonly string Dashboard = "~/Views/Demo/Dashboard.cshtml";
            public readonly string Flot = "~/Views/Demo/Flot.cshtml";
            public readonly string Forms = "~/Views/Demo/Forms.cshtml";
            public readonly string Grid = "~/Views/Demo/Grid.cshtml";
            public readonly string Icons = "~/Views/Demo/Icons.cshtml";
            public readonly string Login = "~/Views/Demo/Login.cshtml";
            public readonly string Morris = "~/Views/Demo/Morris.cshtml";
            public readonly string Notifications = "~/Views/Demo/Notifications.cshtml";
            public readonly string PanelsWells = "~/Views/Demo/PanelsWells.cshtml";
            public readonly string Tables = "~/Views/Demo/Tables.cshtml";
            public readonly string Typography = "~/Views/Demo/Typography.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_DemoController : SimpleBackend.Controllers.DemoController
    {
        public T4MVC_DemoController() : base(Dummy.Instance) { }

        [NonAction]
        partial void DashboardOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Dashboard()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Dashboard);
            DashboardOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void BlankOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Blank()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Blank);
            BlankOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ButtonsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Buttons()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Buttons);
            ButtonsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void FlotOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Flot()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Flot);
            FlotOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void FormsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Forms()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Forms);
            FormsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void IconsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Icons()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Icons);
            IconsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GridOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Grid()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Grid);
            GridOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void LoginOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Login()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Login);
            LoginOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void MorrisOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Morris()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Morris);
            MorrisOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void NotificationsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Notifications()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Notifications);
            NotificationsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void PanelsWellsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult PanelsWells()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PanelsWells);
            PanelsWellsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void TablesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Tables()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Tables);
            TablesOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void TypographyOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Typography()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Typography);
            TypographyOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
