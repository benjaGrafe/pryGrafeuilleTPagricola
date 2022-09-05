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
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.btnElliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearLo
            // 
            this.btnCrearLo.Location = new System.Drawing.Point(12, 16);
            this.btnCrearLo.Name = "btnCrearLo";
            this.btnCrearLo.Size = new System.Drawing.Size(52, 32);
            this.btnCrearLo.TabIndex = 1;
            this.btnCrearLo.Text = "Crear";
            this.btnCrearLo.UseVisualStyleBackColor = true;
            this.btnCrearLo.Click += new System.EventHandler(this.btnCrearLo_Click);
            // 
            // btnEditarLo
            // 
            this.btnEditarLo.Location = new System.Drawing.Point(70, 16);
            this.btnEditarLo.Name = "btnEditarLo";
            this.btnEditarLo.Size = new System.Drawing.Size(62, 32);
            this.btnEditarLo.TabIndex = 2;
            this.btnEditarLo.Text = "Editar";
            this.btnEditarLo.UseVisualStyleBackColor = true;
            this.btnEditarLo.Click += new System.EventHandler(this.btnEditarLo_Click);
            // 
            // txtlocalidades
            // 
            this.txtlocalidades.Location = new System.Drawing.Point(12, 55);
            this.txtlocalidades.Name = "txtlocalidades";
            this.txtlocalidades.Size = new System.Drawing.Size(181, 20);
            this.txtlocalidades.TabIndex = 4;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(12, 81);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(181, 20);
            this.txtIdentificador.TabIndex = 5;
            // 
            // btnElliminar
            // 
            this.btnElliminar.Location = new System.Drawing.Point(138, 15);
            this.btnElliminar.Name = "btnElliminar";
            this.btnElliminar.Size = new System.Drawing.Size(55, 33);
            this.btnElliminar.TabIndex = 6;
            this.btnElliminar.Text = "Eliminar";
            this.btnElliminar.UseVisualStyleBackColor = true;
            this.btnElliminar.Click += new System.EventHandler(this.btnElliminar_Click);
            // 
            // frmlocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 125);
            this.Controls.Add(this.btnElliminar);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.txtlocalidades);
            this.Controls.Add(this.btnEditarLo);
            this.Controls.Add(this.btnCrearLo);
            this.Name = "frmlocalidad";
            this.Text = "Localidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrearLo;
        private System.Windows.Forms.Button btnEditarLo;
        private System.Windows.Forms.TextBox txtlocalidades;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Button btnElliminar;
    }
}