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
    public partial class RegistroCargos : Form
    {
        Cargos cargo = new Cargos();
        public RegistroCargos()
        {
            InitializeComponent();
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

        private void RegistroCargos_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cargo");
            }
            else
            {
                cargo.Nombre = txtNombre.Text.Trim();
                cargo.Departamento_Id = Convert.ToInt32(cbxDepartamento.SelectedValue);
                using (DBEntities db = new DBEntities())
                {
                    db.Cargos.Add(cargo);
                    db.SaveChanges();
                }
                MessageBox.Show("Cargo registrado con éxito");
                txtNombre.Text = "";
                cbxDepartamento.Text = "";
            }
        }
    }
}
