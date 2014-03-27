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
        public AddPrograms(string Path, NewArch parent)
        {
            InitializeComponent();
            ctr_Path.Text = Path;
            _parent = parent;
        }

        private void ctr_AddProgramToBase_Click(object sender, EventArgs e)
        {
            programInformation prog = new programInformation()
            {
                Name = ctr_Name.Text.ToString(),
                Version = ctr_versionprog.Text.ToString(),
                systemType = ctr_system.Text.ToString(),
                Description = ctr_description.Text.ToString(),
                Language = ctr_language.Text.ToString(),
                HelpLink = ctr_linkToHelp.Text.ToString(),
                URLUpdate = ctr_linkToUpdate.Text.ToString(),
                //Tags = ctr_tag.SelectedText.ToList<string>(),
               // Icon = ctr_Ikon,
                Path = ctr_Path.Text.ToString()
                
               
            };
            _parent._AllNewPrograms.Add(prog);
            _parent.refresh();
            this.Close();
        }

        
    }
}
