using ProductoMVVMSQLite.Services;
using ProductoMVVMSQLite.Views;

namespace ProductoMVVMSQLite
{
    public partial class App : Application
    {
        public static ProductoRepository productoRepository {  get; set; }
        public App()
        {
            InitializeComponent();
            productoRepository = new ProductoRepository();
            MainPage = new NavigationPage(new ProductoPage());
        }
    }
}