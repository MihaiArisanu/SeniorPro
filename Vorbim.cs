using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SeniorPro
{
    public partial class Vorbim : Form
    {
        int utilizator;
        string nume;
        string txt = "Introdu textul dorit!";
        string apiUrl = ""; // înlocuiți cu URL-ul real al API-ului
        string secretKey = ""; // înlocuiți cu cheia secretă generată
        bool accept = false;
        bool schimbare = false;
        string numeChat ;
        string raspuns;
        string intrebare;
        ChatbotClient chatbotClient;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SeniorProConnectionString"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;

        public Vorbim(int a, string b)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            utilizator = a;
            nume = b;
            con.Open();
            cmd = new SqlCommand("SELECT numeBot FROM Utilizatori where id = @iduser", con);
            cmd.Parameters.AddWithValue("@iduser", utilizator);
            var red = cmd.ExecuteReader();
            if (red.Read())
                numeChat = red[0].ToString();
            red.Close();
            txtChat.Text = txt;
            txtChat.Click += txtChat_Click;
            txtChat.Leave += txtChat_Leave;

            indroducere();

            //Inițializare ChatbotClient
            //chatbotClient = new ChatbotClient(apiUrl, secretKey);
        }

        private void indroducere()
        {
            label5.Text = "Bună! Eu sunt "+ numeChat+", asistentul tău virtual\n Dacă vrei să mă strigi altfel, scrie !nume nou!";
           
        }

        private void txtChat_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChat.Text))
            {
                txtChat.Text = txt;
            }
        }

        private void txtChat_Click(object sender, EventArgs e)
        {
            txtChat.Clear();
        }

        /*private async void TrimiteIntrebareLaChatbot()
        {
            string intrebareUtilizator = txtChat.Text;
            string raspunsChatbot = await chatbotClient.TrimiteIntrebare(intrebareUtilizator); 
            // Utilizează metoda asincronă pentru a trimite întrebarea și aștepta răspunsul

            AdaugaMesajInChat("Chatbot", raspunsChatbot);
        }

        private void AdaugaMesajInChat(string autor, string mesaj)
        {
            txtChat.AppendText(autor + ": " + mesaj + Environment.NewLine);
        }*/

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            new Main(utilizator, nume).Show();
        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            string s = txtChat.Text;
            if (s.StartsWith("!") && s.EndsWith("!"))
            {
                numeChat = s.Substring(1, s.Length - 2);
                updateBaza(utilizator, numeChat);
            }
            else if  (s.StartsWith("!"))
            {
                txtChat.Text+= "\n "+ numeChat+": dacă vrei să mă strigi altfel scrie !nume nou!\n";
            }
            else 
            {
                txtChat.Text += "\n  Ma gandesc";
            }
            txtChat.Focus();
        }

        private void updateBaza(int idUtilizator, string numeBot)
        {
            string query = "UPDATE Utilizatori SET numeBot = @numeBot WHERE Id = @utilizator";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@utilizator", idUtilizator);
                cmd.Parameters.AddWithValue("@numeBot", numeBot);
                cmd.ExecuteNonQuery();
                label5.Text = "Bună! Eu sunt " + numeChat + ", asistentul tău virtual";
            }
        }

        private void btnAmintiri_Click(object sender, EventArgs e)
        {
            Hide();
            new Amintiri(utilizator, nume).Show();
        }

        private void btnConfigurari_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            new Main(utilizator, nume).Show();
        }
    }
}
