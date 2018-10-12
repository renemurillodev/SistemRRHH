namespace SistemaARD.Vistas
{
    partial class GenerarContratos
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
            this.lblLugarFechaDUI = new System.Windows.Forms.Label();
            this.txtLugarFechaExpedicionDUI = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLugarFechaDUI
            // 
            this.lblLugarFechaDUI.AutoSize = true;
            this.lblLugarFechaDUI.Location = new System.Drawing.Point(28, 26);
            this.lblLugarFechaDUI.Name = "lblLugarFechaDUI";
            this.lblLugarFechaDUI.Size = new System.Drawing.Size(141, 13);
            this.lblLugarFechaDUI.TabIndex = 0;
            this.lblLugarFechaDUI.Text = "Lugar y fecha de expedición";
            // 
            // txtLugarFechaExpedicionDUI
            // 
            this.txtLugarFechaExpedicionDUI.Location = new System.Drawing.Point(214, 23);
            this.txtLugarFechaExpedicionDUI.Name = "txtLugarFechaExpedicionDUI";
            this.txtLugarFechaExpedicionDUI.Size = new System.Drawing.Size(324, 20);
            this.txtLugarFechaExpedicionDUI.TabIndex = 1;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(28, 61);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(31, 100);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(43, 13);
            this.lblPeriodo.TabIndex = 4;
            this.lblPeriodo.Text = "Periodo";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(214, 100);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodo.TabIndex = 5;
            // 
            // GenerarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtLugarFechaExpedicionDUI);
            this.Controls.Add(this.lblLugarFechaDUI);
            this.Name = "GenerarContratos";
            this.Text = "GenerarContratos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLugarFechaDUI;
        private System.Windows.Forms.TextBox txtLugarFechaExpedicionDUI;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox txtPeriodo;
    }
}