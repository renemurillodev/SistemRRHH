namespace SistemaARD.Vistas
{
    partial class ListaIndemnizaciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotalPagoLiquido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(924, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTotalPagoLiquido
            // 
            this.lblTotalPagoLiquido.AutoSize = true;
            this.lblTotalPagoLiquido.Location = new System.Drawing.Point(699, 339);
            this.lblTotalPagoLiquido.Name = "lblTotalPagoLiquido";
            this.lblTotalPagoLiquido.Size = new System.Drawing.Size(31, 13);
            this.lblTotalPagoLiquido.TabIndex = 1;
            this.lblTotalPagoLiquido.Text = "Total";
            // 
            // ListaIndemnizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.lblTotalPagoLiquido);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaIndemnizaciones";
            this.Text = "ListaIndemnizaciones";
            this.Load += new System.EventHandler(this.ListaIndemnizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalPagoLiquido;
    }
}