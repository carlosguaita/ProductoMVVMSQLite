using ProductoMVVMSQLite.ViewModels;

namespace ProductoMVVMSQLite.Views;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
		BindingContext = new NuevoProductoViewModel();
	}

    public NuevoProductoPage(int IdProducto)
    {
        InitializeComponent();
        BindingContext = new NuevoProductoViewModel(IdProducto);
    }
}