namespace Sotfware_PolleriaPioChicken
{
    partial class MantenedorCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorCliente));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCL = new System.Windows.Forms.Button();
            this.btnLeerCL = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnModificarCL = new System.Windows.Forms.Button();
            this.btnEliminarCL = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnCrearCL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEstadoCL = new System.Windows.Forms.CheckBox();
            this.txtIdCL = new System.Windows.Forms.TextBox();
            this.txtNombreCL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCliente.Location = new System.Drawing.Point(28, 31);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(865, 182);
            this.dgvCliente.TabIndex = 5;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.btnCancelarCL);
            this.groupBox1.Controls.Add(this.btnLeerCL);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.btnModificarCL);
            this.groupBox1.Controls.Add(this.btnEliminarCL);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.btnCrearCL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxEstadoCL);
            this.groupBox1.Controls.Add(this.txtIdCL);
            this.groupBox1.Controls.Add(this.txtNombreCL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 279);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // btnCancelarCL
            // 
            this.btnCancelarCL.BackColor = System.Drawing.Color.Black;
            this.btnCancelarCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCL.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCL.Location = new System.Drawing.Point(743, 177);
            this.btnCancelarCL.Name = "btnCancelarCL";
            this.btnCancelarCL.Size = new System.Drawing.Size(116, 34);
            this.btnCancelarCL.TabIndex = 21;
            this.btnCancelarCL.Text = "Cancelar";
            this.btnCancelarCL.UseVisualStyleBackColor = false;
            this.btnCancelarCL.Click += new System.EventHandler(this.btnCancelarCL_Click);
            // 
            // btnLeerCL
            // 
            this.btnLeerCL.BackColor = System.Drawing.Color.Black;
            this.btnLeerCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeerCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerCL.ForeColor = System.Drawing.Color.White;
            this.btnLeerCL.Location = new System.Drawing.Point(743, 217);
            this.btnLeerCL.Name = "btnLeerCL";
            this.btnLeerCL.Size = new System.Drawing.Size(116, 34);
            this.btnLeerCL.TabIndex = 8;
            this.btnLeerCL.Text = "Consultar";
            this.btnLeerCL.UseVisualStyleBackColor = false;
            this.btnLeerCL.Click += new System.EventHandler(this.btnLeerCL_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(87, 217);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(181, 20);
            this.txtCorreo.TabIndex = 20;
            // 
            // btnModificarCL
            // 
            this.btnModificarCL.BackColor = System.Drawing.Color.Black;
            this.btnModificarCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCL.ForeColor = System.Drawing.Color.White;
            this.btnModificarCL.Location = new System.Drawing.Point(743, 97);
            this.btnModificarCL.Name = "btnModificarCL";
            this.btnModificarCL.Size = new System.Drawing.Size(116, 34);
            this.btnModificarCL.TabIndex = 6;
            this.btnModificarCL.Text = "Modificar";
            this.btnModificarCL.UseVisualStyleBackColor = false;
            this.btnModificarCL.Click += new System.EventHandler(this.btnModificarCL_Click);
            // 
            // btnEliminarCL
            // 
            this.btnEliminarCL.BackColor = System.Drawing.Color.Black;
            this.btnEliminarCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCL.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCL.Location = new System.Drawing.Point(743, 137);
            this.btnEliminarCL.Name = "btnEliminarCL";
            this.btnEliminarCL.Size = new System.Drawing.Size(116, 34);
            this.btnEliminarCL.TabIndex = 7;
            this.btnEliminarCL.Text = "Deshabilitar";
            this.btnEliminarCL.UseVisualStyleBackColor = false;
            this.btnEliminarCL.Click += new System.EventHandler(this.btnEliminarCL_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(87, 171);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(181, 20);
            this.txtTelefono.TabIndex = 19;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(87, 125);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(181, 20);
            this.txtDni.TabIndex = 18;
            // 
            // btnCrearCL
            // 
            this.btnCrearCL.BackColor = System.Drawing.Color.Black;
            this.btnCrearCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCL.ForeColor = System.Drawing.Color.White;
            this.btnCrearCL.Location = new System.Drawing.Point(743, 57);
            this.btnCrearCL.Name = "btnCrearCL";
            this.btnCrearCL.Size = new System.Drawing.Size(116, 34);
            this.btnCrearCL.TabIndex = 3;
            this.btnCrearCL.Text = "Agregar";
            this.btnCrearCL.UseVisualStyleBackColor = false;
            this.btnCrearCL.Click += new System.EventHandler(this.btnCrearCL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Id";
            // 
            // cbxEstadoCL
            // 
            this.cbxEstadoCL.AutoSize = true;
            this.cbxEstadoCL.Location = new System.Drawing.Point(321, 34);
            this.cbxEstadoCL.Name = "cbxEstadoCL";
            this.cbxEstadoCL.Size = new System.Drawing.Size(144, 20);
            this.cbxEstadoCL.TabIndex = 13;
            this.cbxEstadoCL.Text = "Estado del Cliente";
            this.cbxEstadoCL.UseVisualStyleBackColor = true;
            // 
            // txtIdCL
            // 
            this.txtIdCL.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCL.Location = new System.Drawing.Point(87, 34);
            this.txtIdCL.Name = "txtIdCL";
            this.txtIdCL.Size = new System.Drawing.Size(77, 20);
            this.txtIdCL.TabIndex = 5;
            // 
            // txtNombreCL
            // 
            this.txtNombreCL.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCL.Location = new System.Drawing.Point(87, 79);
            this.txtNombreCL.Name = "txtNombreCL";
            this.txtNombreCL.Size = new System.Drawing.Size(181, 20);
            this.txtNombreCL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(887, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCliente);
            this.Name = "MantenedorCliente";
            this.Text = "MantenedorCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreCL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLeerCL;
        private System.Windows.Forms.Button btnEliminarCL;
        private System.Windows.Forms.Button btnModificarCL;
        private System.Windows.Forms.Button btnCrearCL;
        private System.Windows.Forms.TextBox txtIdCL;
        private System.Windows.Forms.CheckBox cbxEstadoCL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarCL;
    }
}