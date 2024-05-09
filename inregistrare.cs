using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;


namespace SeniorPro
{

public partial class inregistrare : Form
    {
        private SqlConnection con;
        
        public inregistrare()
        {
            InitializeComponent();

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");
            
            txt_pass.UseSystemPasswordChar = true;
            btn_show.Text = "Arată";
        }

        private void lbl_connect_Click(object sender, EventArgs e)
        {
            Hide();
            new login().Show();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_nickname.Clear();
            txt_email.Clear();
            txt_pass.Clear();
            dateTimePicker1.ResetText();
            txt_phone.Clear();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar)
            {
                txt_pass.UseSystemPasswordChar = false;
                btn_show.Text = "Ascunde";
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
                btn_show.Text = "Arată";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(txt_email.Text))
            {
                MessageBox.Show("Adresa de email invalida", "Eroare la inregistrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (txt_nickname.Text == "" || txt_email.Text == "" || txt_pass.Text == "" || txt_phone.Text == "" || dateTimePicker1.Value == DateTime.MinValue)
            {
                MessageBox.Show("Toate campurile trebuie completate", "Eroare la inregistrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();

                    string query = "INSERT INTO Utilizatori (nume, parola, email, data_nasterii, telefon) VALUES (@nickname,  @pass, @email, @dn, @phone)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@nickname", txt_nickname.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                    cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                    cmd.Parameters.AddWithValue("@dn", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Înregistrare reușită!");

                    Hide();
                    new login().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Adresa de email apare deja in baza de date!", "Eroare la înregistrare!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
