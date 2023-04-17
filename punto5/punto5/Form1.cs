namespace punto5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = NombreCliente.Text;
            double precio = Convert.ToDouble(ValorCompra.Text);
            double pago = Convert.ToDouble(ValorPagado.Text);

            double vuelto = pago - precio;
            MessageBox.Show("El vuelto para " + nombre + " es: " + Math.Round(vuelto, 2));
        }

        private void NombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValorCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValorPagado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}