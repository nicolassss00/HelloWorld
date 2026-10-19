namespace Persistencia.Pages;

public partial class Preferencias : ContentPage
{
	public Preferencias()
	{
		InitializeComponent();
		//Preferences.Set("nombre", "Bea");
		// Preferences.Default.Get("nombre", "");
		// Preferences.Default.Remove("nombre");
		nombretext.Text = Preferences.Get("usuario", String.Empty);
		contrasenatext.Text = Preferences.Get("contrasena", String.Empty);
	}

    private void aceptar_Clicked(object sender, EventArgs e)
    {
		if (this.checktext.IsChecked)
		{
			Preferences.Set("usuario", this.nombretext.Text.Trim());
			Preferences.Set("Contraseña", this.contrasenatext.Text.Trim());
		}
		else
		{
			Preferences.Remove("usuario");
			Preferences.Remove("contraseña");
		}
    }
}