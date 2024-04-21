using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.Common;
using System.Windows;

namespace MikrotikController
{
    

    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        private readonly HttpClient client;
        private string apiURL = Globals.apiURLUsar;
        private string apiPassword = Globals.apiPasswordUsar; 
        private string apiUsername = Globals.apiUsernameUsar;

        //variaveis globais para guardar os dados do login
        public static class Globals
        {
            public static string apiURLUsar { get; set; }
            public static string apiPasswordUsar { get; set; }
            public static string apiUsernameUsar { get; set; }
            public static string passwordHelper { get; set; }
        }
        
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{Globals.apiUsernameUsar}:{Globals.apiPasswordUsar}")));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }
        
        private void customizeDesign()
        {
            panelWirelessSubmenu.Visible = false;
            panelBridgeSubmenu.Visible = false;
            panelFirewallSubmenu.Visible = false;
            panelDHCPSubmenu.Visible = false;
            panelDHCPSubmenu.Visible = false;
            panelDNSSubmenu.Visible = false;
            //btnFirewall.Visible = false;
        }
        private void hideSubMenu()
        {
            if(panelWirelessSubmenu.Visible == true)
               panelWirelessSubmenu.Visible = false;
            if(panelBridgeSubmenu.Visible == true)
               panelBridgeSubmenu.Visible = false;
            if(panelFirewallSubmenu.Visible == true)
                panelFirewallSubmenu.Visible = false;
            if(panelDHCPSubmenu.Visible == true)
                panelDHCPSubmenu.Visible = false;
            if(panelDHCPSubmenu.Visible == true)
                panelDHCPSubmenu.Visible = false;
            if (panelDNSSubmenu.Visible == true)
                panelDNSSubmenu.Visible = false;
        }
        private void showSubMenu(System.Windows.Forms.Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void panelTopo_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX=e.X;
            movY=e.Y;   
        }

        private void panelTopo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov==1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelTopo_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //sidemenuPanel.Hide();
            panelInfo.Show();
            if (apiURL == null && apiUsername == null && apiUsername == null)
            {
                //panelMain.Controls.Clear();
                Login login = new Login();
                login.TopLevel = false;
                panelMain.Controls.Add(login);
                login.Show();
            }
            else
            {
                sidemenuPanel.Show();
            }
            //load interfaces MAIN
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/interface");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<string> interfaceList = new List<string>();
                JArray interfaces = JArray.Parse(responseBody);
                dataGridViewMain.Columns.Clear();
                dataGridViewMain.Rows.Clear();
                dataGridViewMain.ReadOnly = true;
                dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewMain.Columns.Add("id", "ID");
                dataGridViewMain.Columns.Add("name", "Nome");
                dataGridViewMain.Columns.Add("type", "Tipo");
                dataGridViewMain.Columns.Add("lastlink", "Ultima Ligação");
                dataGridViewMain.Columns.Add("disable", "Estado");
                foreach (JObject jo in interfaces)
                {
                    string interfaceId = (string)jo[".id"];
                    string interfaceName = (string)jo["name"];
                    string type = (string)jo["type"];
                    string lastLink = (string)jo["last-link-up-time"];
                    string disable = ((string)jo["disabled"] == "true") ? "Inativa" : "Ativa";
                    dataGridViewMain.Rows.Add(interfaceId, interfaceName, type, lastLink, disable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro a obter dados das interfaces: {ex.Message}");
            }
            try
            {
                HttpClient client2 = new HttpClient();
                client2.DefaultRequestHeaders.Accept.Clear();
                client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{Globals.apiUsernameUsar}:{Globals.apiPasswordUsar}")));
                HttpResponseMessage response1 = await client2.GetAsync($"{Globals.apiURLUsar}/system/resource");
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                var interfaces = JObject.Parse(responseBody1);
                dynamic jsonObj = JsonConvert.DeserializeObject(responseBody1);
                //labelName.Text = "Dispositivo: " + jsonObj["platform"];
                txtUpTime.Text = jsonObj["uptime"];
                txtVersao.Text = jsonObj["version"];
                txtRam.Text = jsonObj["total-memory"] + " MB";
                txtRamDisponivel.Text = jsonObj["free-memory"] + " MB";
                txtHdd.Text = jsonObj["total-hdd-space"] + " MB";
                txtHddDisponivel.Text = jsonObj["free-hdd-space"] + " MB";
                txtCpuCores.Text = jsonObj["cpu-count"];
                txtCpuFrequencia.Text = jsonObj["cpu-frequency"] + " MHz";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            //nome e ip mikrotik
            try
            {
                HttpClient client2 = new HttpClient();
                client2.DefaultRequestHeaders.Accept.Clear();
                client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{Globals.apiUsernameUsar}:{Globals.apiPasswordUsar}")));
                HttpResponseMessage response1 = await client2.GetAsync($"{Globals.apiURLUsar}/system/identity");
                string responseBody1 = await response1.Content.ReadAsStringAsync();
                var interfaces = JObject.Parse(responseBody1);
                dynamic jsonObj = JsonConvert.DeserializeObject(responseBody1);
                Uri uri = new Uri(apiURL);
                labelName.Text = "Dispositivo: " + jsonObj["name"] + "\nIP " + uri.Host;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWireless_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWirelessSubmenu);
        }

        private void btnWirelessConfigurar_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            WirelessConfigurar wirelessConfigurar = new WirelessConfigurar();
            wirelessConfigurar.TopLevel = false;
            panelMain.Controls.Add(wirelessConfigurar);
            wirelessConfigurar.Show();
        }

