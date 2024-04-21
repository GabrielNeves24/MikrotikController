namespace MikrotikController
{
    partial class BridgeConfigurar
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
            this.listagemBridges = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.newBridgeNameTextBox = new System.Windows.Forms.TextBox();
            this.btnCriarBrigde = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxDeleteBrigde = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemoverBrigde = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listagemBridges
            // 
            this.listagemBridges.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listagemBridges.BackColor = System.Drawing.Color.Azure;
            this.listagemBridges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listagemBridges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listagemBridges.Location = new System.Drawing.Point(19, 377);
            this.listagemBridges.Margin = new System.Windows.Forms.Padding(10);
            this.listagemBridges.Multiline = true;
            this.listagemBridges.Name = "listagemBridges";
            this.listagemBridges.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listagemBridges.Size = new System.Drawing.Size(709, 224);
            this.listagemBridges.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 38);
            this.panel1.TabIndex = 53;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.newBridgeNameTextBox);
            this.panel2.Controls.Add(this.btnCriarBrigde);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 67);
            this.panel2.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nome";
            // 
            // newBridgeNameTextBox
            // 
            this.newBridgeNameTextBox.Location = new System.Drawing.Point(69, 24);
            this.newBridgeNameTextBox.Name = "newBridgeNameTextBox";
            this.newBridgeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.newBridgeNameTextBox.TabIndex = 37;
            // 
            // btnCriarBrigde
            // 
            this.btnCriarBrigde.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriarBrigde.FlatAppearance.BorderSize = 0;
            this.btnCriarBrigde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarBrigde.Location = new System.Drawing.Point(234, 22);
            this.btnCriarBrigde.Name = "btnCriarBrigde";
            this.btnCriarBrigde.Size = new System.Drawing.Size(148, 23);
            this.btnCriarBrigde.TabIndex = 36;
            this.btnCriarBrigde.Text = "Criar";
            this.btnCriarBrigde.UseVisualStyleBackColor = false;
            this.btnCriarBrigde.Click += new System.EventHandler(this.btnCriarBrigde_Click_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(747, 27);
            this.label4.TabIndex = 70;
            this.label4.Text = "Adicionar Bridge";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxDeleteBrigde);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnRemoverBrigde);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 69);
            this.panel3.TabIndex = 73;
            // 
            // comboBoxDeleteBrigde
            // 
            this.comboBoxDeleteBrigde.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxDeleteBrigde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleteBrigde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDeleteBrigde.FormattingEnabled = true;
            this.comboBoxDeleteBrigde.Location = new System.Drawing.Point(69, 26);
            this.comboBoxDeleteBrigde.Name = "comboBoxDeleteBrigde";
            this.comboBoxDeleteBrigde.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDeleteBrigde.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Nome";
            // 
            // btnRemoverBrigde
            // 
            this.btnRemoverBrigde.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoverBrigde.FlatAppearance.BorderSize = 0;
            this.btnRemoverBrigde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverBrigde.Location = new System.Drawing.Point(234, 25);
            this.btnRemoverBrigde.Name = "btnRemoverBrigde";
            this.btnRemoverBrigde.Size = new System.Drawing.Size(148, 23);
            this.btnRemoverBrigde.TabIndex = 41;
            this.btnRemoverBrigde.Text = "Remover";
            this.btnRemoverBrigde.UseVisualStyleBackColor = false;
            this.btnRemoverBrigde.Click += new System.EventHandler(this.btnRemoverBrigde_Click_1);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(747, 27);
            this.label3.TabIndex = 72;
            this.label3.Text = "Remover Bridge";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // BridgeConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(747, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listagemBridges);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BridgeConfigurar";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox listagemBridges;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newBridgeNameTextBox;
        private System.Windows.Forms.Button btnCriarBrigde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxDeleteBrigde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemoverBrigde;
        private System.Windows.Forms.Label label3;
    }
}