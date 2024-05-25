using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace SeniorPro
{
    public partial class forgot : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        string randomCode;
        public static string to;
        
        public forgot()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);
            txt_set.UseSystemPasswordChar = true;
            txt_confirm.UseSystemPasswordChar = true;
            btn_show.Text = "Arata";
        }

        private void lbl_inregistrare_Click(object sender, EventArgs e)
        {
            inregistrare go = new inregistrare();
            go.Show();
            this.Hide();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(txt_email.Text))
            {
                MessageBox.Show("Adresa de email invalida", "Eroare la inregistrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             else
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Utilizatori WHERE email = @email", con);
                cmd.Parameters.AddWithValue("email", txt_email.Text);
                int count = (int)cmd.ExecuteScalar(); // Obține numărul de înregistrări care corespund adresei de email

                if (count > 0)
                {
                    // Emailul a fost găsit în baza de date
                    MessageBox.Show("Emailul a fost găsit în baza de date");

                    btn_email.Visible = true;
                    btn_check.Visible = true;
                    label1.Visible = true;
                    label3.Visible = true;
                    txt_code.Visible = true;

                    string from, pass, messageBody;
                    Random ran = new Random();
                    MailMessage message = new MailMessage();

                    randomCode = (ran.Next(100000, 1000000)).ToString();
                    to = txt_email.Text;
                    from = "seniorproapp@gmail.com";
                    pass = "Senior_Pro_123!";
                    messageBody = "Codul dvs. pentru resetarea parolei este" + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Schimbarea parolei";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("code send successfully" + randomCode);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Emailul nu este cunoscut", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Clear();
                    txt_email.Focus();

                    con.Close();
                    con.Open();
                }

                con.Close();
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate", "Eroare la inregistrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long result;
                if (long.TryParse(txt_code.Text, out result))
                {
                    if (randomCode == (txt_code.Text).ToString())
                    {
                        to = txt_code.Text;

                        btn_email.Visible = false;
                        btn_check.Visible = false;
                        label1.Visible = false;
                        label3.Visible = false;
                        txt_email.Visible = false;
                        txt_code.Visible = false;
                        lbl_inregistrare.Visible = false;
                        btn_reset.Visible = true;
                        btn_show.Visible = true;
                        txt_confirm.Visible = true;
                        txt_set.Visible = true;
                        label2.Visible = true;
                        label4.Visible = true;
                        btn_clear.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("wrong code");
                    }                   
                }
                else
                {
                    MessageBox.Show("Textul introdus nu este un număr întreg!");
                }
            }
        }

        private void forgot_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            btn_clear.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            txt_code.Visible = false;
            btn_check.Visible = false;
            btn_reset.Visible = false;
            btn_show.Visible = false;
            txt_confirm.Visible = false;
            txt_set.Visible = false;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_set.UseSystemPasswordChar)
            {
                txt_set.UseSystemPasswordChar = false;
                txt_confirm.UseSystemPasswordChar = false;
                btn_show.Text = "Ascunde";
            }
            else
            {
                txt_confirm.UseSystemPasswordChar = true;
                txt_set.UseSystemPasswordChar = true;
                btn_show.Text = "Arata";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_confirm.Clear();
            txt_set.Clear();
            txt_set.Focus(); 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login go = new login();
            go.Show();
            this.Hide();
        }
    }
}