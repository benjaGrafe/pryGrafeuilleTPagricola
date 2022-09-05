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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void cbmLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbmCultivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TextWriter Guardar = new StreamWriter("./Produccion.txt");
            Guardar.WriteLine(Convert.ToString("Cantidad:" + txtCantidad.Text) + "\nCultivo:" + cbmCultivo.Text+ "\nlocalidad:" + cbmLocalidad.Text);

            Guardar.Close();
            MessageBox.Show("La lista de Produccion se a guardado correctamente", ";)", MessageBoxButtons.OK);

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            File.Create("./Produccion.txt");
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader leerCULTIVOS = new StreamReader("./cultivos.txt");
            while (!leerCULTIVOS.EndOfStream)
            {
                cbmLocalidad.Items.Add(leerCULTIVOS.ReadLine().ToString());
            }

            leerCULTIVOS.Close();

            StreamReader leerlocalidades = new StreamReader("./Localidades.txt");
            while (!leerlocalidades.EndOfStream)
            {
                cbmLocalidad.Items.Add(leerlocalidades.ReadLine().ToString());
            }
            leerlocalidades.Close();




        }
    }
}
