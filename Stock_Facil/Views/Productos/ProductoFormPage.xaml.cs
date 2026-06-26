using Stock_Facil.Models;
using Stock_Facil.Services;

namespace Stock_Facil.Views.Productos;

public partial class ProductoFormPage : ContentPage
{
    private readonly ProductoService productoService;
    public ProductoFormPage()
	{
		InitializeComponent();

        this.productoService = productoService;
    }

    private async void Guardar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            await DisplayAlert("Error",
                "Debe escribir el nombre.",
                "Aceptar");
            return;
        }

        if (string.IsNullOrWhiteSpace(txtCodigo.Text))
        {
            await DisplayAlert("Error",
                "Debe escribir el código.",
                "Aceptar");
            return;
        }

        Producto producto = new Producto
        {
            Nombre = txtNombre.Text,
            Codigo = txtCodigo.Text,
            Categoria = txtCategoria.Text,
            Precio = decimal.TryParse(txtPrecio.Text, out decimal p) ? p : 0,
            Cantidad = int.TryParse(txtCantidad.Text, out int c) ? c : 0,
            Descripcion = txtDescripcion.Text
        };

        productoService.Agregar(producto);

        await DisplayAlert(
            "Éxito",
            "Producto registrado correctamente.",
            "Aceptar");

        txtNombre.Text = "";
        txtCodigo.Text = "";
        txtCategoria.Text = "";
        txtPrecio.Text = "";
        txtCantidad.Text = "";
        txtDescripcion.Text = "";

        await Shell.Current.GoToAsync("//productos");
    }
}