        private void btnWirelessPerfisSeguranca_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            WirelessPerfisSeguranca wirelessPerfisSeguranca = new WirelessPerfisSeguranca();
            wirelessPerfisSeguranca.TopLevel = false;
            panelMain.Controls.Add(wirelessPerfisSeguranca);
            wirelessPerfisSeguranca.Show();
        }

        private void btnBridge_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBridgeSubmenu);
        }

        private void btnConfigurarBridge_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            BridgeConfigurar bridgeConfigurar = new BridgeConfigurar();
            bridgeConfigurar.TopLevel = false;
            panelMain.Controls.Add(bridgeConfigurar);
            bridgeConfigurar.Show();
        }

        private void btnPortarBridge_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            BridgePortas bridgePortas = new BridgePortas();
            bridgePortas.TopLevel = false;
            panelMain.Controls.Add(bridgePortas);
            bridgePortas.Show();

        }

        private void btnFirewall_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelFirewallSubmenu);
            
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FirewallRules firewallRules = new FirewallRules();
            firewallRules.TopLevel = false;
            panelMain.Controls.Add(firewallRules);
            firewallRules.Show();
        }
        private void panelLogo_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Form1Inicio form1Inicio = new Form1Inicio();
            form1Inicio.TopLevel = false;
            panelMain.Controls.Add(form1Inicio);
            form1Inicio.Show();
        }
        private void btnMudaEquipamento_Click(object sender, EventArgs e)
        {
            Program.frm.Show();
            this.Hide();            
        }

        private void btnEndrecosIp_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            EnderecosIP enderecosIP = new EnderecosIP();
            enderecosIP.TopLevel = false;
            panelMain.Controls.Add(enderecosIP);
            enderecosIP.Show();
        }

        private void btnRotasEstaticas_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            RotasEstaticas rotasEstaticas = new RotasEstaticas();
            rotasEstaticas.TopLevel = false;
            panelMain.Controls.Add(rotasEstaticas);
            rotasEstaticas.Show();
        }

        private void btnDNSServidor_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            DNSServidor dnsServidor = new DNSServidor();
            dnsServidor.TopLevel = false;
            panelMain.Controls.Add(dnsServidor);
            dnsServidor.Show();
        }

        private void btnDNS_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelDNSSubmenu);
        }

        private void btnDHCPServer_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            DHCPServer dHCPServer = new DHCPServer();
            dHCPServer.TopLevel = false;
            panelMain.Controls.Add(dHCPServer);
            dHCPServer.Show();
        }

        private void btnDHCPClient_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            DHCPPool dHCPPool = new DHCPPool();
            dHCPPool.TopLevel = false;
            panelMain.Controls.Add(dHCPPool);
            dHCPPool.Show();
            
        }

        private void btnDHCP_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelDHCPSubmenu);
        }

        private void panelTopo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVPN_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            VPN vpn = new VPN();
            vpn.TopLevel = false;
            panelMain.Controls.Add(vpn);
            vpn.Show();

        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
