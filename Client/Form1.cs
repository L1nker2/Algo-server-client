using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client
{
    public class Student
    {
        public int st_id { get; set; }
        public string st_name { get; set; }
        public string st_secname { get; set; }
        public string st_login { get; set; }
        public string st_pass { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://learn.algoritmika.org");
            string json = null;
            try
            {
                await Task.Run(() => CollectData(out json));
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["st_id"].Visible = false;
                dataGridView1.Columns["st_Name"].HeaderText = "Имя";
                dataGridView1.Columns["st_SecName"].HeaderText = "Фамилия";
                dataGridView1.Columns["st_Login"].HeaderText = "Логин";
                dataGridView1.Columns["st_Pass"].HeaderText = "Пароль";
                dataGridView1.Enabled = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Возникла какая то ошибка! \n Описание ошибки:\n{exception}");
            }
        }

        public void CollectData(out string json)
        {
            TcpClient client = new TcpClient("127.0.0.1", 8888);
            byte[] buffer = new byte[1024];
            int bytesCount = client.GetStream().Read(buffer, 0, buffer.Length);
            json = Encoding.UTF8.GetString(buffer, 0, bytesCount);
        }
    }
}