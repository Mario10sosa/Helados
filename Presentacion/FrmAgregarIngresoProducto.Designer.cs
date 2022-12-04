namespace Presentacion
{
    partial class FrmAgregarIngresoProducto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.TxtId_Proveedor = new System.Windows.Forms.TextBox();
            this.TxtId_Ingreso = new System.Windows.Forms.TextBox();
            this.TxtComprobante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNo_Ingreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtId_Detalle = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.TxtCosto_Unitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBuscar_Producto = new System.Windows.Forms.Button();
            this.TxtId_Producto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNomProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCodigo_Producto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DtIngreso_Producto = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTotal_Pago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtIngreso_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(914, 692);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DtpFecha_Ingreso);
            this.groupBox1.Controls.Add(this.BtnBuscarProveedor);
            this.groupBox1.Controls.Add(this.TxtId_Proveedor);
            this.groupBox1.Controls.Add(this.TxtId_Ingreso);
            this.groupBox1.Controls.Add(this.TxtComprobante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNombreProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNo_Ingreso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(660, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fecha Ingresado:";
            // 
            // DtpFecha_Ingreso
            // 
            this.DtpFecha_Ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha_Ingreso.Location = new System.Drawing.Point(664, 61);
            this.DtpFecha_Ingreso.Name = "DtpFecha_Ingreso";
            this.DtpFecha_Ingreso.Size = new System.Drawing.Size(200, 28);
            this.DtpFecha_Ingreso.TabIndex = 32;
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarProveedor.BackColor = System.Drawing.Color.Azure;
            this.BtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(611, 60);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(47, 26);
            this.BtnBuscarProveedor.TabIndex = 31;
            this.BtnBuscarProveedor.Text = "***";
            this.BtnBuscarProveedor.UseVisualStyleBackColor = false;
            this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
            // 
            // TxtId_Proveedor
            // 
            this.TxtId_Proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtId_Proveedor.Location = new System.Drawing.Point(282, 61);
            this.TxtId_Proveedor.Multiline = true;
            this.TxtId_Proveedor.Name = "TxtId_Proveedor";
            this.TxtId_Proveedor.Size = new System.Drawing.Size(30, 26);
            this.TxtId_Proveedor.TabIndex = 7;
            this.TxtId_Proveedor.Visible = false;
            // 
            // TxtId_Ingreso
            // 
            this.TxtId_Ingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtId_Ingreso.Location = new System.Drawing.Point(17, 61);
            this.TxtId_Ingreso.Multiline = true;
            this.TxtId_Ingreso.Name = "TxtId_Ingreso";
            this.TxtId_Ingreso.Size = new System.Drawing.Size(30, 26);
            this.TxtId_Ingreso.TabIndex = 6;
            this.TxtId_Ingreso.Visible = false;
            // 
            // TxtComprobante
            // 
            this.TxtComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtComprobante.Location = new System.Drawing.Point(46, 118);
            this.TxtComprobante.Multiline = true;
            this.TxtComprobante.Name = "TxtComprobante";
            this.TxtComprobante.Size = new System.Drawing.Size(230, 26);
            this.TxtComprobante.TabIndex = 5;
            this.TxtComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtComprobante_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(42, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero De Comprobante:";
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtNombreProveedor.Location = new System.Drawing.Point(311, 61);
            this.TxtNombreProveedor.Multiline = true;
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.ReadOnly = true;
            this.TxtNombreProveedor.Size = new System.Drawing.Size(294, 26);
            this.TxtNombreProveedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(307, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Proveedor:";
            // 
            // TxtNo_Ingreso
            // 
            this.TxtNo_Ingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtNo_Ingreso.Location = new System.Drawing.Point(46, 61);
            this.TxtNo_Ingreso.Multiline = true;
            this.TxtNo_Ingreso.Name = "TxtNo_Ingreso";
            this.TxtNo_Ingreso.ReadOnly = true;
            this.TxtNo_Ingreso.Size = new System.Drawing.Size(230, 26);
            this.TxtNo_Ingreso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No De Ingreso:\r\n";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(788, 692);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 30);
            this.BtnAgregar.TabIndex = 30;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.TxtId_Detalle);
            this.groupBox2.Controls.Add(this.BtnEliminar);
            this.groupBox2.Controls.Add(this.BtnAgregarProducto);
            this.groupBox2.Controls.Add(this.TxtCosto_Unitario);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BtnBuscar_Producto);
            this.groupBox2.Controls.Add(this.TxtId_Producto);
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtNomProducto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtCodigo_Producto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox2.Location = new System.Drawing.Point(14, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1020, 170);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Productos";
            // 
            // TxtId_Detalle
            // 
            this.TxtId_Detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtId_Detalle.Location = new System.Drawing.Point(17, 118);
            this.TxtId_Detalle.Multiline = true;
            this.TxtId_Detalle.Name = "TxtId_Detalle";
            this.TxtId_Detalle.Size = new System.Drawing.Size(30, 26);
            this.TxtId_Detalle.TabIndex = 34;
            this.TxtId_Detalle.Visible = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.BackColor = System.Drawing.Color.Azure;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEliminar.Location = new System.Drawing.Point(916, 118);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(83, 35);
            this.BtnEliminar.TabIndex = 35;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(916, 61);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(83, 35);
            this.BtnAgregarProducto.TabIndex = 34;
            this.BtnAgregarProducto.Text = "Agregar";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // TxtCosto_Unitario
            // 
            this.TxtCosto_Unitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtCosto_Unitario.Location = new System.Drawing.Point(664, 60);
            this.TxtCosto_Unitario.Multiline = true;
            this.TxtCosto_Unitario.Name = "TxtCosto_Unitario";
            this.TxtCosto_Unitario.ReadOnly = true;
            this.TxtCosto_Unitario.Size = new System.Drawing.Size(230, 26);
            this.TxtCosto_Unitario.TabIndex = 33;
            this.TxtCosto_Unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(660, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Costo Unitario:";
            // 
            // BtnBuscar_Producto
            // 
            this.BtnBuscar_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar_Producto.BackColor = System.Drawing.Color.Azure;
            this.BtnBuscar_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar_Producto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBuscar_Producto.Location = new System.Drawing.Point(611, 61);
            this.BtnBuscar_Producto.Name = "BtnBuscar_Producto";
            this.BtnBuscar_Producto.Size = new System.Drawing.Size(47, 26);
            this.BtnBuscar_Producto.TabIndex = 31;
            this.BtnBuscar_Producto.Text = "***";
            this.BtnBuscar_Producto.UseVisualStyleBackColor = false;
            this.BtnBuscar_Producto.Click += new System.EventHandler(this.BtnBuscar_Producto_Click);
            // 
            // TxtId_Producto
            // 
            this.TxtId_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtId_Producto.Location = new System.Drawing.Point(17, 61);
            this.TxtId_Producto.Multiline = true;
            this.TxtId_Producto.Name = "TxtId_Producto";
            this.TxtId_Producto.Size = new System.Drawing.Size(30, 26);
            this.TxtId_Producto.TabIndex = 6;
            this.TxtId_Producto.Visible = false;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtCantidad.Location = new System.Drawing.Point(46, 118);
            this.TxtCantidad.Multiline = true;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(230, 26);
            this.TxtCantidad.TabIndex = 5;
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(42, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantidad:";
            // 
            // TxtNomProducto
            // 
            this.TxtNomProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtNomProducto.Location = new System.Drawing.Point(284, 61);
            this.TxtNomProducto.Multiline = true;
            this.TxtNomProducto.Name = "TxtNomProducto";
            this.TxtNomProducto.ReadOnly = true;
            this.TxtNomProducto.Size = new System.Drawing.Size(321, 26);
            this.TxtNomProducto.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(280, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre Producto:";
            // 
            // TxtCodigo_Producto
            // 
            this.TxtCodigo_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtCodigo_Producto.Location = new System.Drawing.Point(46, 61);
            this.TxtCodigo_Producto.Multiline = true;
            this.TxtCodigo_Producto.Name = "TxtCodigo_Producto";
            this.TxtCodigo_Producto.ReadOnly = true;
            this.TxtCodigo_Producto.Size = new System.Drawing.Size(230, 26);
            this.TxtCodigo_Producto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(42, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codigo Producto:";
            // 
            // DtIngreso_Producto
            // 
            this.DtIngreso_Producto.AllowUserToAddRows = false;
            this.DtIngreso_Producto.AllowUserToDeleteRows = false;
            this.DtIngreso_Producto.AllowUserToOrderColumns = true;
            this.DtIngreso_Producto.AllowUserToResizeRows = false;
            this.DtIngreso_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtIngreso_Producto.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtIngreso_Producto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtIngreso_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtIngreso_Producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Nombre,
            this.Cantidad,
            this.Costo_Unitario,
            this.Sub_Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtIngreso_Producto.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtIngreso_Producto.EnableHeadersVisualStyles = false;
            this.DtIngreso_Producto.Location = new System.Drawing.Point(12, 375);
            this.DtIngreso_Producto.Name = "DtIngreso_Producto";
            this.DtIngreso_Producto.ReadOnly = true;
            this.DtIngreso_Producto.RowHeadersVisible = false;
            this.DtIngreso_Producto.RowHeadersWidth = 51;
            this.DtIngreso_Producto.RowTemplate.Height = 24;
            this.DtIngreso_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtIngreso_Producto.Size = new System.Drawing.Size(1022, 282);
            this.DtIngreso_Producto.TabIndex = 35;
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id Producto";
            this.Id_Producto.MinimumWidth = 6;
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            this.Id_Producto.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Costo_Unitario
            // 
            this.Costo_Unitario.HeaderText = "Costo Unitario";
            this.Costo_Unitario.MinimumWidth = 6;
            this.Costo_Unitario.Name = "Costo_Unitario";
            this.Costo_Unitario.ReadOnly = true;
            this.Costo_Unitario.Width = 125;
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.MinimumWidth = 6;
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            this.Sub_Total.Width = 125;
            // 
            // TxtTotal_Pago
            // 
            this.TxtTotal_Pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtTotal_Pago.Enabled = false;
            this.TxtTotal_Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal_Pago.Location = new System.Drawing.Point(144, 698);
            this.TxtTotal_Pago.Multiline = true;
            this.TxtTotal_Pago.Name = "TxtTotal_Pago";
            this.TxtTotal_Pago.Size = new System.Drawing.Size(230, 26);
            this.TxtTotal_Pago.TabIndex = 37;
            this.TxtTotal_Pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(17, 698);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Total Pagar:";
            // 
            // FrmAgregarIngresoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 734);
            this.Controls.Add(this.TxtTotal_Pago);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtIngreso_Producto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAgregarIngresoProducto";
            this.Text = "Agregar Ingreso Producto";
            this.Load += new System.EventHandler(this.FrmAgregarIngresoProducto_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.BtnAgregar, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.DtIngreso_Producto, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.TxtTotal_Pago, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtIngreso_Producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TxtId_Proveedor;
        public System.Windows.Forms.TextBox TxtId_Ingreso;
        public System.Windows.Forms.TextBox TxtComprobante;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtNo_Ingreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker DtpFecha_Ingreso;
        public System.Windows.Forms.Button BtnBuscarProveedor;
        public System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button BtnEliminar;
        public System.Windows.Forms.Button BtnAgregarProducto;
        public System.Windows.Forms.TextBox TxtCosto_Unitario;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BtnBuscar_Producto;
        public System.Windows.Forms.TextBox TxtId_Producto;
        public System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtNomProducto;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtCodigo_Producto;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView DtIngreso_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        public System.Windows.Forms.TextBox TxtTotal_Pago;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TxtId_Detalle;
    }
}