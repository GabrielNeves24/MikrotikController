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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MikrotikController
{
    public partial class DHCPPool : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar;
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar;
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar;
        public DHCPPool()
        {
            InitializeComponent();
            //customizeDesign();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{apiUsername}:{apiPassword}")));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private async void DHCPPool_Load(object sender, EventArgs e)
        {
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/pool/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray pools = JArray.Parse(responseBody);
                listagemPools.Text += string.Format("Nome \tRanges\r\n");
                foreach (JObject pool in pools)
                {
                    string id = (string)pool[".id"];
                    string name = (string)pool["name"];
                    string ranges = (string)pool["ranges"];
                    listagemPools.Text += string.Format("{0} \t{1}\r\n", name, ranges);
                    comboID.Items.Add(id);
                    string add = string.Format("{0}-{1}", id,name);
                    comboBoxNomePoolsDelete.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro mostrar pools: {ex.Message}");
            }
        }
        private bool IsValidIP(string ip)
        {
            IPAddress address;
            return IPAddress.TryParse(ip, out address);
        }

        private async void btnCriarPool_Click(object sender, EventArgs e)
        {
            string nomePool = txtNomePool.Text;
            string ip1 = txtIP1.Text;
            string ip2 = txtIP2.Text;
            //validacoes ip
            if (string.IsNullOrEmpty(nomePool) ) 
            { 
                MessageBox.Show("Introduza um nome válido para a pool"); 
                return; 
            }
            if (!IsValidIP(ip1) || !IsValidIP(ip2))
            {
                MessageBox.Show("Introduza um endereço IP válido");
                txtIP1.Clear();
                return;
            }

            if (ip1 == ip2)
            {
                MessageBox.Show("Os dois endereços IP devem ser diferentes");
                txtIP1.Clear();
                return;
            }
            try
            {
                string ipRange = string.Format("{0}-{1}", ip1, ip2);
                string txtJson = string.Format("{{\"name\": \"{0}\",\"ranges\": \"{1}\"}}", nomePool, ipRange);
                var content = new StringContent(txtJson, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/pool/add", content);
                response.EnsureSuccessStatusCode();
                MessageBox.Show($"Pool {nomePool} criada com sucesso!");
                listagemPools.Text += string.Format("{0} criada ({1})!\r\n", nomePool, ipRange);
                reloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a criar poll: {ex.Message}");
            }

        }
        private async void reloadForm()
        {
            comboBoxNomePoolsDelete.Items.Clear();
            txtEditPool.Clear();
            comboID.Items.Clear();
            txtNomePool.Clear();
            txtIP1.Clear();
            txtIP2.Clear();
            txtIP1Edit.Clear();
            txtIP2Edit.Clear();
            labelID.Text = string.Empty;
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
                    listagemPools.Text += string.Format("Nome: {0} | Ranges: {1} \r\n", name, ranges);
                    comboID.Items.Add(id);
                    comboBoxNomePoolsDelete.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro mostrar pools: {ex.Message}");
            }
        }

        private async void comboId_SelectedIndexChanged(object sender, EventArgs e)
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
                    if (id == comboID.Text)
                    {
                        txtIP1Edit.Clear();
                        txtIP2Edit.Clear();
                        txtEditPool.Clear();
                        string[] rangeParts = ranges.Split('-');
                        txtIP1Edit.Text = rangeParts[0];
                        txtIP2Edit.Text = rangeParts[1].Replace("-", "");
                        txtEditPool.Text= name;
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a carregar ranges automatico: {ex.Message}");
            }
        }

        private async void btnEditarPool_Click(object sender, EventArgs e)
        {
            string nomePool = txtEditPool.Text;
            string ip1Edit = txtIP1Edit.Text;
            string ip2Edit = txtIP2Edit.Text;
            //validacoes ip
            if (!IsValidIP(ip1Edit) || !IsValidIP(ip2Edit))
            {
                MessageBox.Show("Introduza um endereço IP válido");
                txtIP1.Clear();
                return;
            }

            if (ip1Edit == ip2Edit)
            {
                MessageBox.Show("Os dois endereços IP devem ser diferentes");
                txtIP1.Clear();
                return;
            }
            //buscar o id da pool
            string idAEditar = comboID.Text;

            //comeca a funcao mesmo
            try
            {
                string ipRangeEdit = string.Format("{0}-{1}", ip1Edit, ip2Edit);
                string txtJson = string.Format("{{\".id\": \"{0}\",\"name\": \"{1}\",\"ranges\": \"{2}\"}}",idAEditar, nomePool, ipRangeEdit);
                var content = new StringContent(txtJson, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/pool/set", content);
                response.EnsureSuccessStatusCode();
                MessageBox.Show($"Pool {nomePool} editada com sucesso!");
                listagemPools.Text += string.Format("Pool {0} editada ({1})!\r\n", nomePool, ipRangeEdit);
                reloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a editar poll: {ex.Message}");
            }
        }

        private async void btnRemoverPool_Click(object sender, EventArgs e)
        {
            if (labelID.Text == null)
            {
                MessageBox.Show("Selecione uma pool para remover");
                return;
            }
            if (MessageBox.Show("Tem a certeza que pretende apagar a pool?", "Apagar pool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                
            try
            {
                string txtJson = string.Format("{{\".id\": \"{0}\"}}", labelID.Text);
                var content = new StringContent(txtJson, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/pool/remove", content);
                response.EnsureSuccessStatusCode();
                MessageBox.Show($"Pool {comboBoxNomePoolsDelete.Text} removida com sucesso!");
                listagemPools.Text += string.Format("Pool {0} removida!\r\n", comboBoxNomePoolsDelete.Text);
                reloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a remover poll: {ex.Message}");
            }
        }

        private async void comboBoxNomePoolsDelete_SelectedIndexChanged(object sender, EventArgs e)
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
                    if (name == comboBoxNomePoolsDelete.Text)
                    {
                        labelID.Text= id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter id delete: {ex.Message}");
            }
        }
    }
}
