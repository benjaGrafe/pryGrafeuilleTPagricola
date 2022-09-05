using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryGrafeuilleTPagricola
{
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void btnCrearCu_Click(object sender, EventArgs e)
        {
            File.Create("./cultivos.txt");
            MessageBox.Show("Creaste un archivo Cultivos");
        }

        private void btnEditarCu_Click(object sender, EventArgs e)
        {
            TextWriter editar = new StreamWriter("./cultivos.txt", true);
            editar.WriteLine(Convert.ToString(txtCultivos.Text + "" + nudIdentificador.Text));
            editar.Close();

            MessageBox.Show("se edito correctamente");





            txtCultivos.Text = "";
            nudIdentificador.Text = "";
            txtCultivos.Focus();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro que desea eliminar el archivo?" + "\nAtencion: Si elimina el archivo todo el contenido se perdera" + "\n¿Aun desea continuar?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (r == DialogResult.OK)
            {
                File.Delete("./cultivos.txt");


                MessageBox.Show("Archivo eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (r == DialogResult.Cancel)
            {
                MessageBox.Show("Accion cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
