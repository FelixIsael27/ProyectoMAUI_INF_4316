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

    private async void Ingresar_Clicked(object sender, EventArgs e)
    {
        bool acceso = authService.Login(
            txtUsuario.Text ?? "",
            txtPassword.Text ?? "");

        if (!acceso)
        {
            await DisplayAlert(
                "Acceso Denegado",
                "Usuario o Contraseña Incorrectas.",
                "Aceptar");

            return;
        }

        Application.Current.MainPage = new AppShell();
    }
}