using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLomme
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            Result.Text += "1";
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            Result.Text += "2";
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            Result.Text += "3";
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            Result.Text += "4";
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            Result.Text += "5";
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            Result.Text += "6";
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            Result.Text += "7";
        }

        private void ButtonEIght_Click(object sender, EventArgs e)
        {
            Result.Text += "8";
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            Result.Text += "9";
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Result.Text += "+";
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            Result.Text += "-";
        }

        private void ButtonTimes_Click(object sender, EventArgs e)
        {
            Result.Text += "X";
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            Result.Text += "/";
        }
    }
}
