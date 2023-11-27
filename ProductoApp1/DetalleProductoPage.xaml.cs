using CommunityToolkit.Maui.Core;
using ProductoApp1.Models;
using ProductoApp1.Services;

namespace ProductoApp1;

public partial class DetalleProductoPage : ContentPage
{
    private Producto _producto;
    private readonly APIService _APIService;

    public DetalleProductoPage(APIService apiservice)
	{
		InitializeComponent();
        _APIService = apiservice;

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _producto = BindingContext as Producto;
        Nombre.Text = _producto.Nombre;
        Cantidad.Text = _producto.cantidad.ToString();
        Descripcion.Text = _producto.Descripcion;
    }


    private async void OnClickBorrar(object sender, EventArgs e)
    {
        //Utils.Utils.ListaProductos.Remove(_producto);
        await _APIService.DeleteProducto(_producto.IdProducto);
        await Navigation.PopAsync();
    }

    private async void OnClickEditar(object sender, EventArgs e)
    {
        var toast = CommunityToolkit.Maui.Alerts.Toast.Make(_producto.Nombre, ToastDuration.Short, 14);

        await toast.Show();
        await Navigation.PushAsync(new NuevoProductoPage(_APIService) { 
            BindingContext = _producto,
       });
    }


}