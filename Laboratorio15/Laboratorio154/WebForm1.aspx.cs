using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1, num2,res;

            num1 = Int32.Parse(TextBox1.Text);
            num2 = Int32.Parse(TextBox2.Text);
            res = num1 + num2;
            Label1.Text = "Resultado: " + res.ToString();
        }
    }
}