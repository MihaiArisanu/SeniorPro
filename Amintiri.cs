﻿using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SeniorPro
{
    public partial class Amintiri : Form
    {
<<<<<<< Updated upstream:Amintiri.cs
        public Amintiri()
        {
            InitializeComponent();
=======
        int utilizator;
        string nume;
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public Schema(int a, string b)
        {
            InitializeComponent();

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");
            nume = b;
            utilizator = a;

            pictureBox1.MouseEnter += PictureBox_MouseEnter;
            pictureBox1.MouseLeave += PictureBox_MouseLeave;

            label2.Text = @"Cum completez schema de tratament?

Avem 4 tabele de completat: unul pentru fiecare moment al zilei – dimineața, la prânz,
seara și la nevoie.
În coloana Medicament se completează cu numele.
În coloana Cantitate se completează cu numărul de pastile ce trebuie luate.
În coloana Moment al zilei se completează cu dimineața, la prânz, seara și la nevoie.
În coloana Inainte/Dupa masă se completează cu înainte/după.
În coloana Cantitate se completează cu cantitatea în mg.";
            label2.Font = new Font(label2.Font.FontFamily, 10f, label2.Font.Style);

            label2.Visible = false;
            label2.Location = new Point(12, 45);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool ok = false;
            int id1 = -1, id2 = -1, id3 = -1, id4 = -1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    id1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    ok = true;
                }
            }
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Selected == true)
                {
                    id2 = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value); // Aici ar trebui să fie id2 în loc de id1
                    ok = true;
                }
            }
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                if (dataGridView3.Rows[i].Selected == true)
                {
                    id3 = Convert.ToInt32(dataGridView3.Rows[i].Cells[0].Value); // Aici ar trebui să fie id3 în loc de id1
                    ok = true;
                }
            }
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                if (dataGridView4.Rows[i].Selected == true)
                {
                    id4 = Convert.ToInt32(dataGridView4.Rows[i].Cells[0].Value); // Aici ar trebui să fie id4 în loc de id1
                    ok = true;
                }
            }

            if (ok)
            {
                string q = "DELETE FROM Medicamente WHERE Idmedicament = @id1 OR Idmedicament = @id2 OR Idmedicament = @id3 OR Idmedicament = @id4";
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@id1", id1); // Aici ar trebui să fie @id1 în loc de id1
                cmd.Parameters.AddWithValue("@id2", id2);
                cmd.Parameters.AddWithValue("@id3", id3);
                cmd.Parameters.AddWithValue("@id4", id4);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Stergere efectuata!");
            }
            else
            {
                MessageBox.Show("Pentru a sterge trebuie sa selectati tot randul!", "Selectati tot randul", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb;
            con.Open();

            if (ds.Tables["Medicamente1"].GetChanges() != null)
            {
                foreach (DataRow row in ds.Tables["Medicamente1"].Rows)
                {
                    row[1] = utilizator;
                }
                cb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["Medicamente1"]);
            }

            if (ds.Tables["Medicamente2"].GetChanges() != null)
            {
                foreach (DataRow row in ds.Tables["Medicamente2"].Rows)
                {
                    row[1] = utilizator;
                }
                cb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["Medicamente2"]);
            }

            if (ds.Tables["Medicamente3"].GetChanges() != null)
            {
                foreach (DataRow row in ds.Tables["Medicamente3"].Rows)
                {
                    row[1] = utilizator;
                }
                cb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["Medicamente3"]);
            }

            if (ds.Tables["Medicamente4"].GetChanges() != null)
            {
                foreach (DataRow row in ds.Tables["Medicamente4"].Rows)
                {
                    row[1] = utilizator;
                }
                cb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["Medicamente4"]);
            }

            con.Close();
        }

        private void Schema_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string q = "SELECT Idmedicament, IdUser, medicament As Medicament, cantitate AS Cantitate, moment_al_zilei As [Moment al zilei], masa AS [Inainte/Dupa masa], concentratie AS Concentratie  FROM Medicamente WHERE IdUser = @utilizator AND moment_al_zilei = @moment";
            da = new SqlDataAdapter(q, con);
            da.SelectCommand.Parameters.AddWithValue("@utilizator", utilizator);
            da.SelectCommand.Parameters.AddWithValue("@moment", "dimineata");
            ds = new DataSet();
            da.Fill(ds, "Medicamente1");

            dataGridView1.DataSource = ds.Tables["Medicamente1"];
            dataGridView1.Columns["Idmedicament"].Visible = false;
            dataGridView1.Columns["IdUser"].Visible = false;
            dataGridView1.AllowUserToDeleteRows = false;

            da = new SqlDataAdapter(q, con);
            da.SelectCommand.Parameters.AddWithValue("@utilizator", utilizator);
            da.SelectCommand.Parameters.AddWithValue("@moment", "pranz");
            ds = new DataSet();
            da.Fill(ds, "Medicamente2");

            dataGridView2.DataSource = ds.Tables["Medicamente2"];
            dataGridView2.Columns["Idmedicament"].Visible = false;
            dataGridView2.Columns["IdUser"].Visible = false;
            dataGridView2.AllowUserToDeleteRows = false;

            da = new SqlDataAdapter(q, con);
            da.SelectCommand.Parameters.AddWithValue("@utilizator", utilizator);
            da.SelectCommand.Parameters.AddWithValue("@moment", "seara");
            ds = new DataSet();
            da.Fill(ds, "Medicamente3");

            dataGridView3.DataSource = ds.Tables["Medicamente3"];
            dataGridView3.Columns["Idmedicament"].Visible = false;
            dataGridView3.Columns["IdUser"].Visible = false;
            dataGridView3.AllowUserToDeleteRows = false;

            da = new SqlDataAdapter(q, con);
            da.SelectCommand.Parameters.AddWithValue("@utilizator", utilizator);
            da.SelectCommand.Parameters.AddWithValue("@moment", "la nevoie");
            ds = new DataSet();
            da.Fill(ds, "Medicamente4");

            dataGridView4.DataSource = ds.Tables["Medicamente4"];
            dataGridView4.Columns["Idmedicament"].Visible = false;
            dataGridView4.Columns["IdUser"].Visible = false;
            dataGridView4.AllowUserToDeleteRows = false;
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            hideTot();
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            arataTot();
        }

        private void hideTot()
        {
            label1.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            btn_delete.Visible = false;
            btn_save.Visible = false;

            label2.Visible = true;
        }

        private void arataTot()
        {
            label1.Visible = true;
            label5.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            dataGridView3.Visible = true;
            dataGridView4.Visible = true;
            btn_save.Visible = true;
            btn_delete.Visible = true;

            label2.Visible = false;
>>>>>>> Stashed changes:Schema.cs
        }
    }
}