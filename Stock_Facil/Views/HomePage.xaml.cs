namespace Stock_Facil.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void VerProductos_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//productos");
    }

    private async void RegistrarProducto_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//nuevoProducto");
    }
}