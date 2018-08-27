using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SistemaARD.Vistas;

namespace SistemaARD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /*Evento para mover la ventana*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);
        /*FIN EVENTO*/

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dashboard();
        }

        //METODO PARA ABRIR FORMULADIO DENTRO DEL PANEL PRINCIPAL
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        //Mostrar Dashboard al iniciar la vista principal
        private void dashboard()
        {
            AbrirFormInPanel(new Dashboard());
        }

        //Hora y Fecha batta inferior
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblDiaFecha.Text = DateTime.Now.ToLongDateString();
        }
        //Boton slider
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 60;
                imgLogo.Width = 45;
                imgLogo.Height = 40;
            }
            else
            {
                MenuVertical.Width = 250;
                imgLogo.Width = 233;
                imgLogo.Height = 130;
            }
        }
        //Botones cerrar, minimizar, maximizar y restaurar
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }
        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        //EVENTO PARA PODER MODER LA VENTANA
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112 , 0xf012, 0);
        }

        private void Fullcontainer_Paint(object sender, PaintEventArgs e)
        {
           
        }
        //BOTONES PARA ABRIR CADA FORMULARIO EN EL PANEL
        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FPlanillas());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ListaEmpleados());
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegistroCargos());
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegistroDepartamentos());
        }
    }
}
