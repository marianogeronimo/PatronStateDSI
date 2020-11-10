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

        GestorFinalizarPreparacionPedido()
        {
            fechaHoraActual = DateTime.Now;
        }

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

    }
}
