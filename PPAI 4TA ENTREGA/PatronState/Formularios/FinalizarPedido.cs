﻿using System;
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

        private void cargar_grilla(Pedido pedido)
        {
            tablaPedidos.Rows.Clear();
            for (int i = 0; i < pedido.Productos.Count; i++)
            {
                tablaPedidos.Rows.Add();
                tablaPedidos.Rows[i].Cells[0].Value = pedido.Productos[i].NombreProducto;
                tablaPedidos.Rows[i].Cells[1].Value = pedido.Productos[i].EsMenu;
                tablaPedidos.Rows[i].Cells[2].Value = pedido.Productos[i].Cantidad;
                tablaPedidos.Rows[i].Cells[3].Value = pedido.Mesa.NumeroMesa;
                tablaPedidos.Rows[i].Cells[4].Value = pedido.Mesa.NombreSeccion;
                tablaPedidos.Rows[i].Cells[5].Value = pedido.Mesa.NombreMozo;
            }

        }

        private void cargar_grilla()
        {
            List<Pedido> pedido = obtenerPedidos();
            tablaPedidos.Rows.Clear();
            for (int y = 0; y < pedido.Count(); y++)
                for (int i = 0; i < pedido[y].Productos.Count; i++)
                {
                    tablaPedidos.Rows.Add();
                    tablaPedidos.Rows[i].Cells[0].Value = pedido[y].Productos[i].NombreProducto;
                    tablaPedidos.Rows[i].Cells[1].Value = pedido[y].Productos[i].EsMenu;
                    tablaPedidos.Rows[i].Cells[2].Value = pedido[y].Productos[i].Cantidad;
                    tablaPedidos.Rows[i].Cells[3].Value = pedido[y].Mesa.NumeroMesa;
                    tablaPedidos.Rows[i].Cells[4].Value = pedido[y].Mesa.NombreSeccion;
                    tablaPedidos.Rows[i].Cells[5].Value = pedido[y].Mesa.NombreMozo;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConfirmarFinalizacion frm_finalizar = new ConfirmarFinalizacion();
            frm_finalizar.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Pedidos frm_pedidos = new Pedidos();
            frm_pedidos.ShowDialog();
        }
    }
}