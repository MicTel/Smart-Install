using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_install
{
    public partial class MenuInstall : Form
    {
        private int index;
        public void ChangeStatus() 
        {
            if (_allProgram.Count == index+1)
            {
                MessageBox.Show("Zakończono instalacje programów");
                this.Close();
                return;
            }
            ctr_ListInstalationProgram1.Rows[index].Cells[1].Value = "Zakonczona";
            index++;
            if (_allProgram.Count > index && index>=0)
            {
                ctr_ListInstalationProgram1.Rows[index].Cells[1].Value = "Instalacja";
            }
        }

        private List<programInformation> _allProgram;
        public MenuInstall(List<programInformation> progs)
        {
            
            index = 0;
            InitializeComponent();
            _allProgram = progs;
            initialize_ctr_ListInstalationProgram();
            ctr_ListInstalationProgram1.Rows[index].Cells[1].Value = "Instalacja";
            Task.Run(() =>
            {
                InstallProgram instal = new InstallProgram(this);
                instal.StartInstallPrograms(_allProgram);
            });
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
