using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab02_MVC_Rivera_B.Models;

namespace Lab02_MVC_Rivera_B.Controllers
{ 
    public class DispensadorController : Controller
    {
        // GET: Dispensador
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularBilletes(ClsDispensador objDispensador)
        {
            if (objDispensador.monto > 0) {
                //Restantes del residuo de cada denominacion
                objDispensador.b100 = objDispensador.monto / 100;
                objDispensador.b50 = objDispensador.monto % 100 / 50;
                objDispensador.b20 = objDispensador.monto % 100 % 50 / 20;
                objDispensador.b10 = objDispensador.monto % 100 % 50 % 20 / 10;

                objDispensador.m5 = objDispensador.monto % 100 % 50 % 20 % 10 / 5;
                objDispensador.m2 = objDispensador.monto % 100 % 50 % 20 % 10 % 5 /2;
                objDispensador.m1 = objDispensador.monto % 100 % 50 % 20 % 10 % 5 % 2 /1;
                objDispensador.m05 = (objDispensador.monto % 100 % 50 % 20 % 10 % 5 % 2 % 1) / 0.5f;
                objDispensador.m02 = (objDispensador.monto % 100 % 50 % 20 % 10 % 5 % 2 % 1) / 0.2f;
                objDispensador.m01 = (objDispensador.monto % 100 % 50 % 20 % 10 % 5 % 2 % 1) / 0.1f;

                // Total de billetes
                objDispensador.cantidad = objDispensador.b100 + objDispensador.b50 + objDispensador.b20 + objDispensador.b10;
                objDispensador.moneda = objDispensador.m5 + objDispensador.m2 + objDispensador.m1 + objDispensador.m05 + objDispensador.m02 + objDispensador.m01;
            }
            else
            {
                Response.Write("<script language=javascript>alert('Ingrese monto correcto');</script>");
                return View("Index");
            }
            return View("CalcularBilletes", objDispensador);
        }
    }
}