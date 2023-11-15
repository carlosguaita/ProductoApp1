using ProductoApp1.Models;

namespace ProductoApp1;

public partial class DetalleProductoPage : ContentPage
{

	public DetalleProductoPage()
	{
		InitializeComponent();
       
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Producto producto = BindingContext as Producto;
        Nombre.Text = producto.Nombre;
        Cantidad.Text = producto.cantidad.ToString();
        Descripcion.Text = producto.Descripcion;
    }

    private async void OnClickVolver(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}