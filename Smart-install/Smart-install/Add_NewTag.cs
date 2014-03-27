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
    public partial class Add_NewTag : Form
    {
        private NewArch _parent;
        public Add_NewTag(NewArch parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void ctr_add_newTag_Click(object sender, EventArgs e)
        {

            control.addTags(ctrTB_NewTag.Text);
            _parent.refresh();

        }
    }
}
