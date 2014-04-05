using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_install
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void ctrLT_descriptionHelp_clicked(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            //string N_Autors = "Autorzy";
            //if ( e.Node.Name == e.Node.Text(N_Autors))
            
            if (ctrLT_descriptionHelp.SelectedNode.Name == "Autorzy")
            {
                ctrRTB_description.Text = "Michał Telus, Mateusz Schalau, Patryk Kosiorek, Natalia Rybarczyk";
            }
            
        }
    }
}
