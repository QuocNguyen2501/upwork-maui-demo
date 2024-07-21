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
            Device.BeginInvokeOnMainThread(async () =>
            {
                Shell.Current.GoToAsync($"//{nameof(WelcomePage)}");
            });
		}
		else
		{
            Shell.Current.FlyoutIcon = "profile.jpeg";
        }
    }

    
}