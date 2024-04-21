namespace MikrotikController
{
    partial class EnderecosIP
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
            this.labelID = new System.Windows.Forms.Label();
            this.comboInterfaces = new System.Windows.Forms.ComboBox();
            this.btnLimparKeep = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagarRota = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.editAtiva = new System.Windows.Forms.CheckBox();
            this.btnCriarEditar = new System.Windows.Forms.Button();
            this.txtRede = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1IP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1IP)).BeginInit();
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
            this.panel1.TabIndex = 38;
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
            this.panel2.Controls.Add(this.labelID);
            this.panel2.Controls.Add(this.comboInterfaces);
            this.panel2.Controls.Add(this.btnLimparKeep);
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.btnApagarRota);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.editAtiva);
            this.panel2.Controls.Add(this.btnCriarEditar);
            this.panel2.Controls.Add(this.txtRede);
            this.panel2.Controls.Add(this.txtIP);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 120);
            this.panel2.TabIndex = 71;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(415, 17);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 66;
            // 
            // comboInterfaces
            // 
            this.comboInterfaces.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInterfaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboInterfaces.FormattingEnabled = true;
            this.comboInterfaces.Location = new System.Drawing.Point(230, 31);
            this.comboInterfaces.Name = "comboInterfaces";
            this.comboInterfaces.Size = new System.Drawing.Size(97, 21);
            this.comboInterfaces.TabIndex = 65;
            // 
            // btnLimparKeep
            // 
            this.btnLimparKeep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparKeep.FlatAppearance.BorderSize = 0;
            this.btnLimparKeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparKeep.Location = new System.Drawing.Point(540, 80);
            this.btnLimparKeep.Name = "btnLimparKeep";
            this.btnLimparKeep.Size = new System.Drawing.Size(170, 23);
            this.btnLimparKeep.TabIndex = 64;
            this.btnLimparKeep.Text = "Limpar e Manter Dados";
            this.btnLimparKeep.UseVisualStyleBackColor = false;
            this.btnLimparKeep.Click += new System.EventHandler(this.btnLimparKeep_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(364, 80);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(170, 23);
            this.btnLimpar.TabIndex = 63;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnApagarRota
            // 
            this.btnApagarRota.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnApagarRota.FlatAppearance.BorderSize = 0;
            this.btnApagarRota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarRota.Location = new System.Drawing.Point(188, 80);
            this.btnApagarRota.Name = "btnApagarRota";
            this.btnApagarRota.Size = new System.Drawing.Size(170, 23);
            this.btnApagarRota.TabIndex = 62;
            this.btnApagarRota.Text = "Apagar";
            this.btnApagarRota.UseVisualStyleBackColor = false;
            this.btnApagarRota.Click += new System.EventHandler(this.btnApagarRota_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(326, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Desativado";
            // 
            // editAtiva
            // 
            this.editAtiva.AutoSize = true;
            this.editAtiva.Location = new System.Drawing.Point(348, 35);
            this.editAtiva.Name = "editAtiva";
            this.editAtiva.Size = new System.Drawing.Size(15, 14);
            this.editAtiva.TabIndex = 60;
            this.editAtiva.UseVisualStyleBackColor = true;
            // 
            // btnCriarEditar
            // 
            this.btnCriarEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriarEditar.FlatAppearance.BorderSize = 0;
            this.btnCriarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarEditar.Location = new System.Drawing.Point(12, 80);
            this.btnCriarEditar.Name = "btnCriarEditar";
            this.btnCriarEditar.Size = new System.Drawing.Size(170, 23);
            this.btnCriarEditar.TabIndex = 59;
            this.btnCriarEditar.Text = "Criar";
            this.btnCriarEditar.UseVisualStyleBackColor = false;
            this.btnCriarEditar.Click += new System.EventHandler(this.btnCriarEditar_Click);
            // 
            // txtRede
            // 
            this.txtRede.Location = new System.Drawing.Point(130, 32);
            this.txtRede.Name = "txtRede";
            this.txtRede.Size = new System.Drawing.Size(88, 20);
            this.txtRede.TabIndex = 58;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(14, 32);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(111, 20);
            this.txtIP.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Interface";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Rede";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "IP";
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
            this.label2.TabIndex = 70;
            this.label2.Text = "Interfaces";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // dataGridView1IP
            // 
            this.dataGridView1IP.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1IP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1IP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1IP.Location = new System.Drawing.Point(14, 191);
            this.dataGridView1IP.Name = "dataGridView1IP";
            this.dataGridView1IP.Size = new System.Drawing.Size(721, 417);
            this.dataGridView1IP.TabIndex = 78;
            this.dataGridView1IP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1IP_CellClick);
            // 
            // EnderecosIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(747, 620);
            this.Controls.Add(this.dataGridView1IP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnderecosIP";
            this.Text = "Interfaces";
            this.Load += new System.EventHandler(this.EnderecosIP_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1IP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1IP;
        private System.Windows.Forms.Button btnLimparKeep;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagarRota;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox editAtiva;
        private System.Windows.Forms.Button btnCriarEditar;
        private System.Windows.Forms.TextBox txtRede;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboInterfaces;
        private System.Windows.Forms.Label labelID;
    }
}