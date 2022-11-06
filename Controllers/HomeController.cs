using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_Fase_1.Models;

namespace Proyecto_Fase_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //MantenimientoCarrera mc = new MantenimientoCarrera();
            //return View(mc.RecuperarTodos());
            
            return View();

        }

       /* public ActionResult CarrerasTec()
        {
            MantenimientoCarrera mc = new MantenimientoCarrera();
            return View(mc.RecuperarTodos());


        }*/

        public ActionResult CarrerasIng(string escuela)
        {
            MantenimientoCarreraIng mci = new MantenimientoCarreraIng();
            return View(mci.RecuperarTodos(escuela));


        }



       // public ActionResult CarrerasLic()
       // {
         //   MantenimientoCarreraLic mcl = new MantenimientoCarreraLic();
           // return View(mcl.RecuperarTodos());


        //}
        //public ActionResult CarrerasVirtual()
        //{
          //  MantenimientoCarreraVir mcv = new MantenimientoCarreraVir();
            //return View(mcv.RecuperarTodos());


       // }
    }
}