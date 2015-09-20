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
    public partial class Ejercicio4C6 : Form
    {
        public Ejercicio4C6()
        {
            InitializeComponent();
        }

        static int Menor(int [][] num )
        {
            
            int men = 10;
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < num[i].GetLength(0); x++)
                { 
                    if (num[i][x] < men)
                        men = num[i][x];
                    

                }

            }
            return men;
        }

        static int Mayor(int[][] num)
        {

            int may = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < num[i].GetLength(0); x++)
                {
                    if (num[i][x] > may)
                        may = num[i][x];


                }

            }
            return may;
        }
        static int Promedio(int[][] num)
        {

            int prom = 0, y = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < num[i].GetLength(0); x++)
                {

                    prom += num[i][x];
                    y++;
                }

            }
            return prom/y;
        }
        private void calcularButton_Click(object sender, EventArgs e)
        {
          
         
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
                    calificacionListBox.Items.Add("\t" + calificacion[i][x].ToString());
                }

            }
            promedioTextBox.Text = Promedio(calificacion).ToString();
            menorTextBox.Text = Menor(calificacion).ToString();
            mayorTextBox.Text = Mayor(calificacion).ToString();
        }
    }
}
