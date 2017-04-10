using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesApp.Models
{
    public class EmployeeBL
    {
        private EmployeeDAL dao = new EmployeeDAL();
        public List<Employee> get_employees()
        {
            return dao.get_employees();
        }
        public Employee get_employee(string id)
        {
            return dao.get_employee(id);
        }
        public List<Employee> find_by_email(string email)
        {
            return dao.find_by_email(email);
        }
        public List<Employee> find_by_salary(double min, double max)
        {
            return dao.find_by_salary(min, max);
        }
    }
}