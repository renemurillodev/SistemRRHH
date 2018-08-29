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
        public AdministracionPlanilla()
        {
            InitializeComponent();
        }

        private void AdministracionPlanilla_Load(object sender, EventArgs e)
        {
            
            BuscarDepto();
            CargarDataGrid();
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
