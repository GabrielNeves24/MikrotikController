namespace MikrotikController
{
    partial class WirelessConfigurar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInterfacesWireless = new System.Windows.Forms.ComboBox();
            this.btnDesativarWireless = new System.Windows.Forms.Button();
            this.btnAtivarWireless = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveConfigWireless = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxInterfaceWirelessSSID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxInterfaceWirelessPerfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxInterfaceWirelessConfig = new System.Windows.Forms.ComboBox();
            this.listagemInterfaces = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 38);
            this.panel1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MikrotikController.Properties.Resources.close_cross_icon_128690;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(710, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBoxInterfacesWireless);
            this.panel2.Controls.Add(this.btnDesativarWireless);
            this.panel2.Controls.Add(this.btnAtivarWireless);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 65);
            this.panel2.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Interface:";
            // 
            // comboBoxInterfacesWireless
            // 
            this.comboBoxInterfacesWireless.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxInterfacesWireless.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInterfacesWireless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInterfacesWireless.FormattingEnabled = true;
            this.comboBoxInterfacesWireless.Location = new System.Drawing.Point(12, 25);
            this.comboBoxInterfacesWireless.Name = "comboBoxInterfacesWireless";
            this.comboBoxInterfacesWireless.Size = new System.Drawing.Size(120, 21);
            this.comboBoxInterfacesWireless.TabIndex = 45;
            // 
            // btnDesativarWireless
            // 
            this.btnDesativarWireless.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDesativarWireless.FlatAppearance.BorderSize = 0;
            this.btnDesativarWireless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesativarWireless.Location = new System.Drawing.Point(344, 25);
            this.btnDesativarWireless.Name = "btnDesativarWireless";
            this.btnDesativarWireless.Size = new System.Drawing.Size(170, 22);
            this.btnDesativarWireless.TabIndex = 44;
            this.btnDesativarWireless.Text = "Desativar Wireless";
            this.btnDesativarWireless.UseVisualStyleBackColor = false;
            this.btnDesativarWireless.Click += new System.EventHandler(this.btnDesativarWireless_Click_1);
            // 
            // btnAtivarWireless
            // 
            this.btnAtivarWireless.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtivarWireless.FlatAppearance.BorderSize = 0;
            this.btnAtivarWireless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivarWireless.Location = new System.Drawing.Point(168, 25);
            this.btnAtivarWireless.Name = "btnAtivarWireless";
            this.btnAtivarWireless.Size = new System.Drawing.Size(170, 22);
            this.btnAtivarWireless.TabIndex = 43;
            this.btnAtivarWireless.Text = "Ativar Wireless";
            this.btnAtivarWireless.UseVisualStyleBackColor = false;
            this.btnAtivarWireless.Click += new System.EventHandler(this.btnAtivarWireless_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ativar/Desativar/Criar Wireless";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(747, 27);
            this.label8.TabIndex = 70;
            this.label8.Text = "Configurar Wireless";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveConfigWireless);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtBoxInterfaceWirelessSSID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBoxInterfaceWirelessPerfil);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.comboBoxInterfaceWirelessConfig);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 82);
            this.panel3.TabIndex = 71;
            // 
            // btnSaveConfigWireless
            // 
            this.btnSaveConfigWireless.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveConfigWireless.FlatAppearance.BorderSize = 0;
            this.btnSaveConfigWireless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfigWireless.Location = new System.Drawing.Point(443, 39);
            this.btnSaveConfigWireless.Name = "btnSaveConfigWireless";
            this.btnSaveConfigWireless.Size = new System.Drawing.Size(286, 22);
            this.btnSaveConfigWireless.TabIndex = 75;
            this.btnSaveConfigWireless.Text = "Alterar SSID/Perfil";
            this.btnSaveConfigWireless.UseVisualStyleBackColor = false;
            this.btnSaveConfigWireless.Click += new System.EventHandler(this.btnSaveConfigWireless_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "SSID:";
            // 
            // txtBoxInterfaceWirelessSSID
            // 
            this.txtBoxInterfaceWirelessSSID.Location = new System.Drawing.Point(307, 39);
            this.txtBoxInterfaceWirelessSSID.Name = "txtBoxInterfaceWirelessSSID";
            this.txtBoxInterfaceWirelessSSID.Size = new System.Drawing.Size(120, 20);
            this.txtBoxInterfaceWirelessSSID.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Perfil S:";
            // 
            // comboBoxInterfaceWirelessPerfil
            // 
            this.comboBoxInterfaceWirelessPerfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxInterfaceWirelessPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInterfaceWirelessPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInterfaceWirelessPerfil.FormattingEnabled = true;
            this.comboBoxInterfaceWirelessPerfil.Location = new System.Drawing.Point(168, 39);
            this.comboBoxInterfaceWirelessPerfil.Name = "comboBoxInterfaceWirelessPerfil";
            this.comboBoxInterfaceWirelessPerfil.Size = new System.Drawing.Size(120, 21);
            this.comboBoxInterfaceWirelessPerfil.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Interface:";
            // 
            // comboBoxInterfaceWirelessConfig
            // 
            this.comboBoxInterfaceWirelessConfig.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxInterfaceWirelessConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInterfaceWirelessConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInterfaceWirelessConfig.FormattingEnabled = true;
            this.comboBoxInterfaceWirelessConfig.Location = new System.Drawing.Point(29, 39);
            this.comboBoxInterfaceWirelessConfig.Name = "comboBoxInterfaceWirelessConfig";
            this.comboBoxInterfaceWirelessConfig.Size = new System.Drawing.Size(120, 21);
            this.comboBoxInterfaceWirelessConfig.TabIndex = 69;
            this.comboBoxInterfaceWirelessConfig.SelectedIndexChanged += new System.EventHandler(this.comboBoxInterfaceWirelessConfig_SelectedIndexChanged_1);
            // 
            // listagemInterfaces
            // 
            this.listagemInterfaces.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listagemInterfaces.BackColor = System.Drawing.Color.Azure;
            this.listagemInterfaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listagemInterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listagemInterfaces.Location = new System.Drawing.Point(19, 252);
            this.listagemInterfaces.Margin = new System.Windows.Forms.Padding(10);
            this.listagemInterfaces.Multiline = true;
            this.listagemInterfaces.Name = "listagemInterfaces";
            this.listagemInterfaces.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listagemInterfaces.Size = new System.Drawing.Size(709, 356);
            this.listagemInterfaces.TabIndex = 77;
            // 
            // WirelessConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(747, 620);
            this.Controls.Add(this.listagemInterfaces);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WirelessConfigurar";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Interfaces_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInterfacesWireless;
        private System.Windows.Forms.Button btnDesativarWireless;
        private System.Windows.Forms.Button btnAtivarWireless;
        private System.Windows.Forms.Button btnSaveConfigWireless;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxInterfaceWirelessSSID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxInterfaceWirelessPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxInterfaceWirelessConfig;
        private System.Windows.Forms.TextBox listagemInterfaces;
    }
}