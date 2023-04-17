namespace punto6
{
    public partial class Form1 : Form
    {
        int personas;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int capacidad = Convert.ToInt32(CapacidadPerso.Text);
            int AsisPersona = Convert.ToInt32(Asistencia.Text);


            MessageBox.Show("las personas que asistieron eran " + AsisPersona + ". Pero ingreso una mas y quedo en " + ++AsisPersona);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int capacidad = Convert.ToInt32(CapacidadPerso.Text);
            int AsisPersona = Convert.ToInt32(Asistencia.Text);

            MessageBox.Show("El cine esta en un " + (AsisPersona * 100) / capacidad + "% de su capacidad");
        }

        private void DisminuirPersonas_Click(object sender, EventArgs e)
        {
            int capacidad = Convert.ToInt32(CapacidadPerso.Text);
            int AsisPersona = Convert.ToInt32(Asistencia.Text);


            MessageBox.Show("las personas que asistieron eran " + AsisPersona + ". Pero se fue una mas y quedo en " + --AsisPersona);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}