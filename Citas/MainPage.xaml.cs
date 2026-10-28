namespace Citas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

      

        private void Solicitar_cita(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.SolicitarCitaPage());

        }

        private void Consultar_cita(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.ConsultaCitasPage());
        }
    }
}
