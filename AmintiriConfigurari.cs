using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace SeniorPro
{
    public partial class AmintiriConfigurari : Form
    {
        int utilizator;
        string nume;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        int index = 0;

        public AmintiriConfigurari(int a, string b)
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);
            nume = b;
            utilizator = a;

            label1.Text = label1.Text + nume;
        }

        private void AmintiriConfigurari_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            string query = "SELECT IdImagine, IdUser, CaleFisier FROM Amintiri where IdUser=" + utilizator.ToString();
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "Amintiri");
            loadForIndex(0);
            btn_inainte.Enabled = true;
            btn_inapoi.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
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
                            string query = "INSERT INTO Amintiri (CaleFisier, IdUser) VALUES (@CaleFisier, @IdU)";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@CaleFisier", Cale);
                            cmd.Parameters.AddWithValue("@IdU", utilizator);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Imaginea a fost adaugata", "", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Exista deja o imagine cu acest nume", "", MessageBoxButtons.OK);
                        }
                    }
                    da.Fill(ds, "Amintiri");
                    con.Close();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM  Amintiri where IdImagine=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ds.Tables[0].Rows[index][0]));
            cmd.ExecuteNonQuery();
          //File.Delete(Convert.ToString(ds.Tables[0].Rows[index][2]));
            da.Fill(ds, "Amintiri");
            con.Close();
        }

        private void loadForIndex(int index)
        {
            panel1.BackgroundImage = Image.FromFile(Convert.ToString(ds.Tables[0].Rows[index][2]));
        }
        private void btn_inapoi_Click(object sender, EventArgs e)
        {
            btn_inainte.Enabled = true;
            index--;
            if (index == 0)
            {
                btn_inapoi.Enabled = false;
            }
            loadForIndex(index);
        }

        private void btn_inainte_Click(object sender, EventArgs e)
        {
            index++;
            btn_inapoi.Enabled = true;
            if (index == ds.Tables[0].Rows.Count - 1)
            {
                btn_inainte.Enabled = false;
            }
            loadForIndex(index);
        }
    }
}
