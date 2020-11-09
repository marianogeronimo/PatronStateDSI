using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState.Clases
{
    class Basededatos
    {
        public List<Pedido> valores = new List<Pedido>();


        public void Cargar1()
        {
            // clases iniciales
            // pedido1
            DetallePedido hamburguesa = new DetallePedido("Hamburguesa", 1, 200, false);
            DetallePedido lomito = new DetallePedido("Lomito de Ternera", 1, 300, false);

            Mesa mesa12 = new Mesa(12, 2, "Seccion 1", "Facundo");

            List<DetallePedido> productos = new List<DetallePedido>();
            productos.Add(hamburguesa);
            productos.Add(lomito);

            Pedido pedido1 = new Pedido(1, DateTime.Now, mesa12, productos);

            //pedido2


            //final
            valores.Add(pedido1);
        }

        public List<Pedido> Cargar()
        {
            //if(opcion == 1) {return valores.OrderBy()}
            return valores;
        }


        public List<Pedido> Buscar(Func<Pedido, bool> criterio)
        {
            return valores.Where(criterio).ToList();
        }


        public void Actualizar(Func<Pedido, bool> criterio, Pedido nuevo)
        {
            valores = valores.Select(x =>
            {
                if (criterio(x)) x = nuevo;
                return x;
            }).ToList();
        }
    }
}
