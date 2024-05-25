using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Globalization;
using System.Configuration;

namespace SeniorPro
{
    public partial class Main : Form
    {
        private string txt1 = "Glicemie", ora1 = "Ora, fara minute", txt2 = "Maxima", txt3 = "Minima", ora2 = "Ora, fara minute", txt4 = "Greutate";
        SqlConnection con;
        int utilizator;
        string nume;

        public Main(int a, string b)
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);

            utilizator = a;
            nume = b;

            label1.Text = label1.Text + " " + b;

            btn_glicemie.Enabled = false;
            btn_tensiune.Enabled = false;
            btn_Greutate.Enabled = false;

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

            txt_Greutate.Text = txt4;
            txt_Greutate.Click += txt_Greutate_Click;
            txt_Greutate.Leave += txt_Greutate_Leave;
            
            this.WindowState = FormWindowState.Maximized;
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
                    string query = "INSERT INTO Glicemii (IdUser, glicemie, data, mancat, ora) VALUES (@id, @glice, @ziua, @masa, @ora)";
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
                    string query = "INSERT INTO Tensiuni (IdUser, TA_Sistolica, TA_Diastolica, data, sare, suparare, efort, ora) " +
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
                    con.Close();
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();

               
                    MessageBox.Show("Înregistrare reușită!");
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

