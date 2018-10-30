namespace SistemaARD.Vistas
{
    partial class CambioContrasenia
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.txtRepetirPass = new System.Windows.Forms.TextBox();
            this.lblRePass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.panelCambiar = new System.Windows.Forms.Panel();
            this.panelSolicitar = new System.Windows.Forms.Panel();
            this.panelCambiar.SuspendLayout();
            this.panelSolicitar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Nombre de usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(139, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(80, 65);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(75, 23);
            this.btnSolicitar.TabIndex = 2;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // txtRepetirPass
            // 
            this.txtRepetirPass.Location = new System.Drawing.Point(182, 61);
            this.txtRepetirPass.Name = "txtRepetirPass";
            this.txtRepetirPass.PasswordChar = '*';
            this.txtRepetirPass.Size = new System.Drawing.Size(100, 20);
            this.txtRepetirPass.TabIndex = 6;
            // 
            // lblRePass
            // 
            this.lblRePass.AutoSize = true;
            this.lblRePass.Location = new System.Drawing.Point(40, 61);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.Size = new System.Drawing.Size(97, 13);
            this.lblRePass.TabIndex = 4;
            this.lblRePass.Text = "Repetir contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(182, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 16);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Contraseña";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(106, 111);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 8;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // panelCambiar
            // 
            this.panelCambiar.Controls.Add(this.txtPassword);
            this.panelCambiar.Controls.Add(this.btnCambiar);
            this.panelCambiar.Controls.Add(this.lblPassword);
            this.panelCambiar.Controls.Add(this.txtRepetirPass);
            this.panelCambiar.Controls.Add(this.lblRePass);
            this.panelCambiar.Location = new System.Drawing.Point(12, 128);
            this.panelCambiar.Name = "panelCambiar";
            this.panelCambiar.Size = new System.Drawing.Size(319, 145);
            this.panelCambiar.TabIndex = 9;
            this.panelCambiar.Visible = false;
            // 
            // panelSolicitar
            // 
            this.panelSolicitar.Controls.Add(this.lblUsername);
            this.panelSolicitar.Controls.Add(this.txtUsername);
            this.panelSolicitar.Controls.Add(this.btnSolicitar);
            this.panelSolicitar.Location = new System.Drawing.Point(38, 22);
            this.panelSolicitar.Name = "panelSolicitar";
            this.panelSolicitar.Size = new System.Drawing.Size(257, 100);
            this.panelSolicitar.TabIndex = 10;
            // 
            // CambioContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.panelSolicitar);
            this.Controls.Add(this.panelCambiar);
            this.Name = "CambioContrasenia";
            this.Text = "CambioContrasenia";
            this.panelCambiar.ResumeLayout(false);
            this.panelCambiar.PerformLayout();
            this.panelSolicitar.ResumeLayout(false);
            this.panelSolicitar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.TextBox txtRepetirPass;
        private System.Windows.Forms.Label lblRePass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Panel panelCambiar;
        private System.Windows.Forms.Panel panelSolicitar;
    }
}