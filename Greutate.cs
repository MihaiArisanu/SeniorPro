﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorPro
{
    public partial class Greutate : Form
    {
        int utilizator;
        string nume;

        public Greutate(int a, string b)
        {
            InitializeComponent();
            
            nume = b;
            utilizator = a;
        }

        private void Greutate_Load(object sender, EventArgs e)
        {

        }
    }
}