        private void btnGreutate_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT NumarKg " +
                "FROM Greutate WHERE IdUser = @id AND data = @ziua";
            SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", utilizator);
                    cmd.Parameters.AddWithValue("@greutate", numarKg);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now.Date);

            var red = cmd.ExecuteReader();
            if (red.Read())
            {
                MessageBox.Show("Azi ati inregistrat deja greutatea dumneavoastra, " + red[0] + " Kg");
            }
            else
            {
                txt_Greutate.Show();
                btn_GreutateGata.Visible = true;
            }

            con.Close();
            red.Close();
        }

        private void txt_Greutate_Click(object sender, EventArgs e)
        {
            if (txt_Greutate.Text == txt4)
            {
                txt_Greutate.Text = "";
            }
        }

        private void btn_greutate_Click(object sender, EventArgs e)
        {
            txtGreuate.Visible = true;
            btn_greautateGata.Visible = true;
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
        }

        private void txt_ora_tensiune_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ora_tensiune.Text))
            {
                txt_ora_tensiune.Text = ora2;
                txt_Greutate.Text = txt4;
            }
        }

        private void btn_greutateGata_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txt_Greutate.Text, out int numarKg))
            {
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
                    txt_Greutate.Clear();
                    txt_Greutate.Focus();
                }
                MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă în câmpul greutate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_send_greutate_Click(object sender, EventArgs e)
        {
            if (chart3.Series[0].Points.Count > 0)
            {
                string folderPath = Path.Combine(Application.StartupPath, "Grafic greutate");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string imagePath = Path.Combine(folderPath, "greutate_" + DateTime.Today.ToString("dd_MM_yyyy") + ".png");
                chart3.SaveImage(imagePath, ChartImageFormat.Png);

                MessageBox.Show("Imaginea a fost salvata in folderul Grafic greutate");
            }
            else
            {
                MessageBox.Show("Afisati mai intai graficul dorit");
            }
        }

        private void btnAmintiri_Click(object sender, EventArgs e)
        {
            Hide();
            new Amintiri(utilizator, nume).Show();
        }

        private void btn_configurari_Click(object sender, EventArgs e)
        {
            Hide();
            new Configurari(utilizator, nume).Show();
        }

        private void btnVorbim_Click(object sender, EventArgs e)
        {
            Hide();
            new Vorbim(utilizator, nume).Show();
        }

        private void btnTratament_Click(object sender, EventArgs e)
        {
            Hide();
            new tratament(utilizator, nume).Show();
        }

        private void btnOprire_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            Application.Exit();
        }

        private void btn_ok2_Click(object sender, EventArgs e)
        {
            int nrzile = 7;

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (!int.TryParse(textBox2.Text, out nrzile))
                {
                    MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                textBox2.Text = "7";
            }

            con.Open();
            string query0 = "SELECT T1.TA_Diastolica as TA_Diastolica, T1.TA_Sistolica as TA_Sistolica, T1.data as data, " +
                "T1.efort as efort, T1.sare as sare, T1.suparare as suparare FROM " +
                "(SELECT TA_Diastolica, TA_Sistolica, data, efort, sare, suparare FROM Tensiuni " +
                "WHERE data >= DATEADD(DAY, -1 * @nrzile, GETDATE()) AND IdUser = @id) T1 " +
                "JOIN (SELECT data, MAX(TA_Sistolica) AS MaxSistolica FROM Tensiuni " +
                "WHERE data >= DATEADD(DAY, -1 * @nrzile, GETDATE()) AND IdUser = @id GROUP BY data) T2 " +
                "ON T1.data = T2.data AND T1.TA_Sistolica= T2.MaxSistolica order by T1.data";


            DataTable dt0 = new DataTable();

            SqlCommand cmd0 = new SqlCommand(query0, con);
            cmd0.Parameters.AddWithValue("@id", utilizator);
            cmd0.Parameters.AddWithValue("@nrzile", nrzile);
            SqlDataAdapter adapter0 = new SqlDataAdapter(cmd0);
            adapter0.Fill(dt0);
            con.Close();

            Series seriesDiastolica = chart2.Series[1];
            Series seriesSistolica = chart2.Series[0];

            seriesDiastolica.ChartType = SeriesChartType.Column;
            seriesDiastolica.Points.Clear();

            seriesSistolica.ChartType = SeriesChartType.Column;
            seriesSistolica.Points.Clear();

            for (int i = 0; i < dt0.Rows.Count; i++)
            {
                DateTime date = (DateTime)dt0.Rows[i]["data"];
                int sistolica = Convert.ToInt32(dt0.Rows[i]["TA_Sistolica"]);
                int diastolica = Convert.ToInt32(dt0.Rows[i]["TA_Diastolica"]);

                DataPoint pointSistolica = new DataPoint(date.ToOADate(), sistolica);
                seriesSistolica.Points.Add(pointSistolica);
                DataPoint pointDiastolica = new DataPoint(date.ToOADate(), diastolica);
                seriesDiastolica.Points.Add(pointDiastolica);

                int ef = Convert.ToInt32(dt0.Rows[i]["efort"]);
                int sup = Convert.ToInt32(dt0.Rows[i]["suparare"]);
                int sr = Convert.ToInt32(dt0.Rows[i]["sare"]);

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

        private void btn_send_tensiune_Click(object sender, EventArgs e)
        {
            if (chart2.Series[0].Points.Count > 0)
            {
                string folderPath = Path.Combine(Application.StartupPath, "Grafic tensiune");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string imagePath = Path.Combine(folderPath, "tensiune_" + DateTime.Today.ToString("dd_MM_yyyy") + ".png");
                chart2.SaveImage(imagePath, ChartImageFormat.Png);

                MessageBox.Show("Imaginea a fost salvata in folderul Grafic tensiune");
            }
            else
            {
                MessageBox.Show("Afisati mai intai graficul dorit");
            }
        }

        private void btn_ok_glicemie_Click(object sender, EventArgs e)
        {
            int nrzile = 7;

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (!int.TryParse(textBox1.Text, out nrzile))
                {
                    MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                textBox1.Text = "7";
            }

            con.Open();
            string query0 = "SELECT  AVG(glicemie) AS glicemie, data " +
                "FROM  Glicemii where mancat=0 and data >= DATEADD(DAY, -1*@nrzile, GETDATE()) and idUser= @id  " +
                "group by data ORDER BY data";
            DataTable dt0 = new DataTable();
            SqlCommand cmd0 = new SqlCommand(query0, con);
            cmd0.Parameters.AddWithValue("@id", utilizator);
            cmd0.Parameters.AddWithValue("@nrzile", nrzile);
            SqlDataAdapter adapter0 = new SqlDataAdapter(cmd0);
            adapter0.Fill(dt0);
            con.Close();

            var series0 = chart1.Series[0];
            series0.ChartType = SeriesChartType.Column;
            series0.Points.Clear();
            for (int i = 0; i < dt0.Rows.Count; i++)
            {
                DateTime date = (DateTime)dt0.Rows[i]["data"];
                int glicemie = Convert.ToInt32(dt0.Rows[i]["glicemie"]);
                DataPoint point = new DataPoint(date.ToOADate(), glicemie);
                series0.Points.Add(point);
                point.AxisLabel = date.ToString("dd/MM/yyyy");
            }

            con.Open();
            string query1 = "SELECT  AVG(glicemie) AS glicemie, data " +
                "FROM  Glicemii where mancat=1 and data >= DATEADD(DAY, -1*@nrzile, GETDATE()) and idUser= @id  " +
                "GROUP BY data";
            DataTable dt1 = new DataTable();
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

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count > 0)
            {
                string folderPath = Path.Combine(Application.StartupPath, "Grafic glicemie");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string imagePath = Path.Combine(folderPath, "glicemie_" + DateTime.Today.ToString("dd_MM_yyyy") + ".png");
                chart1.SaveImage(imagePath, ChartImageFormat.Png);

                MessageBox.Show("Imaginea a fost salvata in folderul Grafic glicemie");
            }
            else
            {
                MessageBox.Show("Afisati mai intai graficul dorit");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CheckBirthdays();
        }

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

        private void CheckBirthdays()
        {
            con.Open();

            DateTime today = DateTime.Today;
            int todayDay = today.Day;
            int todayMonth = today.Month;
            CultureInfo romanianCulture = new CultureInfo("ro-RO");

            string query = "SELECT nume, data_nasterii " +
                "FROM Persoane " +
                 "WHERE DAY(data_nasterii) = @todayDay AND MONTH(data_nasterii) = @todayMonth";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@todayDay", todayDay);
            cmd.Parameters.AddWithValue("@todayMonth", todayMonth);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                string monthName = today.ToString("MMMM", romanianCulture);
                string formattedDate = $"{todayDay} {monthName}";

                string s = "Data de astăzi este " + formattedDate + "\n\n";
                while (reader.Read())
                {
                    string nume = reader["nume"].ToString();
                    s += nume + " își sărbătorește ziua de naștere\n\n";
                }
                MessageBox.Show(s,"La mulți ani!");
            }
            else
            {
                reader.Close();

                query = "SELECT nume, data_nasterii " +
                "FROM Persoane " +
                "WHERE MONTH(data_nasterii) = @todayMonth";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@todayMonth", todayMonth);

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    string monthName = today.ToString("MMMM", romanianCulture);
                    string s = "Suntem în luna " + monthName + "\n\n";

                    while (reader.Read())
                    {
                        string nume = reader["nume"].ToString();
                        DateTime dn = Convert.ToDateTime(reader["data_nasterii"]);
                        string zi = dn.Day.ToString();
                        s += nume + " își sărbătorește ziua de naștere pe " + zi + "\n\n";
                    }
                    MessageBox.Show(s, "La mulți ani!");

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Nu este nicio zi de naștere în această lună.");
                }
            }
            con.Close();
        }
    }
}
