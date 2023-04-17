namespace punto3
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

        private void button1_Click(object sender, EventArgs e)
        {
            double ancho = Convert.ToDouble(AnchoPared.Text);
            double alto = Convert.ToDouble(AltoPared.Text);
            double metros3 = Convert.ToDouble(m3.Text);
            double areaPared = ancho * alto;
            double arenafinal = metros3 * areaPared;

            MessageBox.Show("Se necesita " + arenafinal + " m3 de arena para revocar la pared.");

        }

        private void AltoPared_TextChanged(object sender, EventArgs e)
        {

        }

        private void m3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnchoPared_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}