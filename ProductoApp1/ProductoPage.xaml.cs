
using Microsoft.Maui;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using System.Collections.ObjectModel;
using ProductoApp1.Models;

namespace ProductoApp1;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
    {
        InitializeComponent();
       
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var productos = new ObservableCollection<Producto>(Utils.Utils.ListaProductos);
        listaProductos.ItemsSource = productos;
    }

    private async void OnClickNuevoProducto(object sender, EventArgs e)
    {
        //var toast = Toast.Make("Click en nuevo producto", ToastDuration.Short, 14);

        //await toast.Show();

       await Navigation.PushAsync(new NuevoProductoPage());
    }

    private async void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
    {
        var toast = CommunityToolkit.Maui.Alerts.Toast.Make("Click en ver producto", ToastDuration.Short, 14);

        await toast.Show();
        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushAsync(new DetalleProductoPage()
        {
            BindingContext = producto,
        });
    }
}