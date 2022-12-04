namespace Presentacion
{
    partial class FrmEditarEmpresa
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
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MTxtTelefonoEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRncEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdEmpresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(566, 208);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.Azure;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(438, 208);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 30);
            this.BtnEditar.TabIndex = 41;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Telefono Empresa";
            // 
            // MTxtTelefonoEmpresa
            // 
            this.MTxtTelefonoEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MTxtTelefonoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtTelefonoEmpresa.Location = new System.Drawing.Point(379, 118);
            this.MTxtTelefonoEmpresa.Mask = "000-000-0000";
            this.MTxtTelefonoEmpresa.Name = "MTxtTelefonoEmpresa";
            this.MTxtTelefonoEmpresa.Size = new System.Drawing.Size(264, 28);
            this.MTxtTelefonoEmpresa.TabIndex = 39;
            this.MTxtTelefonoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTxtTelefonoEmpresa_KeyPress);
            // 
            // TxtEmailEmpresa
            // 
            this.TxtEmailEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtEmailEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailEmpresa.Location = new System.Drawing.Point(33, 182);
            this.TxtEmailEmpresa.Multiline = true;
            this.TxtEmailEmpresa.Name = "TxtEmailEmpresa";
            this.TxtEmailEmpresa.Size = new System.Drawing.Size(277, 25);
            this.TxtEmailEmpresa.TabIndex = 38;
            this.TxtEmailEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailEmpresa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email Empresa";
            // 
            // TxtDireccionEmpresa
            // 
            this.TxtDireccionEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtDireccionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionEmpresa.Location = new System.Drawing.Point(32, 121);
            this.TxtDireccionEmpresa.Multiline = true;
            this.TxtDireccionEmpresa.Name = "TxtDireccionEmpresa";
            this.TxtDireccionEmpresa.Size = new System.Drawing.Size(337, 25);
            this.TxtDireccionEmpresa.TabIndex = 36;
            this.TxtDireccionEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccionEmpresa_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Direccion Empresa";
            // 
            // TxtRncEmpresa
            // 
            this.TxtRncEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtRncEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRncEmpresa.Location = new System.Drawing.Point(379, 63);
            this.TxtRncEmpresa.Multiline = true;
            this.TxtRncEmpresa.Name = "TxtRncEmpresa";
            this.TxtRncEmpresa.Size = new System.Drawing.Size(264, 25);
            this.TxtRncEmpresa.TabIndex = 34;
            this.TxtRncEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRncEmpresa_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "RNC Empresa";
            // 
            // TxtNombreEmpresa
            // 
            this.TxtNombreEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEmpresa.Location = new System.Drawing.Point(31, 63);
            this.TxtNombreEmpresa.Multiline = true;
            this.TxtNombreEmpresa.Name = "TxtNombreEmpresa";
            this.TxtNombreEmpresa.Size = new System.Drawing.Size(338, 25);
            this.TxtNombreEmpresa.TabIndex = 32;
            this.TxtNombreEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreEmpresa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre Empresa";
            // 
            // TxtIdEmpresa
            // 
            this.TxtIdEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtIdEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdEmpresa.Location = new System.Drawing.Point(340, 35);
            this.TxtIdEmpresa.Multiline = true;
            this.TxtIdEmpresa.Name = "TxtIdEmpresa";
            this.TxtIdEmpresa.Size = new System.Drawing.Size(29, 25);
            this.TxtIdEmpresa.TabIndex = 42;
            this.TxtIdEmpresa.Visible = false;
            // 
            // FrmEditarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 250);
            this.Controls.Add(this.TxtIdEmpresa);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MTxtTelefonoEmpresa);
            this.Controls.Add(this.TxtEmailEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDireccionEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtRncEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombreEmpresa);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarEmpresa";
            this.Text = "Editar Empresa";
            this.Load += new System.EventHandler(this.FrmEditarEmpresa_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtNombreEmpresa, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtRncEmpresa, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtDireccionEmpresa, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtEmailEmpresa, 0);
            this.Controls.SetChildIndex(this.MTxtTelefonoEmpresa, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.BtnEditar, 0);
            this.Controls.SetChildIndex(this.TxtIdEmpresa, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox MTxtTelefonoEmpresa;
        public System.Windows.Forms.TextBox TxtEmailEmpresa;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtDireccionEmpresa;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtRncEmpresa;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtNombreEmpresa;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtIdEmpresa;
    }
}