namespace Proyecto1
{

    // to do list
    /*
     * Crear DB y tablas
     * Terminar interfaz
     * Logica de programa
     * CE (clear entry) / C (clear)
     * Decimales y negativos
     * Boton de Hitorial de calculos
     * Potencia y Raices
     * Conectar BD
     */
    public partial class Form1 : Form
    {
        Operaciones op = new Operaciones();
        int carry = 0;

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

        private void btn0_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.btn_Selec(txbResultado.Text, btn0.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.btn_Selec(txbResultado.Text, btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.btn_Selec(txbResultado.Text, btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.btn_Selec(txbResultado.Text, btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.btn_Selec(txbResultado.Text, btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.btn_Selec(txbResultado.Text, btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.btn_Selec(txbResultado.Text, btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.btn_Selec(txbResultado.Text, btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.btn_Selec(txbResultado.Text, btn8.Text);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.btn_Selec(txbResultado.Text, btn9.Text);
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txbResultado.Text = op.Eliminar(txbResultado.Text);
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (carry == 0)
            {
                carry = Int32.Parse(txbResultado.Text.Trim());
                txbCarry.Text = String.Format($"{carry.ToString()} {btnSumar.Text}");
                txbResultado.Text = "";
            }
            else
                txbResultado.Text = op.Sumar(txbResultado.Text, carry).ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {

        }

        private void btnProd_Click(object sender, EventArgs e)
        {

        }
        private void btnDividir_Click(object sender, EventArgs e)
        {

        }


    }

    public class Operaciones()
    {
        public int Calcular(string val)
        {
            return Convert.ToInt32(val);
        }

        public string btn_Selec(string val, string num)
        {
            if (val == "0")
            {
                return num;
            }
            else
                return val + num;

        }

        public string Eliminar(string val)
        {
            if (val == "0")
            {
                 return "0";
            }
            else if (val.Length == 1)
            {
                return "0";
            }
            else
                return val.Substring(0, val.Length - 1);
        }

        public int Sumar(string val, int carry)
        {
            int calculo = Int32.Parse(val);

            return calculo + carry;
        }
    }
}
