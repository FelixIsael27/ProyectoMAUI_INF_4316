using StockFacil.Views;
using StockFacil.Views.Productos;

namespace Stock_Facil
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(ProductoListPage), typeof(ProductoListPage));
            Routing.RegisterRoute(nameof(ProductoFormPage), typeof(ProductoFormPage));
        }
    }

    private void CerrarSesion_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage =
                new NavigationPage(
                    new LoginPage(new Services.AuthService()));
        }
    }
