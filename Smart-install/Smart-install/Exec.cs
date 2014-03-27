using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_install
{
    class Exec
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///[STAThreadAttribute] 
        [STAThread]
        static void Main()
        {
            //try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new userMenuInstall());
            }
            //catch (Exception ex)
            {
                
               // MessageBox.Show(ex.ToString());
            }
   
        }
    }
}
