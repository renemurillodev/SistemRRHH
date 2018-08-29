namespace SistemaARD.Vistas
{
    partial class AdministracionPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionPlanilla));
            this.lblPlanilla = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblPagoHora = new System.Windows.Forms.Label();
            this.txtPagoHora = new System.Windows.Forms.TextBox();
            this.lblHorasLaboradas = new System.Windows.Forms.Label();
            this.txtHorasLaboradas = new System.Windows.Forms.TextBox();
            this.lblAnticipos = new System.Windows.Forms.Label();
            this.txtAnticipos = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblPagoDiario = new System.Windows.Forms.Label();
            this.lblDiasLaborados = new System.Windows.Forms.Label();
            this.txtPagoDiario = new System.Windows.Forms.TextBox();
            this.txtDiasLaborados = new System.Windows.Forms.TextBox();
            this.chbAfp = new System.Windows.Forms.CheckBox();
            this.chbIsss = new System.Windows.Forms.CheckBox();
            this.lblRetenciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlanilla
            // 
            this.lblPlanilla.AutoSize = true;
            this.lblPlanilla.Location = new System.Drawing.Point(27, 16);
            this.lblPlanilla.Name = "lblPlanilla";
            this.lblPlanilla.Size = new System.Drawing.Size(55, 13);
            this.lblPlanilla.TabIndex = 0;
            this.lblPlanilla.Text = "Planilla de";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(88, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombres,
            this.Apellidos,
            this.Cargo_Id,
            this.Cargo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 329);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Cargo_Id
            // 
            this.Cargo_Id.DataPropertyName = "Cargo_Id";
            this.Cargo_Id.HeaderText = "Cargo_Id";
            this.Cargo_Id.Name = "Cargo_Id";
            this.Cargo_Id.ReadOnly = true;
            this.Cargo_Id.Visible = false;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconCerrar.Image")));
            this.iconCerrar.Location = new System.Drawing.Point(717, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 11;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(418, 102);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblEmpleado.TabIndex = 12;
            this.lblEmpleado.Text = "Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(515, 95);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(212, 20);
            this.txtEmpleado.TabIndex = 13;
            // 
            // lblPagoHora
            // 
            this.lblPagoHora.AutoSize = true;
            this.lblPagoHora.Location = new System.Drawing.Point(418, 154);
            this.lblPagoHora.Name = "lblPagoHora";
            this.lblPagoHora.Size = new System.Drawing.Size(74, 13);
            this.lblPagoHora.TabIndex = 14;
            this.lblPagoHora.Text = "Pago por hora";
            // 
            // txtPagoHora
            // 
            this.txtPagoHora.Location = new System.Drawing.Point(515, 150);
            this.txtPagoHora.Name = "txtPagoHora";
            this.txtPagoHora.Size = new System.Drawing.Size(43, 20);
            this.txtPagoHora.TabIndex = 15;
            // 
            // lblHorasLaboradas
            // 
            this.lblHorasLaboradas.AutoSize = true;
            this.lblHorasLaboradas.Location = new System.Drawing.Point(418, 203);
            this.lblHorasLaboradas.Name = "lblHorasLaboradas";
            this.lblHorasLaboradas.Size = new System.Drawing.Size(84, 13);
            this.lblHorasLaboradas.TabIndex = 16;
            this.lblHorasLaboradas.Text = "Horas laboradas";
            // 
            // txtHorasLaboradas
            // 
            this.txtHorasLaboradas.Location = new System.Drawing.Point(515, 196);
            this.txtHorasLaboradas.Name = "txtHorasLaboradas";
            this.txtHorasLaboradas.Size = new System.Drawing.Size(43, 20);
            this.txtHorasLaboradas.TabIndex = 17;
            // 
            // lblAnticipos
            // 
            this.lblAnticipos.AutoSize = true;
            this.lblAnticipos.Location = new System.Drawing.Point(418, 253);
            this.lblAnticipos.Name = "lblAnticipos";
            this.lblAnticipos.Size = new System.Drawing.Size(50, 13);
            this.lblAnticipos.TabIndex = 18;
            this.lblAnticipos.Text = "Anticipos";
            this.lblAnticipos.Click += new System.EventHandler(this.lblAnticipos_Click);
            // 
            // txtAnticipos
            // 
            this.txtAnticipos.Location = new System.Drawing.Point(515, 246);
            this.txtAnticipos.Name = "txtAnticipos";
            this.txtAnticipos.Size = new System.Drawing.Size(43, 20);
            this.txtAnticipos.TabIndex = 19;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(418, 302);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(515, 302);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 21;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(515, 370);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblPagoDiario
            // 
            this.lblPagoDiario.AutoSize = true;
            this.lblPagoDiario.Location = new System.Drawing.Point(582, 153);
            this.lblPagoDiario.Name = "lblPagoDiario";
            this.lblPagoDiario.Size = new System.Drawing.Size(60, 13);
            this.lblPagoDiario.TabIndex = 23;
            this.lblPagoDiario.Text = "Pago diario";
            this.lblPagoDiario.Visible = false;
            // 
            // lblDiasLaborados
            // 
            this.lblDiasLaborados.AutoSize = true;
            this.lblDiasLaborados.Location = new System.Drawing.Point(582, 196);
            this.lblDiasLaborados.Name = "lblDiasLaborados";
            this.lblDiasLaborados.Size = new System.Drawing.Size(79, 13);
            this.lblDiasLaborados.TabIndex = 24;
            this.lblDiasLaborados.Text = "Días laborados";
            this.lblDiasLaborados.Visible = false;
            // 
            // txtPagoDiario
            // 
            this.txtPagoDiario.Location = new System.Drawing.Point(660, 150);
            this.txtPagoDiario.Name = "txtPagoDiario";
            this.txtPagoDiario.Size = new System.Drawing.Size(44, 20);
            this.txtPagoDiario.TabIndex = 25;
            this.txtPagoDiario.Visible = false;
            // 
            // txtDiasLaborados
            // 
            this.txtDiasLaborados.Location = new System.Drawing.Point(660, 193);
            this.txtDiasLaborados.Name = "txtDiasLaborados";
            this.txtDiasLaborados.Size = new System.Drawing.Size(44, 20);
            this.txtDiasLaborados.TabIndex = 26;
            this.txtDiasLaborados.Visible = false;
            // 
            // chbAfp
            // 
            this.chbAfp.AutoSize = true;
            this.chbAfp.Location = new System.Drawing.Point(421, 61);
            this.chbAfp.Name = "chbAfp";
            this.chbAfp.Size = new System.Drawing.Size(46, 17);
            this.chbAfp.TabIndex = 27;
            this.chbAfp.Text = "AFP";
            this.chbAfp.UseVisualStyleBackColor = true;
            // 
            // chbIsss
            // 
            this.chbIsss.AutoSize = true;
            this.chbIsss.Location = new System.Drawing.Point(493, 61);
            this.chbIsss.Name = "chbIsss";
            this.chbIsss.Size = new System.Drawing.Size(50, 17);
            this.chbIsss.TabIndex = 28;
            this.chbIsss.Text = "ISSS";
            this.chbIsss.UseVisualStyleBackColor = true;
            // 
            // lblRetenciones
            // 
            this.lblRetenciones.AutoSize = true;
            this.lblRetenciones.Location = new System.Drawing.Point(418, 24);
            this.lblRetenciones.Name = "lblRetenciones";
            this.lblRetenciones.Size = new System.Drawing.Size(97, 13);
            this.lblRetenciones.TabIndex = 29;
            this.lblRetenciones.Text = "Aplicar retenciones";
            // 
            // AdministracionPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(754, 411);
            this.Controls.Add(this.lblRetenciones);
            this.Controls.Add(this.chbIsss);
            this.Controls.Add(this.chbAfp);
            this.Controls.Add(this.txtDiasLaborados);
            this.Controls.Add(this.txtPagoDiario);
            this.Controls.Add(this.lblDiasLaborados);
            this.Controls.Add(this.lblPagoDiario);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtAnticipos);
            this.Controls.Add(this.lblAnticipos);
            this.Controls.Add(this.txtHorasLaboradas);
            this.Controls.Add(this.lblHorasLaboradas);
            this.Controls.Add(this.txtPagoHora);
            this.Controls.Add(this.lblPagoHora);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.iconCerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPlanilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministracionPlanilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministracionPlanilla";
            this.Load += new System.EventHandler(this.AdministracionPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlanilla;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblPagoHora;
        private System.Windows.Forms.TextBox txtPagoHora;
        private System.Windows.Forms.Label lblHorasLaboradas;
        private System.Windows.Forms.TextBox txtHorasLaboradas;
        private System.Windows.Forms.Label lblAnticipos;
        private System.Windows.Forms.TextBox txtAnticipos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblPagoDiario;
        private System.Windows.Forms.Label lblDiasLaborados;
        private System.Windows.Forms.TextBox txtPagoDiario;
        private System.Windows.Forms.TextBox txtDiasLaborados;
        private System.Windows.Forms.CheckBox chbAfp;
        private System.Windows.Forms.CheckBox chbIsss;
        private System.Windows.Forms.Label lblRetenciones;
    }
}