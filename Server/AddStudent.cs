using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Server
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            SqlWork sqlWork = new SqlWork();
            string groups = SqlWork.Data(sqlWork.StringSqlConn);
            string[] array = groups.Split(';');
            foreach (var VARIABLE in array)
            {
                comboBox1.Items.Add(VARIABLE);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlstr = new SqlWork().StringSqlConn;
            SqlConnection connection = new SqlConnection(sqlstr);
            string sqlCommand = "SELECT * FROM " + comboBox1.SelectedItem.ToString();
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns["st_id"].Visible = false;
            dataGridView1.Columns["st_Name"].HeaderText = "Имя";
            dataGridView1.Columns["st_SecName"].HeaderText = "Фамилия";
            dataGridView1.Columns["st_Login"].HeaderText = "Логин";
            dataGridView1.Columns["st_Pass"].HeaderText = "Пароль";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["st_Name"].Value.ToString();
                textBox2.Text = row.Cells["st_SecName"].Value.ToString();
                textBox3.Text = row.Cells["st_Login"].Value.ToString();
                textBox4.Text = row.Cells["st_Pass"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            string sqlstr = new SqlWork().StringSqlConn;
            SqlConnection connection = new SqlConnection(sqlstr);
            string sqlCommand = "SELECT * FROM " + comboBox1.SelectedItem.ToString();
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                row.Cells["st_Name"].Value = textBox1.Text;
                row.Cells["st_SecName"].Value = textBox2.Text;
                row.Cells["st_Login"].Value = textBox3.Text;
                row.Cells["st_Pass"].Value = textBox4.Text;
            }
            dataGridView1.EndEdit();
            adapter.Update(table);
            MessageBox.Show("okey");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string GroupName = comboBox1.SelectedItem.ToString();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string id = row.Cells["st_id"].Value.ToString();
            SqlWork sqlWork = new SqlWork();
            SqlWork.DeleteRow(sqlWork.StringSqlConn, GroupName, id);
            MessageBox.Show("Строка успешно удалена!");
            Loaddata();
        }

        public void Loaddata()
        {
            string sqlstr = new SqlWork().StringSqlConn;
            SqlConnection connection = new SqlConnection(sqlstr);
            string sqlCommand = "SELECT * FROM " + comboBox1.SelectedItem.ToString();
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GroupName = comboBox1.SelectedItem.ToString();
            string st_Name = textBox1.Text;
            string st_SecName = textBox2.Text;
            string st_Login = textBox3.Text;
            string st_Pass = textBox4.Text;
            SqlWork sqlWork = new SqlWork();
            SqlWork.InsertDataToTable(sqlWork.StringSqlConn, GroupName, st_Name, st_SecName, st_Login, st_Pass);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Loaddata();
        }
    }
}