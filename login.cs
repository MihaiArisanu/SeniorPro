using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SeniorPro
{
    public partial class login : Form
    {
        private SqlConnection con;

        public login()
        {
            InitializeComponent();

            txt_pass.UseSystemPasswordChar = true;
            btn_show_hide.Text = "Arată";

            txt_pass.Text = "123";
            txt_email.Text = "mihai@yahoo.com";

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new inregistrare().Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT id, nume FROM Utilizatori where email = @email AND parola = @parola", con);
            cmd.Parameters.AddWithValue("email", txt_email.Text);
            cmd.Parameters.AddWithValue("parola", txt_pass.Text);
            var red = cmd.ExecuteReader();
            if (red.Read())
            {
                Hide();
                new Main(red.GetInt32(0), red.GetString(1)).Show();
            }
            else
            {
                MessageBox.Show("Eroare de autentificare");
                con.Close();
                con.Open();
                cmd = new SqlCommand("SELECT id, nume FROM Utilizatori where email = @email AND parola = @parola", con);

                txt_email.Clear();
                txt_pass.Clear();
                txt_email.Focus();
            }
        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            Hide();
            new forgot().Show();
        }

        private void btn_show_hide_Click(object sender, EventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar)
            {
                txt_pass.UseSystemPasswordChar = false;
                txt_pass.Focus();
                btn_show_hide.Text = "Ascunde";
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
                txt_pass.Focus();
                btn_show_hide.Text = "Arată";
            }
        }
    }
}