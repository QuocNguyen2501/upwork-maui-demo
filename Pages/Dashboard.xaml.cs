using UpworkDemo.Services;

namespace UpworkDemo.Pages;

public partial class Dashboard : ContentPage
{
	public Dashboard()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, true);

		if (string.IsNullOrEmpty(UserService.getUser().Username))
		{
			Shell.Current.GoToAsync("//WelcomePage").Wait();
        }
    }

    
}