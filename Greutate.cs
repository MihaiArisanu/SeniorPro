using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SeniorPro
{
    public partial class Greutate : Form
    {
        int utilizator;
        string nume;
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public Greutate(int a, string b)
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);
            
            nume = b;
            utilizator = a;

            label2.Text = label2.Text + nume;
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
                string q = "DELETE FROM Greutate WHERE IdGreutate = @id";
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            foreach (DataRow row in ds.Tables["Greutate"].Rows)
            {
                row[1] = utilizator;
            }
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds.Tables["Greutate"]);
        }

        private void LoadData()
        {
            string query = "SELECT IdGreutate, IdUser, NumarKg As [Numar Kg], data As Data FROM Greutate WHERE IdUser= " + utilizator; // Specificați explicit coloanele cheie
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "Greutate");

            dataGridView1.DataSource = ds.Tables["Greutate"];
            dataGridView1.Columns["IdGreutate"].Visible = false;
            dataGridView1.Columns["IdUser"].Visible = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void Greutate_Load(object sender, EventArgs e)
        {
            con.Open();
            LoadData();
        }
    }
}


