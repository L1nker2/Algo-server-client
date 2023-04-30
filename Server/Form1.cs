using System;
using System.Timers;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelView.Controls.Add(childForm);
            panelView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Start_Lesson());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AddGroup());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStudent());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new DeliteGroup());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Кириллов Евгений\nGithub: github.com/L1nker2\n Telegram: @L1NKERZ1");
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            time_Label.Text = DateTime.Now.ToString();
        }
    }
}