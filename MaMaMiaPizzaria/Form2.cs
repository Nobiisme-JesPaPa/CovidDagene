using System;
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
    public partial class BygSelvForm : Form
    {
        public BygSelvForm()
        {
            InitializeComponent();
        }

        private void PizzaFærdig_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
