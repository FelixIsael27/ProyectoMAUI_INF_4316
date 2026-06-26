using Stock_Facil.Services;

namespace Stock_Facil.Views.Productos;

public partial class ProductoListPage : ContentPage
{
    private readonly ProductoService productoService;
    public ProductoListPage()
	{
		InitializeComponent();

        this.productoService = productoService;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        ListaProductos.ItemsSource = null;
        ListaProductos.ItemsSource = productoService.ObtenerTodos();
    }

    private async void NuevoProducto_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//nuevoProducto");
    }
}