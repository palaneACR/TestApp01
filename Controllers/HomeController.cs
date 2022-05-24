using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Entities;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            dynamic model = new ExpandoObject();
            using (var entity = new PQRSV13Entities())
            {
                var list = entity.tbl_MIPS_Email_Manager_Test.Where( y => y.Subject.Contains("QCDR Submission")).Select(x => x.Category).Distinct().ToList();
                model.items = list;
            }

            return View(model);
        }
        
        [HttpPost]
        public ActionResult SendEmail(string subject, string body)
        {
            return null;
        }
    }
}