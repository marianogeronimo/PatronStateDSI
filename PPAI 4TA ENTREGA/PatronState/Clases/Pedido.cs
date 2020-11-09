using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState.Clases
{
    class Pedido
    {
        int numeroPedido;
        DateTime fechaHoraPedido;
        Mesa mesa;
        List<DetallePedido> productos;

        public Pedido(int nroPedido, DateTime fechaHora, Mesa mesa, List<DetallePedido> productos)
        {
            this.numeroPedido = nroPedido;
            this.fechaHoraPedido = fechaHora;
            this.mesa = mesa;
            this.Productos = productos;

        }

        public int NumeroPedido { get => numeroPedido; set => numeroPedido = value; }
        public DateTime FechaHoraPedido { get => fechaHoraPedido; set => fechaHoraPedido = value; }
        public List<DetallePedido> Productos { get => productos; set => productos = value; }
        public Mesa Mesa { get => mesa; set => mesa = value; }
    }
}
