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

namespace MikrotikController
{
    public partial class WirelessPerfisSeguranca : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar; 
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar; 
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar; 
        public WirelessPerfisSeguranca()
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

        private async void WirelessPerfisSegurança_Load(object sender, EventArgs e)
        {
            comboTipoAutenticacao.Items.Add("wpa2-psk");
            comboTipoAutenticacao.Items.Add("wpa-psk");
            comboTipoAutenticacao.SelectedIndex = 0;
            comboBoxTipoAutenticacaoEditar.Items.Add("wpa2-psk");
            comboBoxTipoAutenticacaoEditar.Items.Add("wpa-psk");
            textBoxPasswordCriar.UseSystemPasswordChar = true;
            textBoxPasswordEditar.UseSystemPasswordChar = true;
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless/security-profiles");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray interfaces = JArray.Parse(responseBody);
                comboBoxTipoAutenticacaoEditar.Text = null;
                textBoxPasswordEditar.Text = null;
                listagemPerfis.Text += string.Format("ID \tNome\r\n");
                foreach (JObject jo in interfaces)
                {
                    comboBoxNomeRede.Items.Add((string)jo["name"]);
                    comboRemoverPerfil.Items.Add((string)jo[".id"]);
                    listagemPerfis.Text += string.Format("{0} \t{1}\r\n", (string)jo[".id"], (string)jo["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter Perfil Seguranca/SSDI: {ex.Message}");
            }
        }

        private async void reloadForm()
        {
            comboTipoAutenticacao.Items.Clear();
            comboTipoAutenticacao.Items.Add("wpa2-psk");
            comboTipoAutenticacao.Items.Add("wpa-psk");
            comboTipoAutenticacao.SelectedIndex = 0;
            comboBoxTipoAutenticacaoEditar.Items.Clear();
            comboBoxTipoAutenticacaoEditar.Items.Add("wpa2-psk");
            comboBoxTipoAutenticacaoEditar.Items.Add("wpa-psk");
            textBoxPasswordCriar.UseSystemPasswordChar = true;
            comboBoxNomeRede.Items.Clear();
            comboRemoverPerfil.Items.Clear();
            textBoxNomePerfil.Text = "";
            textBoxPasswordCriar.Text = "";
            comboTipoAutenticacao.SelectedIndex=0;
            labelID.Text = "";
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless/security-profiles");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray interfaces = JArray.Parse(responseBody);
                comboBoxTipoAutenticacaoEditar.Text = null;
                textBoxPasswordEditar.Text = null;
                foreach (JObject jo in interfaces)
                {
                    comboBoxNomeRede.Items.Add((string)jo["name"]);
                    comboRemoverPerfil.Items.Add((string)jo[".id"]);
                    listagemPerfis.Text += string.Format("{0} \t{1}\r\n", (string)jo[".id"], (string)jo["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter Perfil Seguranca/SSDI: {ex.Message}");
            }
        }

        private async void comboBoxNomeRede_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNomeRede.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless/security-profiles");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray interfaces = JArray.Parse(responseBody);
                comboBoxTipoAutenticacaoEditar.Text = null;
                textBoxPasswordEditar.Text = "";
                foreach (JObject jo in interfaces)
                {
                    string nova = (string)jo["name"];
                    if (nova == comboBoxNomeRede.Text)
                    {
                        if ((string)jo["authentication-types"] == "wpa2-psk")
                        {
                            comboBoxTipoAutenticacaoEditar.Text = (string)jo["authentication-types"];
                            textBoxPasswordEditar.Text = (string)jo["wpa2-pre-shared-key"];
                        }
                        else
                        {
                            comboBoxTipoAutenticacaoEditar.Text = (string)jo["authentication-types"];
                            textBoxPasswordEditar.Text = (string)jo["wpa-pre-shared-key"];
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter perfil seguranca/SSDI: {ex.Message}");
            }
        }

        private async void btnCriarPerfil_Click(object sender, EventArgs e)
        {
            if (textBoxNomePerfil.Text == "" || textBoxPasswordCriar.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos");
            }
            if (textBoxPasswordCriar.Text.Length<8)
                MessageBox.Show("Password minimo 8 caracteres");
            else
            {
                try
                {
                    string perfilNovo = textBoxNomePerfil.Text;
                    string modo = "dynamic-keys";
                    string password = textBoxPasswordCriar.Text;
                    string tipoAutenticacao = comboTipoAutenticacao.Text;
                    string test = null;
                    if (tipoAutenticacao == "wpa2-psk")
                        test = string.Format("{{\"name\": \"{0}\", \"authentication-types\": \"{1}\", \"mode\": \"{2}\", \"wpa2-pre-shared-key\": \"{3}\"}}", perfilNovo, tipoAutenticacao, modo, password);
                    else
                        test = string.Format("{{\"name\": \"{0}\", \"authentication-types\": \"{1}\", \"mode\": \"{2}\", \"wpa-pre-shared-key\": \"{3}\"}}", perfilNovo, tipoAutenticacao, modo, password);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/interface/wireless/security-profiles/add", content);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Perfil criado com sucesso");
                    reloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a criar perfil seguranca/SSDI: {ex.Message}");
                }
            }
        }

        private void btnMostarPassword_MouseUP(object sender, MouseEventArgs e)
        {
            textBoxPasswordCriar.UseSystemPasswordChar = false;
        }

        private void btnMostarPassword_MouseDown(object sender, MouseEventArgs e)
        {
           textBoxPasswordCriar.UseSystemPasswordChar = true;
        }

        private async void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            if (comboBoxNomeRede.Text == "" || textBoxPasswordEditar.Text == "" || comboBoxTipoAutenticacaoEditar.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos");
            }
            else
            {
                try
                {
                    string perfilEditar = comboBoxNomeRede.Text;
                    string modo = "dynamic-keys";
                    string password = textBoxPasswordEditar.Text;
                    string tipoAutenticacao = comboBoxTipoAutenticacaoEditar.Text;
                    string test = null;
                    if (tipoAutenticacao == "wpa2-psk")

                        test = string.Format("{{\"name\": \"{0}\", \"authentication-types\": \"{1}\", \"mode\": \"{2}\", \"wpa2-pre-shared-key\": \"{3}\"}}", perfilEditar, tipoAutenticacao, modo, password);
                    else
                        test = string.Format("{{\"name\": \"{0}\", \"authentication-types\": \"{1}\", \"mode\": \"{2}\", \"wpa-pre-shared-key\": \"{3}\"}}", perfilEditar, tipoAutenticacao, modo, password);
                    var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/interface/wireless/security-profiles/set", content);
                    response.EnsureSuccessStatusCode();
                    listagemPerfis.Text += string.Format("Editado Perfil {0} \r\n", perfilEditar);
                    MessageBox.Show($"Perfil {perfilEditar} alterado com sucesso!");
                    reloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a editar Perfil: {ex.Message}");
                }
            }
        }

        private void btnMostarPwdEditar_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPasswordEditar.UseSystemPasswordChar = true;
        }
        
