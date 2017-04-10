using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace EmployeesApp.Models
{
    [Serializable]
    [XmlRoot(ElementName = "Employee")]
    public class Employee
    {
        public Employee(){}

        public Employee(string id, bool isOnline,
                        string salary,int age,string position,string name,string gender,
                        string email, string phone,string address,List<string> skills)
        {
            this.id = id;
            this.isOnline = isOnline;
            this.salary = salary;
            this.age = age;
            this.position = position;
            this.name = name;
            this.gender = gender;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.skills = skills;
        }

        public string id { get; set; }
        public bool isOnline { get; set; }
        public string salary { get; set; }
        public int age { get; set; }
        public string position { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        [XmlArrayItem("skill")]
        public List<string> skills { get; set; }
    }
}