using TCC.NovaPasta;

namespace TCC
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_Entrar_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Entrar());
        }

        private async void btn_CriarConta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login.CriarConta());
        }
    }

}
