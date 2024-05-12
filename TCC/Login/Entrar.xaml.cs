namespace TCC.NovaPasta;

public partial class Entrar : ContentPage
{
	public Entrar()
	{
		InitializeComponent();
	}

    private void btn_Login_Clicked(object sender, EventArgs e)
    {

    }

    private async void btn_esqueceu_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login.esqueceuSenha());
    }

}