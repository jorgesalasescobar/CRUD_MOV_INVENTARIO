using Microsoft.AspNetCore.Mvc;

using CRUDCORE.Datos;
using CRUDCORE.Models;
using CRUD_MOV_INVENTARIO.Datos;
using CRUD_MOV_INVENTARIO.Models;

namespace CRUDCORE.Controllers
{
    public class MantenedorController : Controller
    {

        //ContactoDatos _ContactoDatos = new ContactoDatos();
        MOV_INVENTARIODatos _MOV_INVENTARIODatos = new MOV_INVENTARIODatos();

        public IActionResult Listar()
        {
            //LA VISTA MOSTRARÁ UNA LISTA DE MOVIMIENTOS
            //var oLista = _ContactoDatos.Listar();
            var oLista = _MOV_INVENTARIODatos.Listar();

            return View(oLista);
        }

        public IActionResult Guardar()
        {
            //METODO SOLO DEVUELVE LA VISTA
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(MOV_INVENTARIOModel oMOV_INVENTARIO)
        {
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN BD
            if (!ModelState.IsValid)
                return View();


            //var respuesta = _ContactoDatos.Guardar(oContacto);
            var respuesta = _MOV_INVENTARIODatos.Guardar(oMOV_INVENTARIO);

            if (respuesta)
                return RedirectToAction("Listar");
            else 
                return View();
        }

        public IActionResult Editar(MOV_INVENTARIOModel oMOV_INVENTARIO)
        {
            //METODO SOLO DEVUELVE LA VISTA

            //if (!ModelState.IsValid)
            //    return View();

            var respuesta = _MOV_INVENTARIODatos.Editar(oMOV_INVENTARIO);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();

        }

        public IActionResult Eliminar(MOV_INVENTARIOModel oMOV_INVENTARIO)
        {
            if (!ModelState.IsValid)
                return View();

            var respuesta = _MOV_INVENTARIODatos.Eliminar(oMOV_INVENTARIO);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

    }
}
