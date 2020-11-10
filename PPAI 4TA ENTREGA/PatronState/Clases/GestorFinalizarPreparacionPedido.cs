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

        public List<Pedido> finalizarPedido()
        {
            // List<DetallePedido> detallesEnPreparacion = buscarDetallePedidosEnPreparacion();
            return Basededatos.valores;
        }



        // metodos que no se usan pero seria la manera correcta
        // ---------------------------------------------------------------------------------
        private List<DetallePedido> buscarDetallePedidosEnPreparacion()
        {
            List<Pedido> pedidos = Basededatos.valores;
            List<DetallePedido> detallesEnPreparacion = new List<DetallePedido>();
            for (int i = 0; i < pedidos.Count; i++)
            {
                foreach (DetallePedido dp in pedidos[i].Productos)
                    if (dp.EstadoActual is EnPreparacion)
                        detallesEnPreparacion.Add(dp);
            }
            ordenarSegunMayorTiempoEspera(detallesEnPreparacion);
            return detallesEnPreparacion;

        }

        private void ordenarSegunMayorTiempoEspera(List<DetallePedido> detalles)
        {
            //detalles.OrderBy(x => x.Hora);
        }
    }
}
