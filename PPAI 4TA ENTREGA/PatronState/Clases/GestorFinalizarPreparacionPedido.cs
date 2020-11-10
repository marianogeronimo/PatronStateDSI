using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState.Clases
{
    class GestorFinalizarPreparacionPedido
    {

        DateTime fechaHoraActual;
        List<DetallePedido> detallePedidoSeleccionado;

        public GestorFinalizarPreparacionPedido()
        {
            fechaHoraActual = DateTime.Now;
        }

        public DateTime FechaHoraActual { get => fechaHoraActual; set => fechaHoraActual = value; }
        internal List<DetallePedido> DetallePedidoSeleccionado { get => detallePedidoSeleccionado; set => detallePedidoSeleccionado = value; }

        public void actualizarEstadoAListoParaServir()
        {
            foreach (DetallePedido dp in detallePedidoSeleccionado)
            {
                dp.finalizarPreparacion(fechaHoraActual);
            }
        }

        public void actualizarEstadoNotificado()
        {
            foreach (DetallePedido dp in detallePedidoSeleccionado)
            {
                dp.notificar(fechaHoraActual);
            }
        }

        public void confirmacionElaboracion()
        {
            actualizarEstadoAListoParaServir();
        }

        public void detalleDePedidoSeleccionado(List<DetallePedido> detalles)
        {
            detallePedidoSeleccionado = detalles;
        }
    }
}
