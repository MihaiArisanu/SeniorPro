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
    public partial class Tensiune : Form
    {
        int utilizator;
        string nume;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        DataTable originalDataTable;

        public Tensiune(int a, string b)
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");

            nume = b;
            utilizator = a;
        }

        private void Tensiune_Load(object sender, EventArgs e)
        {
            con.Open();

            string query = "SELECT IdTensiune,IdUser, TA_Sistolica,TA_Diastolica,  efort as [Efort?], suparare as [Suparare?], sare as [Sare?], data As Data, ora as Ora FROM Tensiuni WHERE IdUser=" + utilizator;
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["IdTensiune"].Visible = false;
            dataGridView1.Columns["IdUser"].Visible = false;
            // Salveaza starea originala a datelor pentru anularea modificarilor
            originalDataTable = dt.Copy();
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.Merge(originalDataTable);
            MessageBox.Show("Modificările au fost anulate!", "Anulare modificări", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Datele au fost salvate cu succes!", "Salvare reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

       
    }
}
