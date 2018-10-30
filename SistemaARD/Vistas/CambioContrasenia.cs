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
    public partial class CambioContrasenia : Form
    {
        public CambioContrasenia()
        {
            InitializeComponent();
        }

        int idUser;

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                var exist = (from u in db.Usuarios
                             where u.Username == txtUsername.Text.Trim()
                             select u).FirstOrDefault();

                if(exist != null)
                {
                    panelCambiar.Visible = true;
                    panelSolicitar.Visible = false;
                    idUser = exist.Id;
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ingresado no corresponde a un usuario registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != "" && txtRepetirPass.Text != "")
            {
                if(txtPassword.Text != txtRepetirPass.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int res;
                    using (DBEntities db = new DBEntities())
                    {
                        db.Database.Connection.Open();
                        System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                        cmd.CommandText = "CambiarPassword";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("Id", idUser));
                        cmd.Parameters.Add(new SqlParameter("Password", txtPassword.Text.Trim()));
                        res = (int)cmd.ExecuteScalar();
                        db.Database.Connection.Close();
                    }
                    if(res > 0)
                    {
                        MessageBox.Show("Contraseña cambiada con éxito", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            
        }
    }
}
