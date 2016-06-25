using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using MobileAzureFieldIntel.Model;
using RestClient.Client;
using RestClient.Models;
using Xamarin.Forms;

namespace RestClient.ViewModels
{
    public class TasksViewModel : INotifyPropertyChanged
    {

        private List<Employee> _employeeList;
         private GenericRestClient<Employee> _genericRestClient;
        private Employee _selectedTask;

        public List<Employee> EmployeesList
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
            set {
                _selectedTask = value;
                OnPropertyChanged();
            }
        }
       public  Command PostCommand
        {
           get
           {
               return new Command(async()=>await _genericRestClient.PostAsync(SelectedTaskModel));
           }
            
        }
        public TasksViewModel()
        {

            _genericRestClient = new GenericRestClient<Employee>();

            DownloadDataAsync();
        }

        public async Task DownloadDataAsync()
        {

          var  Tasks = await _genericRestClient.GetAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
