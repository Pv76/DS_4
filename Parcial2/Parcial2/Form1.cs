using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Parcial2
{
    using Microsoft.Data.SqlClient;
    public partial class Form1 : Form
    {
        public static string connectionString = @"Server=.\sqlexpress;Database=Historial;
                    TrustServerCertificate=true;Integrated Security=SSPI;";

        Calcular cal = new Calcular();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbHex_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnH_D_Click(object sender, EventArgs e)
        {
            string val;

            if (txbDecimal1.Text.Length > 0 && txbHex.Text.Length > 0)
            {
                txbHex.Clear();
                txbDecimal1.Clear();
            }
            else if (txbHex.Text.Length > 0)
            {
                int dec = 0;
                val = txbHex.Text;
                dec = cal.ConvertirHex(val);
                txbDecimal1.Text = dec.ToString();
                txbDecimal1.Enabled = false;
                txbHex.Enabled = false;

                string descripcion = $"Hex: {val} a Decimal = {dec}";
                string sql = "INSERT INTO operaciones (Descripcion)" + "VALUES ('" + descripcion + "')";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.Text;

                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro ingresado correctamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else if (txbDecimal1.Text.Length > 0)
            {
                int dec = 0;
                val = txbDecimal1.Text;

                if (int.TryParse(val, out dec))
                {
                    string hex = dec.ToString("X");
                    txbHex.Text = hex;
                    txbDecimal1.Enabled = false;
                    txbHex.Enabled = false;

                    string descripcion = $"Decimal: {val} a Hex = {hex}";
                    string sql = "INSERT INTO operaciones (Descripcion)" + "VALUES ('" + descripcion + "')";

                    SqlConnection con = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = System.Data.CommandType.Text;

                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Registro ingresado correctamente!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un número decimal válido");
                }
            }
        }

        private void txbDecimal1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbOctal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnO_D_Click(object sender, EventArgs e)
        {
            string val;
            if (txbDecimal2.Text.Length > 0 && txbOctal.Text.Length > 0)
            {
                txbOctal.Clear();
                txbDecimal2.Clear();
            }
            else if (txbOctal.Text.Length > 0)
            {
                int dec = 0;
                val = txbOctal.Text;
                dec = cal.ConvertirOct(val);
                txbDecimal2.Text = dec.ToString();
                txbDecimal2.Enabled = false;
                txbOctal.Enabled = false;

                string descripcion = $"Oct: {val} a Decimal = {dec}";
                string sql = "INSERT INTO operaciones (Descripcion)" + "VALUES ('" + descripcion + "')";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.Text;

                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro ingresado correctamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else if (txbDecimal2.Text.Length > 0)
            {
                string oct;
                int dec = 0;
                dec = Int32.Parse(txbDecimal2.Text);
                oct = cal.ConvertirD_O(dec);
                txbOctal.Text = oct;
                txbOctal.Enabled = false;
                txbDecimal2.Enabled = false;

                string descripcion = $"Decimal: {dec} a Oct = {oct}";
                string sql = "INSERT INTO operaciones (Descripcion)" + "VALUES ('" + descripcion + "')";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.Text;

                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro ingresado correctamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void txbDecimal2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnReset1_Click(object sender, EventArgs e)
        {
            txbHex.Enabled = true;
            txbDecimal1.Enabled = true;
            txbHex.Clear();
            txbDecimal1.Clear();
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            txbOctal.Enabled = true;
            txbDecimal2.Enabled = true;
            txbOctal.Clear();
            txbDecimal2.Clear();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM operaciones";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                listBox1.Items.Clear();

                while (reader.Read())
                {
                    string descripcion = reader["Descripcion"].ToString();
                    listBox1.Items.Add(descripcion);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al cargar historial: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }


    public class Calcular()
    {
        public int ConvertirHex(string hex)
        {
            hex = hex.ToUpper();
            int resultado = 0;
            int potencia = 0;

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                char digito = hex[i];
                int valor;

                if (digito >= '0' && digito <= '9')
                {
                    valor = digito - '0';
                }
                else if (digito >= 'A' && digito <= 'F')
                {
                    valor = digito - 'A' + 10;
                }
                else
                {
                    throw new ArgumentException($"Carácter inválido: {digito}");
                }

                resultado += valor * (int)Math.Pow(16, potencia);
                potencia++;
            }

            return resultado;
        }

        public string ConvertirD_H(int dec)
        {
            if (dec == 0)
            {
                return "0";
            }

            string hex = "";
            char[] digitos = "0123456789ABCDEF".ToCharArray();

            while (dec > 0)
            {
                int residuo = dec % 16;
                hex = digitos[residuo] + hex;
                dec = dec / 16;
            }

            return hex;
        }

        public int ConvertirOct(string oct)
        {
            int resultado = 0;
            int potencia = 0;

            for (int i = oct.Length - 1; i >= 0; i--)
            {
                char digito = oct[i];

                if (digito < '0' || digito > '7')
                {
                    throw new ArgumentException($"Dígito inválido: {digito}. Debe ser 0-7");
                }

                int valor = digito - '0'; 

                resultado += valor * (int)Math.Pow(8, potencia);
                potencia++;
            }

            return resultado;
        }

        public string ConvertirD_O(int dec)
        {
            if (dec == 0) return "0";

            string octal = "";

            while (dec > 0)
            {
                int residuo = dec % 8;
                octal = residuo + octal;
                dec = dec / 8;
            }

            return octal;
        }
    }
}
