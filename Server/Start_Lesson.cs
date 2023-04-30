using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Start_Lesson : Form
    {
        public Start_Lesson()
        {
            InitializeComponent();
            SqlWork sqlWork = new SqlWork();
            string groups = SqlWork.Data(sqlWork.StringSqlConn);
            string[] array = groups.Split(';');
            foreach (var VARIABLE in array)
            {
                listBox1.Items.Add(VARIABLE);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            SqlWork sqlWork = new SqlWork();
            string tableName = listBox1.SelectedItem.ToString();
            string json = SqlWork.GetTableDataAsJson(sqlWork.StringSqlConn, tableName); 
            MessageBox.Show(json);
            Clipboard.SetText(json);
            MyTcpServer server = new MyTcpServer();
            await Task.Run(() => server.Start_server(json));
        }
    }
}