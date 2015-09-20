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
    public partial class Ejercicio1C6 : Form
    {
        public Ejercicio1C6()
        {
            InitializeComponent();
        }
       

     



        
        private void calcularButton_Click(object sender, EventArgs e)
        {
            float prom = 0;
            int y = 0;
            int[][] calificacion = new int[][]
            {
                new int[]{8, 7, 9 },
                new int[]{9,10,9,9 },
                new int[]{7,8,10,6,5 }
            };
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < calificacion[i].GetLength(0); x++)
                {
                    calificacionListBox.Items.Add("\t"+calificacion[i][x].ToString());
                    prom += calificacion[i][x];
                    y++;

                }
                 
            }
            promedioTextBox.Text = (prom/y).ToString();
            
            

            
            
        }
    }
}
