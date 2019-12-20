using Datos;
using DescargaExcel.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DescargaExcel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult List([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                PersonaDato dato = new PersonaDato();
                var nuevaLista = dato.Listar();
                var list = Json(nuevaLista.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
                list.MaxJsonLength = int.MaxValue;
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }   
        }

    }
}