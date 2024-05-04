using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SeniorPro
{
    public partial class Configurari : Form
    {
        int utilizator;
        string nume;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");
        bool ok = false;

        public Configurari(int a, string b)
        {
            InitializeComponent();

            utilizator = a;
            nume = b;

            panelClose();
            label1.Text = "Bine ai venit in configurari!";
            label1.Visible = true;
        }

        private void btnAmintiri_Click(object sender, EventArgs e)
        {
            panelClose();
            if(ok == false)
            {
                ok = true;
                openChildFormInPanel(new AmintiriConfigurari(utilizator, nume));
            }
            else
            {
                panelClose();
                ok = false;
            }
        }

        private void btnDatePersonale_Click(object sender, EventArgs e)
        {
            panelClose();
            openChildFormInPanel(new DatePersonale(utilizator, nume));
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            panelClose();
            openChildFormInPanel(new Contact(utilizator, nume));
        }

        private void btnSchema_Click(object sender, EventArgs e)
        {
            panelClose();
            openChildFormInPanel(new Schema(utilizator, nume));
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Main go = new Main(utilizator, nume);
            this.Close();
            go.Show();
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Valori_Click(object sender, EventArgs e)
        {
            panelClose();
            if (ok == false)
            {
                label1.Text = "Actualizare valori pentru glicemie, greutate, tensiune";
                label1.Visible = true;
                panelValori.Visible = true;
                ok = true;
            }
            else
            {
                panelClose();
                ok = false;
            }
        }

        private void Glicemie_Click(object sender, EventArgs e)
        {
            panelClose();
            openChildFormInPanel(new Glicemie(utilizator, nume));
        }

        private void Greutate_Click(object sender, EventArgs e)
        {
            panelClose();
            openChildFormInPanel(new Greutate(utilizator, nume));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelClose();
            openChildFormInPanel(new Tensiune(utilizator, nume));
        }

        private void panelClose()
        {
            panelValori.Visible = false;
        }
    }
}
