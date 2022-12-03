using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPaperNotes
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Splash());
            Splash splash = new Splash();
            //condiconal para cerrar el splash
            
            if (splash.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Login());
            }
        }
    }
}
