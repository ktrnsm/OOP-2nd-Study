using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2nd_Study.Models
{
    public class Employee
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string ReflectInfo()
        {
            return $"{Name}{LastName}";
        }
    }
}
