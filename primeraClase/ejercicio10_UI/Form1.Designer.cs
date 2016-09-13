namespace ejercicio10_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearCarrera = new System.Windows.Forms.Button();
            this.gpbCarrera = new System.Windows.Forms.GroupBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbAutos = new System.Windows.Forms.GroupBox();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.gpbListadoDeAutos = new System.Windows.Forms.GroupBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.txtPiloto = new System.Windows.Forms.TextBox();
            this.lblPiloto = new System.Windows.Forms.Label();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lsbListado = new System.Windows.Forms.ListBox();
            this.btnCorrerCarrera = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbTipoCarrera = new System.Windows.Forms.ComboBox();
            this.lblTipoCarrera = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUnidadCarrera = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.gpbCarrera.SuspendLayout();
            this.gpbAutos.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            this.gpbListadoDeAutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearCarrera
            // 
            this.btnCrearCarrera.Location = new System.Drawing.Point(501, 37);
            this.btnCrearCarrera.Name = "btnCrearCarrera";
            this.btnCrearCarrera.Size = new System.Drawing.Size(82, 23);
            this.btnCrearCarrera.TabIndex = 4;
            this.btnCrearCarrera.Text = "Crear Carrera";
            this.btnCrearCarrera.UseVisualStyleBackColor = true;
            this.btnCrearCarrera.Click += new System.EventHandler(this.btnCrearCarrera_Click);
            // 
            // gpbCarrera
            // 
            this.gpbCarrera.Controls.Add(this.txtLugar);
            this.gpbCarrera.Controls.Add(this.lblLugar);
            this.gpbCarrera.Controls.Add(this.txtFecha);
            this.gpbCarrera.Controls.Add(this.lblFecha);
            this.gpbCarrera.Controls.Add(this.txtNombre);
            this.gpbCarrera.Controls.Add(this.lblNombre);
            this.gpbCarrera.Controls.Add(this.btnCrearCarrera);
            this.gpbCarrera.Location = new System.Drawing.Point(13, 13);
            this.gpbCarrera.Name = "gpbCarrera";
            this.gpbCarrera.Size = new System.Drawing.Size(605, 71);
            this.gpbCarrera.TabIndex = 1;
            this.gpbCarrera.TabStop = false;
            this.gpbCarrera.Text = "Carrera";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(340, 37);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(155, 20);
            this.txtLugar.TabIndex = 3;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(337, 20);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 5;
            this.lblLugar.Text = "Lugar";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(174, 37);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(155, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(171, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // gpbAutos
            // 
            this.gpbAutos.Controls.Add(this.cmbFabricante);
            this.gpbAutos.Controls.Add(this.btnAgregarAuto);
            this.gpbAutos.Controls.Add(this.txtPiloto);
            this.gpbAutos.Controls.Add(this.lblPiloto);
            this.gpbAutos.Controls.Add(this.lblFabricante);
            this.gpbAutos.Location = new System.Drawing.Point(13, 90);
            this.gpbAutos.Name = "gpbAutos";
            this.gpbAutos.Size = new System.Drawing.Size(287, 109);
            this.gpbAutos.TabIndex = 2;
            this.gpbAutos.TabStop = false;
            this.gpbAutos.Text = "Autos";
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.numCantidad);
            this.gpbResultado.Controls.Add(this.lblUnidadCarrera);
            this.gpbResultado.Controls.Add(this.lblCantidad);
            this.gpbResultado.Controls.Add(this.lblTipoCarrera);
            this.gpbResultado.Controls.Add(this.cmbTipoCarrera);
            this.gpbResultado.Controls.Add(this.txtResultado);
            this.gpbResultado.Controls.Add(this.btnCorrerCarrera);
            this.gpbResultado.Location = new System.Drawing.Point(13, 205);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(287, 221);
            this.gpbResultado.TabIndex = 3;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // gpbListadoDeAutos
            // 
            this.gpbListadoDeAutos.Controls.Add(this.lsbListado);
            this.gpbListadoDeAutos.Location = new System.Drawing.Point(306, 90);
            this.gpbListadoDeAutos.Name = "gpbListadoDeAutos";
            this.gpbListadoDeAutos.Size = new System.Drawing.Size(312, 336);
            this.gpbListadoDeAutos.TabIndex = 4;
            this.gpbListadoDeAutos.TabStop = false;
            this.gpbListadoDeAutos.Text = "Listado de autos";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(7, 16);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 7;
            this.lblFabricante.Text = "Fabricante";
            // 
            // txtPiloto
            // 
            this.txtPiloto.Location = new System.Drawing.Point(10, 73);
            this.txtPiloto.Name = "txtPiloto";
            this.txtPiloto.Size = new System.Drawing.Size(155, 20);
            this.txtPiloto.TabIndex = 6;
            // 
            // lblPiloto
            // 
            this.lblPiloto.AutoSize = true;
            this.lblPiloto.Location = new System.Drawing.Point(7, 56);
            this.lblPiloto.Name = "lblPiloto";
            this.lblPiloto.Size = new System.Drawing.Size(33, 13);
            this.lblPiloto.TabIndex = 7;
            this.lblPiloto.Text = "Piloto";
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(174, 70);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(82, 23);
            this.btnAgregarAuto.TabIndex = 7;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(10, 33);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(155, 21);
            this.cmbFabricante.TabIndex = 5;
            // 
            // lsbListado
            // 
            this.lsbListado.FormattingEnabled = true;
            this.lsbListado.Location = new System.Drawing.Point(7, 20);
            this.lsbListado.Name = "lsbListado";
            this.lsbListado.Size = new System.Drawing.Size(299, 303);
            this.lsbListado.TabIndex = 0;
            // 
            // btnCorrerCarrera
            // 
            this.btnCorrerCarrera.Location = new System.Drawing.Point(171, 81);
            this.btnCorrerCarrera.Name = "btnCorrerCarrera";
            this.btnCorrerCarrera.Size = new System.Drawing.Size(85, 23);
            this.btnCorrerCarrera.TabIndex = 0;
            this.btnCorrerCarrera.Text = "Correr Carrera";
            this.btnCorrerCarrera.UseVisualStyleBackColor = true;
            this.btnCorrerCarrera.Click += new System.EventHandler(this.btnCorrerCarrera_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(10, 81);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(155, 49);
            this.txtResultado.TabIndex = 1;
            // 
            // cmbTipoCarrera
            // 
            this.cmbTipoCarrera.FormattingEnabled = true;
            this.cmbTipoCarrera.Location = new System.Drawing.Point(108, 18);
            this.cmbTipoCarrera.Name = "cmbTipoCarrera";
            this.cmbTipoCarrera.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCarrera.TabIndex = 2;
            this.cmbTipoCarrera.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCarrera_SelectedIndexChanged);
            // 
            // lblTipoCarrera
            // 
            this.lblTipoCarrera.AutoSize = true;
            this.lblTipoCarrera.Location = new System.Drawing.Point(7, 21);
            this.lblTipoCarrera.Name = "lblTipoCarrera";
            this.lblTipoCarrera.Size = new System.Drawing.Size(92, 13);
            this.lblTipoCarrera.TabIndex = 3;
            this.lblTipoCarrera.Text = "Correr carrera por:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 46);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblUnidadCarrera
            // 
            this.lblUnidadCarrera.AutoSize = true;
            this.lblUnidadCarrera.Location = new System.Drawing.Point(168, 46);
            this.lblUnidadCarrera.Name = "lblUnidadCarrera";
            this.lblUnidadCarrera.Size = new System.Drawing.Size(43, 13);
            this.lblUnidadCarrera.TabIndex = 6;
            this.lblUnidadCarrera.Text = "minutos";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(108, 44);
            this.numCantidad.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(57, 20);
            this.numCantidad.TabIndex = 7;
            this.numCantidad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 438);
            this.Controls.Add(this.gpbAutos);
            this.Controls.Add(this.gpbListadoDeAutos);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbCarrera.ResumeLayout(false);
            this.gpbCarrera.PerformLayout();
            this.gpbAutos.ResumeLayout(false);
            this.gpbAutos.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.gpbListadoDeAutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCarrera;
        private System.Windows.Forms.GroupBox gpbCarrera;
        private System.Windows.Forms.GroupBox gpbAutos;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.GroupBox gpbListadoDeAutos;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.TextBox txtPiloto;
        private System.Windows.Forms.Label lblPiloto;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ListBox lsbListado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCorrerCarrera;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTipoCarrera;
        private System.Windows.Forms.ComboBox cmbTipoCarrera;
        private System.Windows.Forms.Label lblUnidadCarrera;
        private System.Windows.Forms.NumericUpDown numCantidad;
    }
}

