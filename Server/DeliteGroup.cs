using System;
using System.Windows.Forms;

namespace Server
{
    public partial class DeliteGroup : Form
    {
        public DeliteGroup()
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
        private void button1_Click(object sender, EventArgs e)
        {
            SqlWork sqlWork = new SqlWork();
            string GroupName = listBox1.SelectedItem.ToString();
            SqlWork.DeleteTable(sqlWork.StringSqlConn, GroupName);
            this.Close();
        }
    }
}