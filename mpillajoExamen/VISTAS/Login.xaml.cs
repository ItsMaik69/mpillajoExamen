namespace mpillajoExamen.VISTAS;

public partial class Login : ContentPage
{
    static string[] usuarios = { "estudiante2024", "examen1","MichaelPillajo" };
    static string[] contrasenas = { "uisrael2024", "parcial1", "2024"};
    public Login()
	{
		InitializeComponent();
	}
    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrase�a.Text;

        bool correcto = false;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuario == usuarios[i] && contrasena == contrasenas[i])
            {
                correcto = true;
                break;
            }
        }

        if (correcto)
        {
            DisplayAlert("Bienvenido", "Usuario conectado: " + usuario, "Aceptar");

            Navigation.PushAsync(new VISTAS.Registro());
        }

        else
        {
            DisplayAlert("Error", "Usuario/Contrase�a incorrectos", "Cancel");
        }
    }

    private void btnAcercade_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Informaci�n del Sistema", "El propietario de este programa es Michael Pillajo", "Cerrar");
    }
}