using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Models
{
    public class EmailContent
    {
        [AllowHtml]
        public string HtmlContent { get; set; }

        public EmailContent()
        {

        }
    }
}