using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeesApp.Models;
using System.Xml.Serialization;

namespace EmployeesApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeBL emp = new EmployeeBL();
        // GET: Employee
        public ActionResult Index()
        {
            var empleados = emp.get_employees();
            return View(empleados);
        }

        public ActionResult Show(string id)
        {
            var empleado= emp.get_employee(id);
            if (empleado == null)
                return RedirectToAction("Index");
            return View(empleado);
        }

        public ActionResult BuscarEmpleado(string email)
        {
            var empleado = emp.find_by_email(email);
            return PartialView(empleado);
        }

        //GET: ../Employee/ConsultarServicio 
        public ActionResult ConsultarServicio()
        {
            return View();
        }

        //POST: ../Employee/ConsultarServicio 
        [HttpPost]
        public ActionResult ConsultarServicio(double? min,double? max)
        {
            double mn = min.HasValue ? (double)min : 0;
            double mx = max.HasValue ? (double)max : 0;

            if (mn > mx)
                return RedirectToAction("ConsultarServicio");

            return RedirectToAction("ServicioXML", new { min = mn, max = mx });

        }

        //GET: ../Employee/ServicioXML
        public ActionResult ServicioXML(double? min, double? max)
        {
            double mn = min.HasValue ? (double)min : 0;
            double mx = max.HasValue ? (double)max : 0;

            XmlSerializer serializer = new XmlSerializer(typeof(EmployeesXML));
            EmployeesXML xml = new EmployeesXML();
            xml.empleados = emp.find_by_salary(mn, mx);

            HttpContext.Response.Clear();
            HttpContext.Response.ContentType = "text/xml";
            serializer.Serialize(HttpContext.Response.Output,xml);
            HttpContext.Response.End();

            return Content("");
        }
    }
}