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
        
        public ListaIndemnizaciones()
        {
            InitializeComponent();
        }

        private void ListaIndemnizaciones_Load(object sender, EventArgs e)
        {
            CargarTodas();
            CalcularPago();
        }

        void LimpiarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
        }

        void CalcularPago()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

            dataGridView1.Columns.Add("TotalPagar", "TOTAL A PAGAR");
            dataGridView1.Columns.Add("Retencion", "RETENCIÓN (10 %)");
            dataGridView1.Columns.Add("LiquidoPagar", "LIQUIDO A PAGAR");

            decimal salarioMensual = 0;
            int diasPendiente = 0;
            decimal totalPagar = 0;
            decimal retencion = 0;
            decimal liquidoPagar = 0;
            decimal totalPagoLiquido = 0;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void CargarFiltro()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ListarTodasIndemnizacionesFiltro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Desde", dtpDesde.Value));
                cmd.Parameters.Add(new SqlParameter("Hasta", dtpHasta.Value));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cnn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("¿Seguro que desea generar la indemnización para todos sus empleados?", "Generar Indemnización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    using (DBEntities db = new DBEntities())
                    {
                        db.Database.Connection.Open();
                        System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                        cmd.CommandText = "InsertarIndemnizacion";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("Desde", dtpDesde.Value));
                        cmd.Parameters.Add(new SqlParameter("Hasta", dtpHasta.Value));
                        cmd.ExecuteScalar();
                        db.Database.Connection.Close();
                    }
                    CargarTodas();
                    CalcularPago();
                    MessageBox.Show("Indemnización generada correctamente para todos los empleados", "Correcto");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            LimpiarGrid();
            CargarFiltro();
            CalcularPago();
        }
    }
}
