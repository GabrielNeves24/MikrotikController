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
    public partial class BridgeConfigurar : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar;
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar;
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar;
        public BridgeConfigurar()
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
      
        private async void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response1 = await client.GetAsync($"{apiURL}/interface/bridge");
                response1.EnsureSuccessStatusCode();
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody1);
                listagemBridges.Text += string.Format("ID \tNome\r\n");
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    listagemBridges.Text += string.Format("{0} \t{1} \r\n", interfaceId, interfaceName);
                    interfaceList.Add($"Interface id: {interfaceId}, Nome: {interfaceName}");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a lista das interfaces: {ex.Message}");
            }

            try
            {
                HttpResponseMessage response1 = await client.GetAsync($"{apiURL}/interface/bridge");
                response1.EnsureSuccessStatusCode();
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody1);
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    comboBoxDeleteBrigde.Items.Add(interfaceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void reloadFormRemover(string bridge, string inserirRemover)
        {
            if (inserirRemover == "remover") 
            {
                listagemBridges.Text += string.Format("Removeu interface {0} \r\n", bridge);
            }else
                listagemBridges.Text += string.Format("Inseriu interface {0} \r\n", bridge);
            try
            {
                HttpResponseMessage response1 = await client.GetAsync($"{apiURL}/interface/bridge");
                response1.EnsureSuccessStatusCode();
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody1);
                
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    listagemBridges.Text += string.Format("{0} \t{1} \r\n", interfaceId, interfaceName);
                    interfaceList.Add($"Interface id: {interfaceId}, Nome: {interfaceName}");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a lista das interfaces: {ex.Message}");
            }
            comboBoxDeleteBrigde.Items.Clear();
            try
            {
                HttpResponseMessage response1 = await client.GetAsync($"{apiURL}/interface/bridge");
                response1.EnsureSuccessStatusCode();
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody1);
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    comboBoxDeleteBrigde.Items.Add(interfaceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnCriarBrigde_Click_1(object sender, EventArgs e)
        {
            try
            {
                string newBridgeName = newBridgeNameTextBox.Text;
                if (string.IsNullOrWhiteSpace(newBridgeName))
                {
                    MessageBox.Show("Insira um nome válido");
                    return;
                }

                HttpResponseMessage response1 = await client.GetAsync($"{apiURL}/interface/bridge");
                response1.EnsureSuccessStatusCode();
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody1);
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    if (interfaceName == newBridgeName)
                    {
                        MessageBox.Show($"Error: Interface com nome já existente");
                        return;
                    }
                }
                var content = new StringContent(JObject.FromObject(new { name = newBridgeName }).ToString(),
                System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync($"{apiURL}/interface/bridge", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                reloadFormRemover(newBridgeName, "inseriu");
                newBridgeNameTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnRemoverBrigde_Click_1(object sender, EventArgs e)
        {
            if(comboBoxDeleteBrigde.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecione uma interface");
            }
            try
            {
                string deleteBridgeName = comboBoxDeleteBrigde.Text;

                var content = new StringContent(JObject.FromObject(new { numbers = deleteBridgeName }).ToString(),
                System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/interface/bridge/remove", content);
                response.EnsureSuccessStatusCode();
                reloadFormRemover(deleteBridgeName, "remover");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
