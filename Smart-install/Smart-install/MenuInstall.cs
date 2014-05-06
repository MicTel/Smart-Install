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
    public partial class MenuInstall : Form
    {
        private List<programInformation> _allProgram;
        public MenuInstall(List<programInformation> progs)
        {
            InitializeComponent();
            _allProgram = progs;
            initialize_ctr_ListInstalationProgram();
        }

        private void pomocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help2 aboutHelp = new Help2();
            aboutHelp.Show();
        }

        private void zamknijOknoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initialize_ctr_ListInstalationProgram()
        {
            foreach (programInformation programs in _allProgram)
            {
                ctr_ListInstalationProgram1.Rows.Add(programs.Name, "Oczekiwanie");
            }
        }
    }
}
