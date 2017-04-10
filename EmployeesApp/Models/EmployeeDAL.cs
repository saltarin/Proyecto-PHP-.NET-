using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesApp.Models
{
    public class EmployeeDAL
    {
        public List<Employee> get_employees()
        {
            var arreglo_json = MyJson.get_json();
            var empleados = (from e in arreglo_json
                             select new Employee((string)e["id"], bool.Parse(e["isOnline"].ToString()),
                                                 (string)e["salary"], int.Parse(e["age"].ToString()),
                                                 (string)e["position"], (string)e["name"],
                                                 (string)e["gender"], (string)e["email"],
                                                 (string)e["phone"], (string)e["address"],
                                                 ( from s in e["skills"]
                                                   select s["skill"].ToString()).ToList()));
            return empleados.ToList();
        }

        public Employee get_employee(string id)
        {
            var arreglo_json = MyJson.get_json();
            var empleados = (from e in arreglo_json
                             where (string)e["id"] == id
                             select new Employee((string)e["id"], bool.Parse(e["isOnline"].ToString()),
                                                 (string)e["salary"], int.Parse(e["age"].ToString()),
                                                 (string)e["position"], (string)e["name"],
                                                 (string)e["gender"], (string)e["email"],
                                                 (string)e["phone"], (string)e["address"],
                                                 (from s in e["skills"]
                                                  select s["skill"].ToString()).ToList()));
            return empleados.FirstOrDefault();
        }

        public List<Employee> find_by_email(string email = "")
        {
            var arreglo_json = MyJson.get_json();
            var empleados = (from e in arreglo_json
                             where e["email"].ToString().Contains(email)
                             select new Employee((string)e["id"], bool.Parse(e["isOnline"].ToString()),
                                                 (string)e["salary"], int.Parse(e["age"].ToString()),
                                                 (string)e["position"], (string)e["name"],
                                                 (string)e["gender"], (string)e["email"],
                                                 (string)e["phone"], (string)e["address"],
                                                 (from s in e["skills"]
                                                  select s["skill"].ToString()).ToList()));
            return empleados.ToList();
        }

        public List<Employee> find_by_salary(double min, double max)
        {
            var arreglo_json = MyJson.get_json();
            var empleados = (from e in arreglo_json
                             let salary_float = Double.Parse(e["salary"].ToString().Replace(",", "").Replace("$",""))
                             where salary_float >= min && salary_float < max
                             select new Employee((string)e["id"], bool.Parse(e["isOnline"].ToString()),
                                                 (string)e["salary"], int.Parse(e["age"].ToString()),
                                                 (string)e["position"], (string)e["name"],
                                                 (string)e["gender"], (string)e["email"],
                                                 (string)e["phone"], (string)e["address"],
                                                 (from s in e["skills"]
                                                  select s["skill"].ToString()).ToList()));
            return empleados.ToList();
        }
    }
}