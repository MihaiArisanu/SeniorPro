using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SeniorPro
{
    public partial class Vorbim : Form
    {
        int utilizator;
        string nume;
        string txt = "Introdu textul dorit!";
        string apiUrl = ""; // înlocuiți cu URL-ul real al API-ului
        string secretKey = ""; // înlocuiți cu cheia secretă generată
        bool accept;
        string numeChat = "Chaty";
        ChatbotClient chatbotClient;

        public Vorbim(int a, string b)
        {
            InitializeComponent();

            utilizator = a;
            nume = b;

            txtChat.Text = txt;
            txtChat.Click += txtChat_Click;
            txtChat.Leave += txtChat_Leave;

            label2.Visible = false;
            label3.Visible = false;

            // Inițializare ChatbotClient
            //chatbotClient = new ChatbotClient(apiUrl, secretKey);
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
            if (txtChat.Text == txt)
            {
                txtChat.Text = "";
            }
        }

        /*private async void TrimiteIntrebareLaChatbot()
        {
            string intrebareUtilizator = txtChat.Text;
            string raspunsChatbot = await chatbotClient.TrimiteIntrebare(intrebareUtilizator); // Utilizează metoda asincronă pentru a trimite întrebarea și aștepta răspunsul

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

        private void btnSend_Click(object sender, EventArgs e)
        {
                if (txtChat.Text != txt)
                {
                    label3.Visible = true;
                    label3.Text = nume + ":" + txtChat.Text;
                    txtChat.Text = txt;
                //TODO TrimiteIntrebareLaChatbot();
                }
        }
    }
}
