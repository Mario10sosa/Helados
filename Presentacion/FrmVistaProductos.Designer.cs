namespace Presentacion
{
    partial class FrmVistaProductos
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
            this.DtVistaProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtVistaProductos)).BeginInit();
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
            this.TxtBuscarProveedores.Location = new System.Drawing.Point(1043, 53);
            this.TxtBuscarProveedores.Multiline = true;
            this.TxtBuscarProveedores.Name = "TxtBuscarProveedores";
            this.TxtBuscarProveedores.Size = new System.Drawing.Size(311, 24);
            this.TxtBuscarProveedores.TabIndex = 22;
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
            this.CBTipoBusqueda.Location = new System.Drawing.Point(877, 53);
            this.CBTipoBusqueda.Name = "CBTipoBusqueda";
            this.CBTipoBusqueda.Size = new System.Drawing.Size(160, 24);
            this.CBTipoBusqueda.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(808, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar";
            // 
            // DtVistaProductos
            // 
            this.DtVistaProductos.AllowUserToAddRows = false;
            this.DtVistaProductos.AllowUserToDeleteRows = false;
            this.DtVistaProductos.AllowUserToOrderColumns = true;
            this.DtVistaProductos.AllowUserToResizeRows = false;
            this.DtVistaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtVistaProductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtVistaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtVistaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtVistaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtVistaProductos.EnableHeadersVisualStyles = false;
            this.DtVistaProductos.Location = new System.Drawing.Point(12, 100);
            this.DtVistaProductos.Name = "DtVistaProductos";
            this.DtVistaProductos.ReadOnly = true;
            this.DtVistaProductos.RowHeadersVisible = false;
            this.DtVistaProductos.RowHeadersWidth = 51;
            this.DtVistaProductos.RowTemplate.Height = 24;
            this.DtVistaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtVistaProductos.Size = new System.Drawing.Size(1342, 428);
            this.DtVistaProductos.TabIndex = 19;
            this.DtVistaProductos.DoubleClick += new System.EventHandler(this.DtVistaProductos_DoubleClick);
            // 
            // FrmVistaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 581);
            this.Controls.Add(this.TxtBuscarProveedores);
            this.Controls.Add(this.CBTipoBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtVistaProductos);
            this.Name = "FrmVistaProductos";
            this.Text = "FrmVistaProductos";
            this.Load += new System.EventHandler(this.FrmVistaProductos_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.DtVistaProductos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.CBTipoBusqueda, 0);
            this.Controls.SetChildIndex(this.TxtBuscarProveedores, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DtVistaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarProveedores;
        private System.Windows.Forms.ComboBox CBTipoBusqueda;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DtVistaProductos;
    }
}