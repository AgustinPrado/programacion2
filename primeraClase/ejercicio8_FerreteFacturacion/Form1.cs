using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio8_FerreteFacturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float Sumar()
        {
            return float.Parse(this.txtNumero1.Text) + float.Parse(this.txtNumero2.Text) + float.Parse(this.txtNumero3.Text);
        }


        private void btnSumar_Click(object sender, EventArgs e)
        {
            this.lblSumar.Text = Sumar().ToString();
            this.lblSumar.Visible = true;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            float promedio = Sumar() / 3;
            this.lblPromedio.Text = promedio.ToString();
            this.lblPromedio.Visible = true;
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            float precioFinal = Sumar() * (float)1.21;
            this.lblPrecioFinal.Text = precioFinal.ToString();
            this.lblPrecioFinal.Visible = true;
        }
    }
}
