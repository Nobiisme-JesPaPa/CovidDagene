﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaMaMiaPizzaria
{
    public partial class MainPizza : Form
    {
        public MainPizza()
        {
            InitializeComponent();
        }

        private void Stor3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Medium3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BygSelf_Click(object sender, EventArgs e)
        {
            BygSelvForm bygSelv = new BygSelvForm();
            bygSelv.Show();
        }

        private void Vidre_Click(object sender, EventArgs e)
        {
            Drikkevare drikkevare = new Drikkevare();
            drikkevare.Show();
            this.Hide();
        }
    }
}
