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
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikrotikController
{
    public partial class WirelessConfigurar : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar; 
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar; 
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar;
        public WirelessConfigurar()
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

        private async void reloadForm()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless/security-profiles");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray interfaces = JArray.Parse(responseBody);
                comboBoxInterfaceWirelessPerfil.Text = null;
                comboBoxInterfaceWirelessPerfil.Items.Clear();
                foreach (JObject jo in interfaces)
                {
                    comboBoxInterfaceWirelessPerfil.Items.Add((string)jo["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter Perfil Seguranca/SSDI: {ex.Message}");
            }
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                comboBoxInterfacesWireless.Items.Clear();
                comboBoxInterfaceWirelessConfig.Items.Clear();
                JArray interfaces = JArray.Parse(responseBody);
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    comboBoxInterfacesWireless.Items.Add(interfaceName);
                    comboBoxInterfaceWirelessConfig.Items.Add(interfaceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a Obter Portas Wireless Adicionar: {ex.Message}");
            }

            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody);
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    string ip = (string)jo["address"];
                    string rede = (string)jo["network"];
                    listagemInterfaces.Text += string.Format("ID {0} \tNome {1} \tIP {2} \tRede {3}\r\n", interfaceId, interfaceName, ip, rede);

                    //interfaceList.Add($"The interface id is {interfaceId}, and the interface name is {interfaceName}");
                }
                //MessageBox.Show(string.Join("\n", interfaceList));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter dados das interfaces: {ex.Message}");
            }
            txtBoxInterfaceWirelessSSID.Clear();
        }


        private async void button9_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody);
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    interfaceList.Add($"ID {interfaceId} \tNome{interfaceName}");
                }
                MessageBox.Show(string.Join("\n", interfaceList));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody);
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    interfaceList.Add($"ID {interfaceId}\tNome {interfaceName}\t");
                }
                MessageBox.Show(string.Join("\n", interfaceList));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void Interfaces_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless/security-profiles");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray interfaces = JArray.Parse(responseBody);
                comboBoxInterfaceWirelessPerfil.Text = null;
                foreach (JObject jo in interfaces)
                {
                    comboBoxInterfaceWirelessPerfil.Items.Add((string)jo["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter Perfil Seguranca/SSDI: {ex.Message}");
            }
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody);
                listagemInterfaces.Text += string.Format("ID \tNome   \tUltima Ligação \t Estado\r\n");
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    string lastLink = ((string)jo["last-link-up-time"] == null) ? "Nunca" : (string)jo["last-link-up-time"];
                    string disable = "";
                    if ((string)jo["disabled"] == "true")
                        disable = "Inativa";
                    else
                        disable = "Ativa";
                    comboBoxInterfacesWireless.Items.Add(interfaceName);
                    comboBoxInterfaceWirelessConfig.Items.Add(interfaceName);
                    listagemInterfaces.Text += string.Format("{0} \t{1}   \t{2} \t{3} \r\n", interfaceId, interfaceName, lastLink, disable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a Obter Portas Wireless Adicionar: {ex.Message}");
            }
        }
        private async void btnSaveConfigWireless_Click(object sender, EventArgs e)
        {
            if (comboBoxInterfaceWirelessConfig.Text == "" || comboBoxInterfaceWirelessPerfil.Text == "" || txtBoxInterfaceWirelessSSID.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos!");
                return;
            }
            try
            {
                string nomeInterfaceWireless = comboBoxInterfaceWirelessConfig.Text;
                string nomePerfilSeguranca = comboBoxInterfaceWirelessPerfil.Text;
                string nomeSSID = txtBoxInterfaceWirelessSSID.Text;
                string test = string.Format("{{\"numbers\": \"{0}\",\"security-profile\": \"{1}\",\"ssid\": \"{2}\"}}", nomeInterfaceWireless, nomePerfilSeguranca, nomeSSID);
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/interface/wireless/set", content);
                response.EnsureSuccessStatusCode();
                MessageBox.Show($"Interface Wirelss {nomeInterfaceWireless} alterada com sucesso!");
                listagemInterfaces.Text += string.Format("Wireless {0} alterado com sucesso (SSID: {1})!\r\n", nomeInterfaceWireless, nomeSSID);
                txtBoxInterfaceWirelessSSID.Clear();
                reloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro configurar WIFI: {ex.Message}");
            }
        }

        private async void btnAtivarWireless_Click_1(object sender, EventArgs e)
        {
            if(comboBoxInterfacesWireless.Text == null)
            {
                MessageBox.Show("Por favor selecione uma interface wireless!");
                return;
            }
            try
            {
                string nomeInterfaceWireless = comboBoxInterfacesWireless.Text;
                string test = string.Format("{{\"numbers\": \"{0}\"}}", nomeInterfaceWireless);
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/interface/wireless/enable", content);
                response.EnsureSuccessStatusCode();
                MessageBox.Show($"Interface Wireless {nomeInterfaceWireless} ativada com sucesso!");
                listagemInterfaces.Text += string.Format("Wireless {0} Ativado!\r\n", nomeInterfaceWireless);
                reloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a ativar Interface: {ex.Message}");
            }
        }

        private async void btnDesativarWireless_Click_1(object sender, EventArgs e)
        {
            if (comboBoxInterfacesWireless.Text == null)
            {
                MessageBox.Show("Por favor selecione uma interface wireless!");
                return;
            }
            try
            {
                string nomeInterfaceWireless = comboBoxInterfacesWireless.Text;
                string test = string.Format("{{\"numbers\": \"{0}\"}}", nomeInterfaceWireless);
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/interface/wireless/disable", content);
                response.EnsureSuccessStatusCode();
                MessageBox.Show($"Interface Wirelss {nomeInterfaceWireless} desativada com sucesso!");
                listagemInterfaces.Text += string.Format("Wireless {0} Desativado!\r\n", nomeInterfaceWireless);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a desativar Interface: {ex.Message}");
            }
        }

        private async void comboBoxInterfaceWirelessConfig_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxInterfaceWirelessConfig.SelectedIndex < 0)
                return;
            try
            {
                string nomeInterfaceWireless = comboBoxInterfaceWirelessConfig.Text;
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray interfaces = JArray.Parse(responseBody);
                comboBoxInterfaceWirelessPerfil.Text = null;
                txtBoxInterfaceWirelessSSID.Text = "";
                foreach (JObject jo in interfaces)
                {
                    string nova = (string)jo["name"];
                    if (nova == nomeInterfaceWireless)
                    {

                        comboBoxInterfaceWirelessPerfil.Text = (string)jo["security-profile"];
                        txtBoxInterfaceWirelessSSID.Text = (string)jo["ssid"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a Obter Perfil Seguranca/SSDI: {ex.Message}");
            }
        }
    }
}
