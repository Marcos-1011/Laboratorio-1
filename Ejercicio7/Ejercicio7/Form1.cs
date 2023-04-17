using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
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

        private void bSuma_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tNum.Text);
            int aux = num;
            int digito1, digito2;
            digito1 = aux % 10;
            aux = aux / 10;
            digito2 = aux % 10;

            int suma = digito1 + digito2;
            MessageBox.Show($"La suma de los digitos de {num} es de: {suma}");

        }
    }
}
