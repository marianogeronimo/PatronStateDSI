namespace PatronState
{
    partial class FinalizarPedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablaPedidos = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asddasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mozosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaPedidos
            // 
            this.tablaPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.menu,
            this.cantidad,
            this.mesa,
            this.seccion,
            this.mozo});
            this.tablaPedidos.Location = new System.Drawing.Point(13, 48);
            this.tablaPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaPedidos.Name = "tablaPedidos";
            this.tablaPedidos.Size = new System.Drawing.Size(1179, 507);
            this.tablaPedidos.TabIndex = 0;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.Width = 250;
            // 
            // menu
            // 
            this.menu.HeaderText = "Menu";
            this.menu.Name = "menu";
            this.menu.Width = 250;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // mesa
            // 
            this.mesa.HeaderText = "Nro Mesa";
            this.mesa.Name = "mesa";
            // 
            // seccion
            // 
            this.seccion.HeaderText = "Seccion";
            this.seccion.Name = "seccion";
            // 
            // mozo
            // 
            this.mozo.HeaderText = "Mozo";
            this.mozo.Name = "mozo";
            this.mozo.Width = 250;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::PatronState.Properties.Resources.si;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = global::PatronState.Properties.Resources.si;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAceptar.Location = new System.Drawing.Point(1057, 586);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(135, 52);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Location = new System.Drawing.Point(891, 586);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(135, 52);
            this.btnDesmarcar.TabIndex = 5;
            this.btnDesmarcar.Text = "Desmarcar todo";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(729, 586);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 52);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(13, 586);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(76, 52);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.dsaToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asddasToolStripMenuItem});
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.asdToolStripMenuItem.Text = "Inicio";
            // 
            // asddasToolStripMenuItem
            // 
            this.asddasToolStripMenuItem.Name = "asddasToolStripMenuItem";
            this.asddasToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.asddasToolStripMenuItem.Text = "asddas";
            // 
            // dsaToolStripMenuItem
            // 
            this.dsaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.mesasToolStripMenuItem,
            this.mozosToolStripMenuItem});
            this.dsaToolStripMenuItem.Name = "dsaToolStripMenuItem";
            this.dsaToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.dsaToolStripMenuItem.Text = "Restaurante";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizarPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // finalizarPedidosToolStripMenuItem
            // 
            this.finalizarPedidosToolStripMenuItem.Name = "finalizarPedidosToolStripMenuItem";
            this.finalizarPedidosToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.finalizarPedidosToolStripMenuItem.Text = "Finalizar pedidos";
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.mesasToolStripMenuItem.Text = "Mesas";
            // 
            // mozosToolStripMenuItem
            // 
            this.mozosToolStripMenuItem.Name = "mozosToolStripMenuItem";
            this.mozosToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.mozosToolStripMenuItem.Text = "Mozos";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // FinalizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PatronState.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1224, 672);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tablaPedidos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinalizarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar pedido";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPedidos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn mozo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asddasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mozosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarPedidosToolStripMenuItem;
    }
}

