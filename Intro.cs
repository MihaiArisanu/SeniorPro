using System;
using System.Windows.Forms;

namespace SeniorPro
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inregistrare form = new inregistrare();
            form.Show();
            this.Hide();
        }
    }
}
