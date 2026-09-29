namespace layouts
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       
        private void VerticalBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.VerticalPage());
        }

        private void HorizontalBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.HorizontalPage());
        }

        private void GridBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.GridPage());

        }

        private void AbsoluteBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.AbsolutePage());
        }

        private void FlexBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.FlexPage());
        }
    }
}
