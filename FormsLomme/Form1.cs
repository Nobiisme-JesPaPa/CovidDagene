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
        bool operation_presed = false;
        public Calculator()
        {
            InitializeComponent();
        }


        //
        //Numrene på lommeregneren
        //
            private void Button_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || (operation_presed))
                Result.Clear();

            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }
        //
        // Button Clear
        //
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        //
        // Opperator knapperne
        //
        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result.Text);
            operation_presed = true;
        }

        private void ButtonEaq_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                   
                    Result.Text = (value + double.Parse(Result.Text)).ToString();
                    break;
                       

                case "-":
                    Result.Text = (value + double.Parse(Result.Text)).ToString();
                    break;

                case "*":
                    Result.Text = (value + double.Parse(Result.Text)).ToString();
                    break;

                case "/":
                    Result.Text = (value + double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_presed = false;
        }

    
    }
}
