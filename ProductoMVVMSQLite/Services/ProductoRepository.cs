using ProductoMVVMSQLite.Models;
using ProductoMVVMSQLite.Utils;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoMVVMSQLite.Services
{
    public class ProductoRepository
    {
        SQLiteConnection connection;
        public ProductoRepository() {

            connection = new SQLiteConnection(Util.DataBasePath, Util.Flags);
            connection.CreateTable<Producto>();
        
        }


        public List<Producto> GetAll()
        {
            List<Producto> ListaProductos = new List<Producto>();
            try{
                ListaProductos = connection.Table<Producto>().ToList();  
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ListaProductos;
        }

        public Producto Get(int IdProducto)
        {
            Producto producto = null;
            try{

                producto = connection.Table<Producto>()
                    .FirstOrDefault(x=>x.IdProducto==IdProducto);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return producto;

        }

        public void Add(Producto producto)
        {
            try
            {
                connection.Insert(producto);
            }catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(Producto producto)
        {
            try
            {
                if (producto.IdProducto != 0)
                {
                    connection.Update(producto);
                }
            }catch(Exception ex) { 
                Console.WriteLine(ex.Message); 
            }
        }

        public void Delete(Producto producto)
        {
            try{
                if (producto.IdProducto != 0)
                {
                    connection.Delete(producto);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