        private void btnMostarPwdEditar_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPasswordEditar.UseSystemPasswordChar = false;
        }

        private async void comboRemoverPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelID.Text = string.Empty;
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface/wireless/security-profiles");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JArray interfaces = JArray.Parse(responseBody);
                comboBoxTipoAutenticacaoEditar.Text = null;
                textBoxPasswordEditar.Text = null;
                foreach (JObject jo in interfaces)
                {
                    labelID.Text = (string)jo["name"] + "-" + (string)jo["authentication-types"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter Perfil Seguranca/SSDI: {ex.Message}");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if(comboRemoverPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecione um perfil para remover");
            }
            else
            {
                try
                {
                    string eleminarID = string.Format("{{\".id\": \"{0}\"}}", comboRemoverPerfil.Text);
                    var content = new StringContent(eleminarID, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiURL}/interface/wireless/security-profiles/remove", content);
                    response.EnsureSuccessStatusCode();
                    listagemPerfis.Text += string.Format("Removido Perfil {0} \r\n", comboRemoverPerfil.Text);
                    MessageBox.Show($"Perfil {comboRemoverPerfil.Text} removido com sucesso!");
                    textBoxNomePerfil.Text = null;
                    textBoxPasswordCriar.Text = null;
                    reloadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a editar Perfil: {ex.Message}");
                }
            }
        }

        private void btnMostarPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordCriar.UseSystemPasswordChar)
            {
                textBoxPasswordCriar.UseSystemPasswordChar = false; 
                btnMostarPassword.Text = "Esconder"; 
            }
            else
            {
                textBoxPasswordCriar.UseSystemPasswordChar = true;
                btnMostarPassword.Text = "Mostrar";
            }
        }

        private void btnMostarPwdEditar_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordEditar.UseSystemPasswordChar)
            {
                textBoxPasswordEditar.UseSystemPasswordChar = false;
                btnMostarPwdEditar.Text = "Esconder"; 
            }
            else
            {
                textBoxPasswordEditar.UseSystemPasswordChar = true; 
                btnMostarPwdEditar.Text = "Mostrar"; 
            }
        }
    }
}
