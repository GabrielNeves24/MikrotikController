using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MikrotikController.Form1;
using System.Net;

namespace MikrotikController
{
    public partial class Form1Inicio : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar;
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar;
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar;
        public Form1Inicio()
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

        private async void Form1Inicio_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody);
                dataGridViewMain.Columns.Clear();
                dataGridViewMain.Rows.Clear();
                dataGridViewMain.ReadOnly = true;
                dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewMain.Columns.Add("id", "ID");
                dataGridViewMain.Columns.Add("name", "Nome");
                dataGridViewMain.Columns.Add("type", "Tipo");
                dataGridViewMain.Columns.Add("lastlink", "Ultima Ligação");
                dataGridViewMain.Columns.Add("disable", "Estado");
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    string type = (string)jo["type"];
                    string lastLink = (string)jo["last-link-up-time"];
                    string disable = ((string)jo["disabled"] == "true") ? "Inativa" : "Ativa";
                    dataGridViewMain.Rows.Add(interfaceId, interfaceName, type, lastLink, disable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter dados das interfaces: {ex.Message}");
            }
            try
            {
                HttpClient client2 = new HttpClient();
                client2.DefaultRequestHeaders.Accept.Clear();
                client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{Globals.apiUsernameUsar}:{Globals.apiPasswordUsar}")));
                HttpResponseMessage response1 = await client2.GetAsync($"{Globals.apiURLUsar}/system/resource");
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                var interfaces = JObject.Parse(responseBody1);
                dynamic jsonObj = JsonConvert.DeserializeObject(responseBody1);
                txtUpTime.Text = jsonObj["uptime"];
                txtVersao.Text = jsonObj["version"];
                txtRam.Text = jsonObj["total-memory"] + " MB";
                txtRamDisponivel.Text = jsonObj["free-memory"] + " MB";
                txtHdd.Text = jsonObj["total-storage"] + " MB";
                txtHddDisponivel.Text = jsonObj["free-hdd-space"] + " MB";
                txtCpuCores.Text = jsonObj["cpu-count"];
                txtCpuFrequencia.Text = jsonObj["cpu-frequency"] + " MHz";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
