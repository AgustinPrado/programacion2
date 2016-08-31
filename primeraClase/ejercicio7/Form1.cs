using System;
using System.Windows.Forms;

namespace ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string aux;
            aux = this.txtNombre.Text;
            MessageBox.Show("Hola " + aux);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.lblNombre.Text = "Cambie el texto";
        }

        private void btnAprobarMateria_MouseLeave(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = true;
        }

        private void btnAprobarMateria_MouseEnter(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = false;
        }
    }
}
