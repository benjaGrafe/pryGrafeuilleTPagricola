namespace pryGrafeuilleTPagricola
{
    partial class frmlocalidad
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
            this.btnCrearLo = new System.Windows.Forms.Button();
            this.btnEditarLo = new System.Windows.Forms.Button();
            this.txtlocalidades = new System.Windows.Forms.TextBox();
            this.btnElliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.npdIdentificador = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.npdIdentificador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearLo
            // 
            this.btnCrearLo.Location = new System.Drawing.Point(12, 12);
            this.btnCrearLo.Name = "btnCrearLo";
            this.btnCrearLo.Size = new System.Drawing.Size(52, 32);
            this.btnCrearLo.TabIndex = 1;
            this.btnCrearLo.Text = "Crear";
            this.btnCrearLo.UseVisualStyleBackColor = true;
            this.btnCrearLo.Click += new System.EventHandler(this.btnCrearLo_Click);
            // 
            // btnEditarLo
            // 
            this.btnEditarLo.Location = new System.Drawing.Point(70, 12);
            this.btnEditarLo.Name = "btnEditarLo";
            this.btnEditarLo.Size = new System.Drawing.Size(62, 32);
            this.btnEditarLo.TabIndex = 2;
            this.btnEditarLo.Text = "Editar";
            this.btnEditarLo.UseVisualStyleBackColor = true;
            this.btnEditarLo.Click += new System.EventHandler(this.btnEditarLo_Click);
            // 
            // txtlocalidades
            // 
            this.txtlocalidades.Location = new System.Drawing.Point(12, 70);
            this.txtlocalidades.Name = "txtlocalidades";
            this.txtlocalidades.Size = new System.Drawing.Size(181, 20);
            this.txtlocalidades.TabIndex = 4;
            // 
            // btnElliminar
            // 
            this.btnElliminar.Location = new System.Drawing.Point(138, 11);
            this.btnElliminar.Name = "btnElliminar";
            this.btnElliminar.Size = new System.Drawing.Size(55, 33);
            this.btnElliminar.TabIndex = 6;
            this.btnElliminar.Text = "Eliminar";
            this.btnElliminar.UseVisualStyleBackColor = true;
            this.btnElliminar.Click += new System.EventHandler(this.btnElliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Localidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Identificador:";
            // 
            // npdIdentificador
            // 
            this.npdIdentificador.Location = new System.Drawing.Point(12, 110);
            this.npdIdentificador.Name = "npdIdentificador";
            this.npdIdentificador.Size = new System.Drawing.Size(181, 20);
            this.npdIdentificador.TabIndex = 10;
            // 
            // frmlocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 142);
            this.Controls.Add(this.npdIdentificador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnElliminar);
            this.Controls.Add(this.txtlocalidades);
            this.Controls.Add(this.btnEditarLo);
            this.Controls.Add(this.btnCrearLo);
            this.Name = "frmlocalidad";
            this.Text = "Localidades";
            ((System.ComponentModel.ISupportInitialize)(this.npdIdentificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrearLo;
        private System.Windows.Forms.Button btnEditarLo;
        private System.Windows.Forms.TextBox txtlocalidades;
        private System.Windows.Forms.Button btnElliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown npdIdentificador;
    }
}