using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SpaceInvaders {
    static class Program
    {


        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());

            if (Menu.gameMode == 1) {
                Application.Run(new GameForm());
            }
        }
    }
}
