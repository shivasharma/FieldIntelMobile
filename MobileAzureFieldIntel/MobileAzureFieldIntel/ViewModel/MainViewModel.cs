using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobileAzureFieldIntel.Model;
using MobileAzureFieldIntel.Services;
using Xamarin.Forms;
using Android.App;
using Android.OS;
using Debug = System.Diagnostics.Debug;

namespace MobileAzureFieldIntel.ViewModel
{
   public class MainViewModel: INotifyPropertyChanged
    {
        private List<Employee> _employeeList;
        private Employee _selectedTask;
       private EmployeeService _employeeService;
        public List<Employee> EmployeeList            
        {
            get { return _employeeList; }
            set
            {
                _employeeList = value;
                OnPropertyChanged();
            }
        }
        public Employee SelectedTaskModel
        {
            get { return _selectedTask; }
            set
            {
                _selectedTask = value;
                OnPropertyChanged();
            }
        }
        //public Command AddEmployee
        //{
            
        //    get
        //    {
                
        //         return new Command(async () => await _employeeService.PostEmployeeAsync(SelectedTaskModel));
              
        //    }

        //}



        public MainViewModel()
        {
            _employeeService = new EmployeeService();
            Initialize();
        }

        public async Task Initialize()
        {
           
            EmployeeList = await _employeeService.GetEmployeesListAsync();

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
