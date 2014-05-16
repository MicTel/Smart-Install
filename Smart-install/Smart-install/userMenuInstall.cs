using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Smart_install
{
    public partial class userMenuInstall : Form
    {
        private List<archiveInformation> _allArchive;
        public userMenuInstall()
        {
            InitializeComponent();
            initialize_ctr_All_InstalledProgram();
            initialize_ctr_getProgram();

        }

        private void initialize_ctr_getProgram()
        {
            _allArchive = control.getArchiveFromDatabase();
            foreach (archiveInformation Archive in _allArchive)
            {
                loadArchive(Archive);
            }

        }

        private void loadArchive(archiveInformation arch)
        { 
            TreeNode  list_arch = new TreeNode(arch.Name);
            foreach (programInformation programs in arch.programList)
            {
                TreeNode treePrograms = new TreeNode(programs.Name);
                list_arch.Nodes.Add(treePrograms);
            }
            ctrLT_arch.Nodes.Add(list_arch);
        }


        private void initialize_ctr_All_InstalledProgram()
        { 
            List<SearchProgram.InstallProgram> getProgramList =  SearchProgram.GetProgramList();
            foreach (SearchProgram.InstallProgram installedProg in getProgramList  )
            {
               int i = ctr_categoriesProgram.Rows.Add(installedProg.displayName, installedProg.displayVersion, installedProg.installDate);
            }
        
        }

        private void searchProgramInList()
        {
            //ctr_RB_searchProgramInList;
        }

        private void ctrLT_arch_NodeClicked(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                foreach (archiveInformation findArchInfo in _allArchive)
                {
                    if (findArchInfo.Name == e.Node.Parent.Text)
                    {
                        foreach (programInformation findProgInfo in findArchInfo.programList)
                        {
                            if (e.Node.Text == findProgInfo.Name)
                            {
                                viewDescriptionProg(findProgInfo);
                            }
                        }
                    }
                }
            }
            else
                foreach (archiveInformation findArchInfo in _allArchive)
                {
                    if (findArchInfo.Name == e.Node.Text)
                    {
                        viewDescriptionArch(findArchInfo);
                    }
                }

        }

        private void viewDescriptionProg(programInformation p)
        {
            ctr_RB_descriptionProgArch.Clear();
            ctr_RB_descriptionProgArch.AppendText("Nazwa: " + p.Name + "\n");
            ctr_RB_descriptionProgArch.AppendText("Opis: " + p.Description + "\n");
            ctr_RB_descriptionProgArch.AppendText("Wersja: " + p.Version + "\n");
            ctr_RB_descriptionProgArch.AppendText("Język: " + p.Language + "\n");
        }

        private void viewDescriptionArch(archiveInformation archInfo)
        {
            ctr_RB_descriptionProgArch.Clear();
            ctr_RB_descriptionProgArch.AppendText("Nazwa archiwum: " + archInfo.Name + "\n");
            ctr_RB_descriptionProgArch.AppendText("Opis archiwum: " + archInfo.Description + "\n");
            ctr_RB_descriptionProgArch.AppendText("Pełna ścieżka do archiwum: " + archInfo.fullPath + "\n");
            ctr_RB_descriptionProgArch.AppendText("Ścieżka do archiwum: " + archInfo.Path + "\n");
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        
        private void noweArchiwumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "tar Files (*.tar)|*.tar|zip Files (*.zip)|*.zip|" + "All files (*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null) { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void skórkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog okienkoKoloru = new ColorDialog();
            if (okienkoKoloru.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = okienkoKoloru.Color;
            }
        }

        //Trzeba poprawić , otwieranie ponownie okna
        private void noweArchiwumToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewArch windowArch = new NewArch(this);
            windowArch.Show();
        }

        private void zPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "zip Files (*.zip)|*.zip|" + "All files (*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archiveInformation arch = control.getArchiveInformaction(openFileDialog1.FileName);
                loadArchive(arch);
                _allArchive.Add(arch);
                
            }
        }

        private void pomocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help2 aboutHelp = new Help2();
            aboutHelp.Show();
        }


        private void ostatnioUżywaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dana funkcja nie została jeszcze zaimplementowana");
        }

      
        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dana funkcja nie została jeszcze zaimplementowana");
        }

        private void filtrujWgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dana funkcja nie została jeszcze zaimplementowana");
        }

        private void kategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dana funkcja nie została jeszcze zaimplementowana");
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dana funkcja nie została jeszcze zaimplementowana");
        }

        private void językToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dana funkcja nie została jeszcze zaimplementowana");
        }

        private void userMenuInstall_Load(object sender, EventArgs e)
        {

        }

        private void zamknijProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy napewno chcesz zamknąć program?", "Zamknij program",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ctrLT_arch_IsChecked(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            if(e.Node.Nodes.Count != 0)
                return;
            foreach (archiveInformation arch in _allArchive)
            {
                if (arch.Name == e.Node.Parent.Text)
                {
                    foreach (programInformation p in arch.programList)
                    {
                        if (p.Name == e.Node.Text)
                        {
                            p.isChecked = e.Node.Checked;
                        }
                    }
                }
            }
        }

        private void ctr_install_Click(object sender, EventArgs e)
        {
            List<programInformation> _listProgram = new List<programInformation>();
            foreach (archiveInformation arch in _allArchive)
            {
                foreach (programInformation p in arch.programList)
                {
                    if (p.isChecked)
                    {
                        _listProgram.Add(p);
                    }
                }
            }
            MenuInstall menuInstall = new MenuInstall(_listProgram);
            menuInstall.Show();
        }

        private void ctr_RB_searchProgramInList_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (DataGridViewRow item in ctr_categoriesProgram.Rows)
            {
                if (item.Cells[0].Value.ToString().ToLower().IndexOf(ctr_RB_searchProgramInList.Text.ToLower()) < 0)
                    item.Visible = false;
                else
                    item.Visible = true;
            }
        }
    }
}
