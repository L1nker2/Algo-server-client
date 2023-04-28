using System;
using System.Windows.Forms;

namespace Server
{
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlWork sqlWork = new SqlWork();
            string GroupName = textBox1.Text;
            SqlWork.CreateTable(sqlWork.StringSqlConn, GroupName);
            this.Close();
        }
    }
}