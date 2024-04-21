namespace MikrotikController
{
    partial class RotasEstaticas
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
            this.dataGridView1Rotas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editDistancia = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.btnLimparKeep = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagarRota = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.editAtiva = new System.Windows.Forms.CheckBox();
            this.btnCriarEditar = new System.Windows.Forms.Button();
            this.editGateway = new System.Windows.Forms.TextBox();
            this.editIPDestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Rotas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1Rotas
            // 
            this.dataGridView1Rotas.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1Rotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1Rotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Rotas.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1Rotas.Name = "dataGridView1Rotas";
            this.dataGridView1Rotas.Size = new System.Drawing.Size(723, 399);
            this.dataGridView1Rotas.TabIndex = 78;
            this.dataGridView1Rotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1Rotas_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 38);
            this.panel1.TabIndex = 79;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.editDistancia);
            this.panel3.Controls.Add(this.labelID);
            this.panel3.Controls.Add(this.btnLimparKeep);
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Controls.Add(this.btnApagarRota);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.editAtiva);
            this.panel3.Controls.Add(this.btnCriarEditar);
            this.panel3.Controls.Add(this.editGateway);
            this.panel3.Controls.Add(this.editIPDestino);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 138);
            this.panel3.TabIndex = 81;
            // 
            // editDistancia
            // 
            this.editDistancia.Location = new System.Drawing.Point(378, 36);
            this.editDistancia.Name = "editDistancia";
            this.editDistancia.Size = new System.Drawing.Size(83, 20);
            this.editDistancia.TabIndex = 53;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(16, 104);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 52;
            // 
            // btnLimparKeep
            // 
            this.btnLimparKeep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparKeep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparKeep.FlatAppearance.BorderSize = 0;
            this.btnLimparKeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparKeep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparKeep.Location = new System.Drawing.Point(565, 69);
            this.btnLimparKeep.Name = "btnLimparKeep";
            this.btnLimparKeep.Size = new System.Drawing.Size(170, 23);
            this.btnLimparKeep.TabIndex = 51;
            this.btnLimparKeep.Text = "Limpar e Manter Dados";
            this.btnLimparKeep.UseVisualStyleBackColor = false;
            this.btnLimparKeep.Click += new System.EventHandler(this.btnLimparKeep_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(377, 69);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(170, 23);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnApagarRota
            // 
            this.btnApagarRota.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnApagarRota.FlatAppearance.BorderSize = 0;
            this.btnApagarRota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarRota.Location = new System.Drawing.Point(196, 69);
            this.btnApagarRota.Name = "btnApagarRota";
            this.btnApagarRota.Size = new System.Drawing.Size(170, 23);
            this.btnApagarRota.TabIndex = 49;
            this.btnApagarRota.Text = "Apagar";
            this.btnApagarRota.UseVisualStyleBackColor = false;
            this.btnApagarRota.Click += new System.EventHandler(this.btnApagarRota_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(477, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Desativada";
            // 
            // editAtiva
            // 
            this.editAtiva.AutoSize = true;
            this.editAtiva.Location = new System.Drawing.Point(498, 39);
            this.editAtiva.Name = "editAtiva";
            this.editAtiva.Size = new System.Drawing.Size(15, 14);
            this.editAtiva.TabIndex = 47;
            this.editAtiva.UseVisualStyleBackColor = true;
            // 
            // btnCriarEditar
            // 
            this.btnCriarEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriarEditar.FlatAppearance.BorderSize = 0;
            this.btnCriarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarEditar.Location = new System.Drawing.Point(12, 69);
            this.btnCriarEditar.Name = "btnCriarEditar";
            this.btnCriarEditar.Size = new System.Drawing.Size(170, 23);
            this.btnCriarEditar.TabIndex = 46;
            this.btnCriarEditar.Text = "Criar";
            this.btnCriarEditar.UseVisualStyleBackColor = false;
            this.btnCriarEditar.Click += new System.EventHandler(this.btnCriarEditar_Click);
            // 
            // editGateway
            // 
            this.editGateway.Location = new System.Drawing.Point(196, 36);
            this.editGateway.Name = "editGateway";
            this.editGateway.Size = new System.Drawing.Size(170, 20);
            this.editGateway.TabIndex = 42;
            // 
            // editIPDestino
            // 
            this.editIPDestino.Location = new System.Drawing.Point(12, 36);
            this.editIPDestino.Name = "editIPDestino";
            this.editIPDestino.Size = new System.Drawing.Size(170, 20);
            this.editIPDestino.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Distancia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Gateway";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "IP Destino";
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
            this.label12.TabIndex = 80;
            this.label12.Text = "Adicionar/Editar Rotas";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // RotasEstaticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(747, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1Rotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RotasEstaticas";
            this.Text = "RotasEstaticas";
            this.Load += new System.EventHandler(this.RotasEstaticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Rotas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1Rotas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnLimparKeep;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagarRota;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox editAtiva;
        private System.Windows.Forms.Button btnCriarEditar;
        private System.Windows.Forms.TextBox editGateway;
        private System.Windows.Forms.TextBox editIPDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox editDistancia;
    }
}