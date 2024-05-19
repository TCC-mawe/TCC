namespace TCC.Login;

public partial class Entrar : ContentPage
{
	public Entrar()
	{
		InitializeComponent();
	}

    private async void btn_Login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login.paginaInicial());
    }

    private async void btn_esqueceu_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login.esqueceuSenha());
    }

}