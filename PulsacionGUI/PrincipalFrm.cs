using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionGUI
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPersonaFrm gestionPersonaFrm = new GestionPersonaFrm();
            gestionPersonaFrm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPersonaFrm consultaPersonaFrm = new ConsultaPersonaFrm();
            consultaPersonaFrm.Show();
           
        }
    }
}
