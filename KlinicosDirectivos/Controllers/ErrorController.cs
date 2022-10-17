using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KlinicosDirectivos.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int error = 0 )
        {
            string desc = (string)Session["desc"];
            string ruta = string.Empty;
            switch (error)
            {
                case 505:
                    ViewBag.Title = "Error 505";
                    ViewBag.Description = "Error interno. Por favor, verifique que los datos seleccionados sean los correctos";
                    ViewBag.DescripcionAdicional = desc;
                    ruta = "~/views/Errores/Error505.cshtml";
                    break;

                case 404:
                    ViewBag.Title = "Error 404";
                    ViewBag.Description = "Página no encontrada. Los datos que esta buscando no se encuentran o no existen.";
                    ViewBag.DescripcionAdicional = desc;
                    ruta = "~/views/Errores/Error404.cshtml";
                    break;

                default:
                    ViewBag.Title = "Error en la aplicación";
                    ViewBag.Description = "Verifique el estado de conexión de su red.";
                    ViewBag.DescripcionAdicional = desc;
                    ruta = "~/views/Shared/Error.cshtml";
                    break;
            }

            return View(ruta);
        }
    }
}

//Recordar apuntar los viewbags a los errores