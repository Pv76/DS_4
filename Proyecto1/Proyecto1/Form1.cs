namespace Proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btn8.Text);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btn9.Text);
        }

        public void btn_Selec(string val, string num)
        {
            if (val == "0")
            {
                txbResultado.Text = num;
            }
            else
                txbResultado.Text = val + num;

        }

        public void Eliminar(string val)
        {
            if (val == "0")
            {
                val = "0";
            }
            else if (val.Length == 1)
            {
                txbResultado.Text = "0";
            }
            else
                txbResultado.Text = val.Substring(0, val.Length - 1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar(txbResultado.Text.ToString());
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btnSumar.Text);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btnRestar.Text);
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            btn_Selec(txbResultado.Text, btnProd.Text);
        }
    }
}
