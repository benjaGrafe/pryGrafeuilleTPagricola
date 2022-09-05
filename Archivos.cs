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
    public partial class frmArchivos : Form
    {
        public frmArchivos()
        {
            InitializeComponent();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos cultivos = new frmCultivos();
            cultivos.ShowDialog();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
           File.Create("./pruebaCrearArchivo");
            MessageBox.Show("Creaste un archivo");


        }

        private void localidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmlocalidad localidad = new frmlocalidad();
            localidad.ShowDialog();


        }

        private void produccionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProduccion produccion = new frmProduccion();
            produccion.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCultivos cultivos = new frmCultivos();
            cultivos.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }

            if (s == DialogResult.No)
            {

            }
//gvhgvhgh
        }
    }
}
