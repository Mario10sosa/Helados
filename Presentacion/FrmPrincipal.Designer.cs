namespace Presentacion
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TmTiempo = new System.Windows.Forms.Timer(this.components);
            this.LBHora = new System.Windows.Forms.Label();
            this.LBFecha = new System.Windows.Forms.Label();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Pink;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeProductosToolStripMenuItem,
            this.gestionDeProveedoresToolStripMenuItem,
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeComprasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.gestionDeVentasToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1403, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            this.gestionDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.gestionDeProductosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_190__;
            this.gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            this.gestionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            this.gestionDeProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.gestionDeProveedoresToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_28__;
            this.gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            this.gestionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.gestionDeProveedoresToolStripMenuItem.Text = "Gestion de Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.gestionDeClientesToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_74__;
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes ";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // gestionDeComprasToolStripMenuItem
            // 
            this.gestionDeComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem});
            this.gestionDeComprasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_66__;
            this.gestionDeComprasToolStripMenuItem.Name = "gestionDeComprasToolStripMenuItem";
            this.gestionDeComprasToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.gestionDeComprasToolStripMenuItem.Text = "Gestion de Compras";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem1});
            this.inventarioToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_42__;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
            // 
            // gestionDeVentasToolStripMenuItem
            // 
            this.gestionDeVentasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.compra_ini__;
            this.gestionDeVentasToolStripMenuItem.Name = "gestionDeVentasToolStripMenuItem";
            this.gestionDeVentasToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.gestionDeVentasToolStripMenuItem.Text = "Gestion de Ventas";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem});
            this.configuracionToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_49__;
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // TmTiempo
            // 
            this.TmTiempo.Enabled = true;
            this.TmTiempo.Tick += new System.EventHandler(this.TmTiempo_Tick);
            // 
            // LBHora
            // 
            this.LBHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBHora.AutoSize = true;
            this.LBHora.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBHora.ForeColor = System.Drawing.Color.Magenta;
            this.LBHora.Location = new System.Drawing.Point(551, 251);
            this.LBHora.Name = "LBHora";
            this.LBHora.Size = new System.Drawing.Size(242, 50);
            this.LBHora.TabIndex = 1;
            this.LBHora.Text = "3:27:00 p.m";
            // 
            // LBFecha
            // 
            this.LBFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBFecha.AutoSize = true;
            this.LBFecha.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFecha.ForeColor = System.Drawing.Color.Magenta;
            this.LBFecha.Location = new System.Drawing.Point(382, 312);
            this.LBFecha.Name = "LBFecha";
            this.LBFecha.Size = new System.Drawing.Size(548, 52);
            this.LBFecha.TabIndex = 2;
            this.LBFecha.Text = "28 de noviembre del 2022";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 655);
            this.Controls.Add(this.LBFecha);
            this.Controls.Add(this.LBHora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema_Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.Timer TmTiempo;
        private System.Windows.Forms.Label LBHora;
        private System.Windows.Forms.Label LBFecha;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
    }
}

