using UpworkDemo.Pages;

namespace UpworkDemo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("dashboard", typeof(Dashboard));
            Routing.RegisterRoute("login", typeof(LoginPage));

        }
    }
}
