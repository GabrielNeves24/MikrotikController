namespace MikrotikController
{
    partial class DNSServidor
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
            this.listagemServersDNS = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServers = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEstadoONOFF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listagemServersDNS
            // 
            this.listagemServersDNS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listagemServersDNS.BackColor = System.Drawing.Color.Azure;
            this.listagemServersDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listagemServersDNS.Location = new System.Drawing.Point(12, 442);
            this.listagemServersDNS.Margin = new System.Windows.Forms.Padding(10);
            this.listagemServersDNS.Multiline = true;
            this.listagemServersDNS.Name = "listagemServersDNS";
            this.listagemServersDNS.Size = new System.Drawing.Size(716, 172);
            this.listagemServersDNS.TabIndex = 87;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 38);
            this.panel1.TabIndex = 84;
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
            // labelEstado
            // 
            this.labelEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(0, 38);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(747, 42);
            this.labelEstado.TabIndex = 88;
            this.labelEstado.Text = "label1";
            this.labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtServers);
            this.panel2.Controls.Add(this.btnCriar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 70);
            this.panel2.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Servers";
            // 
            // txtServers
            // 
            this.txtServers.Location = new System.Drawing.Point(69, 28);
            this.txtServers.Name = "txtServers";
            this.txtServers.Size = new System.Drawing.Size(252, 20);
            this.txtServers.TabIndex = 44;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Location = new System.Drawing.Point(580, 15);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(148, 45);
            this.btnCriar.TabIndex = 39;
            this.btnCriar.Text = "Editar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 27);
            this.label2.TabIndex = 89;
            this.label2.Text = "Configurar";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // btnEstadoONOFF
            // 
            this.btnEstadoONOFF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEstadoONOFF.FlatAppearance.BorderSize = 0;
            this.btnEstadoONOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoONOFF.Location = new System.Drawing.Point(12, 195);
            this.btnEstadoONOFF.Name = "btnEstadoONOFF";
            this.btnEstadoONOFF.Size = new System.Drawing.Size(716, 33);
            this.btnEstadoONOFF.TabIndex = 91;
            this.btnEstadoONOFF.Text = "Desligar";
            this.btnEstadoONOFF.UseVisualStyleBackColor = false;
            this.btnEstadoONOFF.Click += new System.EventHandler(this.btnEstadoONOFF_Click);
            // 
            // DNSServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(747, 620);
            this.Controls.Add(this.btnEstadoONOFF);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.listagemServersDNS);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DNSServidor";
            this.Text = "DNSServidor";
            this.Load += new System.EventHandler(this.DNSServidor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox listagemServersDNS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServers;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEstadoONOFF;
    }
}