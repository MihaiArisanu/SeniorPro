using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SeniorPro
{
    public partial class Configurari : Form
    {
        int utilizator;
        string nume;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");

        public Configurari(int a, string b)
        {
            InitializeComponent();

            utilizator = a;
            nume = b;

            panelAmintiri.Visible = false;
            panelValori.Visible = false;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Imagini (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|Toate fișierele (*.*)|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string debugFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

                    if (!Directory.Exists(debugFolder))
                    {
                        Directory.CreateDirectory(debugFolder);
                    }

                    con.Open();

                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        try
                        {
                            string Cale = Application.StartupPath + @"\Images\" + Path.GetFileName(filePath);
                            File.Copy(filePath, Cale);
                            string insertQuery = "INSERT INTO Amintiri (CaleFisier, IdUser) VALUES (@CaleFisier, @IdU)";
                            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@CaleFisier", Cale);
                                cmd.Parameters.AddWithValue("@IdU", utilizator);

                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Exista deja o imagine cu acest nume", "", MessageBoxButtons.OK);
                        }
                    }

                    con.Close();
                }
            }
        }

        private void btnAmintiri_Click(object sender, EventArgs e)
        {
            if (panelAmintiri.Visible == false)
            {
                panelAmintiri.Visible = true;
                openChildFormInPanel(new AmintiriConfigurari(utilizator, nume));
            }
            else
            {
                panelAmintiri.Visible = false;
            }
        }

        private void btnDatePersonale_Click(object sender, EventArgs e)
        {
            panelAmintiri.Visible = false;
            panelValori.Visible = false;
            openChildFormInPanel(new DatePersonale(utilizator, nume));
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            panelAmintiri.Visible = false;
            panelValori.Visible = false;
            openChildFormInPanel(new Contact(utilizator, nume));
        }

        private void btnSchema_Click(object sender, EventArgs e)
        {
            panelAmintiri.Visible = false;
            panelValori.Visible = false;
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
                activeForm.Close();
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
            panelValori.Visible = false;
            if (panelValori.Visible == false)
            {
                panelValori.Visible = true;
                openChildFormInPanel(new AmintiriConfigurari(utilizator, nume));
            }
            else
            {
                panelValori.Visible = false;
            }
        }

        private void Glicemie_Click(object sender, EventArgs e)
        {
            panelValori.Visible=false;
            panelAmintiri.Visible=false;
            openChildFormInPanel(new Glicemie(utilizator, nume));
        }

        private void Greutate_Click(object sender, EventArgs e)
        {
            panelValori.Visible = false;
            panelAmintiri.Visible = false;
            openChildFormInPanel(new Greutate(utilizator, nume));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelValori.Visible = false;
            panelAmintiri.Visible = false;
            openChildFormInPanel(new Tensiune(utilizator, nume));
        }
    }
}
