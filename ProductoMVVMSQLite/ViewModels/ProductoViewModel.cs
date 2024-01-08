using ProductoMVVMSQLite.Models;
using ProductoMVVMSQLite.Views;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductoMVVMSQLite.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ProductoViewModel
    {
        ObservableCollection<Producto> ListaProductos { get; set; }

        public ProductoViewModel() { 
            
            ListaProductos = new ObservableCollection<Producto>(App.productoRepository.GetAll());
        
        }

        public ICommand CrearProducto =>
            new Command(async () =>
            {
               await App.Current.MainPage.Navigation.PushAsync(new NuevoProductoPage());
            });

    }
}
