using System;
<<<<<<< Updated upstream
using System.Collections.Generic;
using System.ComponentModel;
=======
>>>>>>> Stashed changes
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
<<<<<<< Updated upstream
using System.IO;
=======
>>>>>>> Stashed changes

namespace SeniorPro
{
    public partial class Main : Form
    {
        private string txt1 = "Glicemie", ora1 = "Ora, fara minute", txt2 = "Maxima", txt3 = "Minima", ora2 = "Ora, fara minute", txt4 = "Greutate";
        private SqlConnection con;
        int utilizator;
        string nume;
        List<Imagini> imag;
        Timer t = new Timer { Interval = 2000 };

        public Main(int a, string b)
        {
            InitializeComponent();

            utilizator = a;
            nume = b;

            label1.Text = label1.Text + " " + b;
         
            btn_glicemieGata.Hide();
            btn_tensiuneGata.Hide();
            txt_glicemie.Hide();
            txt_ora_glicemie.Hide();
            txt_ora_tensiune.Hide();
            txt_tensiune_minima.Hide();
            txt_tensiune_maxima.Hide();
            txtGreuate.Hide();
            btn_greautateGata.Hide();
            check_mancat.Hide();
            check_sarat.Hide();
            check_suparat.Hide();
            check_efort.Hide();
            
            txt_glicemie.Text = txt1;
            txt_glicemie.Click += txt_glicemie_Click;
            txt_glicemie.Leave += txt_glicemie_Leave;

            txt_ora_glicemie.Text = ora1;
            txt_ora_glicemie.Click += txt_ora_glicemie_Click;
            txt_ora_glicemie.Leave += txt_ora_glicemie_Leave;

            txt_tensiune_maxima.Text = txt2;
            txt_tensiune_maxima.Click += txt_tensiune_maxima_Click;
            txt_tensiune_maxima.Leave += txt_tensiune_maxima_Leave;

            txt_tensiune_minima.Text = txt3;
            txt_tensiune_minima.Click += txt_tensiune_minima_Click;
            txt_tensiune_minima.Leave += txt_tensiune_minima_Leave;

            txt_ora_tensiune.Text = ora2;
            txt_ora_tensiune.Click += txt_ora_tensiune_Click;
            txt_ora_tensiune.Leave += txt_ora_tensiune_Leave;

            txtGreuate.Text = txt4;
            txtGreuate.Click += txtGreuate_Click;
            txtGreuate.Leave += txtGreuate_Leave;

<<<<<<< Updated upstream
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SlideShow\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");


            btn_man.Hide();
            btn_inainte.Enabled = false;
            btn_inapoi.Enabled = false;

            //button2.Visible = false;
            //button2.Enabled = false;
            //loadImagini();
            
=======
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\SeniorPro\bin\Debug\SeniorPro.mdf;Integrated Security=True;Connect Timeout=30");
            this.WindowState = FormWindowState.Maximized;
>>>>>>> Stashed changes
        }

