using ProductoApp1.Services;

namespace ProductoApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            APIService apiservice = new APIService(); 
            MainPage = new NavigationPage(new ProductoPage(apiservice));
            //MainPage = new ProductoPage();
        }
    }
}