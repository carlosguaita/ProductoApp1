using ProductoApp1.Models;
using ProductoApp1.Services;

namespace ProductoApp1;

public partial class LoginPage : ContentPage
{
    private readonly APIService _APIService;

    public LoginPage(APIService apiservice)
	{
		InitializeComponent();
        _APIService = apiservice;
    }

	private async void OnClickLogin(object sender, EventArgs e)
	{
		string username = Username.Text;
		string password = Password.Text;
		User user = new User
		{
			Username = username,
			Password = password,
		};
		

		User user2 = await _APIService.PostUser(user);
		if (user2 != null)
		{
            Preferences.Set("username", user2.Username);
            Preferences.Set("IdUser", user2.IdUser);
            await Navigation.PopAsync();
        }
		
	}

	
}