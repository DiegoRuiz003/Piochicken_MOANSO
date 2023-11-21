namespace Sotfware_PolleriaPioChicken
{
    partial class RealizaPago
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarNotaVenta = new System.Windows.Forms.Button();
            this.txtBuscarNotaVenta = new System.Windows.Forms.TextBox();
            this.txtNombreNota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDniNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstadoNota = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkPago = new System.Windows.Forms.CheckBox();
            this.datePago = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstadoNota);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotalNota);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDniNota);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscarNotaVenta);
            this.groupBox1.Controls.Add(this.txtBuscarNotaVenta);
            this.groupBox1.Controls.Add(this.txtNombreNota);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS NOTA DE VENTA";
            // 
            // btnBuscarNotaVenta
            // 
            this.btnBuscarNotaVenta.BackColor = System.Drawing.Color.Black;
            this.btnBuscarNotaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarNotaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNotaVenta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNotaVenta.Location = new System.Drawing.Point(251, 36);
            this.btnBuscarNotaVenta.Name = "btnBuscarNotaVenta";
            this.btnBuscarNotaVenta.Size = new System.Drawing.Size(115, 25);
            this.btnBuscarNotaVenta.TabIndex = 10;
            this.btnBuscarNotaVenta.Text = "Buscar";
            this.btnBuscarNotaVenta.UseVisualStyleBackColor = false;
            this.btnBuscarNotaVenta.Click += new System.EventHandler(this.btnBuscarNotaVenta_Click);
            // 
            // txtBuscarNotaVenta
            // 
            this.txtBuscarNotaVenta.Location = new System.Drawing.Point(115, 36);
            this.txtBuscarNotaVenta.Name = "txtBuscarNotaVenta";
            this.txtBuscarNotaVenta.Size = new System.Drawing.Size(130, 23);
            this.txtBuscarNotaVenta.TabIndex = 9;
            // 
            // txtNombreNota
            // 
            this.txtNombreNota.BackColor = System.Drawing.Color.White;
            this.txtNombreNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreNota.ForeColor = System.Drawing.Color.Black;
            this.txtNombreNota.Location = new System.Drawing.Point(514, 36);
            this.txtNombreNota.Name = "txtNombreNota";
            this.txtNombreNota.ReadOnly = true;
            this.txtNombreNota.Size = new System.Drawing.Size(211, 23);
            this.txtNombreNota.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota de Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dni del Cliente";
            // 
            // txtDniNota
            // 
            this.txtDniNota.BackColor = System.Drawing.Color.White;
            this.txtDniNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniNota.ForeColor = System.Drawing.Color.Black;
            this.txtDniNota.Location = new System.Drawing.Point(514, 70);
            this.txtDniNota.Name = "txtDniNota";
            this.txtDniNota.ReadOnly = true;
            this.txtDniNota.Size = new System.Drawing.Size(151, 23);
            this.txtDniNota.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total";
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.Location = new System.Drawing.Point(56, 74);
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Size = new System.Drawing.Size(130, 23);
            this.txtTotalNota.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Estado";
            // 
            // txtEstadoNota
            // 
            this.txtEstadoNota.Location = new System.Drawing.Point(250, 74);
            this.txtEstadoNota.Name = "txtEstadoNota";
            this.txtEstadoNota.Size = new System.Drawing.Size(116, 23);
            this.txtEstadoNota.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbxMetodoPago);
            this.groupBox3.Controls.Add(this.checkPago);
            this.groupBox3.Controls.Add(this.datePago);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnRegistrar);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(890, 145);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DEL PAGO";
            // 
            // checkPago
            // 
            this.checkPago.AutoSize = true;
            this.checkPago.Location = new System.Drawing.Point(24, 66);
            this.checkPago.Name = "checkPago";
            this.checkPago.Size = new System.Drawing.Size(131, 20);
            this.checkPago.TabIndex = 36;
            this.checkPago.Text = "Estado del Pago";
            this.checkPago.UseVisualStyleBackColor = true;
            // 
            // datePago
            // 
            this.datePago.Location = new System.Drawing.Point(132, 25);
            this.datePago.Name = "datePago";
            this.datePago.Size = new System.Drawing.Size(200, 23);
            this.datePago.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Fecha de Pago";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(24, 92);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(96, 39);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Location = new System.Drawing.Point(483, 29);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(203, 24);
            this.cbxMetodoPago.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Metodo de Pago";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(12, 142);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.Size = new System.Drawing.Size(890, 235);
            this.dgvDetalleVenta.TabIndex = 19;
            // 
            // RealizaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 540);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "RealizaPago";
            this.Text = "RealizaPago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarNotaVenta;
        private System.Windows.Forms.TextBox txtBuscarNotaVenta;
        private System.Windows.Forms.TextBox txtNombreNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstadoNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDniNota;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.CheckBox checkPago;
        private System.Windows.Forms.DateTimePicker datePago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
    }
}