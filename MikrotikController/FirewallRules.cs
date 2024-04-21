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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MikrotikController
{
    public partial class FirewallRules : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar; 
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar;
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar;
        public FirewallRules()
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
        private async void FirewallNAT_Load(object sender, EventArgs e)
        {
            labelID.Text = null;
            editAcao.DisplayMember = "action";
            editAcao.ValueMember = "action";
            editAcao.DataSource = dataGridView1.DataSource;

            editChain.DisplayMember = "chain";
            editChain.ValueMember = "chain";
            editChain.DataSource = dataGridView1.DataSource;

            editProtocolo.DisplayMember = "protocol";
            editProtocolo.ValueMember = "protocol";
            editProtocolo.DataSource = dataGridView1.DataSource;

            editChain.Items.Add("forward");
            editChain.Items.Add("output");
            editChain.Items.Add("input");
            editProtocolo.Items.Add("tcp");
            editProtocolo.Items.Add("udp");
            editAcao.Items.Add("accept");
            editAcao.Items.Add("drop");
            editAcao.Items.Add("reject");
            editAcao.Items.Add("return");
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/firewall/filter/print",content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray rules = JArray.Parse(responseBody);

                dataGridView1.Columns.Add("ruleId", "ID");
                dataGridView1.Columns.Add("action", "Acao");
                dataGridView1.Columns.Add("chain", "Chain");
                dataGridView1.Columns.Add("srcAddress", "IP Origem");
                dataGridView1.Columns.Add("dstAddress", "IP Destino");
                dataGridView1.Columns.Add("protocol", "Protocolo");
                dataGridView1.Columns.Add("srcPort", "Porta Origem");
                dataGridView1.Columns.Add("dstPort", "Posta Destino");
                dataGridView1.Columns.Add("Ativa", "Desativada");

                foreach (JObject jo in rules)
                {
                    string ruleId = (string)jo[".id"];
                    string action = (string)jo["action"];
                    string bytes = (string)jo["bytes"];
                    string chain = (string)jo["chain"];
                    string disabled = (string)jo["disabled"];
                    if (disabled=="true")
                        disabled = "Sim";
                    else
                        disabled = "Não";

                    string dstAddress = (string)jo["dst-address"];
                    string dstPort = (string)jo["dst-port"];

                    string dynamic = (string)jo["dynamic"];
                    string invalid = (string)jo["invalid"];
                    string packets = (string)jo["packets"];
                    string protocol = (string)jo["protocol"];

                    string srcAddress = (string)jo["src-address"];
                    string srcPort = (string)jo["src-port"];

                    string log = (string)jo["log"];
                    string logPrefix = (string)jo["log-prefix"];
                    dataGridView1.Rows.Add(ruleId, action, chain, srcAddress, dstAddress, protocol, srcPort, dstPort,disabled);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter as listagem NAT: {ex.Message}");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCriarEditar.Text = "Editar";
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                // get the values of the cells in the selected row
                string ruleId = dataGridView1.Rows[rowIndex].Cells["ruleId"].Value.ToString();
                string action = "";
                if (dataGridView1.Rows[rowIndex].Cells["action"].Value != null)
                    action = dataGridView1.Rows[rowIndex].Cells["action"].Value.ToString();
                else
                    action = "";
                string chain = "";
                if (dataGridView1.Rows[rowIndex].Cells["chain"].Value != null)
                    chain = dataGridView1.Rows[rowIndex].Cells["chain"].Value.ToString();
                else
                    chain = "";
                string srcAddress = "";
                if (dataGridView1.Rows[rowIndex].Cells["srcAddress"].Value != null)
                     srcAddress = dataGridView1.Rows[rowIndex].Cells["srcAddress"].Value.ToString();
                else
                     srcAddress = "";
                string dstAddress = "";
                if (dataGridView1.Rows[rowIndex].Cells["dstAddress"].Value != null)
                    dstAddress = dataGridView1.Rows[rowIndex].Cells["dstAddress"].Value.ToString();
                else
                    dstAddress = "";
                string protocol = "";
                if (dataGridView1.Rows[rowIndex].Cells["protocol"].Value != null)
                    protocol = dataGridView1.Rows[rowIndex].Cells["protocol"].Value.ToString();
                else
                    protocol = "";
                string srcPort = "";
                if (dataGridView1.Rows[rowIndex].Cells["srcPort"].Value != null)
                    srcPort = dataGridView1.Rows[rowIndex].Cells["srcPort"].Value.ToString();
                else
                    srcPort = "";

                string dstPort = "";
                if (dataGridView1.Rows[rowIndex].Cells["dstPort"].Value != null)
                    dstPort = dataGridView1.Rows[rowIndex].Cells["dstPort"].Value.ToString();
                else
                    dstPort = "";

                string disabled = "";
                if (dataGridView1.Rows[rowIndex].Cells["Ativa"].Value != null)
                    disabled = dataGridView1.Rows[rowIndex].Cells["Ativa"].Value.ToString();
                else
                    disabled = "";

                labelID.Text = ruleId;
                editProtocolo.Text = protocol;
                editAcao.Text = action;
                editChain.Text = chain;
                editIPDestino.Text = dstAddress;
                editPortaDestino.Text = srcPort;
                editPortaInterna.Text = srcPort;
                editIPInterno.Text = srcAddress;
                if (disabled == "Não")
                    editAtiva.Checked = false;
                else
                    editAtiva.Checked = true;   
            }
        }

        private async void btnCriarEditar_Click(object sender, EventArgs e)
        {
            if (editIPInterno.Text == "" || editIPDestino.Text == "" || editPortaInterna.Text == "" || editPortaDestino.Text == "" || editProtocolo.Text == "" || editChain.Text == "" || editAcao.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            try
            {

                string action = editAcao.Text;
                string chain = editChain.Text;
                string srcAddress = editIPInterno.Text;
                string dstAddress = editIPDestino.Text;
                string protocol = editProtocolo.Text;
                string srcPort = editPortaInterna.Text;
                string dstPort = editPortaDestino.Text;
                string disabled = "";
                if (editAtiva.Checked)
                    disabled = "true";
                else
                    disabled = "false";
                if (labelID.Text == "")
                {
                    string test = string.Format("{{\"action\": \"{0}\",\"chain\": \"{1}\",\"src-address\": \"{2}\",\"dst-address\": \"{3}\",\"protocol\": \"{4}\",\"src-port\": \"{5}\",\"dst-port\": \"{6}\",\"disabled\": \"{7}\"}}", action, chain, srcAddress, dstAddress, protocol, srcPort, dstPort, disabled);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/firewall/filter/add", content);
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Regra criada com sucesso!");
                }
                else
                {
                    string ruleId = labelID.Text;
                    string test = string.Format("{{\".id\": \"{0}\",\"action\": \"{1}\",\"chain\": \"{2}\",\"src-address\": \"{3}\",\"dst-address\": \"{4}\",\"protocol\": \"{5}\",\"src-port\": \"{6}\",\"dst-port\": \"{7}\",\"disabled\": \"{8}\"}}", ruleId, action, chain, srcAddress, dstAddress, protocol, srcPort, dstPort, disabled);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/firewall/filter/set", content);
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Regra {ruleId} editada com sucesso!");
                }  
                reloadForm();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a editar regra: {ex.Message}");
            }
        }
        private async void reloadForm()
        {
            labelID.Text = null;
            dataGridView1.Rows.Clear();
            editAcao.Items.Clear();
            editChain.Items.Clear();
            editProtocolo.Items.Clear();
            editPortaDestino.Text = string.Empty;
            editIPDestino.Text = string.Empty;
            editPortaInterna.Text = string.Empty;
            editIPInterno.Text = string.Empty;
            editAtiva.Checked = false;
            editAcao.DisplayMember = "action";
            editAcao.ValueMember = "action";
            editAcao.DataSource = dataGridView1.DataSource;

            editChain.DisplayMember = "chain";
            editChain.ValueMember = "chain";
            editChain.DataSource = dataGridView1.DataSource;

            editProtocolo.DisplayMember = "protocol";
            editProtocolo.ValueMember = "protocol";
            editProtocolo.DataSource = dataGridView1.DataSource;

            editChain.Items.Add("forward");
            editChain.Items.Add("output");
            editChain.Items.Add("input");
            editProtocolo.Items.Add("tcp");
            editProtocolo.Items.Add("udp");
            editAcao.Items.Add("accept");
            editAcao.Items.Add("drop");
            editAcao.Items.Add("reject");
            editAcao.Items.Add("return");
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/firewall/filter/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray rules = JArray.Parse(responseBody);

                foreach (JObject jo in rules)
                {
                    string ruleId = (string)jo[".id"];
                    string action = (string)jo["action"];
                    string bytes = (string)jo["bytes"];
                    string chain = (string)jo["chain"];
                    string disabled = (string)jo["disabled"];
                    if (disabled == "true")
                        disabled = "Sim";
                    else
                        disabled = "Não";

                    string dstAddress = (string)jo["dst-address"];
                    string dstPort = (string)jo["dst-port"];

                    string dynamic = (string)jo["dynamic"];
                    string invalid = (string)jo["invalid"];
                    string packets = (string)jo["packets"];
                    string protocol = (string)jo["protocol"];

                    string srcAddress = (string)jo["src-address"];
                    string srcPort = (string)jo["src-port"];

                    string log = (string)jo["log"];
                    string logPrefix = (string)jo["log-prefix"];
                    dataGridView1.Rows.Add(ruleId, action, chain, srcAddress, dstAddress, protocol, srcPort, dstPort, disabled);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a carregar regras: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            reloadForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnCriarEditar.Text = "Criar";
            labelID.Text = null;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (labelID.Text != null)
            {
                if (MessageBox.Show("Tem a certeza que pretende apagar a regra?", "Apagar regra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    string test = string.Format("{{\".id\": \"{0}\"}}", labelID.Text);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync($"{apiURL}/ip/firewall/filter/remove", content).Result;
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Regra {labelID.Text} apagada com sucesso!");
                    reloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a apagar regra: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"Selecione uma regra abaixo ");
                return;
            }
        }
    }
}
