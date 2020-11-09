using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState.Clases
{
    class DetallePedido
    {
        string nombreProducto;
        int cantidad;
        float precioUnitario;
        float precioTotal;
        Boolean esMenu;
        Estado estado;
       
        public DetallePedido(string producto, int cant, float precioU, Boolean esMenu)
        {
            EnPreparacion preparacion = new EnPreparacion();
            this.nombreProducto = producto;
            this.cantidad = cant;
            this.PrecioUnitario = precioU;
            this.PrecioTotal = precioU * cant;
            this.EsMenu = esMenu;
            this.estado = preparacion;
        }

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public float PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public bool EsMenu { get => esMenu; set => esMenu = value; }
        internal Estado Estado { get => estado; set => estado = value; }
    }
}
