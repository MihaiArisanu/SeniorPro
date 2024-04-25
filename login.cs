using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SeniorPro
{
    public partial class login : Form
    {
        private SqlConnection con;

        public login()
        {
            InitializeComponent();

            txt_pass.UseSystemPasswordChar = true;
            btn_show_hide.Text = "Arata";

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SlideShow\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            txt_email.Text = "lmiana@yahoo.com";
            txt_pass.Text = "123";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inregistrare form = new inregistrare();
            form.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT id, nume FROM Utilizatori where email = @email AND parola = @parola", con);
            cmd.Parameters.AddWithValue("email", txt_email.Text);
            cmd.Parameters.AddWithValue("parola", txt_pass.Text);
            var red = cmd.ExecuteReader();
            if (red.Read())
            {
                Main main = new Main(red.GetInt32(0), red.GetString(1));
                main.Show();
                this.Hide();
                main.FormClosed += (a, b) =>
                {
                    this.Show();
                    txt_email.Text = txt_pass.Text = "";
                };
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
            forgot go = new forgot();
            go.Show();
            this.Hide();
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
                btn_show_hide.Text = "Arata";
            }
        }
    }
}