using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD.Vistas
{
    public partial class AdministracionPlanilla : Form
    {
        public string idDepto = "";
        string nDepto = "";
        string idEmpleado = "";
        PlanillasVentas planillaVentas = new PlanillasVentas();
        Reportes reporte = new Reportes();
        Clases.CalculoPlanilla calculoSalario = new Clases.CalculoPlanilla();
        public AdministracionPlanilla()
        {
            InitializeComponent();
        }

        private void AdministracionPlanilla_Load(object sender, EventArgs e)
        {
            
            BuscarDepto();
            CargarDataGrid();
            if(textBox1.Text == "Ventas")
            {
                lblDiasLaborados.Visible = true;
                lblPagoDiario.Visible = true;
                txtDiasLaborados.Visible = true;
                txtPagoDiario.Visible = true;
            }
        }

        void BuscarDepto()
        {
            var id = int.Parse(idDepto);
            if(idDepto != "")
            {
                using (DBEntities db = new DBEntities())
                {
                    var nombreDepto = db.Departamentos.Where(x => x.Id == id).FirstOrDefault();
                    textBox1.Text = nombreDepto.Nombre;
                    nDepto = nombreDepto.Nombre;
                }
            }
            else
            {
                textBox1.Text = "Sin Depto";
            }
        }

        void CargarDataGrid()
        {
            if(nDepto == "")
            {
                MessageBox.Show("No existen empleados registrados en el departamento solicitado");
            }
            else
            { 
                using (DBEntities db = new DBEntities())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    var empleados = db.Database.SqlQuery<LlenarPlanilla>(string.Format("SELECT dbo.Empleados.Id as Id, dbo.Empleados.Nombres as Nombres, dbo.Empleados.Apellidos as Apellidos, dbo.Empleados.Cargo_Id as Cargo_Id, dbo.Cargos.Nombre as Cargo FROM dbo.Empleados INNER JOIN dbo.Cargos ON dbo.Empleados.Cargo_Id = dbo.Cargos.Id INNER JOIN dbo.Departamentos ON dbo.Departamentos.Id = dbo.Cargos.Departamento_Id WHERE dbo.Departamentos.Nombre = '{0}'", nDepto)).ToList();
                    dataGridView1.DataSource = empleados;
                }
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAnticipos_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                idEmpleado = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);
                string nombres = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombres"].Value);
                string apellidos = Convert.ToString(dataGridView1.CurrentRow.Cells["Apellidos"].Value);
                txtEmpleado.Text = string.Format("{0} {1}", nombres, apellidos);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Ventas")
            {
                //Registrar en tabla PlanillaVentas
                planillaVentas.Empleado_Id = Convert.ToInt32(idEmpleado);
                planillaVentas.Pago_diario = Convert.ToDecimal(txtPagoDiario.Text);
                planillaVentas.Dias_laborados = Convert.ToInt32(txtDiasLaborados.Text);
                planillaVentas.Anticipos = Convert.ToDecimal(txtAnticipos.Text);
                planillaVentas.Fecha = dtpFecha.Value;
                planillaVentas.Categoria_Id = 1;

                //Registrar en tabla Reportes 

                var sueldo = Convert.ToDecimal(txtPagoDiario.Text) * Convert.ToDecimal(txtDiasLaborados.Text);
                var afp = sueldo * Convert.ToDecimal(0.0725);
                var isss = sueldo * Convert.ToDecimal(0.03);
                var sueldoPostRetenciones = sueldo - (afp + isss);
                reporte.Empleado_Id = Convert.ToInt32(idEmpleado);
                reporte.Sueldo = sueldo;
                reporte.Pago_Afp = afp;
                reporte.Pago_Isss = isss;

                using (DBEntities db = new DBEntities())
                {
                    try
                    {
                        db.PlanillasVentas.Add(planillaVentas);
                        db.SaveChanges();
                        MessageBox.Show("Pago registrado");
                        txtAnticipos.Text = txtDiasLaborados.Text = txtEmpleado.Text = txtHorasLaboradas.Text = txtPagoDiario.Text = txtPagoHora.Text = "";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Algo salió mal");
                    }
                }
            }
        }
    }

    public class LlenarPlanilla
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Cargo_Id { get; set; }
        public string Cargo { get; set; }
    }
}
