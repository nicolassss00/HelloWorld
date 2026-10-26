using System.Runtime.Intrinsics.Wasm;
using System.Text.Json;

namespace CollectionView
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
           this.listapaises.ItemsSource= cargarPais();
        }

        private List<Pais> cargarPais()
        {
            List<Pais> lista = new List<Pais>();

            lista.Add(new Pais { nombre = "España", bandera= "https://flagcdn.com/64x48/es.png", capital = "Madrid" });
            lista.Add(new Pais { nombre = "Francia", bandera = "https://flagcdn.com\r\n/\r\n64x48\r\n/\r\nmf\r\n.\r\npng", capital = "Paris" });
            lista.Add(new Pais { nombre = "Inglaterra", bandera = "https://flagcdn.com/64x48/gb-eng.png", capital = "Londres" });
            lista.Add(new Pais { nombre = "Alemania", bandera = "https://flagcdn.com\r\n/\r\n64x48\r\n/\r\nde\r\n.\r\npng", capital = "Berlin" });
            lista.Add(new Pais { nombre = "Belgica", bandera = "https://flagcdn.com/64x48/be.png", capital = "Bruselas" });
            return lista;

            
        }

        private async void listapaises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            Pais pais = (Pais)e.CurrentSelection[0];
            string respuesta = await DisplayPromptAsync(
                "Adivina la Capital",
                $"Introduce la capital de {pais.nombre}:",
                "Aceptar",
                "Cancelar"
            );

          
            if (!string.IsNullOrEmpty(respuesta))
            {
                if (respuesta.Trim().Equals(pais.capital, StringComparison.OrdinalIgnoreCase))
                {
                    await DisplayAlert("¡Correcto!", $"¡Muy bien! La capital de {pais.nombre} es **{pais.capital}**.", "Aceptar");
                }
                else
                {
                    await DisplayAlert("Incorrecto", $"Lo siento, '{respuesta}' no es la capital de {pais.nombre}.", "Aceptar");
                }
            }
        }
    }
}
