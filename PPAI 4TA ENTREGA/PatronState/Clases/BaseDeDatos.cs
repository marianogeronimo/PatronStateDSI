using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState.Clases
{
    static class Basededatos
    {
        static public List<Pedido> valores = new List<Pedido>();


        static public void Cargar1()
        {
            if (valores.Count > 0) return;
            // clases iniciales
            // pedido1
            DetallePedido hamburguesa = new DetallePedido("Hamburguesa", 1, 200, false);
            DetallePedido lomito = new DetallePedido("Lomito de Ternera", 1, 300, false);

            Mesa mesa12 = new Mesa(12, 2, "Seccion 3", "Facundo");

            List<DetallePedido> productos = new List<DetallePedido>();
            productos.Add(hamburguesa);
            productos.Add(lomito);

            Pedido pedido1 = new Pedido(1, DateTime.Now, mesa12, productos);

            //pedido2
            DetallePedido pancho = new DetallePedido("Pancho", 2, 100, false);
            DetallePedido papas_fritas = new DetallePedido("Papas Fritas Grandes", 1, 150, false);

            Mesa mesa17 = new Mesa(17, 2, "Seccion 3", "Mariano");

            List<DetallePedido> productos2 = new List<DetallePedido>();
            productos2.Add(pancho);
            productos2.Add(papas_fritas);

            Pedido pedido2 = new Pedido(2, DateTime.Now, mesa17, productos2);

            //pedido3
            DetallePedido picada_4 = new DetallePedido("Picada para 4", 1, 1000, false);
            DetallePedido gaseosa_2lt_CocaCola = new DetallePedido("Coca Cola 2lt.", 1, 175, false);
            DetallePedido cerveza_1lt_Heineken = new DetallePedido("Cerveza Heineken 1lt", 1, 200, false);


            Mesa mesa8 = new Mesa(8, 4, "Seccion 2", "Agustin");

            List<DetallePedido> productos3 = new List<DetallePedido>();
            productos3.Add(picada_4);
            productos3.Add(gaseosa_2lt_CocaCola);
            productos3.Add(cerveza_1lt_Heineken);


            Pedido pedido3 = new Pedido(3, DateTime.Now, mesa8, productos3);

            //pedido4
            DetallePedido milanesa_guarnicion = new DetallePedido("Milanesa con Guarnicion", 1, 250, false);
            DetallePedido gaseosa_2lt_Sprite = new DetallePedido("Sprite 2lt.", 1, 175, false);


            Mesa mesa3 = new Mesa(3, 1, "Seccion 1", "Julian");

            List<DetallePedido> productos4 = new List<DetallePedido>();
            productos4.Add(milanesa_guarnicion);
            productos4.Add(gaseosa_2lt_Sprite);


            Pedido pedido4 = new Pedido(4, DateTime.Now, mesa3, productos4);

            //pedido5
            DetallePedido matambre = new DetallePedido("Matambre Completo", 2, 250, false);
            DetallePedido agua_mineral = new DetallePedido("Agua Mineral sin Gas", 1, 100, false);
            DetallePedido agua_mineral_gas = new DetallePedido("Agua Mineral con Gas", 1, 100, false);


            Mesa mesa14 = new Mesa(14, 2, "Seccion 3", "Gabriel");

            List<DetallePedido> productos5 = new List<DetallePedido>();
            productos5.Add(matambre);
            productos5.Add(agua_mineral);


            Pedido pedido5 = new Pedido(5, DateTime.Now, mesa14, productos5);

            //final
            valores.Add(pedido1);
            valores.Add(pedido2);
            valores.Add(pedido3);
            valores.Add(pedido4);
            valores.Add(pedido5);
        }

        static public List<Pedido> Cargar()
        {
            //if(opcion == 1) {return valores.OrderBy()}
            return valores;
        }


        static public List<Pedido> Buscar(Func<Pedido, bool> criterio)
        {
            return valores.Where(criterio).ToList();
        }


        static public void Actualizar(Func<Pedido, bool> criterio, Pedido nuevo)
        {
            valores = valores.Select(x =>
            {
                if (criterio(x)) x = nuevo;
                return x;
            }).ToList();
        }
    }
}
