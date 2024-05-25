using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SeniorPro
{
    public partial class DatePersonale : Form
    {
        int utilizator;
        string nume;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DatePersonale(int a, string b)
        {
            InitializeComponent();

            nume = b;
            utilizator = a;

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);
            con.Open();
            string query = "SELECT Id, nume, parola, data_nasterii, email, telefon FROM Utilizatori WHERE Id = @id ";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", utilizator);
            reader = cmd.ExecuteReader();
            reader.Read();
            textBoxNume.Text = reader["nume"].ToString();
            textBoxEmail.Text = reader["email"].ToString();
            textBoxParola.Text = reader["parola"].ToString();
            textBoxTelefon.Text = reader["telefon"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(reader["data_nasterii"]);

            textBoxEmail.Click += textBoxEmail_Click;
            textBoxEmail.Leave += textBoxEmail_Leave;
            textBoxNume.Click += textBoxNume_Click;
            textBoxNume.Leave += textBoxNume_Leave;
            textBoxParola.Click += textBoxParola_Click;
            textBoxParola.Leave += textBoxParola_Leave;
            textBoxTelefon.Click += textBoxTelefon_Click;
            textBoxTelefon.Leave += textBoxTelefon_Leave;
        }

        private void textBoxTelefon_Click(object sender, EventArgs e)
        {
            if(textBoxTelefon.Text == reader["telefon"].ToString())
            {
                textBoxTelefon.Clear();
            }
        }

        private void textBoxTelefon_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTelefon.Text))
            {
                textBoxTelefon.Text = reader["telefon"].ToString();
            }
        }

        private void textBoxParola_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxParola.Text))
            {
                textBoxParola.Text = reader["parola"].ToString();
            }
        }

        private void textBoxParola_Click(object sender, EventArgs e)
        {
            if (textBoxParola.Text == reader["parola"].ToString())
            {
                textBoxParola.Clear();
            }
        }

        private void textBoxNume_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNume.Text))
            {
                textBoxNume.Text = reader["nume"].ToString();
            }
        }

        private void textBoxNume_Click(object sender, EventArgs e)
        {
            if (textBoxNume.Text == reader["nume"].ToString())
            {
                textBoxNume.Clear();
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = reader["email"].ToString();
            }
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == reader["email"].ToString())
            {
                textBoxEmail.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            reader.Close();
            string query = "UPDATE Utilizatori SET nume = @nume, parola = @parola, data_nasterii = @data_nasterii, email = @email, telefon = @telefon WHERE Id = @id";
            SqlCommand updateCmd = new SqlCommand(query, con);
            updateCmd.Parameters.AddWithValue("@id", utilizator);
            updateCmd.Parameters.AddWithValue("@nume", textBoxNume.Text);
            updateCmd.Parameters.AddWithValue("@parola", textBoxParola.Text);
            updateCmd.Parameters.AddWithValue("@data_nasterii", dateTimePicker1.Value);
            updateCmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            updateCmd.Parameters.AddWithValue("@telefon", textBoxTelefon.Text);

            try
            {
                int rowsAffected = updateCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Informațiile au fost actualizate cu succes!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nu s-au putut actualiza informațiile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
        }
    }
}
