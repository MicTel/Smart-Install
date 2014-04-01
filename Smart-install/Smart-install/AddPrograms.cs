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

        private NewArch _parent;
        private bool _wasAdded;
        public AddPrograms(string Path, NewArch parent)
        {
            InitializeComponent();

            foreach (string tag in control.getTags())
            {
                ctr_tag.Items.Add(tag);
            }


            ctr_tag.Items.Add("Wpisz nową kategorię");
            _wasAdded = false;
            ctr_Path.Text = Path;
            _parent = parent;
        }

        private void ctr_AddProgramToBase_Click(object sender, EventArgs e)
        {
            List<string> list_tag = new List<string>() ;
            list_tag.Add(ctr_tag.Text);
            programInformation prog = new programInformation()
            {
                Name = ctr_Name.Text.ToString(),
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

            if (_wasAdded)
            {
                control.addTags(ctr_tag.Text);
                _parent.addProgram(prog, ctr_tag.Text);
            }
            else
                _parent.addProgram(prog);
            
            this.Close();
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
