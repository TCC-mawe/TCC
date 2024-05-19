namespace TCC.Login;

public partial class CriarConta : TabbedPage
{
	public CriarConta()
	{
		InitializeComponent();
	}

    private async void btn_Logon_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login.SobreNos());
    }
}