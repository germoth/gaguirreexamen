namespace GAguirreExamen.Vistas;

public partial class VLogin : ContentPage
{

    string[,] usuarios = {
        {"estudiante", "moviles"},
        {"uisrael", "2024"}
    };
    bool usuarioExiste=false;

    public VLogin()
	{
		InitializeComponent();
	}

    private void btn_login_Clicked(object sender, EventArgs e)
    {
        string usuario=txt_usuario.Text;
        string password=txt_password.Text;
        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            if (string.Equals(usuarios[i, 0], usuario)&& string.Equals(usuarios[i, 1], password))
            {
                usuarioExiste = true;
            }
        }

        if (usuarioExiste)
        {
            Navigation.PushAsync(new VRegistro(usuario));
        }
        else
        {
            DisplayAlert("Error", "El Usuario o la Contraseña es Incorrecta.", "OK");
        }
    }
}