using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStateDSI.Clases
{
    class DetalleDePedido
    {

        int cantidad;
        DateTime hora;
        float precio;
        HistorialEstado historialEstado;
        Estado estadoActual;

        public DetalleDePedido(int cantidad, DateTime hora, float precio, HistorialEstado historialEstado, Estado estadoActual)
        {
            this.cantidad = cantidad;
            this.hora = hora;
            this.precio = precio;
            this.historialEstado = historialEstado;
            this.estadoActual = estadoActual;
        }
    }
}
