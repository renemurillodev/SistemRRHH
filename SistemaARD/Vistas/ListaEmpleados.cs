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
    public partial class ListaEmpleados : Form
    {
        private Empleados empleados = new Empleados();
        string idEmpleado = "";
        public ListaEmpleados()
        {
            InitializeComponent();
        }

        private void ListaEmpleados_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        void CargarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.Empleados.ToList<Empleados>();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            string apellido = txtApellido.Text.Trim();
            using (DBEntities db = new DBEntities())
            {

                IQueryable<Empleados> obj = from q in db.Empleados
                                            where q.Apellidos.Contains(apellido)
                                            select q;
                List<Empleados> employee = obj.ToList();

                if (employee == null)
                {
                    MessageBox.Show("El empleado que intenta buscar no existe");
                }
                else
                {
                    
                    dataGridView1.DataSource = employee;
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroEmpleados registro = new RegistroEmpleados();
            if(dataGridView1.CurrentRow.Index != -1)
            {
                registro.texto = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);

                
                registro.Show();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.CurrentRow.Index != -1)
            {
                idEmpleado = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);
                btnEditar.Visible = true;
                btnDetalle.Visible = true;
                btnContrato.Visible = true;
            }
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            //AgregarCargos cargos = new AgregarCargos();
            //cargos.idEmpl = idEmpleado;
            //cargos.Show();
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de cerrar?", "ALERTA!!", MessageBoxButtons.YesNo) == DialogResult.Yes){
                this.Close();
            }
        }

        private void btnRegistroEmp_Click(object sender, EventArgs e)
        {
            RegistroEmpleados REmpleados = new RegistroEmpleados();
            AddOwnedForm(REmpleados);
            REmpleados.TopLevel = false;
            REmpleados.Dock = DockStyle.Fill;
            this.Controls.Add(REmpleados);
            this.Tag = REmpleados;
            REmpleados.BringToFront();
            REmpleados.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            RegistroEmpleados registro = new RegistroEmpleados();
            if (dataGridView1.CurrentRow.Index != -1)
            {
                registro.texto = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);


                AddOwnedForm(registro);
                registro.TopLevel = false;
                registro.Dock = DockStyle.Fill;
                this.Controls.Add(registro);
                this.Tag = registro;
                registro.BringToFront();
                registro.Show();

                
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            RegistroEmpleados registro = new RegistroEmpleados();



            if (dataGridView1.CurrentRow.Index != -1)
            {
                registro.texto = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);

                registro.detalle = "true";
                registro.Show();
            }

            
            AddOwnedForm(registro);
            registro.TopLevel = false;
            registro.Dock = DockStyle.Fill;
            this.Controls.Add(registro);
            this.Tag = registro;
            registro.BringToFront();
            registro.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            GenerarContratos contrato = new GenerarContratos();
            contrato.Id = Convert.ToInt32(idEmpleado);
            contrato.Show();
        }

       
    }
}
