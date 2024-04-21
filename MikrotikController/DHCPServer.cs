using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace MikrotikController
{
    public partial class DHCPServer : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar;
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar; 
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar;
        public DHCPServer()
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

        private async void DHCPServer_Load(object sender, EventArgs e)
        {
            try
            {
                //obter listagem de dhcp client mikrotik
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/ip/dhcp-server");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray nats = JArray.Parse(responseBody);
                List<string> interfaceList = new List<string>();
                listagemServersDHCP.Text += string.Format("ID \tServidor \tPool \tInterface \tTimeUp \r\n");
                foreach (JObject jo in nats)
                {
                    string dhcpId = (string)jo[".id"];
                    string addressPool = (string)jo["address-pool"];
                    string authoritative = (string)jo["authoritative"];
                    string iinterface = (string)jo["interface"];
                    string disabled = (string)jo["disabled"];
                    string dynamic = (string)jo["dynamic"];
                    string invalid = (string)jo["invalid"];
                    string leaseScript = (string)jo["lease-script"];
                    string leaseTime = (string)jo["lease-time"];
                    string name = (string)jo["name"];
                    string useRadius = (string)jo["use-radius"];
                    listagemServersDHCP.Text += string.Format("{0} \t{1} \t{2} \t{3} \t{4} \r\n", dhcpId, name, addressPool, iinterface,leaseTime);
                    comboIDInterface.Items.Add(dhcpId);
                    comboIdDelete.Items.Add(dhcpId);
                    comboListPoolEdit.Items.Add(addressPool);
                    comboInterfacesEdit.Items.Add(iinterface);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter servidores dhcp: {ex.Message}");
            }
            try
            {
                string test = string.Format("{{}}");

                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/pool/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray pools = JArray.Parse(responseBody);
                foreach (JObject pool in pools)
                {
                    string id = (string)pool[".id"];
                    string name = (string)pool["name"];
                    string ranges = (string)pool["ranges"];
                    comboListPool.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro carregar pools: {ex.Message}");
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
                    comboInterfaces.Items.Add(interfaceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a carregar interfaces: {ex.Message}");
            }
        }

        private async void comboPools_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/pool/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray pools = JArray.Parse(responseBody);
                foreach (JObject pool in pools)
                {
                    string id = (string)pool[".id"];
                    string name = (string)pool["name"];
                    string ranges = (string)pool["ranges"];
                    if (name==comboListPool.Text) 
                    {
                        labelPollAdress.Text = ranges;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro carregar pools: {ex.Message}");
            }
        }

        private async void btnCriarPool_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboListPool.Text))
            {
                MessageBox.Show("Selecione uma pool");
                return;
            }
            if (string.IsNullOrEmpty(comboInterfaces.Text))
            {
                MessageBox.Show("Selecione uma interface");
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Selecione uma interface");
                return;
            }
            try
            {
                string txtJson = string.Format("{{\"name\": \"{0}\",\"interface\": \"{1}\",\"address-pool\": \"{2}\"}}", txtNome.Text, comboInterfaces.Text, comboListPool.Text);
                var content = new StringContent(txtJson, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/dhcp-server/add", content);
                response.EnsureSuccessStatusCode();
                MessageBox.Show($"Servidor DHCP {txtNome} criado com sucesso!");
                listagemServersDHCP.Text += string.Format("Servidor {0} criado com sucesso!\r\n", txtNome.Text);
                reloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a criar poll: {ex.Message}");
            }
        }
        private async void reloadForm()
        {
            comboListPool.Items.Clear();
            comboInterfaces.Items.Clear();
            comboIDInterface.Items.Clear();
            comboListPoolEdit.Items.Clear();
            comboInterfacesEdit.Items.Clear();
            comboIdDelete.Items.Clear();
            try
            {
                //obter listagem de dhcp client mikrotik
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/ip/dhcp-server");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray nats = JArray.Parse(responseBody);
                List<string> interfaceList = new List<string>();
                foreach (JObject jo in nats)
                {
                    string dhcpId = (string)jo[".id"];
                    string addressPool = (string)jo["address-pool"];
                    string authoritative = (string)jo["authoritative"];
                    string iinterface = (string)jo["interface"];
                    string disabled = (string)jo["disabled"];
                    string dynamic = (string)jo["dynamic"];
                    string invalid = (string)jo["invalid"];
                    string leaseScript = (string)jo["lease-script"];
                    string leaseTime = (string)jo["lease-time"];
                    string name = (string)jo["name"];
                    string useRadius = (string)jo["use-radius"];
                    listagemServersDHCP.Text += string.Format("{0} \t{1} \t{2} \t{3} \t{4} \r\n", dhcpId, name, addressPool, iinterface, leaseTime);
                    comboIDInterface.Items.Add(dhcpId);
                    comboIdDelete.Items.Add(dhcpId);
                    comboListPoolEdit.Items.Add(addressPool);
                    comboInterfacesEdit.Items.Add(iinterface);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter servidores dhcp: {ex.Message}");
            }
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/pool/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray pools = JArray.Parse(responseBody);
                foreach (JObject pool in pools)
                {
                    string id = (string)pool[".id"];
                    string name = (string)pool["name"];
                    string ranges = (string)pool["ranges"];
                    comboListPool.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro carregar pools: {ex.Message}");
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
                    comboInterfaces.Items.Add(interfaceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a carregar interfaces: {ex.Message}");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void comboIDInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/ip/dhcp-server");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray nats = JArray.Parse(responseBody);
                List<string> interfaceList = new List<string>();
                foreach (JObject jo in nats)
                {

                    string dhcpId = (string)jo[".id"];
                    string addressPool = (string)jo["address-pool"];
                    string authoritative = (string)jo["authoritative"];
                    string iinterface = (string)jo["interface"];
                    string disabled = (string)jo["disabled"];
                    string dynamic = (string)jo["dynamic"];
                    string invalid = (string)jo["invalid"];
                    string leaseScript = (string)jo["lease-script"];
                    string leaseTime = (string)jo["lease-time"];
                    string name = (string)jo["name"];
                    string useRadius = (string)jo["use-radius"];
                    if (dhcpId== comboIDInterface.Text)
                    {
                        comboListPoolEdit.Text = addressPool;
                        comboInterfacesEdit.Text = iinterface;
                        txtNomeEdit.Text = name;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter servidores dhcp para editar: {ex.Message}");
            }
        }

        private async void Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeEdit.Text))
            {
                MessageBox.Show("Selecione uma interface");
                return;
            }
            try
            {
                string txtJson = string.Format("{{\".id\": \"{0}\",\"name\": \"{1}\",\"interface\": \"{2}\",\"address-pool\": \"{3}\"}}", comboIDInterface.Text, txtNomeEdit.Text, comboInterfacesEdit.Text, comboListPoolEdit.Text);
                var content = new StringContent(txtJson, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/dhcp-server/set", content);
                response.EnsureSuccessStatusCode();
                MessageBox.Show($"Servidor DHCP {txtNomeEdit.Text} editado com sucesso!");
                listagemServersDHCP.Text += string.Format("Servidor {0} editado com sucesso!\r\n", txtNome.Text);
                reloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a criar poll: {ex.Message}");
            }
        }

        private async void comboListPoolEdit_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                //string nomeInterfaceWireless = comboBoxInterfacesWireless.Text;
                string test = string.Format("{{}}");

                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/pool/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray pools = JArray.Parse(responseBody);
                foreach (JObject pool in pools)
                {
                    string id = (string)pool[".id"];
                    string name = (string)pool["name"];
                    string ranges = (string)pool["ranges"];
                    if (name == comboListPoolEdit.Text)
                    {
                        labelEdit.Text = ranges;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro carregar pools info edit: {ex.Message}");
            }
        }

        private async void comboIdDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string nomeInterfaceWireless = comboBoxInterfacesWireless.Text;
                //string test = string.Format("{{}}");

                //var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.GetAsync($"{apiURL}/ip/dhcp-server");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray pools = JArray.Parse(responseBody);
                foreach (JObject pool in pools)
                {
                    string id = (string)pool[".id"];
                    string name = (string)pool["name"];
                    string iinterface = (string)pool["interface"];
                    string address = (string)pool["address-pool"];
                    if (id == comboIdDelete.Text)
                    {
                        labelDelete.Text = name;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro carregar info delete: {ex.Message}");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //verificar variaveis varias
            if (string.IsNullOrEmpty(comboIdDelete.Text))
            {
                MessageBox.Show("Selecione uma interface");
                return;
            }
            if (MessageBox.Show("Tem a certeza que pretende apagar a servidor dhcp?", "Apagar server", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                
            try
            {
                string txtJson = string.Format("{{\".id\": \"{0}\"}}", comboIdDelete.Text);
                var content = new StringContent(txtJson, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/dhcp-server/remove", content);
                response.EnsureSuccessStatusCode();
                MessageBox.Show($"Servidor DHCP {labelDelete.Text} removido com sucesso!");
                listagemServersDHCP.Text += string.Format("Servidor {0} removido com sucesso!\r\n", labelDelete.Text);
                reloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a remover servidor dhcp: {ex.Message}");
            }
        }
    }
}
