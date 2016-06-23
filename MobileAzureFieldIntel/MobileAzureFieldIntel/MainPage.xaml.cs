using MobileAzureFieldIntel.ViewModel;
using Xamarin.Forms;

namespace MobileAzureFieldIntel
{
    public partial class MainPage : ContentPage
    {
        readonly MainViewModel vm;
        public MainPage()
        {
           vm=new MainViewModel();
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
