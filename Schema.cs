using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SeniorPro
{
    public partial class Schema : Form
    {
        int utilizator;
        string nume, moment;

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public Schema(int a, string b)
        {
            InitializeComponent();

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);
            nume = b;
            utilizator = a;

            hideTot();
            pictureBox1.MouseEnter += PictureBox_MouseEnter;
            pictureBox1.MouseLeave += PictureBox_MouseLeave;

            label2.Text = @"Cum completează schema de tratament?

Avem 4 tabele de completat: unul pentru fiecare moment al zilei 
    dimineața, la prânz,seara și la nevoie.
În coloana Medicament se completează cu numele.
În coloana Cantitate se completează cu numărul de pastile ce trebuie luate.
În coloana Moment al zilei se completează cu 
     dimineața, la prânz, seara și la nevoie.
În coloana Inainte/Dupa masă se completează cu înainte/după.
În coloana Cantitate se completează cu cantitatea în mg.";
            label2.Font = new Font(label2.Font.FontFamily, 13f, label2.Font.Style);

            label2.Visible = false;
            label2.Location = new Point(12, 45);
            label2.Visible = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb;
            con.Open();

            foreach (DataRow row in ds.Tables["Medicamente"].Rows)
            {
                row[1] = utilizator;
                if (row[4].ToString() == "")
                {
                    row[4] = moment;
                }
            }
            try
            {
                cb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["Medicamente"]);
                MessageBox.Show("Datele au fost actualizate");

            }
            catch
            {
                MessageBox.Show("Datele nu pot fi actualizate", "Verificati");
            }

            con.Close();
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool ok = false;
            int id = -1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    ok = true;
                }
            }

            if (ok)
            {
                con.Open();
                string q = "DELETE FROM Medicamente WHERE Idmedicament = @id";
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@id1", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Stergere efectuata!");
                con.Close();
            }
            else
            {
                MessageBox.Show("Pentru a sterge trebuie sa selectati tot randul!", "Selectati tot randul", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            hideTot();
            label2.Visible = true;
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void hideTot()
        {
            dataGridView1.Visible = false;
            btn_delete.Visible = false;
            btn_save.Visible = false;
            label2.Visible = false;
        }

        private void Schema_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadData()
        {

            string q = "SELECT Idmedicament, IdUser, medicament As Medicament, cantitate AS Cantitate, moment_al_zilei , masa AS [Raportat la masa: inainte/dupa/nu conteaza], concentratie AS Concentratie  FROM Medicamente WHERE IdUser = @utilizator AND moment_al_zilei = @moment";
            da = new SqlDataAdapter(q, con);
            da.SelectCommand.Parameters.AddWithValue("@utilizator", utilizator);
            da.SelectCommand.Parameters.AddWithValue("@moment", moment);
            ds = new DataSet();
            da.Fill(ds, "Medicamente");
            dataGridView1.DataSource = ds.Tables["Medicamente"];
            dataGridView1.Columns["Idmedicament"].Visible = false;
            dataGridView1.Columns["IdUser"].Visible = false;
            dataGridView1.Columns["moment_al_zilei"].Visible = false;
            dataGridView1.AllowUserToDeleteRows = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideTot();
            dataGridView1.Visible = true;
            btn_save.Visible = true;
            btn_delete.Visible = true;
            con.Close();
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Dimineata":
                    moment = "dimineata";
                    break;
                case "La pranz":
                    moment = "pranz";
                    break;
                case "Seara":
                    moment = "seara";
                    break;
                case "La nevoie":
                    moment = "la nevoie";
                    break;
            }
            LoadData();
        }
    }
}
