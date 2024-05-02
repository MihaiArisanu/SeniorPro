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
    public partial class DatePersonale : Form
    {
        int utilizator;
        string nume;

        public DatePersonale(int a, string b)
        {
            InitializeComponent();

            nume = b;
            utilizator = a;
        }
    }
}
