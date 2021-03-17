using System;
using System.Windows.Forms;

namespace ProjektNr2_Kruhlov48720
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dk_Form());
        }
    }
}
