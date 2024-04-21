namespace MikrotikController
{
    partial class FirewallRules
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.editChain = new System.Windows.Forms.ComboBox();
            this.editAcao = new System.Windows.Forms.ComboBox();
            this.editIPDestino = new System.Windows.Forms.TextBox();
            this.editPortaDestino = new System.Windows.Forms.TextBox();
            this.editIPInterno = new System.Windows.Forms.TextBox();
            this.editPortaInterna = new System.Windows.Forms.TextBox();
            this.editProtocolo = new System.Windows.Forms.ComboBox();
            this.btnCriarEditar = new System.Windows.Forms.Button();
            this.editAtiva = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 397);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(747, 27);
            this.label12.TabIndex = 78;
            this.label12.Text = "Adicionar Porta";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "IP Destino";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(613, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Porta Destino";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Chain";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Ação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Protocolo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(237, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "IP Origem";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(525, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Porta Origem";
            // 
            // editChain
            // 
            this.editChain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editChain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editChain.FormattingEnabled = true;
            this.editChain.Location = new System.Drawing.Point(108, 39);
            this.editChain.Name = "editChain";
            this.editChain.Size = new System.Drawing.Size(92, 21);
            this.editChain.TabIndex = 39;
            // 
            // editAcao
            // 
            this.editAcao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editAcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editAcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAcao.FormattingEnabled = true;
            this.editAcao.Location = new System.Drawing.Point(12, 39);
            this.editAcao.Name = "editAcao";
            this.editAcao.Size = new System.Drawing.Size(92, 21);
            this.editAcao.TabIndex = 40;
            // 
            // editIPDestino
            // 
            this.editIPDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editIPDestino.Location = new System.Drawing.Point(323, 39);
            this.editIPDestino.Name = "editIPDestino";
            this.editIPDestino.Size = new System.Drawing.Size(111, 20);
            this.editIPDestino.TabIndex = 41;
            // 
            // editPortaDestino
            // 
            this.editPortaDestino.Location = new System.Drawing.Point(606, 39);
            this.editPortaDestino.Name = "editPortaDestino";
            this.editPortaDestino.Size = new System.Drawing.Size(88, 20);
            this.editPortaDestino.TabIndex = 42;
            // 
            // editIPInterno
            // 
            this.editIPInterno.Location = new System.Drawing.Point(209, 39);
            this.editIPInterno.Name = "editIPInterno";
            this.editIPInterno.Size = new System.Drawing.Size(108, 20);
            this.editIPInterno.TabIndex = 43;
            // 
            // editPortaInterna
            // 
            this.editPortaInterna.Location = new System.Drawing.Point(517, 39);
            this.editPortaInterna.Name = "editPortaInterna";
            this.editPortaInterna.Size = new System.Drawing.Size(83, 20);
            this.editPortaInterna.TabIndex = 44;
            // 
            // editProtocolo
            // 
            this.editProtocolo.FormattingEnabled = true;
            this.editProtocolo.Location = new System.Drawing.Point(440, 38);
            this.editProtocolo.Name = "editProtocolo";
            this.editProtocolo.Size = new System.Drawing.Size(70, 21);
            this.editProtocolo.TabIndex = 45;
            this.editProtocolo.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // btnCriarEditar
            // 
            this.btnCriarEditar.Location = new System.Drawing.Point(8, 85);
            this.btnCriarEditar.Name = "btnCriarEditar";
            this.btnCriarEditar.Size = new System.Drawing.Size(170, 23);
            this.btnCriarEditar.TabIndex = 46;
            this.btnCriarEditar.Text = "Criar";
            this.btnCriarEditar.UseVisualStyleBackColor = true;
            this.btnCriarEditar.Click += new System.EventHandler(this.btnCriarEditar_Click);
            // 
            // editAtiva
            // 
            this.editAtiva.AutoSize = true;
            this.editAtiva.Location = new System.Drawing.Point(709, 43);
            this.editAtiva.Name = "editAtiva";
            this.editAtiva.Size = new System.Drawing.Size(15, 14);
            this.editAtiva.TabIndex = 47;
            this.editAtiva.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(683, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Desativado";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Apagar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(360, 85);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(170, 23);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Limpar e Manter Dados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(14, 116);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 12);
            this.labelID.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelID);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.editAtiva);
            this.panel3.Controls.Add(this.btnCriarEditar);
            this.panel3.Controls.Add(this.editProtocolo);
            this.panel3.Controls.Add(this.editPortaInterna);
            this.panel3.Controls.Add(this.editIPInterno);
            this.panel3.Controls.Add(this.editPortaDestino);
            this.panel3.Controls.Add(this.editIPDestino);
            this.panel3.Controls.Add(this.editAcao);
            this.panel3.Controls.Add(this.editChain);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 140);
            this.panel3.TabIndex = 79;
            // 
            // FirewallRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(747, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirewallRules";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FirewallNAT_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox editChain;
        private System.Windows.Forms.ComboBox editAcao;
        private System.Windows.Forms.TextBox editIPDestino;
        private System.Windows.Forms.TextBox editPortaDestino;
        private System.Windows.Forms.TextBox editIPInterno;
        private System.Windows.Forms.TextBox editPortaInterna;
        private System.Windows.Forms.ComboBox editProtocolo;
        private System.Windows.Forms.Button btnCriarEditar;
        private System.Windows.Forms.CheckBox editAtiva;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel panel3;
    }
}