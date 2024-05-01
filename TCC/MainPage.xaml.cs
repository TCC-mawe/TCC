using TCC.NovaPasta;

namespace TCC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_Entrar_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Entrar());
        }

        private void btn_CriarConta_Clicked(object sender, EventArgs e)
        {

        }
    }

}
