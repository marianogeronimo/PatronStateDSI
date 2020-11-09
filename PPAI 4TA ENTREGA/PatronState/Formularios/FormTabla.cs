using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatronState.Clases;

namespace PatronState
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cargar_grilla(Pedido pedido)
        {
            dgv1.Rows.Clear();
            for (int i = 0; i < pedido.Productos.Count; i++)
            {
                dgv1.Rows.Add();
                dgv1.Rows[i].Cells[0].Value = pedido.Productos[i].NombreProducto;
                dgv1.Rows[i].Cells[1].Value = pedido.Productos[i].EsMenu;
                dgv1.Rows[i].Cells[2].Value = pedido.Productos[i].Cantidad;
                dgv1.Rows[i].Cells[3].Value = pedido.Mesa.NumeroMesa;
                dgv1.Rows[i].Cells[4].Value = pedido.Mesa.NombreSeccion;
                dgv1.Rows[i].Cells[5].Value = pedido.Mesa.NombreMozo;
            }

        }

        private void cargar_grilla()
        {
            List<Pedido> pedido = obtenerPedidos();
            dgv1.Rows.Clear();
            for (int y = 0; y < pedido.Count(); y++)
                for (int i = 0; i < pedido[y].Productos.Count; i++)
                {
                    dgv1.Rows.Add();
                    dgv1.Rows[i].Cells[0].Value = pedido[y].Productos[i].NombreProducto;
                    dgv1.Rows[i].Cells[1].Value = pedido[y].Productos[i].EsMenu;
                    dgv1.Rows[i].Cells[2].Value = pedido[y].Productos[i].Cantidad;
                    dgv1.Rows[i].Cells[3].Value = pedido[y].Mesa.NumeroMesa;
                    dgv1.Rows[i].Cells[4].Value = pedido[y].Mesa.NombreSeccion;
                    dgv1.Rows[i].Cells[5].Value = pedido[y].Mesa.NombreMozo;
                }

        }

        private List<Pedido> obtenerPedidos()
        {
            Basededatos<Pedido> bd = new Clases.Basededatos<Pedido>("./persistencia/bd_pedidos");
            bd.Cargar();
            return bd.valores;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DetallePedido hamburguesa = new DetallePedido("Hamburguesa", 1, 200, false);
            DetallePedido lomito = new DetallePedido("Lomito de Ternera", 1, 300, false);

            Mesa mesa12 = new Mesa(12, 2, "Seccion 1", "Facundo");


            List<DetallePedido> productos = new List<DetallePedido>();
            productos.Add(hamburguesa);
            productos.Add(lomito);
            Pedido pedido1 = new Pedido(1, DateTime.Now, mesa12,productos);

            cargar_grilla(pedido1);
        }

     
    }
}
