namespace Persistencia
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PreferenciasBtn_Clicked(object? sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Preferencias());
        }

        private void FicheroBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Fichero());
        }

        private void BasedeDatosBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.BasedeDatos());
        }
    }
}
