namespace MikrotikController
{
    partial class DHCPServer
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPollAdress = new System.Windows.Forms.Label();
            this.comboListPool = new System.Windows.Forms.ComboBox();
            this.comboInterfaces = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listagemServersDHCP = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboIDInterface = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.comboListPoolEdit = new System.Windows.Forms.ComboBox();
            this.comboInterfacesEdit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboIdDelete = new System.Windows.Forms.ComboBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 38);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelPollAdress);
            this.panel2.Controls.Add(this.comboListPool);
            this.panel2.Controls.Add(this.comboInterfaces);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCriar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 70);
            this.panel2.TabIndex = 73;
            // 
            // labelPollAdress
            // 
            this.labelPollAdress.AutoSize = true;
            this.labelPollAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPollAdress.Location = new System.Drawing.Point(187, 44);
            this.labelPollAdress.Name = "labelPollAdress";
            this.labelPollAdress.Size = new System.Drawing.Size(0, 13);
            this.labelPollAdress.TabIndex = 48;
            // 
            // comboListPool
            // 
            this.comboListPool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboListPool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboListPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboListPool.FormattingEnabled = true;
            this.comboListPool.Location = new System.Drawing.Point(55, 39);
            this.comboListPool.Name = "comboListPool";
            this.comboListPool.Size = new System.Drawing.Size(126, 21);
            this.comboListPool.TabIndex = 47;
            this.comboListPool.SelectedIndexChanged += new System.EventHandler(this.comboPools_SelectedIndexChanged);
            // 
            // comboInterfaces
            // 
            this.comboInterfaces.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInterfaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboInterfaces.FormattingEnabled = true;
            this.comboInterfaces.Location = new System.Drawing.Point(270, 14);
            this.comboInterfaces.Name = "comboInterfaces";
            this.comboInterfaces.Size = new System.Drawing.Size(126, 21);
            this.comboInterfaces.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(126, 20);
            this.txtNome.TabIndex = 44;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Pool";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Interface";
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Location = new System.Drawing.Point(427, 15);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(148, 45);
            this.btnCriar.TabIndex = 39;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriarPool_Click);
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
            this.label2.TabIndex = 72;
            this.label2.Text = "Adicionar";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // listagemServersDHCP
            // 
            this.listagemServersDHCP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listagemServersDHCP.BackColor = System.Drawing.Color.Azure;
            this.listagemServersDHCP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listagemServersDHCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listagemServersDHCP.Location = new System.Drawing.Point(18, 358);
            this.listagemServersDHCP.Margin = new System.Windows.Forms.Padding(10);
            this.listagemServersDHCP.Multiline = true;
            this.listagemServersDHCP.Name = "listagemServersDHCP";
            this.listagemServersDHCP.Size = new System.Drawing.Size(710, 250);
            this.listagemServersDHCP.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboIDInterface);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.labelEdit);
            this.panel3.Controls.Add(this.comboListPoolEdit);
            this.panel3.Controls.Add(this.comboInterfacesEdit);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtNomeEdit);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 100);
            this.panel3.TabIndex = 81;
            // 
            // comboIDInterface
            // 
            this.comboIDInterface.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboIDInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIDInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboIDInterface.FormattingEnabled = true;
            this.comboIDInterface.Location = new System.Drawing.Point(56, 14);
            this.comboIDInterface.Name = "comboIDInterface";
            this.comboIDInterface.Size = new System.Drawing.Size(126, 21);
            this.comboIDInterface.TabIndex = 50;
            this.comboIDInterface.SelectedIndexChanged += new System.EventHandler(this.comboIDInterface_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "ID";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.Location = new System.Drawing.Point(187, 47);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(0, 13);
            this.labelEdit.TabIndex = 48;
            // 
            // comboListPoolEdit
            // 
            this.comboListPoolEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboListPoolEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboListPoolEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboListPoolEdit.FormattingEnabled = true;
            this.comboListPoolEdit.Location = new System.Drawing.Point(56, 42);
            this.comboListPoolEdit.Name = "comboListPoolEdit";
            this.comboListPoolEdit.Size = new System.Drawing.Size(126, 21);
            this.comboListPoolEdit.TabIndex = 47;
            this.comboListPoolEdit.TextUpdate += new System.EventHandler(this.comboListPoolEdit_TextUpdate);
            // 
            // comboInterfacesEdit
            // 
            this.comboInterfacesEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboInterfacesEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInterfacesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboInterfacesEdit.FormattingEnabled = true;
            this.comboInterfacesEdit.Location = new System.Drawing.Point(56, 70);
            this.comboInterfacesEdit.Name = "comboInterfacesEdit";
            this.comboInterfacesEdit.Size = new System.Drawing.Size(126, 21);
            this.comboInterfacesEdit.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Nome";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNomeEdit
            // 
            this.txtNomeEdit.Location = new System.Drawing.Point(252, 17);
            this.txtNomeEdit.Name = "txtNomeEdit";
            this.txtNomeEdit.Size = new System.Drawing.Size(126, 20);
            this.txtNomeEdit.TabIndex = 44;
            this.txtNomeEdit.TextChanged += new System.EventHandler(this.txtNomeEdit_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Pool";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Interface";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(427, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 45);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(747, 27);
            this.label9.TabIndex = 80;
            this.label9.Text = "Editar";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboIdDelete);
            this.panel4.Controls.Add(this.labelDelete);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnRemover);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(747, 56);
            this.panel4.TabIndex = 83;
            // 
            // comboIdDelete
            // 
            this.comboIdDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboIdDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboIdDelete.FormattingEnabled = true;
            this.comboIdDelete.Location = new System.Drawing.Point(55, 19);
            this.comboIdDelete.Name = "comboIdDelete";
            this.comboIdDelete.Size = new System.Drawing.Size(88, 21);
            this.comboIdDelete.TabIndex = 51;
            this.comboIdDelete.SelectedIndexChanged += new System.EventHandler(this.comboIdDelete_SelectedIndexChanged);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.Location = new System.Drawing.Point(149, 22);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(0, 13);
            this.labelDelete.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "ID";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(427, 15);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(148, 25);
            this.btnRemover.TabIndex = 39;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(0, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(747, 27);
            this.label15.TabIndex = 82;
            this.label15.Text = "Remover";
            this.label15.UseCompatibleTextRendering = true;
            // 
            // DHCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(747, 620);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listagemServersDHCP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DHCPServer";
            this.Text = "DHCPServer";
            this.Load += new System.EventHandler(this.DHCPServer_Load);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox listagemServersDHCP;
        private System.Windows.Forms.ComboBox comboListPool;
        private System.Windows.Forms.ComboBox comboInterfaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelPollAdress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.ComboBox comboListPoolEdit;
        private System.Windows.Forms.ComboBox comboInterfacesEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboIDInterface;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboIdDelete;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label15;
    }
}