        private void txt_glicemie_Click(object sender, EventArgs e)
        {
           if (txt_glicemie.Text == txt1)
            {
                txt_glicemie.Text = "";
            }
        }
        private void txt_glicemie_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_glicemie.Text))
            {
                txt_glicemie.Text = txt1;
            }
        }

        private void txt_ora_glicemie_Click(object sender, EventArgs e)
        {
            if (txt_ora_glicemie.Text == ora1)
            {
                txt_ora_glicemie.Text = "";
            }
        }

        private void txt_ora_glicemie_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ora_glicemie.Text))
            {
                txt_ora_glicemie.Text = ora1;
            }
        }

        private void txt_tensiune_maxima_Click(object sender, EventArgs e)
        {
            if (txt_tensiune_maxima.Text == txt2)
            {
                txt_tensiune_maxima.Text = "";
            }
        }

        private void txt_tensiune_maxima_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tensiune_maxima.Text))
            {
                txt_tensiune_maxima.Text = txt2;
            }
        }

        private void txt_tensiune_minima_Click(object sender, EventArgs e)
        {
            if (txt_tensiune_minima.Text == txt3)
            {
                txt_tensiune_minima.Text = "";
            }
        }

        private void txt_tensiune_minima_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tensiune_minima.Text))
            {
                txt_tensiune_minima.Text = txt3;
            }
        }

        private void txt_ora_tensiune_Click(object sender, EventArgs e)
        {
            if (txt_ora_tensiune.Text == ora2)
            {
                txt_ora_tensiune.Text = "";
            }
        }

        private void btn_glicemieGata_Click(object sender, EventArgs e)
        {
            if ((txt_glicemie.Text == " " || txt_glicemie.Text == txt1) || (txt_ora_glicemie.Text == " " || txt_ora_glicemie.Text == ora1))
            {
                MessageBox.Show("Trebuie sa completezi toate casetele de text", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txt_glicemie.Text, out int numericValue_glicemie))
            {
                MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă în câmpul glicemie !");
            }
            else if (!int.TryParse(txt_ora_glicemie.Text, out int numericValue_ora))
            {
                MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă în câmpul ora !");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Glicemii (Id, glicemie, data, mancat, ora) VALUES (@id, @glice,  @ziua, @masa, @ora)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", utilizator);
                    cmd.Parameters.AddWithValue("@glice", numericValue_glicemie);
                    cmd.Parameters.AddWithValue("@ziua", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@ora", numericValue_ora);
                    if (check_mancat.Checked)
                    {
                        cmd.Parameters.AddWithValue("@masa", 1);
                    }   
                    else
                    {
                        cmd.Parameters.AddWithValue("@masa", 0);
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Înregistrare reușită!");
                    txt_glicemie.Hide();
                    btn_glicemieGata.Hide();
                    txt_ora_glicemie.Hide();
                    check_mancat.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la înregistrare!" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_tensiuneGata_Click(object sender, EventArgs e)
        {
                if ((txt_tensiune_minima.Text == " " || txt_tensiune_minima.Text == txt3) || (txt_tensiune_maxima.Text == " " || txt_tensiune_maxima.Text == txt2) || (txt_ora_tensiune.Text == " " || txt_ora_tensiune.Text == ora2))
                {
                    MessageBox.Show("Trebuie sa completezi toate casetele de text", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!int.TryParse(txt_tensiune_minima.Text, out int numericValue_tensiuneMinima))
                {
                MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă in campul tensiune minima!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!int.TryParse(txt_tensiune_maxima.Text, out int numericValue_tensiuneMaxima))
                {
                MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă in campul tensiune maxima!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!int.TryParse(txt_ora_tensiune.Text, out int numericValue_ora))
                {
                MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă in campul ora!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "INSERT INTO Tensiuni (Id, TA_Sistolica, TA_Diastolica, data, sare, suparare, efort, ora) " +
                        "VALUES (@id, @maxima, @minima, @ziua, @sarat, @suparat, @efort, @ora)";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@id", utilizator);
                        cmd.Parameters.AddWithValue("@minima", numericValue_tensiuneMinima);
                        cmd.Parameters.AddWithValue("@maxima", numericValue_tensiuneMaxima);
                        cmd.Parameters.AddWithValue("@ziua", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@ora", numericValue_ora);
                        cmd.Parameters.AddWithValue("@sarat", check_sarat.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@suparat", check_suparat.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@efort", check_efort.Checked ? 1 : 0);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Înregistrare reușită!");
                        txt_ora_tensiune.Hide();
                        txt_tensiune_minima.Hide();
                        txt_tensiune_maxima.Hide();
                        btn_tensiuneGata.Hide();
                        check_sarat.Hide();
                        check_suparat.Hide();
                        check_efort.Hide();
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la înregistrare!" + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
        }

        private void btn_ok2_Click(object sender, EventArgs e) //FillChartTensiune
        {
            int nrzile = 30; // Valoare implicită

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (!int.TryParse(textBox2.Text, out nrzile))
                {
                    MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Ieși din metodă dacă valoarea introdusă nu este validă
                }
            }
            else
            {
                textBox2.Text = "30";
            }

            con.Open();
            string query0 = "SELECT T1.TA_Diastolica as TA_Diastolica, T1.TA_Sistolica as TA_Sistolica, T1.data as data, " +
                "T1.efort as efort, T1.sare as sare, T1.suparare as suparare FROM " +
                "(SELECT TA_Diastolica, TA_Sistolica, data, efort, sare, suparare FROM Tensiuni " +
                "WHERE data >= DATEADD(DAY, -1 * @nrzile, GETDATE()) AND Id = @id) T1 " +
                "JOIN (SELECT data, MAX(TA_Sistolica) AS MaxSistolica FROM Tensiuni " +
                "WHERE data >= DATEADD(DAY, -1 * @nrzile, GETDATE()) AND Id = @id GROUP BY data) T2 " +
                "ON T1.data = T2.data AND T1.TA_Sistolica= T2.MaxSistolica order by T1.data";

            DataSet ds0 = new DataSet();
            SqlCommand cmd0 = new SqlCommand(query0, con);
            cmd0.Parameters.AddWithValue("@id", utilizator);
            cmd0.Parameters.AddWithValue("@nrzile", nrzile);
            SqlDataAdapter adapter0 = new SqlDataAdapter(cmd0);
            adapter0.Fill(ds0);
            con.Close();

            Series seriesDiastolica = chart2.Series[1];
            Series seriesSistolica = chart2.Series[0];

            seriesDiastolica.ChartType = SeriesChartType.Column;
            seriesDiastolica.Points.Clear();

            seriesSistolica.ChartType = SeriesChartType.Column;
            seriesSistolica.Points.Clear();

            for (int i = 0; i < ds0.Tables[0].Rows.Count; i++)
            {
                DateTime date = (DateTime)ds0.Tables[0].Rows[i]["data"];
                int sistolica = Convert.ToInt32(ds0.Tables[0].Rows[i]["TA_Sistolica"]);
                int diastolica = Convert.ToInt32(ds0.Tables[0].Rows[i]["TA_Diastolica"]);
                
                DataPoint pointSistolica = new DataPoint(date.ToOADate(), sistolica);
                seriesSistolica.Points.Add(pointSistolica);
                DataPoint pointDiastolica = new DataPoint(date.ToOADate(), diastolica);
                seriesDiastolica.Points.Add(pointDiastolica);

                int ef = Convert.ToInt32(ds0.Tables[0].Rows[i]["efort"]);
                int sup = Convert.ToInt32(ds0.Tables[0].Rows[i]["suparare"]);
                int sr = Convert.ToInt32(ds0.Tables[0].Rows[i]["sare"]);

                pointDiastolica.AxisLabel = date.ToString("dd/MM/yyyy");
                if (ef == 1)
                    pointDiastolica.AxisLabel += "\nefort";
                if (sup == 1)
                    pointDiastolica.AxisLabel += "\nsuparare";
                if (sr == 1)
                    pointDiastolica.AxisLabel += "\nsare";
             }
            adapter0.Dispose();
        }

        private void txt_ora_tensiune_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ora_tensiune.Text))
            {
                txt_ora_tensiune.Text = ora2;
            }
        }

        private void btn_configurari_Click(object sender, EventArgs e)
        {
            Configurari go = new Configurari(utilizator, nume);
            this.Hide();
            go.Show();
        }

        private void btn_greautateGata_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtGreuate.Text, out int numarKg))
            {
<<<<<<< Updated upstream
                MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numarKg > 200 || numarKg < 40)
            {
                DialogResult result = MessageBox.Show("Sunteți sigur că valorile sunt introduse corect?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string query = "INSERT INTO Greutate (IdUser, NumarKg, data) VALUES (@id, @greutate, @data)";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@id", utilizator);
                        cmd.Parameters.AddWithValue("@greutate", numarKg);
                        cmd.Parameters.AddWithValue("@data", DateTime.Now.Date);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Înregistrare reușită!");

                        txtGreuate.Hide();
                        txtGreuate.Clear();
                        btn_greautateGata.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la înregistrare!" + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    txtGreuate.Clear();
                    txtGreuate.Focus();
                }
