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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudIdentificador = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdentificador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearCu
            // 
            this.btnCrearCu.Location = new System.Drawing.Point(12, 14);
            this.btnCrearCu.Name = "btnCrearCu";
            this.btnCrearCu.Size = new System.Drawing.Size(63, 32);
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
            this.txtCultivos.Location = new System.Drawing.Point(12, 73);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(195, 20);
            this.txtCultivos.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "cutlivos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Identificador:";
            // 
            // nudIdentificador
            // 
            this.nudIdentificador.Location = new System.Drawing.Point(12, 121);
            this.nudIdentificador.Name = "nudIdentificador";
            this.nudIdentificador.Size = new System.Drawing.Size(195, 20);
            this.nudIdentificador.TabIndex = 8;
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 153);
            this.Controls.Add(this.nudIdentificador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCultivos);
            this.Controls.Add(this.btnEditarCu);
            this.Controls.Add(this.btnCrearCu);
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdentificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCu;
        private System.Windows.Forms.Button btnEditarCu;
        private System.Windows.Forms.TextBox txtCultivos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudIdentificador;
    }
}