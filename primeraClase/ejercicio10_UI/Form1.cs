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
            this.gpbOrdenar.Enabled = false;

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

            this.cmbOrdenar.Items.Add("Fabricante");
            this.cmbOrdenar.Items.Add("Piloto");
            this.cmbOrdenar.SelectedIndex = 0;
            this.cmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;

            this.radAscendente.Checked = true; //para que empieze ya con uno de los dos rad seleccionados

            // para testing
            this.txtNombre.Text = "TEST";
            this.txtFecha.Text = "TEST";
            this.txtLugar.Text = "TEST";
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
                  this.lsbListado.Items.Add(item.DatosEnStringListado);
            }

            this.gpbListadoDeAutos.Enabled = true;
            this.gpbResultado.Enabled = true;
            this.gpbOrdenar.Enabled = true;

            this.txtPiloto.Clear();  
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

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (this.cmbOrdenar.SelectedItem.ToString() == "Fabricante")
            {
                if (this.radAscendente.Checked)
                    this._carrera.ListaDeAutos.Sort(Auto.OrdenarPorFabricanteAsc);
                else
                    this._carrera.ListaDeAutos.Sort(Auto.OrdenarPorFabricanteDesc);
            }
            else
            {
                if (this.radAscendente.Checked)
                    this._carrera.ListaDeAutos.Sort(Auto.OrdenarPorPilotoAsc);
                else
                    this._carrera.ListaDeAutos.Sort(Auto.OrdenarPorPilotoDesc);
            }
            this.cargarListado();
        }

    }
}
