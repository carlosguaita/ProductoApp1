using Android.Widget;
using Microsoft.Maui;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using CommunityToolkit.Maui.Core;

namespace ProductoApp1;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
    {
        InitializeComponent();
        listaProductos.ItemsSource = Utils.Utils.ListaProductos;
    }

    private async void OnClickNuevoProducto(object sender, EventArgs e)
    {
        var toast = CommunityToolkit.Maui.Alerts.Toast.Make("Click en nuevo producto", ToastDuration.Short, 14);

        await toast.Show();
    }
}