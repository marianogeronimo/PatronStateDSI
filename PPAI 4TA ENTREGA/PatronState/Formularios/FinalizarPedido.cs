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
using PatronState.Formularios;

namespace PatronState
{
    public partial class FinalizarPedido : Form
    {
        public FinalizarPedido()
        {
            InitializeComponent();
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
                    tablaPedidos.Rows[c].Cells[1].Value = pedido[y].Productos[i].NombreProducto;
                    tablaPedidos.Rows[c].Cells[2].Value = pedido[y].Productos[i].EsMenu;
                    tablaPedidos.Rows[c].Cells[3].Value = pedido[y].Productos[i].Cantidad;
                    tablaPedidos.Rows[c].Cells[4].Value = pedido[y].Mesa.NumeroMesa;
                    c += 1;
                }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Basededatos.Cargar1();
            cargar_grilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConfirmarFinalizacion frm_finalizar = new ConfirmarFinalizacion();
            frm_finalizar.Show();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection filas = tablaPedidos.Rows;
            foreach (DataGridViewRow fila in filas)
            {
                fila.Cells[0].Value = false;
            }
        }
    }
}
