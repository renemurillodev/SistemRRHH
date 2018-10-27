namespace SistemaARD.Vistas
{
    partial class AdministracionPagos
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
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtgPagos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(32, 23);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(56, 13);
            this.lblModalidad.TabIndex = 0;
            this.lblModalidad.Text = "Modalidad";
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Location = new System.Drawing.Point(35, 63);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(75, 13);
            this.lblValorPago.TabIndex = 1;
            this.lblValorPago.Text = "Valor del pago";
            // 
            // txtModalidad
            // 
            this.txtModalidad.Location = new System.Drawing.Point(149, 23);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.Size = new System.Drawing.Size(100, 20);
            this.txtModalidad.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(149, 63);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // dtgPagos
            // 
            this.dtgPagos.AllowUserToAddRows = false;
            this.dtgPagos.AllowUserToDeleteRows = false;
            this.dtgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Modalidad,
            this.Cantidad});
            this.dtgPagos.Location = new System.Drawing.Point(35, 148);
            this.dtgPagos.Name = "dtgPagos";
            this.dtgPagos.ReadOnly = true;
            this.dtgPagos.Size = new System.Drawing.Size(240, 150);
            this.dtgPagos.TabIndex = 4;
            this.dtgPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPagos_CellContentClick);
            this.dtgPagos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPagos_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Modalidad
            // 
            this.Modalidad.DataPropertyName = "Modalidad";
            this.Modalidad.HeaderText = "Modalidad";
            this.Modalidad.Name = "Modalidad";
            this.Modalidad.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Pago";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(97, 106);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // AdministracionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtgPagos);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtModalidad);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.lblModalidad);
            this.Name = "AdministracionPagos";
            this.Text = "AdministracionPagos";
            this.Load += new System.EventHandler(this.AdministracionPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dtgPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnRegistrar;
    }
}