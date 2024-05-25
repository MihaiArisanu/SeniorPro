using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace SeniorPro
{
    public partial class Amintiri : Form
    {
       
        int utilizator;
        string nume;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        int index = 0;

        public Amintiri(int a, string b)
        {
            InitializeComponent();

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);
            con.Open();

            utilizator = a;
            nume = b;

            this.WindowState = FormWindowState.Maximized;
        }

        private void loadForIndex(int index)
        {
            panel1.BackgroundImage = Image.FromFile(Convert.ToString(ds.Tables[0].Rows[index][2]));
        }

        private void btn_inapoi_Click(object sender, EventArgs e)
        {
            btn_inainte.Enabled = true;
            index--;
            if (index == 0)
            {
                btn_inapoi.Enabled = false;
            }
            loadForIndex(index);
        }

        private void btn_inainte_Click(object sender, EventArgs e)
        {
            index++;
            btn_inapoi.Enabled = true;
            if (index == ds.Tables[0].Rows.Count - 1)
            {
                btn_inainte.Enabled = false;
               
            }
          loadForIndex(index);
        }

        private void Amintiri_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            string query = "SELECT IdImagine, IdUser, CaleFisier FROM Amintiri where IdUser=" + utilizator.ToString();
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "Amintiri");
            loadForIndex(0);
            btn_inainte.Enabled = true;
            btn_inapoi.Enabled = false;
        }

        private void btnAmintiri_Click(object sender, EventArgs e)
        {
            Hide();
            new Amintiri(utilizator, nume).Show();
        }

        private void btnConfigurari_Click(object sender, EventArgs e)
        {
            Close();
            new Configurari(utilizator, nume).Show();
        }

        private void btnVorbim_Click(object sender, EventArgs e)
        {
            Hide();
            new Vorbim(utilizator, nume).Show();
        }

        private void btnTratament_Click(object sender, EventArgs e)
        {
            Hide();
            new tratament(utilizator, nume).Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            new Main(utilizator, nume).Show();
        }
    }
}
