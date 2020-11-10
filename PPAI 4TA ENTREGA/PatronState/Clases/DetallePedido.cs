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
        Estado estadoActual;
        List<HistorialEstado> historialEstados;
       
        public DetallePedido(string producto, int cant, float precioU, Boolean esMenu)
        {
            EnPreparacion preparacion = new EnPreparacion();
            this.nombreProducto = producto;
            this.cantidad = cant;
            this.PrecioUnitario = precioU;
            this.PrecioTotal = precioU * cant;
            this.EsMenu = esMenu;
            this.estadoActual = preparacion;
        }

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public float PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public bool EsMenu { get => esMenu; set => esMenu = value; }
        public Estado EstadoActual { get => estadoActual; set => estadoActual = value; }
        internal List<HistorialEstado> HistorialEstados { get => historialEstados; set => historialEstados = value; }

        public void finalizarPreparacion(DateTime fechaHoraActual)
        {

        }


        public void agregarHistorial(HistorialEstado historial)
        {
            historialEstados.Add(historial);
        }

        public void setEstadoActual(Estado estado)
        {
            estadoActual = estado;
        } 
    }
}
