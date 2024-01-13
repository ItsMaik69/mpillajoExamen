namespace mpillajoExamen.VISTAS;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}
    private void btnCalcular(object sender, EventArgs e)
    {
        string monto = Monto.Text;
        float calculo = (float)(((1500 - float.Parse(monto)) / 4) + (1500 * 0.04));
        mensual.Text = calculo.ToString();

    }

    private void resumen_Clicked(object sender, EventArgs e)
    {

        DateTime fechaSeleccionada = fecha.Date;
        string ciudadSeleccionada = ciudad.SelectedItem.ToString();
        string paisSeleccionado = pais.SelectedItem.ToString();
        float pagoMensual = float.Parse(mensual.Text);
        double total = pagoMensual * 4;

        string[] persona = {
            nombre.Text,
            apellido.Text,
            edad.Text,
            fechaSeleccionada.ToString(),
            ciudadSeleccionada,
            paisSeleccionado,
            Monto.Text,
            pagoMensual.ToString(),
            total.ToString()
        };

        Navigation.PushAsync(new Resumen(persona));

    }
}