using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingChallenge.Models;
using CodingChallenge.Data.Classes; 

namespace CodingChallenge.Controllers
{
    public class TituloDeBolsaController : Controller

    {

        private HomeModel homeModel = new HomeModel();
        private DetalleModel detalleModel = new DetalleModel();

        public ActionResult Home()
        {

            return View();
        }
        
        public ActionResult Detalle()
        {
            
            int Id = int.Parse(Request.QueryString["idt"]);
            Titulo titulo = new Titulo();
            titulo = (Titulo)homeModel.tituloList.Where(x => x.Id == Id).First();
            detalleModel.descripcion = titulo.Descripcion;
            detalleModel.detalle = titulo.Detalle;
            detalleModel.moneda = titulo.Moneda.ToString();
            detalleModel.simbolo = titulo.Simbolo;
            detalleModel.tipo = titulo.Tipo.ToString();

            return View(detalleModel);
        }

        //Function that is called by the autocomplete
        public JsonResult TituloDeBolsaAutocomplete(string term)
        {
            var titulos = (from t in homeModel.tituloList
                           where t.Descripcion.ToLower().Contains(term.ToLower())
                           select t).ToList();
            return Json(titulos, JsonRequestBehavior.AllowGet);
        }
    }
}