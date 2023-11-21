namespace Sotfware_PolleriaPioChicken
{
    partial class MantenedorProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorProveedor));
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstadoPV = new System.Windows.Forms.CheckBox();
            this.txtTelefonoPV = new System.Windows.Forms.TextBox();
            this.txtIdPV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazonPV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLeerPV = new System.Windows.Forms.Button();
            this.btnModificarPV = new System.Windows.Forms.Button();
            this.btnEliminarPV = new System.Windows.Forms.Button();
            this.btnCrearPV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedor.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedor.Location = new System.Drawing.Point(12, 12);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.Size = new System.Drawing.Size(714, 182);
            this.dgvProveedor.TabIndex = 7;
            this.dgvProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.cbxEstadoPV);
            this.groupBox1.Controls.Add(this.txtTelefonoPV);
            this.groupBox1.Controls.Add(this.txtIdPV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRazonPV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombrePV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 297);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PROVEEDOR";
            // 
            // cbxEstadoPV
            // 
            this.cbxEstadoPV.AutoSize = true;
            this.cbxEstadoPV.Location = new System.Drawing.Point(30, 232);
            this.cbxEstadoPV.Name = "cbxEstadoPV";
            this.cbxEstadoPV.Size = new System.Drawing.Size(166, 18);
            this.cbxEstadoPV.TabIndex = 12;
            this.cbxEstadoPV.Text = "ESTADO DEL PROVEEDOR";
            this.cbxEstadoPV.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoPV
            // 
            this.txtTelefonoPV.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoPV.Location = new System.Drawing.Point(133, 180);
            this.txtTelefonoPV.Name = "txtTelefonoPV";
            this.txtTelefonoPV.Size = new System.Drawing.Size(234, 20);
            this.txtTelefonoPV.TabIndex = 11;
            // 
            // txtIdPV
            // 
            this.txtIdPV.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPV.Location = new System.Drawing.Point(133, 27);
            this.txtIdPV.Name = "txtIdPV";
            this.txtIdPV.Size = new System.Drawing.Size(234, 20);
            this.txtIdPV.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // txtRazonPV
            // 
            this.txtRazonPV.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonPV.Location = new System.Drawing.Point(133, 125);
            this.txtRazonPV.Name = "txtRazonPV";
            this.txtRazonPV.Size = new System.Drawing.Size(234, 20);
            this.txtRazonPV.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Razon Social";
            // 
            // txtNombrePV
            // 
            this.txtNombrePV.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePV.Location = new System.Drawing.Point(133, 71);
            this.txtNombrePV.Name = "txtNombrePV";
            this.txtNombrePV.Size = new System.Drawing.Size(234, 20);
            this.txtNombrePV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLeerPV);
            this.groupBox2.Controls.Add(this.btnModificarPV);
            this.groupBox2.Controls.Add(this.btnEliminarPV);
            this.groupBox2.Controls.Add(this.btnCrearPV);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(520, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 297);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPERACIONES";
            // 
            // btnLeerPV
            // 
            this.btnLeerPV.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerPV.Location = new System.Drawing.Point(6, 232);
            this.btnLeerPV.Name = "btnLeerPV";
            this.btnLeerPV.Size = new System.Drawing.Size(194, 47);
            this.btnLeerPV.TabIndex = 3;
            this.btnLeerPV.Text = "Consultar";
            this.btnLeerPV.UseVisualStyleBackColor = true;
            this.btnLeerPV.Click += new System.EventHandler(this.btnLeerPV_Click);
            // 
            // btnModificarPV
            // 
            this.btnModificarPV.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPV.Location = new System.Drawing.Point(6, 159);
            this.btnModificarPV.Name = "btnModificarPV";
            this.btnModificarPV.Size = new System.Drawing.Size(194, 47);
            this.btnModificarPV.TabIndex = 2;
            this.btnModificarPV.Text = "Modificar";
            this.btnModificarPV.UseVisualStyleBackColor = true;
            this.btnModificarPV.Click += new System.EventHandler(this.btnModificarPV_Click);
            // 
            // btnEliminarPV
            // 
            this.btnEliminarPV.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPV.Location = new System.Drawing.Point(6, 93);
            this.btnEliminarPV.Name = "btnEliminarPV";
            this.btnEliminarPV.Size = new System.Drawing.Size(194, 47);
            this.btnEliminarPV.TabIndex = 1;
            this.btnEliminarPV.Text = "Eliminar";
            this.btnEliminarPV.UseVisualStyleBackColor = true;
            this.btnEliminarPV.Click += new System.EventHandler(this.btnEliminarPV_Click);
            // 
            // btnCrearPV
            // 
            this.btnCrearPV.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPV.Location = new System.Drawing.Point(6, 27);
            this.btnCrearPV.Name = "btnCrearPV";
            this.btnCrearPV.Size = new System.Drawing.Size(194, 47);
            this.btnCrearPV.TabIndex = 0;
            this.btnCrearPV.Text = "Crear";
            this.btnCrearPV.UseVisualStyleBackColor = true;
            this.btnCrearPV.Click += new System.EventHandler(this.btnCrearPV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(882, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MantenedorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProveedor);
            this.Name = "MantenedorProveedor";
            this.Text = "MantenedorProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdPV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRazonPV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefonoPV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLeerPV;
        private System.Windows.Forms.Button btnModificarPV;
        private System.Windows.Forms.Button btnEliminarPV;
        private System.Windows.Forms.Button btnCrearPV;
        private System.Windows.Forms.CheckBox cbxEstadoPV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}