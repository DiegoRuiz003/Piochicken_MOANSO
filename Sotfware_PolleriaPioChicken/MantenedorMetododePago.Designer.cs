namespace Sotfware_PolleriaPioChicken
{
    partial class MantenedorMetododePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorMetododePago));
            this.dgvMetodoPago = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstadoMP = new System.Windows.Forms.CheckBox();
            this.btnCancelarMP = new System.Windows.Forms.Button();
            this.btnLeerCL = new System.Windows.Forms.Button();
            this.btnModificarMP = new System.Windows.Forms.Button();
            this.btnDeshabilitarMP = new System.Windows.Forms.Button();
            this.btnAgregarMP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMP = new System.Windows.Forms.TextBox();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMetodoPago
            // 
            this.dgvMetodoPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMetodoPago.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodoPago.Location = new System.Drawing.Point(13, 12);
            this.dgvMetodoPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMetodoPago.Name = "dgvMetodoPago";
            this.dgvMetodoPago.Size = new System.Drawing.Size(863, 162);
            this.dgvMetodoPago.TabIndex = 5;
            this.dgvMetodoPago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetodoPago_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(883, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.cbxEstadoMP);
            this.groupBox1.Controls.Add(this.btnCancelarMP);
            this.groupBox1.Controls.Add(this.btnLeerCL);
            this.groupBox1.Controls.Add(this.btnModificarMP);
            this.groupBox1.Controls.Add(this.btnDeshabilitarMP);
            this.groupBox1.Controls.Add(this.btnAgregarMP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdMP);
            this.groupBox1.Controls.Add(this.txtMetodoPago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 279);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL METODO DE PAGO";
            // 
            // cbxEstadoMP
            // 
            this.cbxEstadoMP.AutoSize = true;
            this.cbxEstadoMP.Location = new System.Drawing.Point(20, 128);
            this.cbxEstadoMP.Name = "cbxEstadoMP";
            this.cbxEstadoMP.Size = new System.Drawing.Size(205, 20);
            this.cbxEstadoMP.TabIndex = 22;
            this.cbxEstadoMP.Text = "Estado del Metodo de Pago";
            this.cbxEstadoMP.UseVisualStyleBackColor = true;
            // 
            // btnCancelarMP
            // 
            this.btnCancelarMP.BackColor = System.Drawing.Color.Black;
            this.btnCancelarMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMP.ForeColor = System.Drawing.Color.White;
            this.btnCancelarMP.Location = new System.Drawing.Point(743, 177);
            this.btnCancelarMP.Name = "btnCancelarMP";
            this.btnCancelarMP.Size = new System.Drawing.Size(116, 34);
            this.btnCancelarMP.TabIndex = 21;
            this.btnCancelarMP.Text = "Cancelar";
            this.btnCancelarMP.UseVisualStyleBackColor = false;
            this.btnCancelarMP.Click += new System.EventHandler(this.btnCancelarMP_Click);
            // 
            // btnLeerCL
            // 
            this.btnLeerCL.BackColor = System.Drawing.Color.Black;
            this.btnLeerCL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeerCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeerCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerCL.ForeColor = System.Drawing.Color.White;
            this.btnLeerCL.Location = new System.Drawing.Point(743, 217);
            this.btnLeerCL.Name = "btnLeerCL";
            this.btnLeerCL.Size = new System.Drawing.Size(116, 34);
            this.btnLeerCL.TabIndex = 8;
            this.btnLeerCL.Text = "Consultar";
            this.btnLeerCL.UseVisualStyleBackColor = false;
            // 
            // btnModificarMP
            // 
            this.btnModificarMP.BackColor = System.Drawing.Color.Black;
            this.btnModificarMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMP.ForeColor = System.Drawing.Color.White;
            this.btnModificarMP.Location = new System.Drawing.Point(743, 97);
            this.btnModificarMP.Name = "btnModificarMP";
            this.btnModificarMP.Size = new System.Drawing.Size(116, 34);
            this.btnModificarMP.TabIndex = 6;
            this.btnModificarMP.Text = "Modificar";
            this.btnModificarMP.UseVisualStyleBackColor = false;
            this.btnModificarMP.Click += new System.EventHandler(this.btnModificarMP_Click);
            // 
            // btnDeshabilitarMP
            // 
            this.btnDeshabilitarMP.BackColor = System.Drawing.Color.Black;
            this.btnDeshabilitarMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitarMP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarMP.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitarMP.Location = new System.Drawing.Point(743, 137);
            this.btnDeshabilitarMP.Name = "btnDeshabilitarMP";
            this.btnDeshabilitarMP.Size = new System.Drawing.Size(116, 34);
            this.btnDeshabilitarMP.TabIndex = 7;
            this.btnDeshabilitarMP.Text = "Deshabilitar";
            this.btnDeshabilitarMP.UseVisualStyleBackColor = false;
            this.btnDeshabilitarMP.Click += new System.EventHandler(this.btnDeshabilitarMP_Click);
            // 
            // btnAgregarMP
            // 
            this.btnAgregarMP.BackColor = System.Drawing.Color.Black;
            this.btnAgregarMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMP.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMP.Location = new System.Drawing.Point(743, 57);
            this.btnAgregarMP.Name = "btnAgregarMP";
            this.btnAgregarMP.Size = new System.Drawing.Size(116, 34);
            this.btnAgregarMP.TabIndex = 3;
            this.btnAgregarMP.Text = "Agregar";
            this.btnAgregarMP.UseVisualStyleBackColor = false;
            this.btnAgregarMP.Click += new System.EventHandler(this.btnAgregarMP_Click);
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
            // txtIdMP
            // 
            this.txtIdMP.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMP.Location = new System.Drawing.Point(137, 34);
            this.txtIdMP.Name = "txtIdMP";
            this.txtIdMP.Size = new System.Drawing.Size(77, 20);
            this.txtIdMP.TabIndex = 5;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetodoPago.Location = new System.Drawing.Point(137, 79);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(181, 20);
            this.txtMetodoPago.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Metodo de Pago";
            // 
            // MantenedorMetododePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvMetodoPago);
            this.Name = "MantenedorMetododePago";
            this.Text = "MantenedorFormadePago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMetodoPago;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelarMP;
        private System.Windows.Forms.Button btnLeerCL;
        private System.Windows.Forms.Button btnModificarMP;
        private System.Windows.Forms.Button btnDeshabilitarMP;
        private System.Windows.Forms.Button btnAgregarMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdMP;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxEstadoMP;
    }
}