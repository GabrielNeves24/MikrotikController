using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MikrotikController.Form1;

namespace MikrotikController
{
    public partial class Login : Form
    {
        int mov;
        int movX;
        int movY;
        private readonly HttpClient client;
        private string apiURL = MikrotikController.Form1.Globals.apiURLUsar; 
        private string apiPassword = MikrotikController.Form1.Globals.apiPasswordUsar; 
        private string apiUsername = MikrotikController.Form1.Globals.apiUsernameUsar;
        private Form1 form1;
        public Login()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{apiUsername}:{apiPassword}")));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private void dataGridView1Mikrotik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            dataGridView1Mikrotik.Columns.Add("IP", "IP");
            dataGridView1Mikrotik.Columns.Add("User", "User");
            dataGridView1Mikrotik.Columns.Add("Password", "Password");
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = dir + @"\LoginsUsers.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Ficheiro não encontrado");
                return;
            }
            else
            {
                string fileContents = File.ReadAllText(filePath);
                string[] rows = fileContents.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string row in rows)
                {
                    string[] cells = row.Split(':');
                    if (cells.Length == 3)
                    {
                        int rowIndex = dataGridView1Mikrotik.Rows.Add(cells);
                        var passwordCell = dataGridView1Mikrotik.Rows[rowIndex].Cells["Password"];
                        //password
                        passwordCell.Value = cells[2];
                        passwordCell.Style.NullValue = "****";
                        passwordCell.Style.DataSourceNullValue = "****";
                    }
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (txtIP == null && txtPassword == null && txtUsername == null)
            {
                MessageBox.Show("Introduza todos os dados");
            }
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = dir + @"\LoginsUsers.txt";
            if (File.Exists(filePath) == false)
            {
                MessageBox.Show("A criar novo ficheiro");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"{txtIP.Text}:{txtUsername.Text}:{txtPassword.Text}");
                    MessageBox.Show("Criado e Guardado com sucesso");
                }
            }
            else
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            string str = line;
                            string[] parts = str.Split(':');

                            if (parts[0] == txtIP.Text && parts[1] == txtUsername.Text && parts[2] == txtPassword.Text)
                            {
                                string apiUrl2 = string.Format("https://{0}/rest", parts[0]);
                                Globals.apiURLUsar = apiUrl2;
                                Globals.apiUsernameUsar = parts[1];
                                Globals.apiPasswordUsar = parts[2];
                                reloadForm();
                               // if (form1 != null)
                               // {
                               //     form1.Show();
                               //     this.Hide();
                               // }
                               // else
                               // {
                                    form1 = new Form1();
                                    form1.Show();
                                    this.Hide();
                                //}
                            }
                            line = reader.ReadLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro não validar login: {ex.Message}");
                }
            }
        }

        private void reloadForm()
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIP == null && txtPassword == null && txtUsername == null)
            {
                MessageBox.Show("Introduza todos os dados");
                return;
            }
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = dir + @"\LoginsUsers.txt";
            
            if (File.Exists(filePath) == false)
            {
                MessageBox.Show("A criar novo ficheiro");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"{txtIP.Text}:{txtUsername.Text}:{txtPassword.Text}");
                    MessageBox.Show("Criado e Guardado com sucesso");
                }
            }
            else
            {
                string newLine = ($"{txtIP.Text}:{txtUsername.Text}:{txtPassword.Text}");
                string fileContents = File.ReadAllText(filePath);
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string str = line;
                        string[] parts = str.Split(':');

                        if (parts[0] == txtIP.Text && parts[1] == txtUsername.Text && parts[2] == txtPassword.Text)
                        {
                            MessageBox.Show("Dados já existentes");
                            return;
                        }
                        line = reader.ReadLine();
                    }
                }
                DialogResult result = MessageBox.Show("Deseja Guardar os Dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string updatedContents = fileContents + newLine + "\n";
                    File.WriteAllText(filePath, updatedContents);
                    MessageBox.Show("Adicionado com sucesso");
                    dataGridView1Mikrotik.Rows.Clear();
                    string fileContents2 = File.ReadAllText(filePath);
                    string[] rows = fileContents2.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string row in rows)
                    {
                        string[] cells = row.Split(':');
                        if (cells.Length == 3)
                        {
                            int rowIndex = dataGridView1Mikrotik.Rows.Add(cells);
                            var passwordCell = dataGridView1Mikrotik.Rows[rowIndex].Cells["Password"];
                            //password
                            passwordCell.Value = cells[2];
                            passwordCell.Style.NullValue = "****";
                            passwordCell.Style.DataSourceNullValue = "****";
                        }
                    }
                }                
            }
        }

        private void dataGridView1Mikrotik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1Mikrotik.Rows.Count)
            {
                string addressIp = "";
                if (dataGridView1Mikrotik.Rows[rowIndex].Cells["Ip"].Value != null)
                    addressIp = dataGridView1Mikrotik.Rows[rowIndex].Cells["Ip"].Value.ToString();
                else
                    addressIp = "";
                string user = "";
                if (dataGridView1Mikrotik.Rows[rowIndex].Cells["User"].Value != null)
                    user = dataGridView1Mikrotik.Rows[rowIndex].Cells["User"].Value.ToString();
                else
                    user = "";
                string password = "";
                if (dataGridView1Mikrotik.Rows[rowIndex].Cells["Password"].Value != null)
                    password = dataGridView1Mikrotik.Rows[rowIndex].Cells["Password"].Value.ToString();
                else
                    password = "";
                txtIP.Text = addressIp;
                txtPassword.Text = password;
                txtUsername.Text = user;
                Globals.passwordHelper = password;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1Mikrotik_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1Mikrotik.Columns[e.ColumnIndex].Name == "Password")
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void PasswordBtn_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                PasswordBtn.Text = "Esconder";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                PasswordBtn.Text = "Mostrar";
            }
        }

        private void panelTopoLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelTopoLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelTopoLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = dir + @"\LoginsUsers.txt";
            string[] lines = File.ReadAllLines(filePath);
            List<string> updatedLines = new List<string>(lines);

            for (int i = 0; i < updatedLines.Count; i++)
            {
                if (updatedLines[i].Contains(txtIP.Text))
                {
                    updatedLines.RemoveAt(i);
                    i--;
                }
            }

            File.WriteAllLines(filePath, updatedLines);
        }
    }
}
