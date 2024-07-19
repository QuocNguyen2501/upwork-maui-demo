namespace UpworkDemo.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void btnContinue_Clicked(object sender, EventArgs e)
    {
		string _username = username.Text;
		if (!string.IsNullOrEmpty(_username))
		{
            usernameForm.IsVisible = false;
            passwordForm.IsVisible = true;
            userDisplay.Text = _username;
        }
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dashboard());
    }
}
