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
            ArchiveBaseEntities2 database = new ArchiveBaseEntities2();
            Tag tag = new Tag();
            tag.Id=1;
            tag.TagName="Sterowniki";
            database.Tags.Add(tag);
            database.SaveChanges();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new userMenuInstall());
   
        }
    }
}
