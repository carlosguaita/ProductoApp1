namespace ProductoApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ProductoPage());
            //MainPage = new ProductoPage();
        }
    }
}