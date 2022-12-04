namespace Presentacion
{
    partial class FrmCompras
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
            this.TxtBuscarClientes = new System.Windows.Forms.TextBox();
            this.CBTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnAnular = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.DtCompra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(1238, 570);
            // 
            // TxtBuscarClientes
            // 
            this.TxtBuscarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarClientes.BackColor = System.Drawing.Color.Linen;
            this.TxtBuscarClientes.Location = new System.Drawing.Point(1045, 38);
            this.TxtBuscarClientes.Multiline = true;
            this.TxtBuscarClientes.Name = "TxtBuscarClientes";
            this.TxtBuscarClientes.Size = new System.Drawing.Size(311, 24);
            this.TxtBuscarClientes.TabIndex = 28;
            // 
            // CBTipoBusqueda
            // 
            this.CBTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBTipoBusqueda.BackColor = System.Drawing.Color.Linen;
            this.CBTipoBusqueda.FormattingEnabled = true;
            this.CBTipoBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "RNC_Cliente"});
            this.CBTipoBusqueda.Location = new System.Drawing.Point(879, 38);
            this.CBTipoBusqueda.Name = "CBTipoBusqueda";
            this.CBTipoBusqueda.Size = new System.Drawing.Size(160, 24);
            this.CBTipoBusqueda.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Buscar:";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnImprimir.BackColor = System.Drawing.Color.Azure;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(267, 544);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(120, 30);
            this.BtnImprimir.TabIndex = 25;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // BtnAnular
            // 
            this.BtnAnular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAnular.BackColor = System.Drawing.Color.Azure;
            this.BtnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnular.Location = new System.Drawing.Point(141, 544);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(120, 30);
            this.BtnAnular.TabIndex = 24;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNuevo.BackColor = System.Drawing.Color.Azure;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(15, 544);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(120, 30);
            this.BtnNuevo.TabIndex = 23;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DtCompra
            // 
            this.DtCompra.AllowUserToAddRows = false;
            this.DtCompra.AllowUserToDeleteRows = false;
            this.DtCompra.AllowUserToOrderColumns = true;
            this.DtCompra.AllowUserToResizeRows = false;
            this.DtCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtCompra.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtCompra.EnableHeadersVisualStyles = false;
            this.DtCompra.Location = new System.Drawing.Point(14, 81);
            this.DtCompra.Name = "DtCompra";
            this.DtCompra.ReadOnly = true;
            this.DtCompra.RowHeadersVisible = false;
            this.DtCompra.RowHeadersWidth = 51;
            this.DtCompra.RowTemplate.Height = 24;
            this.DtCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtCompra.Size = new System.Drawing.Size(1342, 438);
            this.DtCompra.TabIndex = 22;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 612);
            this.Controls.Add(this.TxtBuscarClientes);
            this.Controls.Add(this.CBTipoBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.DtCompra);
            this.Name = "FrmCompras";
            this.Text = "Gestion Compra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.DtCompra, 0);
            this.Controls.SetChildIndex(this.BtnNuevo, 0);
            this.Controls.SetChildIndex(this.BtnAnular, 0);
            this.Controls.SetChildIndex(this.BtnImprimir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.CBTipoBusqueda, 0);
            this.Controls.SetChildIndex(this.TxtBuscarClientes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DtCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarClientes;
        private System.Windows.Forms.ComboBox CBTipoBusqueda;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnImprimir;
        public System.Windows.Forms.Button BtnAnular;
        public System.Windows.Forms.Button BtnNuevo;
        public System.Windows.Forms.DataGridView DtCompra;
    }
}