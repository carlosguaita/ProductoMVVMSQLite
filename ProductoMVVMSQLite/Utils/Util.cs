using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductoMVVMSQLite.Models;
using System.Collections.ObjectModel;

namespace ProductoMVVMSQLite.Utils
{
    public static class Util
    {

        public static ObservableCollection<Producto> ListaProductos  {get; set;}

        private const string DBFileName = "productos4.db3";
        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string DataBasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
