﻿using System;
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
    public partial class RegistroDepartamentos : Form
    {
        Departamentos dptos = new Departamentos();
        string idDepartamento = "";
        public RegistroDepartamentos()
        {
            InitializeComponent();
        }

        private void RegistroDepartamentos_Load(object sender, EventArgs e)
        {
            btnAdministrar.Visible = false;
            LlenarDataGrid();
        }

        void LlenarDataGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.Departamentos.ToList<Departamentos>();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            else
            {
                dptos.Nombre = txtNombre.Text.Trim();
                using (DBEntities db = new DBEntities())
                {
                    db.Departamentos.Add(dptos);
                    db.SaveChanges();
                }
                MessageBox.Show("Departamento almacenado con éxito");
                txtNombre.Text = "";
                LlenarDataGrid();
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                idDepartamento = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);
                btnAdministrar.Visible = true;
            }
            
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            AdministracionPlanilla admonplanilla = new AdministracionPlanilla();
            admonplanilla.idDepto = idDepartamento;
            admonplanilla.Show();
        }
    }
}
