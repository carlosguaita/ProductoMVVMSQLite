using PropertyChanged;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoMVVMSQLite.Models
{
    [AddINotifyPropertyChangedInterface]
    [Table("Productos")]
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int IdProducto { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("descripcion")]
        public string Descripcion { get; set; }
        [Column("cantidad")]
        public int Cantidad { get; set;}
        [Column("imagen")]
        public string Imagen { get; set; }

        [Ignore]
        public ImageSource ImagenProducto
        {
            get
            {
                return ImageSource.FromFile(Imagen);
            }
        }
    }
}
