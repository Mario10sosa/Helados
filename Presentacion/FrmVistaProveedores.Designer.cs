namespace Presentacion
{
    partial class FrmVistaProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtBuscarProveedores = new System.Windows.Forms.TextBox();
            this.CBTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtVistaProveedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtVistaProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(1234, 539);
            // 
            // TxtBuscarProveedores
            // 
            this.TxtBuscarProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarProveedores.BackColor = System.Drawing.Color.Linen;
            this.TxtBuscarProveedores.Location = new System.Drawing.Point(1043, 36);
            this.TxtBuscarProveedores.Multiline = true;
            this.TxtBuscarProveedores.Name = "TxtBuscarProveedores";
            this.TxtBuscarProveedores.Size = new System.Drawing.Size(311, 24);
            this.TxtBuscarProveedores.TabIndex = 18;
            // 
            // CBTipoBusqueda
            // 
            this.CBTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBTipoBusqueda.BackColor = System.Drawing.Color.Linen;
            this.CBTipoBusqueda.FormattingEnabled = true;
            this.CBTipoBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "RNC_Proveedor"});
            this.CBTipoBusqueda.Location = new System.Drawing.Point(877, 36);
            this.CBTipoBusqueda.Name = "CBTipoBusqueda";
            this.CBTipoBusqueda.Size = new System.Drawing.Size(160, 24);
            this.CBTipoBusqueda.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(808, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar";
            // 
            // DtVistaProveedor
            // 
            this.DtVistaProveedor.AllowUserToAddRows = false;
            this.DtVistaProveedor.AllowUserToDeleteRows = false;
            this.DtVistaProveedor.AllowUserToOrderColumns = true;
            this.DtVistaProveedor.AllowUserToResizeRows = false;
            this.DtVistaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtVistaProveedor.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtVistaProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtVistaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtVistaProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtVistaProveedor.EnableHeadersVisualStyles = false;
            this.DtVistaProveedor.Location = new System.Drawing.Point(12, 83);
            this.DtVistaProveedor.Name = "DtVistaProveedor";
            this.DtVistaProveedor.ReadOnly = true;
            this.DtVistaProveedor.RowHeadersVisible = false;
            this.DtVistaProveedor.RowHeadersWidth = 51;
            this.DtVistaProveedor.RowTemplate.Height = 24;
            this.DtVistaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtVistaProveedor.Size = new System.Drawing.Size(1342, 428);
            this.DtVistaProveedor.TabIndex = 15;
            this.DtVistaProveedor.DoubleClick += new System.EventHandler(this.DtVistaProveedor_DoubleClick);
            // 
            // FrmVistaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 581);
            this.Controls.Add(this.TxtBuscarProveedores);
            this.Controls.Add(this.CBTipoBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtVistaProveedor);
            this.Name = "FrmVistaProveedores";
            this.Text = "Vista Proveedores";
            this.Load += new System.EventHandler(this.FrmVistaProveedores_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.DtVistaProveedor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.CBTipoBusqueda, 0);
            this.Controls.SetChildIndex(this.TxtBuscarProveedores, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DtVistaProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarProveedores;
        private System.Windows.Forms.ComboBox CBTipoBusqueda;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DtVistaProveedor;
    }
}