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
    public partial class Help2 : Form
    {
        public Help2()
        {
            InitializeComponent();
        }


        private void ctrLV_options_clicked(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
           //if (ctrLV_options.SelectedNode.Checked == e.Node.Checked)
           //{
           //}

            switch (e.Node.Index)
            {
                case 0:
                    ctrRTB_description.Text = "     Michał Telus" + "\n" + "     Mateusz Schalau" + "\n"
                + "     Patryk Kosiorek" + "\n" + "     Natalia Rybarczyk" + "\n";
                    break;
                case 1:
                    ctrRTB_description.Text = " Program wymaga: \n      .NET framework 4.5 \n       SQL Serwer 2012";
                    break;
                case 2:
                    ctrRTB_description.Text = " Strona programu online: \n ";
                    break;
            }
        }

    }
}
