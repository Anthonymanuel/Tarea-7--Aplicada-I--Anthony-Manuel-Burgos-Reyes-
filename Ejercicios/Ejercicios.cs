using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicios : Form
    {
        public Ejercicios()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1C6 ejercicio1C6 = new Ejercicio1C6();
            ejercicio1C6.MdiParent = this;
            ejercicio1C6.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2C6 ejercicio2C6 = new Ejercicio2C6();
            ejercicio2C6.MdiParent = this;
            ejercicio2C6.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3C6 ejercicio3C6 = new Ejercicio3C6();
            ejercicio3C6.MdiParent = this;
            ejercicio3C6.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio4C6 ejercicio4C6 = new Ejercicio4C6();
            ejercicio4C6.MdiParent = this;
            ejercicio4C6.Show();
            
        }
    }
}
