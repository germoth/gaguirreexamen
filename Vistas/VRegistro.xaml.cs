namespace GAguirreExamen.Vistas;

public partial class VRegistro : ContentPage
{
    int valorInicial = 1500;
    double porcentaje = 0.04;
    double calculoMensual = 0.0;
    double calculoTotal = 0.0;
    string userLogin = "";

    public VRegistro(string usuario)
	{
		InitializeComponent();
        lbl_usuario.Text = "Usuario Conectado: "+ usuario;
        userLogin = usuario;

    }

    private void btn_calcular_Clicked(object sender, EventArgs e)
    {
        if(txt_monto.Text is not null) { 
            calculoMensual=((valorInicial-double.Parse(txt_monto.Text))/4) + (valorInicial * porcentaje);
            calculoTotal=calculoMensual * 4 + double.Parse(txt_monto.Text);
            lbl_pMensual.Text= calculoMensual.ToString();
        }
        else
        {
            DisplayAlert("Error", "Ingrese el Monto Inicial", "OK");
        }
    }

    private void btn_resumen_Clicked(object sender, EventArgs e)
    {
        string pais = pkr_pais.Items[pkr_pais.SelectedIndex].ToString();
        string ciudad = pkr_ciudad.Items[pkr_ciudad.SelectedIndex].ToString();
        string fecha = dtp_fecha.Date.ToString();
        string[] datos = {txt_nombre.Text,txt_apellido.Text, txt_edad.Text, fecha,ciudad,pais,txt_monto.Text,
            calculoMensual.ToString(), calculoTotal.ToString() ,userLogin};
        Navigation.PushAsync(new VResumen(datos));

    }
}