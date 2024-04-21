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
    public partial class EnderecosIP : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar; // Please enter your IP address
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar; // Input your password here
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar; // Input your username here
        public EnderecosIP()
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

        private async void EnderecosIP_Load(object sender, EventArgs e)
        {
            labelID.Text = null;
            comboInterfaces.DisplayMember = "interface";
            comboInterfaces.ValueMember = "interface";
            comboInterfaces.DataSource = dataGridView1IP.DataSource;
            //get interfaces
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
                    string ip = (string)jo["address"];
                    string rede = (string)jo["network"];
                    comboInterfaces.Items.Add(interfaceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter dados das interfaces: {ex.Message}");
            }

            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/address/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray rules = JArray.Parse(responseBody);

                dataGridView1IP.Columns.Add("addressId", "ID");
                dataGridView1IP.Columns.Add("address", "Enderecos");
                dataGridView1IP.Columns.Add("network", "Rede");
                dataGridView1IP.Columns.Add("interface", "Interface");
                dataGridView1IP.Columns.Add("disabled", "Desativada");

                foreach (JObject jo in rules)
                {
                    string addressID = (string)jo[".id"];
                    string address = (string)jo["address"];
                    string network = (string)jo["network"];
                    string interfaceName = (string)jo["interface"];
                    string disabled = (string)jo["disabled"];
                    if ((string)jo["disabled"] == "false")
                        disabled = "Não";
                    else
                        disabled = "Sim";
                    dataGridView1IP.Rows.Add(addressID, address, network, interfaceName, disabled);
                    dataGridView1IP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os IPs: {ex.Message}");
            }
        }

        private async void reloadForm()
        {
            dataGridView1IP.Rows.Clear();
            labelID.Text = string.Empty;
            txtRede.Text = string.Empty;
            txtIP.Text = string.Empty;
            comboInterfaces.SelectedIndex = -1;
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/address/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray rules = JArray.Parse(responseBody);
                foreach (JObject jo in rules)
                {
                    string addressID = (string)jo[".id"];
                    string address = (string)jo["address"];
                    string network = (string)jo["network"];
                    string interfaceName = (string)jo["interface"];
                    string disabled = (string)jo["disabled"];
                    if ((string)jo["disabled"] == "false")
                        disabled = "Não";
                    else
                        disabled = "Sim";
                    dataGridView1IP.Rows.Add(addressID, address, network, interfaceName, disabled);
                    dataGridView1IP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os IPs: {ex.Message}");
            }
        }

        private void dataGridView1IP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCriarEditar.Text = "Editar";
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1IP.Rows.Count)
            {
                string addressId = "";
                if (dataGridView1IP.Rows[rowIndex].Cells["addressId"].Value != null)
                    addressId = dataGridView1IP.Rows[rowIndex].Cells["addressId"].Value.ToString();
                else
                    addressId = "";
                string address = "";
                if (dataGridView1IP.Rows[rowIndex].Cells["address"].Value != null)
                    address = dataGridView1IP.Rows[rowIndex].Cells["address"].Value.ToString();
                else
                    address = "";
                string network = "";
                if (dataGridView1IP.Rows[rowIndex].Cells["network"].Value != null)
                    network = dataGridView1IP.Rows[rowIndex].Cells["network"].Value.ToString();
                else
                    network = "";
                string interfaceName = "";
                if (dataGridView1IP.Rows[rowIndex].Cells["interface"].Value != null)
                    interfaceName = dataGridView1IP.Rows[rowIndex].Cells["interface"].Value.ToString();
                else
                    interfaceName = "";

                string disabled = "";
                if (dataGridView1IP.Rows[rowIndex].Cells["disabled"].Value != null)
                    disabled = dataGridView1IP.Rows[rowIndex].Cells["disabled"].Value.ToString();
                else
                    disabled = "";

                labelID.Text = addressId;
                txtIP.Text = address;
                comboInterfaces.Text = interfaceName;
                txtRede.Text = network;
                if (disabled == "Sim")
                    editAtiva.Checked = true;
                else
                    editAtiva.Checked = false;
            }
        }

        private async void btnCriarEditar_Click(object sender, EventArgs e)
        {
            if (txtIP.Text == "" || txtRede.Text == "" || comboInterfaces.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            string addressId = labelID.Text;
            string address = txtIP.Text;
            string network = txtRede.Text;
            string interfaceName = comboInterfaces.Text;
            string disabled = "";
            if (editAtiva.Checked)
                disabled = "true";
            else
                disabled = "false";
            if (addressId == "")
            {
                try
                {
                    string test = string.Format("{{\"disabled\": \"{0}\",\"address\": \"{1}\",\"interface\": \"{2}\",\"network\": \"{3}\"}}", disabled, address, interfaceName, network);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/address/add", content);
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Endereço criado com sucesso!");
                    reloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a criar endereço: {ex.Message}");
                }
            }
            else
            {
                try
                {
                    string test = string.Format("{{\".id\": \"{0}\",\"disabled\": \"{1}\",\"address\": \"{2}\",\"interface\": \"{3}\",\"network\": \"{4}\"}}", addressId,disabled, address, interfaceName, network);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/address/set", content);
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Endereço {addressId} editado com sucesso!");
                    reloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a editar endereço: {ex.Message}");
                }
            }
        }

        private async void btnApagarRota_Click(object sender, EventArgs e)
        {
            if (labelID.Text != null)
            {
                if (MessageBox.Show("Tem a certeza que pretende apagar o endereço?", "Apagar endereço", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    string test = string.Format("{{\".id\": \"{0}\"}}", labelID.Text);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync($"{apiURL}/ip/address/remove", content).Result;
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Endereço {labelID.Text} apagado com sucesso!");
                    reloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a apagar endereço: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"Selecione um endereço abaixo ");
                return;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            reloadForm();
            btnCriarEditar.Text = "Criar";
        }

        private void btnLimparKeep_Click(object sender, EventArgs e)
        {
            btnCriarEditar.Text = "Criar";
            labelID.Text = null;
        }
    }
}
