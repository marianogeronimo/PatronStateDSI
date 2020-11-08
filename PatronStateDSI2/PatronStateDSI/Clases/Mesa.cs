using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStateDSI.Clases
{
    class Mesa
    {
        int capacidadComensales;
        int espacioQueOcupa;
        Estado estado;
        string filaEnPlano;
        string forma;
        int numero;
        string ordenEnPlano;
        Pedido pedido;

        public Mesa(int capacidadComensales, int espacioQueOcupa, Estado estado, string filaEnPlano, string forma, int numero, string ordenEnPlano, Pedido pedido)
        {
            this.capacidadComensales = capacidadComensales;
            this.espacioQueOcupa = espacioQueOcupa;
            this.estado = estado;
            this.filaEnPlano = filaEnPlano;
            this.forma = forma;
            this.numero = numero;
            this.ordenEnPlano = ordenEnPlano;
            this.pedido = pedido;
        }
    }
}
