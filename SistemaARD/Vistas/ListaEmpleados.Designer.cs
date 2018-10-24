namespace SistemaARD.Vistas
{
    partial class ListaEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaEmpleados));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afp_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Afp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Isss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.btnRegistroEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnContrato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombres,
            this.Apellidos,
            this.FechaNacimiento,
            this.Direccion,
            this.N_Dui,
            this.N_Nit,
            this.Afp_Id,
            this.N_Afp,
            this.N_Isss,
            this.FechaIngreso,
            this.Estado_Id});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(757, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
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
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Visible = false;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // N_Dui
            // 
            this.N_Dui.DataPropertyName = "N_Dui";
            this.N_Dui.HeaderText = "DUI";
            this.N_Dui.Name = "N_Dui";
            this.N_Dui.ReadOnly = true;
            // 
            // N_Nit
            // 
            this.N_Nit.DataPropertyName = "N_Nit";
            this.N_Nit.HeaderText = "NIT";
            this.N_Nit.Name = "N_Nit";
            this.N_Nit.ReadOnly = true;
            // 
            // Afp_Id
            // 
            this.Afp_Id.DataPropertyName = "Afp_Id";
            this.Afp_Id.HeaderText = "AFP";
            this.Afp_Id.Name = "Afp_Id";
            this.Afp_Id.ReadOnly = true;
            this.Afp_Id.Visible = false;
            // 
            // N_Afp
            // 
            this.N_Afp.DataPropertyName = "N_Afp";
            this.N_Afp.HeaderText = "NUP";
            this.N_Afp.Name = "N_Afp";
            this.N_Afp.ReadOnly = true;
            // 
            // N_Isss
            // 
            this.N_Isss.DataPropertyName = "N_Isss";
            this.N_Isss.HeaderText = "ISSS";
            this.N_Isss.Name = "N_Isss";
            this.N_Isss.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha de ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // Estado_Id
            // 
            this.Estado_Id.DataPropertyName = "Estado_Id";
            this.Estado_Id.HeaderText = "Estado";
            this.Estado_Id.Name = "Estado_Id";
            this.Estado_Id.ReadOnly = true;
            this.Estado_Id.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lblApellido.Location = new System.Drawing.Point(6, 36);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(147, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido del empleado";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(172, 34);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 21);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellido_KeyDown);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtApellido_KeyUp);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(470, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 45);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalle.Image")));
            this.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalle.Location = new System.Drawing.Point(334, 25);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(130, 45);
            this.btnDetalle.TabIndex = 7;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Visible = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconCerrar.Image")));
            this.iconCerrar.Location = new System.Drawing.Point(733, 7);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 10;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // btnRegistroEmp
            // 
            this.btnRegistroEmp.FlatAppearance.BorderSize = 0;
            this.btnRegistroEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.btnRegistroEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroEmp.Image")));
            this.btnRegistroEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroEmp.Location = new System.Drawing.Point(9, 25);
            this.btnRegistroEmp.Name = "btnRegistroEmp";
            this.btnRegistroEmp.Size = new System.Drawing.Size(152, 45);
            this.btnRegistroEmp.TabIndex = 11;
            this.btnRegistroEmp.Text = "Agregar";
            this.btnRegistroEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroEmp.UseVisualStyleBackColor = true;
            this.btnRegistroEmp.Click += new System.EventHandler(this.btnRegistroEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Empleados";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 67);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de empleado";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnContrato);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnRegistroEmp);
            this.groupBox2.Controls.Add(this.btnDetalle);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(16, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 76);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de empleados";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(606, 25);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 45);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(4, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(763, 238);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de empleados";
            // 
            // btnContrato
            // 
            this.btnContrato.Location = new System.Drawing.Point(188, 29);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(127, 35);
            this.btnContrato.TabIndex = 17;
            this.btnContrato.Text = "Generar contrato";
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Visible = false;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // ListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconCerrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaEmpleados";
            this.Text = "Lista de empleados";
            this.Load += new System.EventHandler(this.ListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afp_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Afp;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Isss;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Id;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.Button btnRegistroEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnContrato;
    }
}