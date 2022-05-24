using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TinyMCEController : Controller
    {
        // GET: TinyMCE
        public ActionResult Index(string categoryType)
        {
            EmailContent model = new EmailContent()
            {
                HtmlContent = "<b>Test Data</b>"
            };
            using (var entity = new PQRSV13Entities())
            {
                model.HtmlContent = entity.tbl_MIPS_Email_Manager_Test.Where(y => y.Category == categoryType).Select(x => x.Body).FirstOrDefault();
            }
            model.HtmlContent = HttpUtility.HtmlDecode(model.HtmlContent);
            return PartialView(model);
        }

        // An action that will accept your Html Content
        [HttpPost]
        public ActionResult Index(string updateBody, string CatType)
        {
            var result = false;
            updateBody = HttpUtility.UrlDecode(updateBody);
            using (var entity = new PQRSV13Entities())
            {
                var data = entity.tbl_MIPS_Email_Manager_Test.Where(y => y.Category == CatType).FirstOrDefault();
                if (data != null)
                {
                    data.Body = HttpUtility.HtmlEncode(updateBody);
                    entity.SaveChanges();
                    result = true;
                }
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SendEmail(string subject, string body)
        {
            bool result = false;
            body = HttpUtility.UrlDecode(body);
            try
            {
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("saipavankumaralane@gmail.com","Ss16122114@"),
                    
                };

                using (var message = new MailMessage("saipavankumaralane@gmail.com", "ranjithmamidipelli123@gmail.com")
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                })

                    smtp.Send(message);
            }
            catch(Exception ex)
            {
                string ErrMessage = ex.Message;
            }
            
            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}