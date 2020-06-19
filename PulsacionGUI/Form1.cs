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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            string nomrbre = openFile.FileName;
            MessageBox.Show("Resultado de Carge \n Archivos reportados =>7 \n Cargados Satisfactoriamente=>5  \n Con error de  2");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
