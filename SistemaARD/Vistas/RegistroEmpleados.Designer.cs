namespace SistemaARD.Vistas
{
    partial class RegistroEmpleados
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cbxNombreAfp = new System.Windows.Forms.ComboBox();
            this.txtNumeroIsss = new System.Windows.Forms.MaskedTextBox();
            this.txtNup = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroNit = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroDui = new System.Windows.Forms.MaskedTextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblIsss = new System.Windows.Forms.Label();
            this.lblNup = new System.Windows.Forms.Label();
            this.lblNombreAFP = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(350, 460);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 43;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(178, 460);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 42;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(178, 425);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 41;
            // 
            // cbxNombreAfp
            // 
            this.cbxNombreAfp.FormattingEnabled = true;
            this.cbxNombreAfp.Location = new System.Drawing.Point(178, 312);
            this.cbxNombreAfp.Name = "cbxNombreAfp";
            this.cbxNombreAfp.Size = new System.Drawing.Size(121, 21);
            this.cbxNombreAfp.TabIndex = 40;
            // 
            // txtNumeroIsss
            // 
            this.txtNumeroIsss.Location = new System.Drawing.Point(178, 385);
            this.txtNumeroIsss.Mask = "000000000";
            this.txtNumeroIsss.Name = "txtNumeroIsss";
            this.txtNumeroIsss.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroIsss.TabIndex = 39;
            // 
            // txtNup
            // 
            this.txtNup.Location = new System.Drawing.Point(178, 352);
            this.txtNup.Mask = "000000000000";
            this.txtNup.Name = "txtNup";
            this.txtNup.Size = new System.Drawing.Size(121, 20);
            this.txtNup.TabIndex = 38;
            // 
            // txtNumeroNit
            // 
            this.txtNumeroNit.Location = new System.Drawing.Point(178, 275);
            this.txtNumeroNit.Mask = "0000-000000-000-0";
            this.txtNumeroNit.Name = "txtNumeroNit";
            this.txtNumeroNit.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroNit.TabIndex = 37;
            // 
            // txtNumeroDui
            // 
            this.txtNumeroDui.Location = new System.Drawing.Point(178, 238);
            this.txtNumeroDui.Mask = "00000000-0";
            this.txtNumeroDui.Name = "txtNumeroDui";
            this.txtNumeroDui.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroDui.TabIndex = 36;
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(178, 184);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(121, 21);
            this.cbxGenero.TabIndex = 35;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(178, 134);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(233, 20);
            this.txtDireccion.TabIndex = 33;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(178, 45);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(233, 20);
            this.txtApellidos.TabIndex = 32;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(178, 6);
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(233, 20);
            this.txtNombres.TabIndex = 34;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(55, 460);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(58, 425);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(89, 13);
            this.lblFechaIngreso.TabIndex = 30;
            this.lblFechaIngreso.Text = "Fecha de ingreso";
            // 
            // lblIsss
            // 
            this.lblIsss.AutoSize = true;
            this.lblIsss.Location = new System.Drawing.Point(55, 392);
            this.lblIsss.Name = "lblIsss";
            this.lblIsss.Size = new System.Drawing.Size(31, 13);
            this.lblIsss.TabIndex = 29;
            this.lblIsss.Text = "ISSS";
            // 
            // lblNup
            // 
            this.lblNup.AutoSize = true;
            this.lblNup.Location = new System.Drawing.Point(52, 355);
            this.lblNup.Name = "lblNup";
            this.lblNup.Size = new System.Drawing.Size(30, 13);
            this.lblNup.TabIndex = 28;
            this.lblNup.Text = "NUP";
            // 
            // lblNombreAFP
            // 
            this.lblNombreAFP.AutoSize = true;
            this.lblNombreAFP.Location = new System.Drawing.Point(52, 321);
            this.lblNombreAFP.Name = "lblNombreAFP";
            this.lblNombreAFP.Size = new System.Drawing.Size(82, 13);
            this.lblNombreAFP.TabIndex = 27;
            this.lblNombreAFP.Text = "Nombre de AFP";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(49, 278);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(80, 13);
            this.lblNit.TabIndex = 26;
            this.lblNit.Text = "Número de NIT";
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(48, 238);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(81, 13);
            this.lblDui.TabIndex = 25;
            this.lblDui.Text = "Número de DUI";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(48, 193);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 24;
            this.lblGenero.Text = "Género";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(48, 141);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 23;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(48, 93);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNacimiento.TabIndex = 22;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(178, 93);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 21;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(48, 52);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 20;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(45, 13);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 19;
            this.lblNombres.Text = "Nombres";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(364, 184);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "label1";
            // 
            // RegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 495);
            this.ControlBox = false;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.cbxNombreAfp);
            this.Controls.Add(this.txtNumeroIsss);
            this.Controls.Add(this.txtNup);
            this.Controls.Add(this.txtNumeroNit);
            this.Controls.Add(this.txtNumeroDui);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblIsss);
            this.Controls.Add(this.lblNup);
            this.Controls.Add(this.lblNombreAFP);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.lblDui);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Name = "RegistroEmpleados";
            this.Text = "RegistroEmpleados";
            this.Load += new System.EventHandler(this.RegistroEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblIsss;
        private System.Windows.Forms.Label lblNup;
        private System.Windows.Forms.Label lblNombreAFP;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox cbxNombreAfp;
        private System.Windows.Forms.MaskedTextBox txtNumeroIsss;
        private System.Windows.Forms.MaskedTextBox txtNup;
        private System.Windows.Forms.MaskedTextBox txtNumeroNit;
        private System.Windows.Forms.MaskedTextBox txtNumeroDui;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}