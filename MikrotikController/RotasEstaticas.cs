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
    public partial class RotasEstaticas : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar;
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar;
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar;
        public RotasEstaticas()
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

        private async void RotasEstaticas_Load(object sender, EventArgs e)
        {
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/route/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray rotas = JArray.Parse(responseBody);
                dataGridView1Rotas.Columns.Add("routeId", "ID");
                dataGridView1Rotas.Columns.Add("dst-address", "IP Destino");
                dataGridView1Rotas.Columns.Add("gateway", "Gateway");
                dataGridView1Rotas.Columns.Add("distance", "Distancia");
                dataGridView1Rotas.Columns.Add("routing-table", "Tabela");
                dataGridView1Rotas.Columns.Add("inactive", "Desativada");
                foreach (JObject jo in rotas)
                {
                    string disabled = "";
                    if ((string)jo["disabled"] == "true")
                        disabled = "Sim";
                    else 
                        disabled = "Não";
                    string dstAddress = (string)jo["dst-address"];
                    string gateway = (string)jo["gateway"];
                    string routingTable = (string)jo["routing-table"];
                    string staticRoute = (string)jo["static"];
                    string suppressHwOffload = (string)jo["suppress-hw-offload"];
                    string routeId = (string)jo[".id"];
                    string distance = (string)jo["distance"];
                    string logPrefix = (string)jo["log-prefix"];
                    dataGridView1Rotas.Rows.Add(routeId, dstAddress, gateway, distance, routingTable, disabled);
                    dataGridView1Rotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter rotas estáticas: {ex.Message}");
            }
        }

        private async void reloadForm()
        {
            dataGridView1Rotas.Rows.Clear();
            editIPDestino.Text = string.Empty;
            editDistancia.Text = string.Empty;
            editGateway.Text = string.Empty;
            editAtiva.Checked = false;
            labelID.Text = null;
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/route/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray rotas = JArray.Parse(responseBody);

                foreach (JObject jo in rotas)
                {
                    string disabled = "";
                    if ((string)jo["disabled"] == "true")
                        disabled = "Sim";
                    else
                        disabled = "Não";
                    string dstAddress = (string)jo["dst-address"];
                    string gateway = (string)jo["gateway"];
                    string routingTable = (string)jo["routing-table"];
                    string staticRoute = (string)jo["static"];
                    string suppressHwOffload = (string)jo["suppress-hw-offload"];
                    string routeId = (string)jo[".id"];
                    string distance = (string)jo["distance"];
                    string logPrefix = (string)jo["log-prefix"];
                    dataGridView1Rotas.Rows.Add(routeId, dstAddress, gateway, distance, routingTable, disabled);
                    dataGridView1Rotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter rotas estáticas: {ex.Message}");
            }
        }

        private async void btnCriarEditar_Click(object sender, EventArgs e)
        {
            string destino = editIPDestino.Text;
            string gateway = editGateway.Text;
            string distance = editDistancia.Text;
            string inactive = "";
            if (editAtiva.Checked)
            inactive = "true";
            else
            inactive = "false";
            if (labelID.Text == "")
            {
                try
                {
                    string test = string.Format("{{\"dst-address\": \"{0}\",\"gateway\": \"{1}\",\"routing-table\": \"{2}\",\"suppress-hw-offload\": \"{3}\",\"disabled\": \"{4}\"}}", destino, gateway, "", "no",inactive);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/route/add", content);
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Rota criada com sucesso!");
                    reloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a criar rota: {ex.Message}");
                } 
            }
            else
            {
                try
                {
                    string rotaId = labelID.Text;
                    string test = string.Format("{{\".id\": \"{0}\",\"disabled\": \"{1}\",\"dst-address\": \"{2}\",\"gateway\": \"{3}\",\"routing-table\": \"{4}\",\"suppress-hw-offload\": \"{5}\"}}", rotaId, inactive, destino, gateway, "", "no");
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/route/set", content);
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Rota {rotaId} editada com sucesso!");
                    reloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a editar rota: {ex.Message}");
                }
            }
        }

        private async void btnApagarRota_Click(object sender, EventArgs e)
        {
            if (labelID.Text != null)
            {
                try
                {
                    string test = string.Format("{{\".id\": \"{0}\"}}", labelID.Text);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync($"{apiURL}/ip/route/remove", content).Result;
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Regra {labelID.Text} apagada com sucesso!");
                    reloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a apagar rota: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"Selecione uma rota abaixo ");
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

        private void dataGridView1Rotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCriarEditar.Text = "Editar";
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1Rotas.Rows.Count)
            {
                string routeId = "";
                if (dataGridView1Rotas.Rows[rowIndex].Cells["routeId"].Value != null)
                    routeId = dataGridView1Rotas.Rows[rowIndex].Cells["routeId"].Value.ToString();
                else
                    routeId = "";
                string dstaddress = "";
                if (dataGridView1Rotas.Rows[rowIndex].Cells["dst-address"].Value != null)
                    dstaddress = dataGridView1Rotas.Rows[rowIndex].Cells["dst-address"].Value.ToString();
                else
                    dstaddress = "";
                string gateway = "";
                if (dataGridView1Rotas.Rows[rowIndex].Cells["gateway"].Value != null)
                    gateway = dataGridView1Rotas.Rows[rowIndex].Cells["gateway"].Value.ToString();
                else
                    gateway = "";
                string distance = "";
                if (dataGridView1Rotas.Rows[rowIndex].Cells["distance"].Value != null)
                    distance = dataGridView1Rotas.Rows[rowIndex].Cells["distance"].Value.ToString();
                else
                    distance = "";
                string routingTable = "";
                if (dataGridView1Rotas.Rows[rowIndex].Cells["routing-table"].Value != null)
                    routingTable = dataGridView1Rotas.Rows[rowIndex].Cells["routing-table"].Value.ToString();
                else
                    routingTable = "";

                string inactive = "";
                if (dataGridView1Rotas.Rows[rowIndex].Cells["inactive"].Value != null)
                    inactive = dataGridView1Rotas.Rows[rowIndex].Cells["inactive"].Value.ToString();
                else
                    inactive = "";
                labelID.Text = routeId;
                editIPDestino.Text = dstaddress;
                editGateway.Text =  gateway;
                editDistancia.Text = distance;
                if (inactive == "Sim")
                    editAtiva.Checked = true;
                else
                    editAtiva.Checked = false;
            }
        }
    }
}
