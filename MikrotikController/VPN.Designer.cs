namespace MikrotikController
{
    partial class VPN
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeTunel = new System.Windows.Forms.TextBox();
            this.btnCriarTunel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listagemTuneis = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordIdentidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntCriarIdentidade = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboPeer = new System.Windows.Forms.ComboBox();
            this.bntMostrarPWD = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboPeerPolicy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIPLocal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bntCriarPolitica = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIPDestino = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 38);
            this.panel1.TabIndex = 39;
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
            this.button1.Location = new System.Drawing.Point(694, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNomeTunel);
            this.panel2.Controls.Add(this.btnCriarTunel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 74);
            this.panel2.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Endereço Público Destino";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(365, 21);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(130, 20);
            this.txtEndereco.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome";
            // 
            // txtNomeTunel
            // 
            this.txtNomeTunel.Location = new System.Drawing.Point(62, 20);
            this.txtNomeTunel.Name = "txtNomeTunel";
            this.txtNomeTunel.Size = new System.Drawing.Size(154, 20);
            this.txtNomeTunel.TabIndex = 40;
            // 
            // btnCriarTunel
            // 
            this.btnCriarTunel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriarTunel.FlatAppearance.BorderSize = 0;
            this.btnCriarTunel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarTunel.Location = new System.Drawing.Point(575, 12);
            this.btnCriarTunel.Name = "btnCriarTunel";
            this.btnCriarTunel.Size = new System.Drawing.Size(148, 40);
            this.btnCriarTunel.TabIndex = 42;
            this.btnCriarTunel.Text = "Criar";
            this.btnCriarTunel.UseVisualStyleBackColor = false;
            this.btnCriarTunel.Click += new System.EventHandler(this.btnCriarTunel_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(731, 27);
            this.label2.TabIndex = 72;
            this.label2.Text = "Criar Tunel";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // listagemTuneis
            // 
            this.listagemTuneis.BackColor = System.Drawing.Color.Azure;
            this.listagemTuneis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listagemTuneis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listagemTuneis.Location = new System.Drawing.Point(11, 368);
            this.listagemTuneis.Margin = new System.Windows.Forms.Padding(10);
            this.listagemTuneis.Multiline = true;
            this.listagemTuneis.Name = "listagemTuneis";
            this.listagemTuneis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listagemTuneis.Size = new System.Drawing.Size(709, 205);
            this.listagemTuneis.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bntMostrarPWD);
            this.panel3.Controls.Add(this.comboPeer);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPasswordIdentidade);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.bntCriarIdentidade);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 67);
            this.panel3.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Password";
            // 
            // txtPasswordIdentidade
            // 
            this.txtPasswordIdentidade.Location = new System.Drawing.Point(290, 21);
            this.txtPasswordIdentidade.Name = "txtPasswordIdentidade";
            this.txtPasswordIdentidade.Size = new System.Drawing.Size(130, 20);
            this.txtPasswordIdentidade.TabIndex = 44;
            this.txtPasswordIdentidade.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Peer";
            // 
            // bntCriarIdentidade
            // 
            this.bntCriarIdentidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntCriarIdentidade.FlatAppearance.BorderSize = 0;
            this.bntCriarIdentidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCriarIdentidade.Location = new System.Drawing.Point(575, 12);
            this.bntCriarIdentidade.Name = "bntCriarIdentidade";
            this.bntCriarIdentidade.Size = new System.Drawing.Size(148, 40);
            this.bntCriarIdentidade.TabIndex = 45;
            this.bntCriarIdentidade.Text = "Criar";
            this.bntCriarIdentidade.UseVisualStyleBackColor = false;
            this.bntCriarIdentidade.Click += new System.EventHandler(this.bntCriarIdentidade_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(731, 27);
            this.label6.TabIndex = 80;
            this.label6.Text = "Criar Identidade";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // comboPeer
            // 
            this.comboPeer.FormattingEnabled = true;
            this.comboPeer.Location = new System.Drawing.Point(62, 20);
            this.comboPeer.Name = "comboPeer";
            this.comboPeer.Size = new System.Drawing.Size(154, 21);
            this.comboPeer.TabIndex = 43;
            // 
            // bntMostrarPWD
            // 
            this.bntMostrarPWD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntMostrarPWD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntMostrarPWD.Location = new System.Drawing.Point(427, 18);
            this.bntMostrarPWD.Name = "bntMostrarPWD";
            this.bntMostrarPWD.Size = new System.Drawing.Size(73, 23);
            this.bntMostrarPWD.TabIndex = 100;
            this.bntMostrarPWD.Text = "Mostrar";
            this.bntMostrarPWD.UseVisualStyleBackColor = false;
            this.bntMostrarPWD.Click += new System.EventHandler(this.bntMostrarPWD_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtIPDestino);
            this.panel4.Controls.Add(this.comboPeerPolicy);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtIPLocal);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.bntCriarPolitica);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(731, 67);
            this.panel4.TabIndex = 83;
            // 
            // comboPeerPolicy
            // 
            this.comboPeerPolicy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboPeerPolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPeerPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPeerPolicy.FormattingEnabled = true;
            this.comboPeerPolicy.Location = new System.Drawing.Point(62, 20);
            this.comboPeerPolicy.Name = "comboPeerPolicy";
            this.comboPeerPolicy.Size = new System.Drawing.Size(154, 21);
            this.comboPeerPolicy.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "IP Local";
            // 
            // txtIPLocal
            // 
            this.txtIPLocal.Location = new System.Drawing.Point(284, 12);
            this.txtIPLocal.Name = "txtIPLocal";
            this.txtIPLocal.Size = new System.Drawing.Size(130, 20);
            this.txtIPLocal.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Peer";
            // 
            // bntCriarPolitica
            // 
            this.bntCriarPolitica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntCriarPolitica.FlatAppearance.BorderSize = 0;
            this.bntCriarPolitica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCriarPolitica.Location = new System.Drawing.Point(575, 12);
            this.bntCriarPolitica.Name = "bntCriarPolitica";
            this.bntCriarPolitica.Size = new System.Drawing.Size(148, 40);
            this.bntCriarPolitica.TabIndex = 49;
            this.bntCriarPolitica.Text = "Criar";
            this.bntCriarPolitica.UseVisualStyleBackColor = false;
            this.bntCriarPolitica.Click += new System.EventHandler(this.bntCriarPolitica_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(731, 27);
            this.label9.TabIndex = 82;
            this.label9.Text = "Criar Politica";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "IP Destino";
            // 
            // txtIPDestino
            // 
            this.txtIPDestino.Location = new System.Drawing.Point(284, 38);
            this.txtIPDestino.Name = "txtIPDestino";
            this.txtIPDestino.Size = new System.Drawing.Size(130, 20);
            this.txtIPDestino.TabIndex = 48;
            // 
            // VPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(731, 581);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listagemTuneis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VPN";
            this.Text = "VPN";
            this.Load += new System.EventHandler(this.VPN_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeTunel;
        private System.Windows.Forms.Button btnCriarTunel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox listagemTuneis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboPeer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasswordIdentidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntCriarIdentidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntMostrarPWD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboPeerPolicy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIPLocal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bntCriarPolitica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIPDestino;
    }
}