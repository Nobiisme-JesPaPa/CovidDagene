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
        Double value = 0;
        string operation = "";
        public Calculator()
        {
            InitializeComponent();
        }


        //
        //Numrene på lommeregneren
        //
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
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Result.Text = "";
        }

        //
        // Opperator knapperne
        //
        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result.Text);
        }
    }
}
