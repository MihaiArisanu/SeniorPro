using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorPro
{
    public partial class Glicemie : Form
    {
        int utilizator;
        string nume;
        SqlConnection con;
        SqlDataAdapter da=new SqlDataAdapter();
        DataTable dt;
      

        public Glicemie(int a, string b)
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");

            nume = b;
            utilizator = a;
            label_titlu.Text = label_titlu.Text + " " + b;
        }

      
        private void btn_save_Click(object sender, EventArgs e)
        {
           
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Datele au fost salvate cu succes!", "Salvare reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.Refresh();
            //con.Close();
        }
        private void Load_data()
        {
            string query = "SELECT IdGlicemie,IdUser, Glicemie, mancat as [Ai mancat?], data As Data, ora as Ora FROM Glicemii WHERE IdUser=" + utilizator;  //  Specificați explicit coloanele cheie
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["idGlicemie"].Visible = false;
            dataGridView1.Columns["IdUser"].Visible = false;
            //dataGridView1.AllowUserToAddRows = false;
            //originalDataTable = dt.Copy();
            // Salveaza starea originala a datelor pentru anularea modificarilor

        }
        private void Glicemie_Load(object sender, EventArgs e)
        {
            con.Open();
            Load_data();
        }

        private void btn_sterge_Click(object sender, EventArgs e)
        {
            // Verifică dacă există cel puțin un rând selectat în DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obține rândul selectat
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Șterge rândul selectat din DataGridView
                dataGridView1.Rows.Remove(selectedRow);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dt);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Selectează mai întâi o înregistrare de șters.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
