namespace GAguirreExamen.Vistas;

public partial class VResumen : ContentPage
{
	public VResumen(string[] datos)
	{
		InitializeComponent();
		lbl_nombre.Text = datos[0];
        lbl_apellido.Text = datos[1];
		lbl_edad.Text = datos[2];
		lbl_fecha.Text = datos[3];
		lbl_ciudad.Text = datos[4];
		lbl_pais.Text = datos[5];
		lbl_montoInicial.Text = datos[6];
		lbl_pagoMensual.Text = datos[7];
		lbl_pagoTotal.Text = datos[8];
		lbl_usuario.Text = lbl_usuario.Text = "Usuario Conectado: " + datos[9];
    }
}