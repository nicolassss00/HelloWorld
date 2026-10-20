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

            lista.Add(new Pais { nombre = "España", bandera= "https://flagcdn.com\r\n/\r\n64x48\r\n/\r\nes\r\n.\r\npng", capital = "Madrid" });
            lista.Add(new Pais { nombre = "Francia", bandera = "https://flagcdn.com\r\n/\r\n64x48\r\n/\r\nmf\r\n.\r\npng", capital = "Paris" });
            lista.Add(new Pais { nombre = "Inglaterra", bandera = "https://flagcdn.com\r\n/\r\n64x48\r\n/\r\ngb-eng\r\n.\r\npng", capital = "Londres" });
            lista.Add(new Pais { nombre = "Alemania", bandera = "https://flagcdn.com\r\n/\r\n64x48\r\n/\r\nde\r\n.\r\npng", capital = "Berlin" });
            lista.Add(new Pais { nombre = "Belgica", bandera = "https://flagcdn.com\r\n/\r\n64x48\r\n/\r\nbe\r\n.\r\npng\r\n", capital = "Bruselas" });
            return lista;

            
        }
    }
}
