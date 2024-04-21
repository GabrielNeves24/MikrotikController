namespace MikrotikController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTopo = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sidemenuPanel = new System.Windows.Forms.Panel();
            this.btnVPN = new System.Windows.Forms.Button();
            this.btnMudaEquipamento = new System.Windows.Forms.Button();
            this.btnEndrecosIp = new System.Windows.Forms.Button();
            this.btnRotasEstaticas = new System.Windows.Forms.Button();
            this.panelDNSSubmenu = new System.Windows.Forms.Panel();
            this.btnDNSServidor = new System.Windows.Forms.Button();
            this.btnDNS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDHCPSubmenu = new System.Windows.Forms.Panel();
            this.btnDHCPServer = new System.Windows.Forms.Button();
            this.btnDHCPClient = new System.Windows.Forms.Button();
            this.btnDHCP = new System.Windows.Forms.Button();
            this.panelFirewallSubmenu = new System.Windows.Forms.Panel();
            this.btnina = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnFirewall = new System.Windows.Forms.Button();
            this.panelBridgeSubmenu = new System.Windows.Forms.Panel();
            this.btnPortarBridge = new System.Windows.Forms.Button();
            this.btnConfigurarBridge = new System.Windows.Forms.Button();
            this.btnBridge = new System.Windows.Forms.Button();
            this.panelWirelessSubmenu = new System.Windows.Forms.Panel();
            this.btnWirelessPerfisSeguranca = new System.Windows.Forms.Button();
            this.btnWirelessConfigurar = new System.Windows.Forms.Button();
            this.btnWireless = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.txtCpuFrequencia = new System.Windows.Forms.TextBox();
            this.txtCpuCores = new System.Windows.Forms.TextBox();
            this.txtHddDisponivel = new System.Windows.Forms.TextBox();
            this.txtRamDisponivel = new System.Windows.Forms.TextBox();
            this.txtHdd = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.txtUpTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.panelTopo.SuspendLayout();
            this.sidemenuPanel.SuspendLayout();
            this.panelDNSSubmenu.SuspendLayout();
            this.panelDHCPSubmenu.SuspendLayout();
            this.panelFirewallSubmenu.SuspendLayout();
            this.panelBridgeSubmenu.SuspendLayout();
            this.panelWirelessSubmenu.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTopo.Controls.Add(this.labelName);
            this.panelTopo.Controls.Add(this.button1);
            resources.ApplyResources(this.panelTopo, "panelTopo");
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTopo_Paint);
            this.panelTopo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopo_MouseDown);
            this.panelTopo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopo_MouseMove);
            this.panelTopo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopo_MouseUp);
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelName.Name = "labelName";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MikrotikController.Properties.Resources.close_cross_icon_128690;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidemenuPanel
            // 
            resources.ApplyResources(this.sidemenuPanel, "sidemenuPanel");
            this.sidemenuPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sidemenuPanel.Controls.Add(this.btnVPN);
            this.sidemenuPanel.Controls.Add(this.btnMudaEquipamento);
            this.sidemenuPanel.Controls.Add(this.btnEndrecosIp);
            this.sidemenuPanel.Controls.Add(this.btnRotasEstaticas);
            this.sidemenuPanel.Controls.Add(this.panelDNSSubmenu);
            this.sidemenuPanel.Controls.Add(this.btnDNS);
            this.sidemenuPanel.Controls.Add(this.label1);
            this.sidemenuPanel.Controls.Add(this.panelDHCPSubmenu);
            this.sidemenuPanel.Controls.Add(this.btnDHCP);
            this.sidemenuPanel.Controls.Add(this.panelFirewallSubmenu);
            this.sidemenuPanel.Controls.Add(this.btnFirewall);
            this.sidemenuPanel.Controls.Add(this.panelBridgeSubmenu);
            this.sidemenuPanel.Controls.Add(this.btnBridge);
            this.sidemenuPanel.Controls.Add(this.panelWirelessSubmenu);
            this.sidemenuPanel.Controls.Add(this.btnWireless);
            this.sidemenuPanel.Controls.Add(this.panelLogo);
            this.sidemenuPanel.Name = "sidemenuPanel";
            // 
            // btnVPN
            // 
            this.btnVPN.AllowDrop = true;
            resources.ApplyResources(this.btnVPN, "btnVPN");
            this.btnVPN.FlatAppearance.BorderSize = 0;
            this.btnVPN.ForeColor = System.Drawing.Color.White;
            this.btnVPN.Name = "btnVPN";
            this.btnVPN.TabStop = false;
            this.btnVPN.UseVisualStyleBackColor = true;
            this.btnVPN.Click += new System.EventHandler(this.btnVPN_Click);
            // 
            // btnMudaEquipamento
            // 
            this.btnMudaEquipamento.AllowDrop = true;
            resources.ApplyResources(this.btnMudaEquipamento, "btnMudaEquipamento");
            this.btnMudaEquipamento.FlatAppearance.BorderSize = 0;
            this.btnMudaEquipamento.ForeColor = System.Drawing.Color.White;
            this.btnMudaEquipamento.Name = "btnMudaEquipamento";
            this.btnMudaEquipamento.TabStop = false;
            this.btnMudaEquipamento.UseVisualStyleBackColor = true;
            this.btnMudaEquipamento.Click += new System.EventHandler(this.btnMudaEquipamento_Click);
            // 
            // btnEndrecosIp
            // 
            this.btnEndrecosIp.AllowDrop = true;
            resources.ApplyResources(this.btnEndrecosIp, "btnEndrecosIp");
            this.btnEndrecosIp.FlatAppearance.BorderSize = 0;
            this.btnEndrecosIp.ForeColor = System.Drawing.Color.White;
            this.btnEndrecosIp.Name = "btnEndrecosIp";
            this.btnEndrecosIp.TabStop = false;
            this.btnEndrecosIp.UseVisualStyleBackColor = true;
            this.btnEndrecosIp.Click += new System.EventHandler(this.btnEndrecosIp_Click);
            // 
            // btnRotasEstaticas
            // 
            this.btnRotasEstaticas.AllowDrop = true;
            resources.ApplyResources(this.btnRotasEstaticas, "btnRotasEstaticas");
            this.btnRotasEstaticas.FlatAppearance.BorderSize = 0;
            this.btnRotasEstaticas.ForeColor = System.Drawing.Color.White;
            this.btnRotasEstaticas.Name = "btnRotasEstaticas";
            this.btnRotasEstaticas.TabStop = false;
            this.btnRotasEstaticas.UseVisualStyleBackColor = true;
            this.btnRotasEstaticas.Click += new System.EventHandler(this.btnRotasEstaticas_Click);
            // 
            // panelDNSSubmenu
            // 
            this.panelDNSSubmenu.Controls.Add(this.btnDNSServidor);
            resources.ApplyResources(this.panelDNSSubmenu, "panelDNSSubmenu");
            this.panelDNSSubmenu.Name = "panelDNSSubmenu";
            // 
            // btnDNSServidor
            // 
            this.btnDNSServidor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnDNSServidor, "btnDNSServidor");
            this.btnDNSServidor.FlatAppearance.BorderSize = 0;
            this.btnDNSServidor.ForeColor = System.Drawing.Color.Black;
            this.btnDNSServidor.Name = "btnDNSServidor";
            this.btnDNSServidor.UseVisualStyleBackColor = false;
            this.btnDNSServidor.Click += new System.EventHandler(this.btnDNSServidor_Click_1);
            // 
            // btnDNS
            // 
            this.btnDNS.AllowDrop = true;
            resources.ApplyResources(this.btnDNS, "btnDNS");
            this.btnDNS.FlatAppearance.BorderSize = 0;
            this.btnDNS.ForeColor = System.Drawing.Color.White;
            this.btnDNS.Name = "btnDNS";
            this.btnDNS.TabStop = false;
            this.btnDNS.UseVisualStyleBackColor = true;
            this.btnDNS.Click += new System.EventHandler(this.btnDNS_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panelDHCPSubmenu
            // 
            this.panelDHCPSubmenu.Controls.Add(this.btnDHCPServer);
            this.panelDHCPSubmenu.Controls.Add(this.btnDHCPClient);
            resources.ApplyResources(this.panelDHCPSubmenu, "panelDHCPSubmenu");
            this.panelDHCPSubmenu.Name = "panelDHCPSubmenu";
            // 
            // btnDHCPServer
            // 
            this.btnDHCPServer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnDHCPServer, "btnDHCPServer");
            this.btnDHCPServer.FlatAppearance.BorderSize = 0;
            this.btnDHCPServer.ForeColor = System.Drawing.Color.Black;
            this.btnDHCPServer.Name = "btnDHCPServer";
            this.btnDHCPServer.UseVisualStyleBackColor = false;
            this.btnDHCPServer.Click += new System.EventHandler(this.btnDHCPServer_Click_1);
            // 
            // btnDHCPClient
            // 
            this.btnDHCPClient.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnDHCPClient, "btnDHCPClient");
            this.btnDHCPClient.FlatAppearance.BorderSize = 0;
            this.btnDHCPClient.ForeColor = System.Drawing.Color.Black;
            this.btnDHCPClient.Name = "btnDHCPClient";
            this.btnDHCPClient.UseVisualStyleBackColor = false;
            this.btnDHCPClient.Click += new System.EventHandler(this.btnDHCPClient_Click_1);
            // 
            // btnDHCP
            // 
            this.btnDHCP.AllowDrop = true;
            resources.ApplyResources(this.btnDHCP, "btnDHCP");
            this.btnDHCP.FlatAppearance.BorderSize = 0;
            this.btnDHCP.ForeColor = System.Drawing.Color.White;
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.TabStop = false;
            this.btnDHCP.UseVisualStyleBackColor = true;
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click_1);
            // 
            // panelFirewallSubmenu
            // 
            this.panelFirewallSubmenu.Controls.Add(this.btnina);
            this.panelFirewallSubmenu.Controls.Add(this.btnRules);
            resources.ApplyResources(this.panelFirewallSubmenu, "panelFirewallSubmenu");
            this.panelFirewallSubmenu.Name = "panelFirewallSubmenu";
            // 
            // btnina
            // 
            this.btnina.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnina, "btnina");
            this.btnina.FlatAppearance.BorderSize = 0;
            this.btnina.ForeColor = System.Drawing.Color.Black;
            this.btnina.Name = "btnina";
            this.btnina.UseVisualStyleBackColor = false;
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnRules, "btnRules");
            this.btnRules.FlatAppearance.BorderSize = 0;
            this.btnRules.ForeColor = System.Drawing.Color.Black;
            this.btnRules.Name = "btnRules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnFirewall
            // 
            this.btnFirewall.AllowDrop = true;
            resources.ApplyResources(this.btnFirewall, "btnFirewall");
            this.btnFirewall.FlatAppearance.BorderSize = 0;
            this.btnFirewall.ForeColor = System.Drawing.Color.White;
            this.btnFirewall.Name = "btnFirewall";
            this.btnFirewall.TabStop = false;
            this.btnFirewall.UseVisualStyleBackColor = true;
            this.btnFirewall.Click += new System.EventHandler(this.btnFirewall_Click_1);
            // 
            // panelBridgeSubmenu
            // 
            this.panelBridgeSubmenu.Controls.Add(this.btnPortarBridge);
            this.panelBridgeSubmenu.Controls.Add(this.btnConfigurarBridge);
            resources.ApplyResources(this.panelBridgeSubmenu, "panelBridgeSubmenu");
            this.panelBridgeSubmenu.Name = "panelBridgeSubmenu";
            // 
            // btnPortarBridge
            // 
            this.btnPortarBridge.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnPortarBridge, "btnPortarBridge");
            this.btnPortarBridge.FlatAppearance.BorderSize = 0;
            this.btnPortarBridge.ForeColor = System.Drawing.Color.Black;
            this.btnPortarBridge.Name = "btnPortarBridge";
            this.btnPortarBridge.UseVisualStyleBackColor = false;
            this.btnPortarBridge.Click += new System.EventHandler(this.btnPortarBridge_Click_1);
            // 
            // btnConfigurarBridge
            // 
            this.btnConfigurarBridge.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnConfigurarBridge, "btnConfigurarBridge");
            this.btnConfigurarBridge.FlatAppearance.BorderSize = 0;
            this.btnConfigurarBridge.ForeColor = System.Drawing.Color.Black;
            this.btnConfigurarBridge.Name = "btnConfigurarBridge";
            this.btnConfigurarBridge.UseVisualStyleBackColor = false;
            this.btnConfigurarBridge.Click += new System.EventHandler(this.btnConfigurarBridge_Click_1);
            // 
            // btnBridge
            // 
            this.btnBridge.AllowDrop = true;
            resources.ApplyResources(this.btnBridge, "btnBridge");
            this.btnBridge.FlatAppearance.BorderSize = 0;
            this.btnBridge.ForeColor = System.Drawing.Color.White;
            this.btnBridge.Name = "btnBridge";
            this.btnBridge.TabStop = false;
            this.btnBridge.UseVisualStyleBackColor = true;
            this.btnBridge.Click += new System.EventHandler(this.btnBridge_Click);
            // 
            // panelWirelessSubmenu
            // 
            this.panelWirelessSubmenu.Controls.Add(this.btnWirelessPerfisSeguranca);
            this.panelWirelessSubmenu.Controls.Add(this.btnWirelessConfigurar);
            resources.ApplyResources(this.panelWirelessSubmenu, "panelWirelessSubmenu");
            this.panelWirelessSubmenu.Name = "panelWirelessSubmenu";
            // 
            // btnWirelessPerfisSeguranca
            // 
            this.btnWirelessPerfisSeguranca.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnWirelessPerfisSeguranca, "btnWirelessPerfisSeguranca");
            this.btnWirelessPerfisSeguranca.FlatAppearance.BorderSize = 0;
            this.btnWirelessPerfisSeguranca.ForeColor = System.Drawing.Color.Black;
            this.btnWirelessPerfisSeguranca.Name = "btnWirelessPerfisSeguranca";
            this.btnWirelessPerfisSeguranca.UseVisualStyleBackColor = false;
            this.btnWirelessPerfisSeguranca.Click += new System.EventHandler(this.btnWirelessPerfisSeguranca_Click_1);
            // 
            // btnWirelessConfigurar
            // 
            this.btnWirelessConfigurar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btnWirelessConfigurar, "btnWirelessConfigurar");
            this.btnWirelessConfigurar.FlatAppearance.BorderSize = 0;
            this.btnWirelessConfigurar.ForeColor = System.Drawing.Color.Black;
            this.btnWirelessConfigurar.Name = "btnWirelessConfigurar";
            this.btnWirelessConfigurar.UseVisualStyleBackColor = false;
            this.btnWirelessConfigurar.Click += new System.EventHandler(this.btnWirelessConfigurar_Click_1);
            // 
            // btnWireless
            // 
            this.btnWireless.AllowDrop = true;
            resources.ApplyResources(this.btnWireless, "btnWireless");
            this.btnWireless.FlatAppearance.BorderSize = 0;
            this.btnWireless.ForeColor = System.Drawing.Color.White;
            this.btnWireless.Name = "btnWireless";
            this.btnWireless.TabStop = false;
            this.btnWireless.UseCompatibleTextRendering = true;
            this.btnWireless.UseVisualStyleBackColor = true;
            this.btnWireless.Click += new System.EventHandler(this.btnWireless_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::MikrotikController.Properties.Resources.MikroTik;
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click_1);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.txtCpuFrequencia);
            this.panelInfo.Controls.Add(this.txtCpuCores);
            this.panelInfo.Controls.Add(this.txtHddDisponivel);
            this.panelInfo.Controls.Add(this.txtRamDisponivel);
            this.panelInfo.Controls.Add(this.txtHdd);
            this.panelInfo.Controls.Add(this.txtRam);
            this.panelInfo.Controls.Add(this.txtVersao);
            this.panelInfo.Controls.Add(this.txtUpTime);
            this.panelInfo.Controls.Add(this.label9);
            this.panelInfo.Controls.Add(this.label8);
            this.panelInfo.Controls.Add(this.label7);
            this.panelInfo.Controls.Add(this.label6);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            resources.ApplyResources(this.panelInfo, "panelInfo");
            this.panelInfo.Name = "panelInfo";
            // 
            // txtCpuFrequencia
            // 
            this.txtCpuFrequencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtCpuFrequencia, "txtCpuFrequencia");
            this.txtCpuFrequencia.Name = "txtCpuFrequencia";
            // 
            // txtCpuCores
            // 
            this.txtCpuCores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtCpuCores, "txtCpuCores");
            this.txtCpuCores.Name = "txtCpuCores";
            // 
            // txtHddDisponivel
            // 
            this.txtHddDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtHddDisponivel, "txtHddDisponivel");
            this.txtHddDisponivel.Name = "txtHddDisponivel";
            // 
            // txtRamDisponivel
            // 
            this.txtRamDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtRamDisponivel, "txtRamDisponivel");
            this.txtRamDisponivel.Name = "txtRamDisponivel";
            // 
            // txtHdd
            // 
            this.txtHdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtHdd, "txtHdd");
            this.txtHdd.Name = "txtHdd";
            // 
            // txtRam
            // 
            this.txtRam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtRam, "txtRam");
            this.txtRam.Name = "txtRam";
            // 
            // txtVersao
            // 
            this.txtVersao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtVersao, "txtVersao");
            this.txtVersao.Name = "txtVersao";
            // 
            // txtUpTime
            // 
            this.txtUpTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtUpTime, "txtUpTime");
            this.txtUpTime.Name = "txtUpTime";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Name = "label2";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Azure;
            this.panelMain.Controls.Add(this.dataGridViewMain);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.panelInfo);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.GridColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.dataGridViewMain, "dataGridViewMain");
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellContentClick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.sidemenuPanel);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTopo.ResumeLayout(false);
            this.sidemenuPanel.ResumeLayout(false);
            this.panelDNSSubmenu.ResumeLayout(false);
            this.panelDHCPSubmenu.ResumeLayout(false);
            this.panelFirewallSubmenu.ResumeLayout(false);
            this.panelBridgeSubmenu.ResumeLayout(false);
            this.panelWirelessSubmenu.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel sidemenuPanel;
        private System.Windows.Forms.Button btnMudaEquipamento;
        private System.Windows.Forms.Button btnEndrecosIp;
        private System.Windows.Forms.Button btnRotasEstaticas;
        private System.Windows.Forms.Panel panelDNSSubmenu;
        private System.Windows.Forms.Button btnDNSServidor;
        private System.Windows.Forms.Button btnDNS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDHCPSubmenu;
        private System.Windows.Forms.Button btnDHCPServer;
        private System.Windows.Forms.Button btnDHCPClient;
        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.Panel panelFirewallSubmenu;
        private System.Windows.Forms.Button btnina;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnFirewall;
        private System.Windows.Forms.Panel panelBridgeSubmenu;
        private System.Windows.Forms.Button btnPortarBridge;
        private System.Windows.Forms.Button btnConfigurarBridge;
        private System.Windows.Forms.Button btnBridge;
        private System.Windows.Forms.Panel panelWirelessSubmenu;
        private System.Windows.Forms.Button btnWirelessPerfisSeguranca;
        private System.Windows.Forms.Button btnWirelessConfigurar;
        private System.Windows.Forms.Button btnWireless;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelInfo;
        public System.Windows.Forms.TextBox txtCpuFrequencia;
        public System.Windows.Forms.TextBox txtCpuCores;
        public System.Windows.Forms.TextBox txtHddDisponivel;
        public System.Windows.Forms.TextBox txtRamDisponivel;
        public System.Windows.Forms.TextBox txtHdd;
        public System.Windows.Forms.TextBox txtRam;
        public System.Windows.Forms.TextBox txtVersao;
        public System.Windows.Forms.TextBox txtUpTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button btnVPN;
    }
}

