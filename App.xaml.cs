using UpworkDemo.Pages;

namespace UpworkDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WelcomePage();
        }
    }
}
