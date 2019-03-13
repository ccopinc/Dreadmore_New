using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Web.Mvc;
using Dreadmore.DTOModels;
using Dreadmore.Managers;

namespace Dreadmore.Controllers
{
    public class MainController : Controller
    {

        SiteManager site = new SiteManager();

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/Main/GetQuote/")]
        public ActionResult GetQuote()
        {
            var quote = site.GetQuote();
            return View(quote);
        }
    }
}
