using PatronState.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronState.Formularios
{
    public partial class Pedidos : Form
    {

        public Pedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarPedidos_Click(object sender, EventArgs e)
        {
            FinalizarPedido frmFinalizarPerdido = new FinalizarPedido();
            frmFinalizarPerdido.ShowDialog();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            Basededatos.Cargar1();
            cargar_grilla();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void cargar_grilla()
        {

            int c = 0;
            List<Pedido> pedido = Basededatos.valores;
            tablaPedidos.Rows.Clear();
            for (int y = 0; y < pedido.Count(); y++)
                for (int i = 0; i < pedido[y].Productos.Count; i++)
                {

                    tablaPedidos.Rows.Add();
                    tablaPedidos.Rows[c].Cells[0].Value = pedido[y].Productos[i].EstadoActual.getNombre();
                    tablaPedidos.Rows[c].Cells[1].Value = pedido[y].Productos[i].NombreProducto;
                    tablaPedidos.Rows[c].Cells[2].Value = pedido[y].Productos[i].EsMenu;
                    tablaPedidos.Rows[c].Cells[3].Value = pedido[y].Productos[i].Cantidad;
                    tablaPedidos.Rows[c].Cells[4].Value = pedido[y].Mesa.NumeroMesa;
                    tablaPedidos.Rows[c].Cells[5].Value = pedido[y].Mesa.NombreSeccion;
                    tablaPedidos.Rows[c].Cells[6].Value = pedido[y].Mesa.NombreMozo;
                    c += 1;
                    
                }
        }

        private void btn_ActualizarPedido_Click(object sender, EventArgs e)
        {
            cargar_grilla();
        }
    }
}