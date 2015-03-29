using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGPol
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmMain frmMain = FrmMain.getInstance();
            Application.Run(frmMain);
        }
    }
}
