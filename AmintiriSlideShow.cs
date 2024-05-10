﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


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

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            utilizator = a;
            nume = b;

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
                btn_inainte.Enabled = true;
                btn_inapoi.Enabled = false;
            }
            loadForIndex(index);
        }

        private void btn_inainte_Click(object sender, EventArgs e)
        {
            index++;
            if (index == ds.Tables[0].Rows.Count - 1)
            {
                btn_inainte.Enabled = false;
                btn_inapoi.Enabled = true;
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            new Main(utilizator, nume).Show();
        }
    }
}