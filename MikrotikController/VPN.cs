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

namespace MikrotikController
{
    public partial class VPN : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar;
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar;
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar;
        public VPN()
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

        private async void btnCriarTunel_Click(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "" || txtNomeTunel.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                try
                {
                    string test = string.Format("{{\"address\": \"{0}\",\"name\": \"{1}\"}}",txtEndereco.Text,txtNomeTunel.Text);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/ipsec/peer/add", content);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Tunel {txtNomeTunel.Text} criado com sucesso!");
                    listagemTuneis.Text += string.Format("Tunel {0} criado com sucesso\r\n", txtNomeTunel.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a criar tunel: {ex.Message}");
                }
            }  
        }

        private async void VPN_Load(object sender, EventArgs e)
        {
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/ipsec/active-peers/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray tunels = JArray.Parse(responseBody);
                listagemTuneis.Text += string.Format("ID \tEstado \tLocal \tRemoto\r\n");
                foreach (JObject tunel in tunels)
                {
                    string id = (string)tunel[".id"];
                    string localAddress = (string)tunel["local-address"];
                    string remoteAddress = (string)tunel["remote-address"];
                    string estado = "";
                    if ((string)tunel["state"] == "established") estado = "Ligado"; else estado = "Desligado";
                    listagemTuneis.Text += string.Format("{0} \t{1} \t{2} \t{3} \r\n", id,estado, localAddress, remoteAddress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro mostrar tuneis: {ex.Message}");
            }
            try
            {
                string test = string.Format("{{}}");
                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/ipsec/peer/print", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray identidade = JArray.Parse(responseBody);
                listagemTuneis.Text += string.Format("ID \tNome \r\n");
                foreach (JObject iden in identidade)
                {
                    string id = (string)iden[".id"];
                    string nome = (string)iden["name"];
                    comboPeer.Items.Add(nome);
                    comboPeerPolicy.Items.Add(nome);
                    //listagemTuneis.Text += string.Format("{0} \t{1} \r\n", id, nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro mostrar identidades: {ex.Message}");
            }
        }

        private async void bntCriarIdentidade_Click(object sender, EventArgs e)
        {
            if (txtPasswordIdentidade.Text == "" || comboPeer.SelectedIndex < 0)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                try
                {
                    string test = string.Format("{{\"peer\": \"{0}\",\"secret\": \"{1}\"}}", comboPeer.Text, txtPasswordIdentidade.Text);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/ipsec/identity/add", content);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Identidade {comboPeer.Text} criada com sucesso!");
                    listagemTuneis.Text += string.Format("Identidade {0} criada com sucesso\r\n", comboPeer.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a criar identidade: {ex.Message}");
                }
            }
            
        }

        private void bntMostrarPWD_Click(object sender, EventArgs e)
        {
            if (txtPasswordIdentidade.UseSystemPasswordChar)
            {
                txtPasswordIdentidade.UseSystemPasswordChar = false;
                bntMostrarPWD.Text = "Esconder";
            }
            else
            {
                txtPasswordIdentidade.UseSystemPasswordChar = true;
                bntMostrarPWD.Text = "Mostrar";
            }
        }

        private async void bntCriarPolitica_Click(object sender, EventArgs e)
        {
            if (comboPeerPolicy.SelectedIndex<0 || txtIPDestino.Text == "" || txtIPLocal.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                try
                {
                    string test = string.Format("{{\"dst-address\": \"{0}\",\"peer\": \"{1}\",\"src-address\": \"{2}\",\"tunnel\": \"{3}\"}}", txtIPDestino.Text, comboPeerPolicy.Text,txtIPLocal.Text,"yes");
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/ipsec/policy/add", content);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Politica criada com sucesso!");
                    listagemTuneis.Text += "Politica criada com sucesso\r\n";


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a criar politica: {ex.Message}");
                }
                //nat rules
                try
                {
                    string test = string.Format("{{\"dst-address\": \"{0}\",\"action\": \"{1}\",\"src-address\": \"{2}\",\"chain\": \"{3}\"}}", txtIPDestino.Text, "accept", txtIPLocal.Text,"srcnat");
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/ip/firewall/nat/add", content);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseBody);
                    string ruleId = (string)json["ret"];
                    MessageBox.Show($"Regra criada com sucesso!");
                    listagemTuneis.Text += "Regra criada com sucesso\r\n";


                    string test2 = string.Format("{{\"destination\": \"0\",\"numbers\": \"{0}\"}}", ruleId);
                    var content2 = new StringContent(test2, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response2 = await client.PostAsync($"{apiURL}/ip/firewall/nat/move", content2);
                    response2.EnsureSuccessStatusCode();
                    string responseBody2 = await response2.Content.ReadAsStringAsync();
                    MessageBox.Show($"Tunel VPN IPSec configurado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a criar regra ou mover a mesma: {ex.Message}");
                }
            }

        }
    }
}
