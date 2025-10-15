namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        Operaciones op = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            string nota1,nota2,nota3;
            nota1 = txbNota1.Text;
            nota2 = txbNota2.Text;
            nota3 = txbNota3.Text;
            
            txbPromedio.Text = op.Promediar(nota1,nota2,nota3).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbNota1.Text = "";
            txbNota2.Text = "";
            txbNota3.Text = "";
            txbPromedio.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class Operaciones()
        {
            public int Promediar(string n1, string n2, string n3)
            {
                int promedio, nota1, nota2, nota3;
                nota1 = int.Parse(n1);
                nota2 = int.Parse(n2);
                nota3 = int.Parse(n3);
                promedio = (nota1 + nota2 + nota3) / 3;

                return promedio;
            }
        }
}
