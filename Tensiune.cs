using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SeniorPro
{
    public partial class Tensiune : Form
    {
        int utilizator;
        string nume;
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public Tensiune(int a, string b)
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);
            
            nume = b;
            utilizator = a;

            label2.Text = label2.Text + nume;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            foreach (DataRow row in ds.Tables["Tensiuni"].Rows)
            {
                row[1] = utilizator;

                if (row[4].ToString() == "")
                    row[4] = "False";
                if (row[5].ToString() == "")
                    row[5] = "False";
                if (row[6].ToString() == "")
                    row[6] = "False";
           }
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["Tensiuni"]);
            }
            catch {
                MessageBox.Show("Actualizare incorecta");
            }
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
                string q = "DELETE FROM Tensiuni WHERE IdTensiune = @id";
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

        private void LoadData()
        {
            string query = "SELECT IdTensiune, IdUser, TA_Sistolica AS [TA Sistolica], TA_Diastolica AS [TA Diastolica], efort AS [Efort], suparare AS [Suparare], sare AS [Sare], data AS Data, ora AS Ora FROM Tensiuni WHERE IdUser= " + utilizator;
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "Tensiuni");

            dataGridView1.DataSource = ds.Tables["Tensiuni"];
            dataGridView1.Columns["IdTensiune"].Visible = false;
            dataGridView1.Columns["IdUser"].Visible = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void Tensiune_Load(object sender, EventArgs e)
        {
            con.Open();
            LoadData();
        }
    }
}
