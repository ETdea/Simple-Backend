using ETdea.Librarys.Mail;
using SimpleBackend.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SimpleBackend.ViewModels
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

}

namespace SimpleBackend.Controllers
{
    public class SystemSettingsController : BaseController
    {
        //
        // GET: /SmtpSettings/
        public ActionResult Index()
        {
            return RedirectToAction("Edit");
        }

        //
        // GET: /SmtpSettings/Edit/5
        public ActionResult Edit()
        {
            var smtp = SmtpClient.GetConfiguration();

            var viewModel = new SmtpSettingsViewModel()
            {
                From = smtp.Settings.From,
                Host = smtp.Settings.Network.Host,
                DefaultCredentials = smtp.Settings.Network.DefaultCredentials,
                Port = (ushort)smtp.Settings.Network.Port,
                EnableSsl = smtp.Settings.Network.EnableSsl,
                Password = smtp.Settings.Network.Password,
                UserName = smtp.Settings.Network.UserName
            };

            return View(viewModel);
        }

        //
        // POST: /SmtpSettings/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(SmtpSettingsViewModel model)
        {
            var smtp = SmtpClient.GetConfiguration();

            smtp.Settings.From = model.From;
            smtp.Settings.Network.Host = model.Host;
            smtp.Settings.Network.DefaultCredentials = model.DefaultCredentials;
            smtp.Settings.Network.Port = model.Port;
            smtp.Settings.Network.EnableSsl = model.EnableSsl;
            smtp.Settings.Network.Password = model.Password;
            smtp.Settings.Network.UserName = model.UserName;

            smtp.save();

            return RedirectToAction("Index");
        }
    }
}
