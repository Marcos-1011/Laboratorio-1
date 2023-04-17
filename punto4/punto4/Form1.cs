namespace punto4
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

        private void NombreArchivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TamanoArchivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = NombreArchivo.Text;
            double tamano = Convert.ToDouble(TamanoArchivo.Text);

            double valor = tamano / 1024;

            MessageBox.Show("El tamanio del archivo " + nombre + " en GB es: " + valor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}