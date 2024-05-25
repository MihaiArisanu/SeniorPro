using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SeniorPro
{
    public partial class tratament : Form
    {
        int utilizator;
        string nume;
        SqlDataReader reader;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);
        
        public tratament(int a, string b)
        {
            InitializeComponent();

            nume = b;
            utilizator = a;
            lbl_dimineata.Text = "";
            lbl_dimineata.Visible = false;
            lbl_pranz.Text = "";
            lbl_pranz.Visible = false;
            lbl_seara.Text = "";
            lbl_seara.Visible = false;
            lbl_nevoie.Text = "";
            lbl_nevoie.Visible = false;

            this.WindowState = FormWindowState.Maximized;
        }

        private void tratament_Load(object sender, EventArgs e)
        {
            string query = "SELECT Idmedicament, IdUser, medicament, cantitate, moment_al_zilei, masa , concentratie  FROM Medicamente WHERE IdUser = @utilizator";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@utilizator", utilizator);
            con.Open();
            reader = cmd.ExecuteReader();
            string q1 = "", q2 = "", q3 = "";
            string s1 = "", s2 = "", s3 = "";
            string w1 = "", w2 = "", w3 = "";
            string v1 = "", v2 = "", v3 = "";
            while (reader.Read())

            {

                if (reader[4].ToString() == "dimineata")
                {
                    if (reader[5].ToString() == "inainte")
                        q1 = q1 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                    else
                        if (reader[5].ToString() == "dupa")
                        q2 = q2 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                    else
                        q3 = q3 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                }
                else
                     if (reader[4].ToString() == "pranz")
                {
                    if (reader[5].ToString() == "inainte")
                    {
                        s1 = s1 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";

                    }
                    else
                        if (reader[5].ToString() == "dupa")
                        s2 = s2 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                    else
                        s3 = s3 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                }
                else
                     if (reader[4].ToString() == "seara")
                {
                    if (reader[5].ToString() == "inainte")
                        w1 = w1 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                    else
                        if (reader[5].ToString() == "dupa")
                        w2 = w2 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                    else
                        w3 = w3 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                }
                else
                {
                    if (reader[5].ToString() == "inainte")
                        v1 = v1 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                    else
                        if (reader[2].ToString() == "dupa")
                        v2 = v2 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                    else
                        v3 = v3 + reader[3].ToString() + " " + reader[2].ToString() + " " + reader[6].ToString() + "\n";
                }
            }
            if (q1 != "")
                lbl_dimineata.Text = lbl_dimineata.Text + "  INAINTE DE MASA\n" + q1;
            if (q2 != "")
                lbl_dimineata.Text = lbl_dimineata.Text + "  \nDUPA MASA\n" + q2;
            if (q3 != "")
                lbl_dimineata.Text = lbl_dimineata.Text + "\nINAINTE/ DUPA MASA\n" + q3;
            if (s1 != "")
                lbl_pranz.Text = lbl_pranz.Text + "  INAINTE DE MASA\n" + s1;
            if (s2 != "")
                lbl_pranz.Text = lbl_pranz.Text + "  \nDUPA MASA\n" + s2;
            if (s3 != "")
                lbl_pranz.Text = lbl_pranz.Text + " \nINAINTE/ DUPA MASA\n" + s3;

            if (w1 != "")
                lbl_seara.Text = lbl_seara.Text + "  INAINTE DE MASA\n" + w1;
            if (w2 != "")
                lbl_seara.Text = lbl_seara.Text + "  \nDUPA MASA\n" + w2;
            if (w3 != "")
                lbl_seara.Text = lbl_seara.Text + "\nINAINTE/ DUPA MASA\n" + w3;

            if (v1 != "")
                lbl_nevoie.Text = lbl_nevoie.Text + "  INAINTE DE MASA\n" + v1;
            if (v2 != "")
                lbl_nevoie.Text = lbl_nevoie.Text + "  \nDUPA MASA\n" + v2;
            if (v3 != "")
                lbl_nevoie.Text = lbl_nevoie.Text + "\nINAINTE/ DUPA MASA\n" + v3;



        }

        private void btn_dimineata_Click(object sender, EventArgs e)
        {
            lbl_dimineata.Visible = true;
        }

        private void btn_pranz_Click(object sender, EventArgs e)
        {
            lbl_pranz.Visible = true;
        }

        private void btn_seara_Click(object sender, EventArgs e)
        {
            lbl_seara.Visible = true;
        }

        private void btn_nevoie_Click(object sender, EventArgs e)
        {
            lbl_nevoie.Visible = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            new Main(utilizator, nume).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            new Main(utilizator, nume).Show();
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

        private void btnOprire_Click(object sender, EventArgs e)
        {
            Close();
            new Main(utilizator, nume).Show();
        }
    }
}