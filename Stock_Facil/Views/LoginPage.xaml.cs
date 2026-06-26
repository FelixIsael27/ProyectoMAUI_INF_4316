using Stock_Facil.Services;

namespace Stock_Facil.Views;

public partial class LoginPage : ContentPage
{
    private readonly AuthService authService;

    public LoginPage(AuthService authService)
    {
        InitializeComponent();

        this.authService = authService;
    }

    private async void Login_Clicked(object sender, EventArgs e)
    {
        bool valido = authService.Login(
            txtUsuario.Text ?? "",
            txtPassword.Text ?? "");

        if (!valido)
        {
            await DisplayAlert(
                "Error",
                "Usuario o Contraseña Incorrectas.",
                "Aceptar");

            return;
        }

        Application.Current.MainPage = new AppShell();
    }
}