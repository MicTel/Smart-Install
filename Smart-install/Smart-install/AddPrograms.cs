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
    public partial class AddPrograms : Form
    {
        private string exe;
        private NewArch _parent;
        private bool _wasAdded;
        
       
        
        
        public AddPrograms(string Path, NewArch parent)
        {
            InitializeComponent();
            string[] tabExe = Path.Split(new char[] { '.' });
            exe = tabExe[tabExe.Count() - 1];
            foreach (string tag in control.getTags())
            {
                ctr_tag.Items.Add(tag);
            }
            ctr_tag.Items.Add("Wpisz nową kategorię");
            _wasAdded = false;
            ctr_Path.Text = Path;
            ctr_Path.Enabled = false;
            _parent = parent;
            programInformation progr = SearchProgram.AboutProgram(Path);
            ctr_description.Text = progr.Description;
            ctr_language.Text = progr.Language;
            ctr_Name.Text = progr.Name;
            ctr_versionprog.Text = progr.Version;
            ctr_Icon.Image = (Image)progr.Icon;
            //ctr_Icon.ClientSize = new Size(450,150);
            this.ctr_AddProgramToBase.Click += new System.EventHandler(this.ctr_AddProgramToBase_ClickAdd);
        }

        public AddPrograms(programInformation firstProgram, NewArch parent)
        {
            InitializeComponent();
            foreach (Control contr in this.Controls)
            {
                contr.Enabled = false;
            }
            
            foreach (string tag in control.getTags())
            {
                ctr_tag.Items.Add(tag);
            }
            _parent = parent;

            ctr_description.Text = firstProgram.Description;
            ctr_language.Text = firstProgram.Language;
            ctr_linkToHelp.Text = firstProgram.HelpLink;
            ctr_linkToUpdate.Text = firstProgram.URLUpdate;
            ctr_Name.Text = firstProgram.Name;
            ctr_Path.Text = firstProgram.Path;
            ctr_system.Text = firstProgram.systemType;
            ctr_tag.Visible = false;
            ctrTB_NewTag.Visible = true;
            ctrTB_NewTag.Text = firstProgram.Tags[0];
            ctr_AddProgramToBase.Text = "Usuń program";
            ctr_AddProgramToBase.Enabled = true;
            this.ctr_AddProgramToBase.Click += new System.EventHandler(this.ctr_AddProgramToBase_ClickDelete);
        }

        private void ctr_AddProgramToBase_ClickAdd(object sender, EventArgs e)
        {
            if (ctr_tag.Text == "")
            {
                MessageBox.Show("Musisz wybrać kategorię");
                return;
            }
            List<string> list_tag = new List<string>();
            list_tag.Add(ctr_tag.Text);
            programInformation prog = new programInformation()
            {
                Name = ctr_Name.Text.ToString() + "." + exe,
                Version = ctr_versionprog.Text.ToString(),
                systemType = ctr_system.Text.ToString(),
                Description = ctr_description.Text.ToString(),
                Language = ctr_language.Text.ToString(),
                HelpLink = ctr_linkToHelp.Text.ToString(),
                URLUpdate = ctr_linkToUpdate.Text.ToString(),
                Tags = list_tag,
                // Icon = ctr_Ikon,
                Path = ctr_Path.Text.ToString()


            };
            foreach (programInformation p in _parent.allPrograms)
            {
                if (p.Name == prog.Name)
                {
                    MessageBox.Show("Program o podanej nazwie już istnieje");
                    AddPrograms OldProgram = new AddPrograms(p,_parent);
                    OldProgram.Show();
                    return;
                }
            }

            if (_wasAdded)
            {
                control.addTags(ctr_tag.Text);
                _parent.addProgram(prog, ctr_tag.Text);
            }
            else
                _parent.addProgram(prog);

            this.Close();
        }

        private void ctr_AddProgramToBase_ClickDelete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy napewno chcesz usunąć program z bazy?","Usunięcie programu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _parent.DeleteProgram(ctr_Name.Text);
                this.Close();
            }
            
        }

        private void ctr_tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctr_tag.Text == "Wpisz nową kategorię")
            {
                ctr_tag.Visible = false;
                ctrTB_NewTag.Visible = true;
                ctrTB_NewTag.Text = "Wpisz nową kategorię";
                ctrTB_NewTag.Select();
            }
        }

        private void ctrTB_NewTagKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ctr_tag.Items.RemoveAt(ctr_tag.Items.Count - 1);
                    ctr_tag.Items.Add(ctrTB_NewTag.Text);
                    ctr_tag.Items.Add("Wpisz nową kategorię");
                    ctr_tag.Text = ctr_tag.Items[ctr_tag.Items.Count-2].ToString();
                    ctr_tag.Visible = true;
                    ctrTB_NewTag.Visible = false;
                    _wasAdded = true;
                break;
                case Keys.Escape:
                    ctr_tag.Visible = true;
                    ctrTB_NewTag.Visible = false;
                    _wasAdded = true;
                break;
            }
        }
        
    }
}
