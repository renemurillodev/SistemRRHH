using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD.Vistas
{
    public partial class ListaIndemnizaciones : Form
    {
        SqlConnection cnn = new SqlConnection(Clases.Connection.ObtenerConexion());
        decimal salarioMensual = 0;
        int diasPendiente = 0;
        decimal totalPagar = 0;
        decimal retencion = 0;
        decimal liquidoPagar = 0;
        decimal totalPagoLiquido = 0;
        public ListaIndemnizaciones()
        {
            InitializeComponent();
        }

        private void ListaIndemnizaciones_Load(object sender, EventArgs e)
        {
            CargarTodas();
        }

        void CargarTodas()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarIndemnizaciones", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;

                dataGridView1.Columns.Add("TotalPagar", "TOTAL A PAGAR");
                dataGridView1.Columns.Add("Retencion", "RETENCIÓN (10 %)");
                dataGridView1.Columns.Add("LiquidoPagar", "LIQUIDO A PAGAR");

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    salarioMensual = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    diasPendiente = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());

                    totalPagar = Convert.ToDecimal((salarioMensual * diasPendiente) / 365);

                    retencion = Convert.ToDecimal(totalPagar * Convert.ToDecimal(0.1));
                    liquidoPagar = totalPagar - retencion;

                    dataGridView1.Rows[i].Cells[7].Value = "$" + Math.Round(totalPagar, 2);
                    dataGridView1.Rows[i].Cells[8].Value = "$" + Math.Round(retencion, 2);
                    dataGridView1.Rows[i].Cells[9].Value = "$" + Math.Round(liquidoPagar, 2);

                    totalPagoLiquido += liquidoPagar;
                }

                lblTotalPagoLiquido.Text = "El total a pagar es: $" + Math.Round(totalPagoLiquido, 2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