=======
                MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă în câmpul greutate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
>>>>>>> Stashed changes
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Greutate (IdUser, NumarKg, data) VALUES (@id, @greutate, @data)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", utilizator);
                    cmd.Parameters.AddWithValue("@greutate", numarKg);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now.Date);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Înregistrare reușită!");

                    txtGreuate.Hide();
                    txtGreuate.Clear();
                    btn_greautateGata.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la înregistrare!" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_greutate_Click(object sender, EventArgs e)
        {
            txtGreuate.Visible = true;
            btn_greautateGata.Visible = true;
        }

        private void txtGreuate_Click(object sender, EventArgs e)
        {
            if (txtGreuate.Text == txt4)
            {
                txtGreuate.Text = "";
            }
        }

        private void txtGreuate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGreuate.Text))
            {
<<<<<<< Updated upstream
                txtGreuate.Text = txt4;
=======
                txt_Greutate.Text = txt4;
            }
        }

        private void btn_ok3_Click(object sender, EventArgs e)
        {
            int nrluni = 6;

            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                if (!int.TryParse(textBox4.Text, out nrluni))
                {
                    MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                textBox4.Text = "6";
            }

            con.Open();

            string query = @"
        SELECT 
            AVG(NumarKg) AS GreutateMedie,
            DATEPART(MONTH, data) AS Luna,
            DATEPART(YEAR, data) AS An
        FROM 
            Greutate
        WHERE 
            IdUser = @id 
            AND DATEADD(MONTH, @nrluni, data) >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
        GROUP BY 
            DATEPART(MONTH, data), 
            DATEPART(YEAR, data) 
        ORDER BY An, Luna";

            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            cmd.Parameters.AddWithValue("@id", utilizator);
            cmd.Parameters.AddWithValue("@nrluni", nrluni - 1);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            con.Close();

            Series seriegreutate = chart3.Series[0];
            seriegreutate.ChartType = SeriesChartType.Column;
            seriegreutate.Points.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double greutateMedie = Convert.ToDouble(dt.Rows[i]["GreutateMedie"]);
                int luna = Convert.ToInt32(dt.Rows[i]["Luna"]);
                int an = Convert.ToInt32(dt.Rows[i]["An"]);

                DateTime luna_an = new DateTime(an, luna, 1);
                DataPoint point = new DataPoint(luna_an.ToOADate(), greutateMedie);
                seriegreutate.Points.Add(point);
                point.AxisLabel = luna_an.ToString("MMM \n yyyy");
            }
            adapter.Dispose();
        }


        private void txt_ora_tensiune_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ora_tensiune.Text))
            {
                txt_ora_tensiune.Text = ora2;
>>>>>>> Stashed changes
            }
        }

        private void btn_ok_glicemie_Click(object sender, EventArgs e) // FillChartGlicemie
        {
            int nrzile = 30; // Valoare implicită

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (!int.TryParse(textBox1.Text, out nrzile))
                {
                    MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Ieși din metodă dacă valoarea introdusă nu este validă
                }
            }
            else
            {
                textBox1.Text = "30";
            }

            con.Open();
            string query0 = "SELECT  AVG(glicemie) AS glicemie, data FROM  Glicemii where mancat=0 and data >= DATEADD(DAY, -1*@nrzile, GETDATE()) and id= @id  group by data ORDER BY data";
            DataSet ds0 = new DataSet();
            SqlCommand cmd0 = new SqlCommand(query0, con);
            cmd0.Parameters.AddWithValue("@id", utilizator);
            cmd0.Parameters.AddWithValue("@nrzile", nrzile);
            SqlDataAdapter adapter0 = new SqlDataAdapter(cmd0);
            adapter0.Fill(ds0);
            con.Close();

            var series0 = chart1.Series[0];
            series0.ChartType = SeriesChartType.Column;
            series0.Points.Clear();
            for (int i = 0; i < ds0.Tables[0].Rows.Count; i++)
            {
                DateTime date = (DateTime)ds0.Tables[0].Rows[i]["data"];
                int glicemie = Convert.ToInt32(ds0.Tables[0].Rows[i]["glicemie"]);
                DataPoint point = new DataPoint(date.ToOADate(), glicemie);
                series0.Points.Add(point);
                point.AxisLabel = date.ToString("dd/MM/yyyy");
            }

            con.Open();
            string query1 = "SELECT  AVG(glicemie) AS glicemie, data FROM  Glicemii where mancat=1 and data >= DATEADD(DAY, -1*@nrzile, GETDATE()) and id= @id  GROUP BY data";
            DataSet ds1 = new DataSet();
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.Parameters.AddWithValue("@id", utilizator);
            cmd1.Parameters.AddWithValue("@nrzile", nrzile);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            adapter1.Fill(ds1);
            con.Close();

            Series series1 = chart1.Series[1];
            series1.ChartType = SeriesChartType.Column;
            series1.Points.Clear();

            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                DateTime date = (DateTime)ds1.Tables[0].Rows[i]["data"];
                int glicemie = Convert.ToInt32(ds1.Tables[0].Rows[i]["glicemie"]);
                DataPoint point = new DataPoint(date.ToOADate(), glicemie);
                series1.Points.Add(point);
                point.AxisLabel = date.ToString("dd/MM/yyyy");
            }
        }

<<<<<<< Updated upstream
=======
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            Application.Exit();
        }

        private void btn_tratament_Click(object sender, EventArgs e)
        {
            new tratament(utilizator, nume).Show();
            this.Hide();
        }

>>>>>>> Stashed changes
        private void btn_glicemie_Click(object sender, EventArgs e)
        {
                txt_glicemie.Show();
                btn_glicemie.Show();
                btn_glicemieGata.Show();
                txt_ora_glicemie.Show();
                check_mancat.Show();
         }

        private void btn_tensiune_Click(object sender, EventArgs e)
        {
                txt_ora_tensiune.Show();
                txt_tensiune_minima.Show();
                txt_tensiune_maxima.Show();
                btn_tensiune.Show();
                btn_tensiuneGata.Show();
                check_sarat.Show();
                check_suparat.Show();
                check_efort.Show();

        }

        private void loadImagini()
        {
            imag = new List<Imagini>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [CaleFisier] FROM Amintiri", con);
            var red = cmd.ExecuteReader();
            while (red.Read())
            {
                imag.Add(new Imagini { CaleFisier = red[0].ToString() });
            }
            con.Close();
        }
    }
}
