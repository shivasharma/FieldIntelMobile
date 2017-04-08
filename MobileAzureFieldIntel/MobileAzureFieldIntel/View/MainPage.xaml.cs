using System;
using MobileAzureFieldIntel.View;
using MobileAzureFieldIntel.ViewModel;
using Xamarin.Forms;

namespace MobileAzureFieldIntel
{
    public partial class MainPage : ContentPage
    {
       // readonly MainViewModel vm;
        public MainPage()
        {
          // vm=new MainViewModel();
           // BindingContext = vm;
            InitializeComponent();
        }

        private async void NavigateToAddPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployee());
        }
    }
}
