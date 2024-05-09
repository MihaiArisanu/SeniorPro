using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorPro
{
    public partial class Vorbim : Form
    {
        int utilizator;
        string nume;
        string txt = "Introdu textul dorit!";

        public Vorbim(int a, string b)
        {
            InitializeComponent();

            utilizator = a;
            nume = b;

            txtChat.Text = txt;
            txtChat.Click += txtChat_Click;
            txtChat.Leave += txtChat_Leave;
        }

        private void txtChat_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChat.Text))
            {
                txtChat.Text = txt;
            }
        }

        private void txtChat_Click(object sender, EventArgs e)
        {
            if (txtChat.Text == txt)
            {
                txtChat.Text = "";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            new Main(utilizator, nume).Show();
        }
    }
}
