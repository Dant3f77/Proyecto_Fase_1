using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_Fase_1.Models;

namespace Proyecto_Fase_1.Controllers
{
    public class AspiranteController : Controller
    {
        MantenimientoAspirante ma;
        // GET: Aspirante
        public ActionResult Listar()
        {

           ma = new MantenimientoAspirante();
            return View(ma.RecuperarTodos());

           
        }
        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(FormCollection collection)
        {
            ma = new MantenimientoAspirante();
            Inscripcion inscripcion = new Inscripcion
            {
                
                nombres = (collection["Nombres"]),
                apellidoP = (collection["ApellidoP"]),
                apellidoS =(collection["ApellidoS"]),
                dui = (collection["Dui"]),
                nit = (collection["Nit"]),
                correo = (collection["Correo"]),
                telefono = (collection["Telefono"]),
                idCarrera =int.Parse(collection["IdCarrera"]),
            };
            ma.Alta(inscripcion);
            return RedirectToAction("Listar");
        }

        public ActionResult Baja(int id)
        {
          ma = new MantenimientoAspirante();
            ma.Borrar(id);
            return RedirectToAction("Listar");
        }


        public ActionResult Modificacion(int id)
        {
           ma = new MantenimientoAspirante();   
           return View(ma.Recuperar(id));
        }
     
        [HttpPost]
        public ActionResult Modificacion(FormCollection collection)
        {
            ma = new MantenimientoAspirante();
            Inscripcion carr = new Inscripcion();
            {
                carr.id = int.Parse(collection["Id"].ToString());
                carr.nombres = collection["Nombres"].ToString();
                carr.apellidoP = collection["ApellidoP"].ToString();
                carr.apellidoS = collection["ApellidoS"].ToString();
                carr.dui = collection["Dui"].ToString();
                carr.nit = collection["Nit"].ToString();
                carr.correo = collection["Correo"].ToString();
                carr.telefono = collection["Telefono"].ToString();
                carr.idCarrera = int.Parse(collection["IdCarrera"].ToString());
            };
            ma.Modificar(carr);
            return RedirectToAction("Listar");
        }

        public ActionResult Detalles(int id)
        {
            ma = new MantenimientoAspirante();
            return View(ma.Recuperar(id));
        }
    }



}
