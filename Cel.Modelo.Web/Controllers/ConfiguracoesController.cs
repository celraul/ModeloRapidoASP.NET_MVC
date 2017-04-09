using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cel.Modelo.web.Controllers
{
    [Authorize]
    public class ConfiguracoesController : Controller
    {
        // GET: Configuracoes
        public ActionResult Lista()
        {
            return View();
        }
    }
}