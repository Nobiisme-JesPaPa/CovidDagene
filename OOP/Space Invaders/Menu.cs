using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace SpaceInvaders {
    public partial class Menu : Form {
        public static short gameMode = 0;
        string[] scoresSP = new string[] { "0", "0", "0" };
        string[] scoresMP = new string[] { "0", "0", "0" };
        string fileNameSP = Path.Combine(Environment.CurrentDirectory, "highscoreSingle.txt");
        public Menu()
        {
            InitializeComponent();


            using (StreamReader fileRead = new StreamReader(fileNameSP))
            {
                scoresSP[0] = fileRead.ReadLine();
                scoresSP[1] = fileRead.ReadLine();
                scoresSP[2] = fileRead.ReadLine();
            }
        }
            

        public GameForm SinglePlayerForm
        {
            get => default;
            set
            {
            }
        }

        private void onePlayerButton_Click(object sender, EventArgs e)
        {
            gameMode = 1;
            Close();
        }
    }
}
