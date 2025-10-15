namespace Laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbTiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbVelocidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float distancia, velocidad, tiempo;
            tiempo = float.Parse(txtbTiempo.Text);
            velocidad = float.Parse(txtbVelocidad.Text);
            distancia = velocidad * tiempo;
            txtbDistancia.Text = distancia.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbDistancia.Text = "";
            txtbTiempo.Text = "";
            txtbVelocidad.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
