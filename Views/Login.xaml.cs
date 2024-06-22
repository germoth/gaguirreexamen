using static Android.Net.Wifi.Hotspot2.Pps.Credential;

namespace gaguirreexamen.Views;

public partial class Login : ContentPage
{
	public Login()
	{
        InitializeComponent();
    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        if (_userCredentials.ContainsKey(username) && _userCredentials[username] == password)
        {
            // Navegar a la siguiente p�gina con el nombre de usuario
            await Navigation.PushAsync(new RegistroPage(username));
        }
        else
        {
            // Mostrar notificaci�n de datos incorrectos
            await DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }
    }
}
}
