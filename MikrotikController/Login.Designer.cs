namespace MikrotikController
{
    partial class Login
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
            this.panelTopoLogin = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1Mikrotik = new System.Windows.Forms.DataGridView();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.PasswordBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panelTopoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Mikrotik)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopoLogin
            // 
            this.panelTopoLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTopoLogin.Controls.Add(this.button1);
            this.panelTopoLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopoLogin.Location = new System.Drawing.Point(0, 0);
            this.panelTopoLogin.Name = "panelTopoLogin";
            this.panelTopoLogin.Size = new System.Drawing.Size(731, 38);
            this.panelTopoLogin.TabIndex = 54;
            this.panelTopoLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopoLogin_MouseDown);
            this.panelTopoLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopoLogin_MouseMove);
            this.panelTopoLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopoLogin_MouseUp);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1Mikrotik
            // 
            this.dataGridView1Mikrotik.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1Mikrotik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1Mikrotik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Mikrotik.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1Mikrotik.Name = "dataGridView1Mikrotik";
            this.dataGridView1Mikrotik.Size = new System.Drawing.Size(707, 225);
            this.dataGridView1Mikrotik.TabIndex = 55;
            this.dataGridView1Mikrotik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1Mikrotik_CellClick);
            this.dataGridView1Mikrotik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1Mikrotik_CellContentClick);
            this.dataGridView1Mikrotik.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1Mikrotik_CellFormatting);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.button4);
            this.panelLogin.Controls.Add(this.button3);
            this.panelLogin.Controls.Add(this.PasswordBtn);
            this.panelLogin.Controls.Add(this.label17);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.txtIP);
            this.panelLogin.Controls.Add(this.label11);
            this.panelLogin.Controls.Add(this.label12);
            this.panelLogin.Controls.Add(this.button2);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.label10);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Location = new System.Drawing.Point(0, 38);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(731, 158);
            this.panelLogin.TabIndex = 56;
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.button3.Location = new System.Drawing.Point(553, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 30);
            this.button3.TabIndex = 42;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PasswordBtn
            // 
            this.PasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordBtn.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PasswordBtn.Location = new System.Drawing.Point(422, 80);
            this.PasswordBtn.Name = "PasswordBtn";
            this.PasswordBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordBtn.Size = new System.Drawing.Size(56, 24);
            this.PasswordBtn.TabIndex = 41;
            this.PasswordBtn.Text = "Mostrar";
            this.PasswordBtn.UseVisualStyleBackColor = true;
            this.PasswordBtn.Click += new System.EventHandler(this.PasswordBtn_Click);
            this.PasswordBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button4_MouseClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label17.Location = new System.Drawing.Point(11, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 16);
            this.label17.TabIndex = 39;
            this.label17.Text = "Login";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(211, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(142, 20);
            this.txtUsername.TabIndex = 38;
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Location = new System.Drawing.Point(32, 56);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(142, 20);
            this.txtIP.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label11.Location = new System.Drawing.Point(257, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "User:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label12.Location = new System.Drawing.Point(85, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Ip";
            // 
            // button2
            // 
            this.button2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.button2.Location = new System.Drawing.Point(553, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Entrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(381, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 20);
            this.txtPassword.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label10.Location = new System.Drawing.Point(415, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 61);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Software desenvolvido por\r\nAndré Jorge | Gabriel Neves\r\n2204019  |  2200495";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.button4.Location = new System.Drawing.Point(553, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 30);
            this.button4.TabIndex = 43;
            this.button4.Text = "Remover";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(731, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1Mikrotik);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelTopoLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelTopoLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Mikrotik)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopoLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1Mikrotik;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PasswordBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}