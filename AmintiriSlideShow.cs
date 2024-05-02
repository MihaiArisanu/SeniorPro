using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorPro
{
    public partial class Amintiri : Form
    {
        private SqlConnection con;
        int utilizator;
        string nume;
        List<Imagini> imagini;
        private int index = -1;
        Timer t = new Timer { Interval = 2000 };

        public Amintiri(int a, string b)
        {
            InitializeComponent();

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            utilizator = a;
            nume = b;

            t.Tick += (m, n) =>
            {
                if (index < imagini.Count - 1)
                {
                    progressBar1.Maximum = imagini.Count - 1;
                    index++;
                    progressBar1.Value++;
                    if (progressBar1.Maximum == progressBar1.Value)
                    {
                        btn_inapoi.Enabled = true;
                    }
                    loadForIndex();
                }
            };
            loadImagini();

            t.Start();
        }

        public void loadImagini()
        {
            imagini = new List<Imagini>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM amintiri", con);
            var red = cmd.ExecuteReader();
            while (red.Read())
            {
                imagini.Add(new Imagini
                {
                    CaleFisier = red[1].ToString(),
                });
            }

            if (imagini.Count > 0 && index == -1)
                index = 0;

            loadForIndex();
        }

        public void loadForIndex()
        {
            panel1.BackgroundImage = Image.FromFile(imagini[index].CaleFisier);
        }

        private void btn_inapoi_Click(object sender, EventArgs e)
        {
            btn_inainte.Enabled = true;
            index--;
            if (index == 0)
            {
                btn_inainte.Enabled = true;
                btn_inapoi.Enabled = false;
            }
            progressBar1.Value--;
            loadForIndex();
        }

        private void btn_automat_Click(object sender, EventArgs e)
        {
            btn_inainte.Enabled = false;
            btn_inapoi.Enabled = false;
            btn_manual.Visible = true;
            t.Start();
        }

        private void btn_manual_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = imagini.Count - 1;
            btn_inainte.Enabled = true;
            btn_inapoi.Enabled = true;
            btn_manual.Visible = false;
            t.Stop();
        }

        private void btn_inainte_Click(object sender, EventArgs e)
        {
            index++;
            if (index == imagini.Count - 1)
            {
                btn_inainte.Enabled = false;
                btn_inapoi.Enabled = true;
            }
            progressBar1.Value++;
            loadForIndex();
        }

        private void Amintiri_Load(object sender, EventArgs e)
        {
            btn_inainte.Enabled = false;
            btn_inapoi.Enabled = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            new Main(utilizator, nume).Show();
        }
    }
}
