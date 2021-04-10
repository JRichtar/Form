using System;
using System.Collections.Generic;
using System.Text;

namespace Formulář
{
    class Employee : Human
    {
        public static List<Employee> AllEmployees = new List<Employee>();

        public string HighestEducation { get; set; }
        public string Job { get; set; }
        public string Payment { get; set; }
    }
}
