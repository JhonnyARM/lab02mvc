using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab02_MVC_Rivera_B.Models;
namespace Lab02_MVC_Rivera_B.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult MostrarUno()
        {
            ClsPersona objPersona = new ClsPersona();
            objPersona.DNI = "12345678";
            objPersona.Apellido = "TEST TEST";
            objPersona.Nombre = "Prueba";
            objPersona.edad = 35;
            objPersona.Sexo = true;
            objPersona.talla = 1.55;
            objPersona.peso = 80;
            return View(objPersona);
        }
        public ActionResult ListarTodos()
        {
            List<ClsPersona> List = new List<ClsPersona>();

            ClsPersona objPersona1 = new ClsPersona();

            objPersona1.DNI = "12341678";
            objPersona1.Apellido = "APAZA MAMANI";
            objPersona1.Nombre = "EDWARD";
            objPersona1.edad = 35;
            objPersona1.Sexo = true;
            objPersona1.talla = 1.55;
            objPersona1.peso = 80;
            List.Add(objPersona1);
            
            ClsPersona objPersona2 = new ClsPersona();

            objPersona2.DNI = "11122233";
            objPersona2.Apellido = "CANO SUCSO";
            objPersona2.Nombre = "Anthony Alexander";
            objPersona2.edad = 23;
            objPersona2.Sexo = true;
            objPersona2.talla = 1.66;
            objPersona2.peso = 75;
            List.Add(objPersona2);
            
            ClsPersona objPersona3 = new ClsPersona();

            objPersona3.DNI = "11155233";
            objPersona3.Apellido = "LIMA CCOSI";
            objPersona3.Nombre = "Jeakory Geilly";
            objPersona3.edad = 25;
            objPersona3.Sexo = false;
            objPersona3.talla = 1.44;
            objPersona3.peso = 70;
            List.Add(objPersona3);
            
            ClsPersona objPersona4 = new ClsPersona();
            objPersona4.DNI = "61126236";
            objPersona4.Apellido = "MAMANI CONDORI";
            objPersona4.Nombre = "Gilmer Donaldo";
            objPersona4.edad = 26;
            objPersona4.Sexo = true;
            objPersona4.talla = 1.57;
            objPersona4.peso = 70;

            List.Add(objPersona4);ClsPersona objPersona5 = new ClsPersona();
            objPersona5.DNI = "61126217";
            objPersona5.Apellido = "ASDASDASD";
            objPersona5.Nombre = "ASDASDAD";
            objPersona5.edad = 26;
            objPersona5.Sexo = true;
            objPersona5.talla = 1.57;
            objPersona5.peso = 70;
            List.Add(objPersona5);
            


            return View(List);
            
        }
    }
}