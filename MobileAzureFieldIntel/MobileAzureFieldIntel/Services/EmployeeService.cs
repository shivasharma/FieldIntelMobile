using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileAzureFieldIntel.Model;

namespace MobileAzureFieldIntel.Services
{
   public class EmployeeService
    {
        public List<Employee> GetEmployees()
        {
            var list = new List<Employee>
           {
               new Employee
               {
                   Name = "shiva",
                   Department = "IT"
               },
               new Employee
               {
                    Name = "Keshab",
                   Department = "Sales"
               }

           };
            return list;
        }
    }
}
