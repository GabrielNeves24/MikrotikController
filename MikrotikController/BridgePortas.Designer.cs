namespace MikrotikController
{
    partial class BridgePortas
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
            this.label10 = new System.Windows.Forms.Label();
            this.getNomeInterface = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdcionarPorta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboInterface = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboRemove = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoverPorta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listagemPortas = new System.Windows.Forms.TextBox();
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
            this.panel1.TabIndex = 54;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Interface";
            // 
            // getNomeInterface
            // 
            this.getNomeInterface.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getNomeInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getNomeInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getNomeInterface.FormattingEnabled = true;
            this.getNomeInterface.Location = new System.Drawing.Point(255, 36);
            this.getNomeInterface.Name = "getNomeInterface";
            this.getNomeInterface.Size = new System.Drawing.Size(109, 21);
            this.getNomeInterface.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Bridge";
            // 
            // btnAdcionarPorta
            // 
            this.btnAdcionarPorta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdcionarPorta.FlatAppearance.BorderSize = 0;
            this.btnAdcionarPorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdcionarPorta.Location = new System.Drawing.Point(414, 37);
            this.btnAdcionarPorta.Name = "btnAdcionarPorta";
            this.btnAdcionarPorta.Size = new System.Drawing.Size(164, 23);
            this.btnAdcionarPorta.TabIndex = 55;
            this.btnAdcionarPorta.Text = "Adicionar";
            this.btnAdcionarPorta.UseVisualStyleBackColor = false;
            this.btnAdcionarPorta.Click += new System.EventHandler(this.btnAdcionarPorta_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboInterface);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.getNomeInterface);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnAdcionarPorta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 91);
            this.panel2.TabIndex = 73;
            // 
            // comboInterface
            // 
            this.comboInterface.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInterface.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboInterface.FormattingEnabled = true;
            this.comboInterface.Location = new System.Drawing.Point(76, 36);
            this.comboInterface.Name = "comboInterface";
            this.comboInterface.Size = new System.Drawing.Size(111, 21);
            this.comboInterface.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 27);
            this.label1.TabIndex = 72;
            this.label1.Text = "Adicionar Porta";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboRemove);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnRemoverPorta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 91);
            this.panel3.TabIndex = 75;
            // 
            // comboRemove
            // 
            this.comboRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboRemove.FormattingEnabled = true;
            this.comboRemove.Location = new System.Drawing.Point(104, 39);
            this.comboRemove.Name = "comboRemove";
            this.comboRemove.Size = new System.Drawing.Size(208, 21);
            this.comboRemove.TabIndex = 67;
            this.comboRemove.SelectedIndexChanged += new System.EventHandler(this.comboInterfaceRemove_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Interface/Bridge";
            // 
            // btnRemoverPorta
            // 
            this.btnRemoverPorta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoverPorta.FlatAppearance.BorderSize = 0;
            this.btnRemoverPorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverPorta.Location = new System.Drawing.Point(414, 37);
            this.btnRemoverPorta.Name = "btnRemoverPorta";
            this.btnRemoverPorta.Size = new System.Drawing.Size(164, 23);
            this.btnRemoverPorta.TabIndex = 63;
            this.btnRemoverPorta.Text = "Remover";
            this.btnRemoverPorta.UseVisualStyleBackColor = false;
            this.btnRemoverPorta.Click += new System.EventHandler(this.btnRemoverPorta_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(747, 27);
            this.label5.TabIndex = 74;
            this.label5.Text = "Remover Porta";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // listagemPortas
            // 
            this.listagemPortas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listagemPortas.BackColor = System.Drawing.Color.Azure;
            this.listagemPortas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listagemPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listagemPortas.Location = new System.Drawing.Point(17, 299);
            this.listagemPortas.Margin = new System.Windows.Forms.Padding(10);
            this.listagemPortas.Multiline = true;
            this.listagemPortas.Name = "listagemPortas";
            this.listagemPortas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listagemPortas.Size = new System.Drawing.Size(709, 302);
            this.listagemPortas.TabIndex = 98;
            // 
            // BridgePortas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(747, 620);
            this.Controls.Add(this.listagemPortas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BridgePortas";
            this.Text = "BridgePortas";
            this.Load += new System.EventHandler(this.BridgePortas_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox getNomeInterface;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdcionarPorta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemoverPorta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboInterface;
        private System.Windows.Forms.ComboBox comboRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox listagemPortas;
    }
}