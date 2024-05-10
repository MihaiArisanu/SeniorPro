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
            new login().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new inregistrare().Show();
            Hide();
        }
    }
}