using System.Security.Cryptography;

namespace Citas.Pages;

public partial class SolicitarCitaPage : ContentPage
{
  
    public SolicitarCitaPage()
    {
        InitializeComponent();
    }

    private async void OnSolicitarCitaClicked(object sender, EventArgs e)
    {
        if (condicionesCheckBox.IsChecked)
        {
            
            Preferences.Default.Set("recuerda_datos", true);
            Preferences.Default.Set("nombre", NombreEntry.Text ?? string.Empty);
            Preferences.Default.Set("apellidos", ApellidosEntry.Text ?? string.Empty);
            Preferences.Default.Set("numero", NumeroEntry.Text ?? string.Empty);

            await DisplayAlert("Éxito", "Cita solicitada y datos guardados.", "OK");
        }
        else
        {
            
            Preferences.Default.Remove("recuerda_datos");
            Preferences.Default.Remove("nombre");
            Preferences.Default.Remove("apellidos");
            Preferences.Default.Remove("numero");

            await DisplayAlert("Éxito", "Cita solicitada. Datos eliminados.", "OK");
        }
    }
}