using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            double horas1, minutos1, segundos1;
            horas1 = Convert.ToDouble(tHoras1.Text);
            minutos1= Convert.ToDouble(tMinutos1.Text);
            segundos1= Convert.ToDouble(tSegundos1.Text);
            double horas2 = Convert.ToDouble(tHoras2.Text), minutos2 = Convert.ToDouble(tMinutos2.Text), segundos2 = Convert.ToDouble(tSegundos2.Text);

            double sumaHoras,sumaMinutos,sumaSegundos;

            sumaHoras = horas1 + horas2;
            sumaMinutos = minutos1 + minutos2;
            sumaSegundos = segundos1 + segundos2;

            MessageBox.Show("La suma de los tiempos es de\n" + sumaHoras + " horas\n" + sumaMinutos + " minutos\n" + sumaSegundos + " segundos");

        }
    }
}
