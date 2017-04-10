using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Xml.Serialization;

namespace EmployeesApp.Models
{
    [XmlRoot("Registros")]
    public class EmployeesXML
    {
        [XmlArrayItem(typeof(Employee))]
        public List<Employee> empleados { get; set; }

        public EmployeesXML()
        {
            empleados = new List<Employee>();
        }
    }
}