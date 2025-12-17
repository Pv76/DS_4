using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.UI;


namespace ProyectoFinal
{

    public partial class _Default : Page
    {
        private static HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd("ProyectoFinalTest");
        }

        private static void GetUser(string usuario)
        {
            string url = $"https://api.github.com/users/{usuario}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("User-Agent: ProyectoFinalTest");
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using(Stream reader = response.GetResponseStream())
                    {
                        if (reader == null) return;
                        using(StreamReader objreader = new StreamReader(reader))
                        {
                            string responseBody = objreader.ReadToEnd();
                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch(WebException ex)
            { }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuario = txbUsuario.Text.Trim();
            Console.WriteLine(usuario);
            GetUser(usuario);

        }
    }
}