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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                int res;
                using (DBEntities db = new DBEntities())
                {
                    db.Database.Connection.Open();
                    System.Data.Common.DbCommand cmd = db.Database.Connection.CreateCommand();
                    cmd.CommandText = "IniciarSesion";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("Username", txtUsername.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("Password", txtPassword.Text.Trim()));
                    res = (int)cmd.ExecuteScalar();
                    db.Database.Connection.Close();
                }
                if(res == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bienvenido");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            CambioContrasenia newPass = new CambioContrasenia();
            newPass.Show();
        }
    }
}
