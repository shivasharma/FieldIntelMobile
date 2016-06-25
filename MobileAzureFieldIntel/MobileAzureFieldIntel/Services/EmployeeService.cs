using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileAzureFieldIntel.Model;
using Plugin.RestClient;

namespace MobileAzureFieldIntel.Services
{
   public class EmployeeService
    {
        private readonly RestClient<Employee> _genericRestClient;
        public EmployeeService()
       {
            _genericRestClient = new RestClient<Employee>();
        }
        public async Task<List<Employee>> GetEmployees()
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
               },
               new Employee
               {
                    Name = "John",
                   Department = "Marketing"
               }

           };
            return  list;
        }


        public async Task<List<Employee>>GetEmployeesListAsync()
        {
            var result=   await _genericRestClient.GetAsync();
            return result;
        }

       public async Task PostEmployeeAsync(Employee employee)
       {
           var client=new RestClient<Employee>();
           var employeeList = await client.PostAsync(employee);
           
       }
    }
}
              