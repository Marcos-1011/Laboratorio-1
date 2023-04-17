namespace punto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TiempoDuracion_Click(object sender, EventArgs e)
        {
            string lugar = LugarViaje.Text;
            double distancia = Convert.ToDouble(DistanciaKM.Text);
            double velocidad = Convert.ToDouble(VelConstante.Text);
            double horas = (distancia / velocidad);

            MessageBox.Show($"El tiempo de duracion del viaje a " + lugar + " es de: " + Math.Round(horas) + " horas");
        }

        private void LugarViaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void DistanciaKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void VelConstante_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}