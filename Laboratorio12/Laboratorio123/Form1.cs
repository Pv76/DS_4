namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        Operaciones op = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSemiP_Click(object sender, EventArgs e)
        {
            int ladoA, ladoB, ladoC;
            ladoA = int.Parse(txbLadoA.Text);
            ladoB = int.Parse(txbLadoB.Text);
            ladoC = int.Parse(txbLadoC.Text);

            txbSemiP.Text = op.SemiPerimetro(ladoA,ladoB, ladoC).ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            int ladoA, ladoB, ladoC;
            ladoA = int.Parse(txbLadoA.Text);
            ladoB = int.Parse(txbLadoB.Text);
            ladoC = int.Parse(txbLadoC.Text);

            txbArea.Text = op.Area(ladoA, ladoB, ladoC).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbArea.Text = "";
            txbSemiP.Text = "";
            txbLadoA.Text = "";
            txbLadoB.Text = "";
            txbLadoC.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class Operaciones()
    {
        public int SemiPerimetro(int lA, int lB, int lC)
        {
            int semi;
            semi = lA + lB + lC/ 2;

            return semi;
        }

        public int Area(int lA, int lB,int lC)
        {
            int area, semi;
            semi = lA + lB + lC / 2;

            area = semi * (semi - lA) * (semi - lB) * (semi - lC);
            area = (int)Math.Sqrt(area);

            return area;
        }

    }
}
