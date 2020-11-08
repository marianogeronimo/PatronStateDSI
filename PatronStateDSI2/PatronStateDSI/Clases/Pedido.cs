using System;

namespace PatronStateDSI.Clases
{
    class Pedido
    {
        int cantComensales;
        string detPedido;
        string factura;
        DateTime fechaHoraPed;
        HistorialEstado historialEstado;
        string nroPedido;

        public Pedido(int cantComensales, string detPedido, string factura, DateTime fechaHoraPed, HistorialEstado historialEstado, string nroPedido)
        {
            this.cantComensales = cantComensales;
            this.detPedido = detPedido;
            this.factura = factura;
            this.fechaHoraPed = fechaHoraPed;
            this.historialEstado = historialEstado;
            this.nroPedido = nroPedido;
        }
    }
}