using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace SeniorPro
{
    public partial class Contact : Form
    {
        int utilizator;
        string nume;
        SqlConnection con;
        SqlDataAdapter da= new SqlDataAdapter();
        DataTable dt;
      
        public Contact(int a, string b)
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");
        
            nume = b;
            utilizator = a;
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            con.Open();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT idpers, IdUser, nume As Nume, data_nasterii As [Data nasterii], email, telefon FROM Persoane WHERE IdUser= " + utilizator; // Specificați explicit coloanele cheie
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["idpers"].Visible = false;
            dataGridView1.Columns["IdUser"].Visible = false;
            // Salveaza starea originala a datelor pentru anularea modificarilor
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dt.Clear();
            //dt.Merge(originalDataTable);
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
