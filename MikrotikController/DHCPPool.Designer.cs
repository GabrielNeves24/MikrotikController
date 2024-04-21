namespace MikrotikController
{
    partial class DHCPPool
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePool = new System.Windows.Forms.TextBox();
            this.btnCriarPool = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listagemPools = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEditPool = new System.Windows.Forms.TextBox();
            this.comboID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIP2Edit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIP1Edit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditarPool = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.comboBoxNomePoolsDelete = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemoverPool = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtIP2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtIP1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNomePool);
            this.panel2.Controls.Add(this.btnCriarPool);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 67);
            this.panel2.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "a";
            // 
            // txtIP2
            // 
            this.txtIP2.Location = new System.Drawing.Point(460, 21);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(100, 20);
            this.txtIP2.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "IP de:";
            // 
            // txtIP1
            // 
            this.txtIP1.Location = new System.Drawing.Point(341, 21);
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(100, 20);
            this.txtIP1.TabIndex = 42;
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
            // txtNomePool
            // 
            this.txtNomePool.Location = new System.Drawing.Point(62, 20);
            this.txtNomePool.Name = "txtNomePool";
            this.txtNomePool.Size = new System.Drawing.Size(219, 20);
            this.txtNomePool.TabIndex = 40;
            // 
            // btnCriarPool
            // 
            this.btnCriarPool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriarPool.FlatAppearance.BorderSize = 0;
            this.btnCriarPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPool.Location = new System.Drawing.Point(575, 12);
            this.btnCriarPool.Name = "btnCriarPool";
            this.btnCriarPool.Size = new System.Drawing.Size(148, 40);
            this.btnCriarPool.TabIndex = 39;
            this.btnCriarPool.Text = "Criar";
            this.btnCriarPool.UseVisualStyleBackColor = false;
            this.btnCriarPool.Click += new System.EventHandler(this.btnCriarPool_Click);
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
            this.label2.Text = "Criar Pool";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // listagemPools
            // 
            this.listagemPools.BackColor = System.Drawing.Color.Azure;
            this.listagemPools.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listagemPools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listagemPools.Location = new System.Drawing.Point(19, 342);
            this.listagemPools.Margin = new System.Windows.Forms.Padding(10);
            this.listagemPools.Multiline = true;
            this.listagemPools.Name = "listagemPools";
            this.listagemPools.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listagemPools.Size = new System.Drawing.Size(709, 259);
            this.listagemPools.TabIndex = 78;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEditPool);
            this.panel3.Controls.Add(this.comboID);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtIP2Edit);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtIP1Edit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnEditarPool);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 58);
            this.panel3.TabIndex = 80;
            // 
            // txtEditPool
            // 
            this.txtEditPool.Location = new System.Drawing.Point(157, 23);
            this.txtEditPool.Name = "txtEditPool";
            this.txtEditPool.Size = new System.Drawing.Size(139, 20);
            this.txtEditPool.TabIndex = 52;
            // 
            // comboID
            // 
            this.comboID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboID.FormattingEnabled = true;
            this.comboID.Location = new System.Drawing.Point(61, 22);
            this.comboID.Name = "comboID";
            this.comboID.Size = new System.Drawing.Size(56, 21);
            this.comboID.TabIndex = 51;
            this.comboID.SelectedIndexChanged += new System.EventHandler(this.comboId_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "a";
            // 
            // txtIP2Edit
            // 
            this.txtIP2Edit.Location = new System.Drawing.Point(460, 23);
            this.txtIP2Edit.Name = "txtIP2Edit";
            this.txtIP2Edit.Size = new System.Drawing.Size(100, 20);
            this.txtIP2Edit.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "IP de:";
            // 
            // txtIP1Edit
            // 
            this.txtIP1Edit.Location = new System.Drawing.Point(341, 23);
            this.txtIP1Edit.Name = "txtIP1Edit";
            this.txtIP1Edit.Size = new System.Drawing.Size(100, 20);
            this.txtIP1Edit.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nome";
            // 
            // btnEditarPool
            // 
            this.btnEditarPool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditarPool.FlatAppearance.BorderSize = 0;
            this.btnEditarPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPool.Location = new System.Drawing.Point(575, 8);
            this.btnEditarPool.Name = "btnEditarPool";
            this.btnEditarPool.Size = new System.Drawing.Size(148, 40);
            this.btnEditarPool.TabIndex = 39;
            this.btnEditarPool.Text = "Editar";
            this.btnEditarPool.UseVisualStyleBackColor = false;
            this.btnEditarPool.Click += new System.EventHandler(this.btnEditarPool_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(747, 27);
            this.label4.TabIndex = 79;
            this.label4.Text = "Editar Pool";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelID);
            this.panel4.Controls.Add(this.comboBoxNomePoolsDelete);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btnRemoverPool);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(747, 60);
            this.panel4.TabIndex = 82;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(288, 20);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 43;
            // 
            // comboBoxNomePoolsDelete
            // 
            this.comboBoxNomePoolsDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxNomePoolsDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomePoolsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNomePoolsDelete.FormattingEnabled = true;
            this.comboBoxNomePoolsDelete.Location = new System.Drawing.Point(62, 16);
            this.comboBoxNomePoolsDelete.Name = "comboBoxNomePoolsDelete";
            this.comboBoxNomePoolsDelete.Size = new System.Drawing.Size(220, 21);
            this.comboBoxNomePoolsDelete.TabIndex = 42;
            this.comboBoxNomePoolsDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomePoolsDelete_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Nome";
            // 
            // btnRemoverPool
            // 
            this.btnRemoverPool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoverPool.FlatAppearance.BorderSize = 0;
            this.btnRemoverPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverPool.Location = new System.Drawing.Point(575, 8);
            this.btnRemoverPool.Name = "btnRemoverPool";
            this.btnRemoverPool.Size = new System.Drawing.Size(148, 40);
            this.btnRemoverPool.TabIndex = 39;
            this.btnRemoverPool.Text = "Remover";
            this.btnRemoverPool.UseVisualStyleBackColor = false;
            this.btnRemoverPool.Click += new System.EventHandler(this.btnRemoverPool_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(747, 27);
            this.label12.TabIndex = 81;
            this.label12.Text = "Remover Pool";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // DHCPPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(747, 620);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listagemPools);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DHCPPool";
            this.Text = "DHCPCliente";
            this.Load += new System.EventHandler(this.DHCPPool_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox listagemPools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePool;
        private System.Windows.Forms.Button btnCriarPool;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIP1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditarPool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIP2Edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIP1Edit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxNomePoolsDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemoverPool;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditPool;
    }
}