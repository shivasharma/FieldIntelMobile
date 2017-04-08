using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileAzureFieldIntel.Model;
using MobileAzureFieldIntel.Services;
using MobileAzureFieldIntel.ViewModel;
using Xamarin.Forms;

namespace MobileAzureFieldIntel.View
{
    public partial class AddEmployee : ContentPage
    {
        private EmployeeService _employeeService;
        public AddEmployee()
        {
            _employeeService = new EmployeeService();
            InitializeComponent();

        }


        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var mainviewModel = BindingContext as MainViewModel;
            var name = EmployeeName.Text;
            var department = Department.Text;
            var employee = new Employee();
            employee.Name = name;
            employee.Department = department;
            await _employeeService.PostEmployeeAsync(employee);
        }
    }
}
