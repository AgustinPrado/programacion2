using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicio4;

namespace ejercicio10_UI
{
    public partial class Form1 : Form
    {
        private Carrera _carrera;

        public Form1()
        {
            InitializeComponent();

            this.gpbAutos.Enabled = false;
            this.gpbListadoDeAutos.Enabled = false;
            this.gpbResultado.Enabled = false;

            foreach (EFabricante item in Enum.GetValues(typeof(EFabricante)))
            {
                this.cmbFabricante.Items.Add(item);
            }
            this.cmbFabricante.SelectedIndex = 1;
            this.cmbFabricante.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbTipoCarrera.Items.Add("Tiempo");
            this.cmbTipoCarrera.Items.Add("Kilometro");
            this.cmbTipoCarrera.SelectedIndex = 0;
            this.cmbTipoCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCrearCarrera_Click(object sender, EventArgs e)
        {
            this._carrera = new Carrera(this.txtNombre.Text, this.txtFecha.Text, this.txtLugar.Text);
            this.gpbCarrera.Enabled = false;
            this.gpbAutos.Enabled = true;
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            Auto autoAux = new Auto(this.txtPiloto.Text, (EFabricante)this.cmbFabricante.SelectedItem);
            this._carrera = this._carrera + autoAux;

            cargarListado();
        }

        private void cargarListado()
        {
            this.lsbListado.Items.Clear();

            foreach (Auto item in this._carrera.ListaDeAutos)
            {
                  this.lsbListado.Items.Add(item.DatosEnString);
            }

            this.gpbListadoDeAutos.Enabled = true;
            this.gpbResultado.Enabled = true;
        }

        private void btnCorrerCarrera_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoCarrera.SelectedItem.ToString() == "Tiempo")
                this.txtResultado.Text = this._carrera.CorrerCarrera((Tiempo)numCantidad.Value);
            else
                this.txtResultado.Text = this._carrera.CorrerCarrera((Kilometro)numCantidad.Value);   
        }

        private void cmbTipoCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoCarrera.SelectedItem.ToString() == "Tiempo")
                this.lblUnidadCarrera.Text = "minutos";
            else
                this.lblUnidadCarrera.Text = "km";
        }

    }
}
