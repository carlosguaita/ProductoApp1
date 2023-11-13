using CommunityToolkit.Maui.Core;
using ProductoApp1.Models;

namespace ProductoApp1;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
	}

    private async void OnClickGuardarNuevoProducto(object sender, EventArgs e)
    {
        var toast = CommunityToolkit.Maui.Alerts.Toast.Make("Click en guardar prodcuto", ToastDuration.Short, 14);

        await toast.Show();

        Producto producto = new Producto
        {
            IdProducto = 0,
            Nombre = Nombre.Text,
            Descripcion = Descripcion.Text,
            cantidad = Int32.Parse(cantidad.Text)
        };

        Utils.Utils.ListaProductos.Add(producto);

    }
}