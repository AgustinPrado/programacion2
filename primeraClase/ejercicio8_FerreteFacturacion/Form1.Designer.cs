namespace ejercicio8_FerreteFacturacion
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnPrecioFinal = new System.Windows.Forms.Button();
            this.lblSumar = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(13, 13);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(13, 40);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(13, 67);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(100, 20);
            this.txtNumero3.TabIndex = 2;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(13, 94);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 3;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(13, 124);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 4;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnPrecioFinal
            // 
            this.btnPrecioFinal.Location = new System.Drawing.Point(13, 154);
            this.btnPrecioFinal.Name = "btnPrecioFinal";
            this.btnPrecioFinal.Size = new System.Drawing.Size(75, 23);
            this.btnPrecioFinal.TabIndex = 5;
            this.btnPrecioFinal.Text = "Precio Final";
            this.btnPrecioFinal.UseVisualStyleBackColor = true;
            this.btnPrecioFinal.Click += new System.EventHandler(this.btnPrecioFinal_Click);
            // 
            // lblSumar
            // 
            this.lblSumar.AutoSize = true;
            this.lblSumar.Location = new System.Drawing.Point(94, 99);
            this.lblSumar.Name = "lblSumar";
            this.lblSumar.Size = new System.Drawing.Size(35, 13);
            this.lblSumar.TabIndex = 6;
            this.lblSumar.Text = "label1";
            this.lblSumar.Visible = false;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(94, 129);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(35, 13);
            this.lblPromedio.TabIndex = 7;
            this.lblPromedio.Text = "label2";
            this.lblPromedio.Visible = false;
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(94, 159);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(35, 13);
            this.lblPrecioFinal.TabIndex = 8;
            this.lblPrecioFinal.Text = "label3";
            this.lblPrecioFinal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblSumar);
            this.Controls.Add(this.btnPrecioFinal);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnPrecioFinal;
        private System.Windows.Forms.Label lblSumar;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblPrecioFinal;
    }
}

