using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikrotikController
{
    public partial class DNSServidor : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar; // Please enter your IP address
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar; // Input your password here
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar; // Input your username here
        public DNSServidor()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{apiUsername}:{apiPassword}")));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private async void DNSServidor_Load(object sender, EventArgs e)
        {
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/dns/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray pools = JArray.Parse(responseBody);
                foreach (JObject pool in pools)
                {
                    string servers = (string)pool["servers"];
                    if (servers != "")
                    {
                        labelEstado.Text = "LIGADO";
                        labelEstado.BackColor = Color.Green;
                        txtServers.Text=servers;
                    }
                    else
                    {
                        labelEstado.Text = "DESLIGADO";
                        labelEstado.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro carregar pools: {ex.Message}");
            }
        }

        private async void btnEstadoONOFF_Click(object sender, EventArgs e)
        {
            try
            {
                string test = string.Format("{{\"servers\": \"{0}\"}}", "");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/dns/set", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray pools = JArray.Parse(responseBody);
                MessageBox.Show($"Servidor DNS desligado com sucesso!");
                listagemServersDNS.Text += string.Format("Servidor DNS desligado com sucesso!\r\n");
                reloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro carregar pools: {ex.Message}");
            }

        }

        private async void btnCriar_Click(object sender, EventArgs e)
        {
            string ipText = txtServers.Text;
            string[] ips = ipText.Split(',');
            foreach (string ip in ips)
            {
                if (!IPAddress.TryParse(ip, out IPAddress ipAddress))
                {
                    MessageBox.Show("O endereço IP " + ip + " não é válido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                string test = string.Format("{{\"servers\": \"{0}\"}}",ips);
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/dns/set", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray pools = JArray.Parse(responseBody);
                MessageBox.Show($"Servidor DNS editado com sucesso!");
                listagemServersDNS.Text += string.Format("Servidor DNS editado com sucesso!\r\n");
                reloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro carregar pools: {ex.Message}");
            }
        }
        private async void reloadForm()
        {
            txtServers.Clear();
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/dns/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray pools = JArray.Parse(responseBody);
                foreach (JObject pool in pools)
                {
                    string servers = (string)pool["servers"];
                    if (servers != "")
                    {
                        labelEstado.Text = "LIGADO";
                        labelEstado.BackColor = Color.Green;
                        txtServers.Text = servers;
                        listagemServersDNS.Text += string.Format("Servidor DNS Ligado ({0})!\r\n",servers);
                    }
                    else
                    {
                        labelEstado.Text = "DESLIGADO";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro carregar pools: {ex.Message}");
            }
        }
    }
}
