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
namespace SimpleBackend.Areas.HelpPage.Controllers
{
    public partial class HelpController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HelpController(Dummy d) { }

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

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Api()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Api);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ResourceModel()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ResourceModel);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HelpController Actions { get { return MVC.HelpPage.Help; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "HelpPage";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Help";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Help";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Api = "Api";
            public readonly string ResourceModel = "ResourceModel";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Api = "Api";
            public const string ResourceModel = "ResourceModel";
        }


        static readonly ActionParamsClass_Api s_params_Api = new ActionParamsClass_Api();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Api ApiParams { get { return s_params_Api; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Api
        {
            public readonly string apiId = "apiId";
        }
        static readonly ActionParamsClass_ResourceModel s_params_ResourceModel = new ActionParamsClass_ResourceModel();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ResourceModel ResourceModelParams { get { return s_params_ResourceModel; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ResourceModel
        {
            public readonly string modelName = "modelName";
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
                public readonly string Api = "Api";
                public readonly string Index = "Index";
                public readonly string ResourceModel = "ResourceModel";
            }
            public readonly string Api = "~/Areas/HelpPage/Views/Help/Api.cshtml";
            public readonly string Index = "~/Areas/HelpPage/Views/Help/Index.cshtml";
            public readonly string ResourceModel = "~/Areas/HelpPage/Views/Help/ResourceModel.cshtml";
            static readonly _DisplayTemplatesClass s_DisplayTemplates = new _DisplayTemplatesClass();
            public _DisplayTemplatesClass DisplayTemplates { get { return s_DisplayTemplates; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _DisplayTemplatesClass
            {
                public readonly string ApiGroup = "ApiGroup";
                public readonly string CollectionModelDescription = "CollectionModelDescription";
                public readonly string ComplexTypeModelDescription = "ComplexTypeModelDescription";
                public readonly string DictionaryModelDescription = "DictionaryModelDescription";
                public readonly string EnumTypeModelDescription = "EnumTypeModelDescription";
                public readonly string HelpPageApiModel = "HelpPageApiModel";
                public readonly string ImageSample = "ImageSample";
                public readonly string InvalidSample = "InvalidSample";
                public readonly string KeyValuePairModelDescription = "KeyValuePairModelDescription";
                public readonly string ModelDescriptionLink = "ModelDescriptionLink";
                public readonly string Parameters = "Parameters";
                public readonly string Samples = "Samples";
                public readonly string SimpleTypeModelDescription = "SimpleTypeModelDescription";
                public readonly string TextSample = "TextSample";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HelpController : SimpleBackend.Areas.HelpPage.Controllers.HelpController
    {
        public T4MVC_HelpController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ApiOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string apiId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Api(string apiId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Api);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "apiId", apiId);
            ApiOverride(callInfo, apiId);
            return callInfo;
        }

        [NonAction]
        partial void ResourceModelOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string modelName);

        [NonAction]
        public override System.Web.Mvc.ActionResult ResourceModel(string modelName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ResourceModel);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "modelName", modelName);
            ResourceModelOverride(callInfo, modelName);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
