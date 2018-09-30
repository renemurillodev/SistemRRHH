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
    public partial class MostrarAguinaldos : Form
    {
        public MostrarAguinaldos()
        {
            InitializeComponent();
        }

        private void MostrarAguinaldos_Load(object sender, EventArgs e)
        {
            CargarCombo();
            LlenarAguinaldoAdministracion();
        }

        void CargarCombo()
        {
            using (DBEntities db = new DBEntities())
            {
                cbxDepartamento.DataSource = db.Departamentos.ToList<Departamentos>();
                cbxDepartamento.DisplayMember = "Nombre";
                cbxDepartamento.ValueMember = "Id";
            }
        }

        void LlenarAguinaldoAdministracion()
        {
            try
            {
                string con = "Data Source =.; Initial catalog = losnacimientos; Integrated security = True;";
                SqlConnection cnn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("ListarAguinaldosAdministracion", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                var aguinaldos = cmd.ExecuteScalar();
                cnn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }



    public class LlenarAguinaldo
    {
        public int Id { get; }
        public string Empleado_Id { get; }
        public string Empleado { get; }
        public decimal SalarioDiario { get; }
        public DateTime FechaIngreso { get; }
        public int AniosTrabajo { get; }
        public int DiasTrabajo { get; }
        public int DiasPagar { get; }
        public decimal TotalPagar
        {
            get
            {
                
                    return DiasPagar * DiasTrabajo;
                

            }
        }
    }
}
