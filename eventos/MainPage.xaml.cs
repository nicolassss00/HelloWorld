namespace eventos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void Button_Clicked(object sender, EventArgs e)
        {
         string email=   this.correoEntry.Text;
            string textarea = this.comentariosEditor.Text;

            if (condicionesCheckBox.IsChecked)
                DisplayAlert("Mensaje", "Tu email es:" + email, "Aceptar");
            else
                DisplayAlert("Mensaje", "Tu comentatrio es :"+ textarea, "Aceptar");
            if (this.cursoPicker.SelectedItem == null) 
            DisplayAlert("Atención", "No has seleccionado ningún curso", "Aceptar");
                else
                DisplayAlert("Mensaje", "Curso seleccionado: " + this.cursoPicker.SelectedItem.ToString(), "Aceptar");
        }

        private void notificacionesSwitch_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void volumenSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void fechaDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}
