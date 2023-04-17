using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSalario_Click(object sender, EventArgs e)
        {
            string nombre= tNombre.Text;
            double tarifa = Convert.ToDouble(tTarifa.Text), anio = Convert.ToDouble(tAño.Text), horas = Convert.ToDouble(tHoras.Text), dias = Convert.ToDouble(tDias.Text);

            double salarioTotal,salario, retenciones,retencionesTotales,antiguedad;
            salario = tarifa * horas * dias;
            antiguedad = 2023 - anio;
            retenciones = 0.20 + 0.015 * antiguedad;
            retencionesTotales = salario * retenciones;
            salarioTotal = salario - retencionesTotales;
            MessageBox.Show($"El salario total de {nombre} es de: {salarioTotal}$");
        }
    }
}
