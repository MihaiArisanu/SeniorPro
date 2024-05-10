using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SeniorPro
{
    public partial class Contact : Form
    {
        int utilizator;
        string nume;
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public Contact(int a, string b)
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");
            nume = b;
            utilizator = a;

            label2.Text = label2.Text + nume;
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
            ds = new DataSet();
            da.Fill(ds, "Persoane");

            dataGridView1.DataSource = ds.Tables["Persoane"];
            dataGridView1.Columns["idpers"].Visible = false;
            dataGridView1.Columns["IdUser"].Visible = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            foreach (DataRow row in ds.Tables["Persoane"].Rows)
            {
                row[1] = utilizator;
            }
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds.Tables["Persoane"]);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool ok = false;
            int id = 0;

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
                string q = "DELETE FROM Persoane WHERE idpers = @id";
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Stergere efectuata!");
            }
            else
            {
                MessageBox.Show("Pentru a sterge trebuie sa selectati tot randul!", "Selectati tot randul", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
