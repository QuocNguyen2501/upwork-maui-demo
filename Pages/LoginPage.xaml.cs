using UpworkDemo.Services;

namespace UpworkDemo.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        username.Text = "nguyendangquoc.ndq@gmail.com";
        password.Text = "123456";
    }

    private void btnContinue_Clicked(object sender, EventArgs e)
    {
		string _username = username.Text;
		if (!string.IsNullOrEmpty(_username))
		{
            UserService.setUsername(_username);
            usernameForm.IsVisible = false;
            passwordForm.IsVisible = true;
            userDisplay.Text = _username;
        }
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(Dashboard)}");
    }
}
