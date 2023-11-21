namespace Sotfware_PolleriaPioChicken
{
    partial class RealizaVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizaVenta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDniCL = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDniV = new System.Windows.Forms.TextBox();
            this.txtNombreCLB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionPL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnQuitarDetV = new System.Windows.Forms.Button();
            this.btnAgregarDetV = new System.Windows.Forms.Button();
            this.txtCantidadV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPlatoBuscar = new System.Windows.Forms.ComboBox();
            this.cbxTipoPlatoBuscar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalV = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateNotaVenta = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDniCL);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtDniV);
            this.groupBox1.Controls.Add(this.txtNombreCLB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 72);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Id";
            // 
            // txtDniCL
            // 
            this.txtDniCL.Location = new System.Drawing.Point(86, 69);
            this.txtDniCL.Name = "txtDniCL";
            this.txtDniCL.Size = new System.Drawing.Size(100, 23);
            this.txtDniCL.TabIndex = 11;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(235, 33);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarCliente.TabIndex = 10;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDniV
            // 
            this.txtDniV.Location = new System.Drawing.Point(86, 35);
            this.txtDniV.Name = "txtDniV";
            this.txtDniV.Size = new System.Drawing.Size(130, 23);
            this.txtDniV.TabIndex = 9;
            // 
            // txtNombreCLB
            // 
            this.txtNombreCLB.BackColor = System.Drawing.Color.White;
            this.txtNombreCLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCLB.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCLB.Location = new System.Drawing.Point(86, 102);
            this.txtNombreCLB.Name = "txtNombreCLB";
            this.txtNombreCLB.ReadOnly = true;
            this.txtNombreCLB.Size = new System.Drawing.Size(195, 23);
            this.txtNombreCLB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(887, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescripcionPL);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnQuitarDetV);
            this.groupBox2.Controls.Add(this.btnAgregarDetV);
            this.groupBox2.Controls.Add(this.txtCantidadV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPrecioBuscar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxPlatoBuscar);
            this.groupBox2.Controls.Add(this.cbxTipoPlatoBuscar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 360);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DEL PLATO";
            // 
            // txtDescripcionPL
            // 
            this.txtDescripcionPL.Location = new System.Drawing.Point(98, 125);
            this.txtDescripcionPL.Multiline = true;
            this.txtDescripcionPL.Name = "txtDescripcionPL";
            this.txtDescripcionPL.Size = new System.Drawing.Size(212, 67);
            this.txtDescripcionPL.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Descripcion";
            // 
            // btnQuitarDetV
            // 
            this.btnQuitarDetV.BackColor = System.Drawing.Color.Black;
            this.btnQuitarDetV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarDetV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarDetV.ForeColor = System.Drawing.Color.White;
            this.btnQuitarDetV.Location = new System.Drawing.Point(239, 306);
            this.btnQuitarDetV.Name = "btnQuitarDetV";
            this.btnQuitarDetV.Size = new System.Drawing.Size(92, 36);
            this.btnQuitarDetV.TabIndex = 16;
            this.btnQuitarDetV.Text = "Quitar";
            this.btnQuitarDetV.UseVisualStyleBackColor = false;
            this.btnQuitarDetV.Click += new System.EventHandler(this.btnQuitarDetV_Click);
            // 
            // btnAgregarDetV
            // 
            this.btnAgregarDetV.BackColor = System.Drawing.Color.Black;
            this.btnAgregarDetV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDetV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetV.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDetV.Location = new System.Drawing.Point(131, 305);
            this.btnAgregarDetV.Name = "btnAgregarDetV";
            this.btnAgregarDetV.Size = new System.Drawing.Size(92, 36);
            this.btnAgregarDetV.TabIndex = 11;
            this.btnAgregarDetV.Text = "Agregar";
            this.btnAgregarDetV.UseVisualStyleBackColor = false;
            this.btnAgregarDetV.Click += new System.EventHandler(this.btnAgregarDetV_Click);
            // 
            // txtCantidadV
            // 
            this.txtCantidadV.Location = new System.Drawing.Point(98, 259);
            this.txtCantidadV.Name = "txtCantidadV";
            this.txtCantidadV.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadV.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "S/.";
            // 
            // txtPrecioBuscar
            // 
            this.txtPrecioBuscar.BackColor = System.Drawing.Color.White;
            this.txtPrecioBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioBuscar.Location = new System.Drawing.Point(126, 213);
            this.txtPrecioBuscar.Name = "txtPrecioBuscar";
            this.txtPrecioBuscar.ReadOnly = true;
            this.txtPrecioBuscar.Size = new System.Drawing.Size(97, 20);
            this.txtPrecioBuscar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad";
            // 
            // cbxPlatoBuscar
            // 
            this.cbxPlatoBuscar.FormattingEnabled = true;
            this.cbxPlatoBuscar.Items.AddRange(new object[] {
            "Seleciona Plato"});
            this.cbxPlatoBuscar.Location = new System.Drawing.Point(98, 81);
            this.cbxPlatoBuscar.Name = "cbxPlatoBuscar";
            this.cbxPlatoBuscar.Size = new System.Drawing.Size(212, 24);
            this.cbxPlatoBuscar.TabIndex = 10;
            this.cbxPlatoBuscar.SelectedIndexChanged += new System.EventHandler(this.cbxPlatoBuscar_SelectedIndexChanged);
            // 
            // cbxTipoPlatoBuscar
            // 
            this.cbxTipoPlatoBuscar.FormattingEnabled = true;
            this.cbxTipoPlatoBuscar.Items.AddRange(new object[] {
            ""});
            this.cbxTipoPlatoBuscar.Location = new System.Drawing.Point(98, 40);
            this.cbxTipoPlatoBuscar.Name = "cbxTipoPlatoBuscar";
            this.cbxTipoPlatoBuscar.Size = new System.Drawing.Size(212, 24);
            this.cbxTipoPlatoBuscar.TabIndex = 9;
            this.cbxTipoPlatoBuscar.SelectedIndexChanged += new System.EventHandler(this.cbxTipoPlatoBuscar_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Plato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Plato";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDetalleVenta.Location = new System.Drawing.Point(357, 17);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.Size = new System.Drawing.Size(526, 340);
            this.dgvDetalleVenta.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Plato";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            this.Column3.Width = 193;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.Width = 45;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            this.Column5.Width = 45;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SubTotal";
            this.Column6.Name = "Column6";
            this.Column6.Width = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(433, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "TOTAL ";
            // 
            // txtTotalV
            // 
            this.txtTotalV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalV.Location = new System.Drawing.Point(411, 101);
            this.txtTotalV.Name = "txtTotalV";
            this.txtTotalV.Size = new System.Drawing.Size(100, 27);
            this.txtTotalV.TabIndex = 34;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.dateNotaVenta);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTotalV);
            this.groupBox3.Controls.Add(this.btnRegistrar);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(357, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 145);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DE NOTA VENTA";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 20);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Estado NotaVenta";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateNotaVenta
            // 
            this.dateNotaVenta.Location = new System.Drawing.Point(151, 25);
            this.dateNotaVenta.Name = "dateNotaVenta";
            this.dateNotaVenta.Size = new System.Drawing.Size(200, 23);
            this.dateNotaVenta.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fecha Nota Venta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(126, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 39);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // RealizaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 520);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RealizaVenta";
            this.Text = "Realiza Venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDniV;
        private System.Windows.Forms.TextBox txtNombreCLB;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPlatoBuscar;
        private System.Windows.Forms.ComboBox cbxTipoPlatoBuscar;
        private System.Windows.Forms.Button btnQuitarDetV;
        private System.Windows.Forms.Button btnAgregarDetV;
        private System.Windows.Forms.TextBox txtCantidadV;
        private System.Windows.Forms.TextBox txtDescripcionPL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalV;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateNotaVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDniCL;
        private System.Windows.Forms.Button btnCancelar;
    }
}

