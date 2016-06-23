using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobileAzureFieldIntel.Model;
using MobileAzureFieldIntel.Services;

namespace MobileAzureFieldIntel.ViewModel
{
   public class MainViewModel
    {
        private List<Employee> _employeeList;

        public List<Employee> EmployeeList
        {
            get { return _employeeList; }
            set
            {
                _employeeList = value;
               }
        }

        

        public MainViewModel()
        {
            var employeeService = new EmployeeService();
            EmployeeList = employeeService.GetEmployees();

        }

       
    }
}
