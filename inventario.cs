using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System.Collections.Generic;

    public class Articulo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Bodega { get; set; }

        // Constructor para inicializar los atributos
        public Articulo(int codigo, string nombre, decimal precio, int cantidad, string bodega)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Bodega = bodega;
        }
    }

    public class GestorArticulos
    {
        private List<Articulo> articulos = new List<Articulo>();

        public void IngresarArticulo(Articulo articulo)
        {
            articulos.Add(articulo);
        }

        public void ModificarArticulo(int codigo, Articulo nuevoArticulo)
        {
            var articulo = articulos.Find(a => a.Codigo == codigo);
            if (articulo != null)
            {
                articulo.Nombre = nuevoArticulo.Nombre;
                articulo.Precio = nuevoArticulo.Precio;
                articulo.Cantidad = nuevoArticulo.Cantidad;
                articulo.Bodega = nuevoArticulo.Bodega;
            }
        }

        public void BorrarArticulo(int codigo)
        {
            articulos.RemoveAll(a => a.Codigo == codigo);
        }

        public List<Articulo> ConsultarArticulos()
        {
            return articulos;
        }

        public Articulo BuscarArticuloPorCodigo(int codigo)
        {
            return articulos.Find(a => a.Codigo == codigo);
        }

        public List<Articulo> BuscarArticulosPorNombre(string nombre)
        {
            return articulos.FindAll(a => a.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase));
        }
    }
}
