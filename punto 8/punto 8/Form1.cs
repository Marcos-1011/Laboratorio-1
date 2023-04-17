namespace punto_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroA = NumA.Text;
            string numeroB = NumB.Text;
            string aux;

            aux = numeroA;
            numeroA = numeroB;
            numeroB = aux;

            MessageBox.Show("Numero A: " + numeroA + " Numero B: " + numeroB);

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}