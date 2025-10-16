namespace Laboratorio13
{
    using Microsoft.Data.SqlClient;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public partial class Form1 : Form
    {
        public static string connectionString = @"Server=.\sqlexpress;Database=Northwind;
                    TrustServerCertificate=true;Integrated Security=SSPI;";

        SqlConnection conexion = new SqlConnection(connectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y " +
                "se seleccionó la base de datos");

            string query = "select ProductName from[dbo].[Products]";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader["ProductName"].ToString());
            }

            reader.Close();
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
