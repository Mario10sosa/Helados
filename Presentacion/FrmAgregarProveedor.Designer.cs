namespace Presentacion
{
    partial class FrmAgregarProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRncProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmailProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MTxtTelefonoProveedor = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(502, 232);
            this.BtnCancelar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Proveedor:";
            // 
            // TxtCodigoProveedor
            // 
            this.TxtCodigoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtCodigoProveedor.Enabled = false;
            this.TxtCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProveedor.Location = new System.Drawing.Point(24, 50);
            this.TxtCodigoProveedor.Multiline = true;
            this.TxtCodigoProveedor.Name = "TxtCodigoProveedor";
            this.TxtCodigoProveedor.Size = new System.Drawing.Size(180, 25);
            this.TxtCodigoProveedor.TabIndex = 0;
            this.TxtCodigoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProveedor.Location = new System.Drawing.Point(223, 50);
            this.TxtNombreProveedor.Multiline = true;
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(394, 25);
            this.TxtNombreProveedor.TabIndex = 4;
            this.TxtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Proveedor:";
            // 
            // TxtRncProveedor
            // 
            this.TxtRncProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtRncProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRncProveedor.Location = new System.Drawing.Point(24, 121);
            this.TxtRncProveedor.Multiline = true;
            this.TxtRncProveedor.Name = "TxtRncProveedor";
            this.TxtRncProveedor.Size = new System.Drawing.Size(180, 25);
            this.TxtRncProveedor.TabIndex = 8;
            this.TxtRncProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRncProveedor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "RNC Proveedor:";
            // 
            // TxtDireccionProveedor
            // 
            this.TxtDireccionProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtDireccionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionProveedor.Location = new System.Drawing.Point(223, 121);
            this.TxtDireccionProveedor.Multiline = true;
            this.TxtDireccionProveedor.Name = "TxtDireccionProveedor";
            this.TxtDireccionProveedor.Size = new System.Drawing.Size(394, 25);
            this.TxtDireccionProveedor.TabIndex = 10;
            this.TxtDireccionProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccionProveedor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direccion Proveedor:";
            // 
            // TxtEmailProveedor
            // 
            this.TxtEmailProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtEmailProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailProveedor.Location = new System.Drawing.Point(223, 188);
            this.TxtEmailProveedor.Multiline = true;
            this.TxtEmailProveedor.Name = "TxtEmailProveedor";
            this.TxtEmailProveedor.Size = new System.Drawing.Size(327, 25);
            this.TxtEmailProveedor.TabIndex = 12;
            this.TxtEmailProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailProveedor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email Proveedor:";
            // 
            // MTxtTelefonoProveedor
            // 
            this.MTxtTelefonoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MTxtTelefonoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtTelefonoProveedor.Location = new System.Drawing.Point(24, 188);
            this.MTxtTelefonoProveedor.Mask = "000-000-0000";
            this.MTxtTelefonoProveedor.Name = "MTxtTelefonoProveedor";
            this.MTxtTelefonoProveedor.Size = new System.Drawing.Size(180, 28);
            this.MTxtTelefonoProveedor.TabIndex = 13;
            this.MTxtTelefonoProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTxtTelefonoProveedor_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefono Proveedor:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(376, 232);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 30);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmAgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 274);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MTxtTelefonoProveedor);
            this.Controls.Add(this.TxtEmailProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDireccionProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtRncProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombreProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigoProveedor);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarProveedor";
            this.Text = "FrmAgregarProveedor";
            this.Load += new System.EventHandler(this.FrmAgregarProveedor_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtCodigoProveedor, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNombreProveedor, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtRncProveedor, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.TxtDireccionProveedor, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtEmailProveedor, 0);
            this.Controls.SetChildIndex(this.MTxtTelefonoProveedor, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.BtnAgregar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtCodigoProveedor;
        public System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtRncProveedor;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtDireccionProveedor;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtEmailProveedor;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox MTxtTelefonoProveedor;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button BtnAgregar;
    }
}