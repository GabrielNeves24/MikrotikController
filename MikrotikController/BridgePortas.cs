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
    public partial class BridgePortas : Form
    {
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar; // Please enter your IP address
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar; // Input your password here
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar; // Input your username here
        public BridgePortas()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAdcionarPorta_Click(object sender, EventArgs e)
        {
            try
            {
                string interfaceAdicionar = comboInterface.Text;
                string nomeInterface = getNomeInterface.Text;
                string test = string.Format("{{\"interface\": \"{0}\", \"bridge\": \"{1}\"}}", interfaceAdicionar,nomeInterface);

                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"{apiURL}/interface/bridge/port/add", content);
                response.EnsureSuccessStatusCode();
                //string responseBody = await response.Content.ReadAsStringAsync();
                //string bridgeId = (string)JObject.Parse(responseBody)[".id"];
                MessageBox.Show($"Bridge {nomeInterface} interface {interfaceAdicionar} adicionada com sucesso!");
                recarregarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a adicionar portas à Bridge: {ex.Message}");
            }
        }

        private async void btnRemoverPorta_Click(object sender, EventArgs e)
        {
            try
            {
                String s = comboRemove.Text;
                String[] array = s.Split(' ');
                string idRemovePort = null;
                for (int i = 0; i < array.Length; i++)
                {
                    idRemovePort = array[0];
                }
                

                string test = string.Format("{{\".id\": \"{0}\"}}", idRemovePort);
                

                var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"{apiURL}/interface/bridge/port/remove", content);
                response.EnsureSuccessStatusCode();
                //string responseBody = await response.Content.ReadAsStringAsync();
                //string bridgeId = (string)JObject.Parse(responseBody)[".id"];
                MessageBox.Show($"{comboRemove.Text} removida com sucesso!");
                // apos alteracao atualizar os dados do form
                recarregarForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a remover: {ex.Message}");
            }
        }

        private async void recarregarForm()
        {
            try
            {
                comboInterface.Items.Clear();
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody);
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    comboInterface.Items.Add(interfaceName);
                    //comboInterfaceRemove.Items.Add(interfaceName);
                    //interfaceList.Add($"The interface id is {interfaceId}, and the interface name is {interfaceName}");
                }
                //MessageBox.Show(string.Join("\n", interfaceList));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            //enche o remover bridge
            try
            {
                comboRemove.Items.Clear();
                HttpResponseMessage response1 = await client.GetAsync($"{apiURL}/interface/bridge/port");
                response1.EnsureSuccessStatusCode();
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody1);
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["interface"];
                    string portNumber = (string)jo["port-number"];
                    string bridge = (string)jo["bridge"];
                    //int i = int.Parse(interfaceId.Last().ToString());
                    string conjunto = interfaceId + " " + interfaceName + " " + bridge;
                    comboRemove.Items.Add(conjunto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            try
            {
                getNomeInterface.Items.Clear();
                HttpResponseMessage response1 = await client.GetAsync($"{apiURL}/interface/bridge");
                response1.EnsureSuccessStatusCode();
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody1);
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    getNomeInterface.Items.Add(interfaceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void comboInterfaceRemove_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void BridgePortas_Load_1(object sender, EventArgs e)
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
                    comboInterface.Items.Add(interfaceName);
                    //comboInterfaceRemove.Items.Add(interfaceName);
                    //interfaceList.Add($"The interface id is {interfaceId}, and the interface name is {interfaceName}");
                }
                //MessageBox.Show(string.Join("\n", interfaceList));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            //enche o remover bridge
            try
            {
                HttpResponseMessage response1 = await client.GetAsync($"{apiURL}/interface/bridge/port");
                response1.EnsureSuccessStatusCode();
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody1);
                listagemPortas.Text += string.Format("ID \tInterface \tNºPorta \tBridge \tEstado\r\n");

                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["interface"];
                    string portNumber = (string)jo["port-number"];
                    string bridge = (string)jo["bridge"];
                    string disabled = "";
                    if ((string)jo["disabled"] == "true")
                        disabled = "Inativa";
                    else
                    {
                        disabled = "Ativa";
                    }
                    //int i = int.Parse(interfaceId.Last().ToString());
                    string conjunto = interfaceId + " " + interfaceName + " " + bridge;
                    comboRemove.Items.Add(conjunto);
                    listagemPortas.Text += string.Format("{0} \t{1} \t{2} \t{3} \t{4}\r\n", interfaceId, interfaceName , portNumber, bridge, disabled);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
                    getNomeInterface.Items.Add(interfaceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        //private async void btnEditarBrigdeRemover_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string idARemover = comboBridgeRemove.Text;
        //        string idApenas = idARemover.Substring(0, idARemover.IndexOf(" "));


        //        string test = string.Format("{{\"numbers\": \"{0}\"}}", idApenas);

        //        var content = new StringContent(test, System.Text.Encoding.UTF8, "application/json");

        //        HttpResponseMessage response = await client.PostAsync($"{apiURL}/interface/bridge/port/remove", content);
        //        response.EnsureSuccessStatusCode();
        //        //string responseBody = await response.Content.ReadAsStringAsync();
        //        //string bridgeId = (string)JObject.Parse(responseBody)[".id"];
        //        MessageBox.Show($"Bridge com id {idApenas} removida com sucesso!");
        //        this.Refresh();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}


    }
}
