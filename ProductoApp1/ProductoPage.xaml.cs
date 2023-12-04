
using Microsoft.Maui;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using System.Collections.ObjectModel;
using ProductoApp1.Models;
using ProductoApp1.Services;

namespace ProductoApp1;

public partial class ProductoPage : ContentPage
{
    private readonly APIService _APIService;
	public ProductoPage(APIService apiservice)
    {
        InitializeComponent();
        _APIService = apiservice;
     

       
    }

    private async void validarLogin()
    {
        if (Preferences.Get("username", "0").Equals("0"))
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        validarLogin();
        string username = Preferences.Get("username", "0");
        Username.Text = username;
        List<Producto> ListaProducto = await _APIService.GetProductos();
        var productos = new ObservableCollection<Producto>(ListaProducto);
        listaProductos.ItemsSource = productos;
    }

    private async void OnClickNuevoProducto(object sender, EventArgs e)
    {
        //var toast = Toast.Make("Click en nuevo producto", ToastDuration.Short, 14);

        //await toast.Show();

       await Navigation.PushAsync(new NuevoProductoPage(_APIService));
    }

    private async void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
    {
        var toast = CommunityToolkit.Maui.Alerts.Toast.Make("Click en ver producto", ToastDuration.Short, 14);

        await toast.Show();
        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushAsync(new DetalleProductoPage(_APIService)
        {
            BindingContext = producto,
        });
    }

    private async void OnClickLogout(object sender, EventArgs e)
    {
        Preferences.Set("username", "0");
        await Navigation.PushAsync(new LoginPage());
    }
}