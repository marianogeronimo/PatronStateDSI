﻿using System;
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

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
}