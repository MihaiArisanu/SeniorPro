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

            panelContact.Visible = false;
            panelAmintiri.Visible = false;
            panelImagini.Visible = false;
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

            panelContact.Visible = false;
            if (panelAmintiri.Visible == false && panelImagini.Visible == false)
            {
                panelAmintiri.Visible = true;
                panelImagini.Visible = true;
            }
            else
            {
                panelAmintiri.Visible = false;
                panelImagini.Visible = false;
            }
        }

        private void btnDatePersonale_Click(object sender, EventArgs e)
        {
            panelContact.Visible = false;
            panelAmintiri.Visible = false;
            panelImagini.Visible = false;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            AfiseazaPersoanele();

            panelContact.Visible = true;
            panelAmintiri.Visible = false;
            panelImagini.Visible = false;
        }

        private void btnSchema_Click(object sender, EventArgs e)
        {
            panelContact.Visible = false;
            panelAmintiri.Visible = false;
            panelImagini.Visible = false;
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Main go = new Main(utilizator, nume);
            this.Close();
            go.Show();
        }

        private void AfiseazaPersoanele()
        {
            try
            {
                con.Open();
                string query = "SELECT nume FROM Persoane";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                string listaPersoane = "";
                while (reader.Read())
                {
                    listaPersoane += reader["Nume"].ToString() + "\n";
                }
                reader.Close();

                labelPersoane.Text = listaPersoane;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnPersoane_Click(object sender, EventArgs e)
        {
            AfiseazaPersoanele();
        }
    }
}
