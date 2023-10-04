using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;

namespace Matricula.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            
            ViewBag.tiposmatricula = new TipoMatricula().ReadAll();
            ViewBag.cursos = new Curso().ReadAll();
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "tipo_matricula, codigo_alumno, id_curso")] Entity.Matricula matricula)
        {
            try
            {
                // TODO: Add insert logic here
                matricula.Save();
                TempData["mensaje"] = "Guardado Correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        
    }
}