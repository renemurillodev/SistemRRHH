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
    public partial class AgregarCargos : Form
    {
        public string idEmpl = "0";
        CargosEmpleados cargosEmp = new CargosEmpleados();
        public AgregarCargos()
        {
            InitializeComponent();
        }

        private void AgregarCargos_Load(object sender, EventArgs e)
        {
            CargarNombres(idEmpl);
            LlenarCargos();
        }

        void CargarNombres(string id)
        {
            int idBusqueda = int.Parse(id);

            if(idBusqueda != 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    cbxEmpleados.DataSource = db.Empleados.ToList<Empleados>();

                    cbxEmpleados.DisplayMember = "NombreCompleto";
                    cbxEmpleados.ValueMember = "Id";
                    cbxEmpleados.SelectedValue = idBusqueda;
                }
            }
            
        }

        void LlenarCargos()
        {
            using (DBEntities db = new DBEntities())
            {
                cbxCargos.DataSource = db.Cargos.ToList<Cargos>();

                cbxCargos.DisplayMember = "Nombre";
                cbxCargos.ValueMember = "Id";
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            cargosEmp.Cargo_Id = Convert.ToInt32(cbxCargos.SelectedValue);
            cargosEmp.Empleado_Id = Convert.ToInt32(cbxEmpleados.SelectedValue);
            cargosEmp.FechaInicio = dateTimePicker1.Value;
            if(cbxEstado.Text == "Activo")
            {
                cargosEmp.Estado = "A";
            }else if(cbxEstado.Text == "Inactivo")
            {
                cargosEmp.Estado = "I";
            }
            else
            {
                MessageBox.Show("Seleccione un estado");
            }

            using (DBEntities db = new DBEntities())
            {
                try
                {
                    
                    db.CargosEmpleados.Add(cargosEmp);
                    db.SaveChanges();
                    MessageBox.Show("Cargo asignado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo salió mal");
                }
            }
        }
    }
}
