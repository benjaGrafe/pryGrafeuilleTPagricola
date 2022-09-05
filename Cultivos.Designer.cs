namespace pryGrafeuilleTPagricola
{
    partial class frmCultivos
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
            this.btnCrearCu = new System.Windows.Forms.Button();
            this.btnEditarCu = new System.Windows.Forms.Button();
            this.txtCultivos = new System.Windows.Forms.TextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearCu
            // 
            this.btnCrearCu.Location = new System.Drawing.Point(12, 12);
            this.btnCrearCu.Name = "btnCrearCu";
            this.btnCrearCu.Size = new System.Drawing.Size(63, 34);
            this.btnCrearCu.TabIndex = 0;
            this.btnCrearCu.Text = "Crear";
            this.btnCrearCu.UseVisualStyleBackColor = true;
            this.btnCrearCu.Click += new System.EventHandler(this.btnCrearCu_Click);
            // 
            // btnEditarCu
            // 
            this.btnEditarCu.Location = new System.Drawing.Point(81, 14);
            this.btnEditarCu.Name = "btnEditarCu";
            this.btnEditarCu.Size = new System.Drawing.Size(63, 32);
            this.btnEditarCu.TabIndex = 1;
            this.btnEditarCu.Text = "Editar";
            this.btnEditarCu.UseVisualStyleBackColor = true;
            this.btnEditarCu.Click += new System.EventHandler(this.btnEditarCu_Click);
            // 
            // txtCultivos
            // 
            this.txtCultivos.Location = new System.Drawing.Point(12, 61);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(195, 20);
            this.txtCultivos.TabIndex = 3;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(12, 87);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(195, 20);
            this.txtIdentificador.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(150, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 32);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 153);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.txtCultivos);
            this.Controls.Add(this.btnEditarCu);
            this.Controls.Add(this.btnCrearCu);
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCu;
        private System.Windows.Forms.Button btnEditarCu;
        private System.Windows.Forms.TextBox txtCultivos;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Button btnEliminar;
    }
}