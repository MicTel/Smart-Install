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
        public userMenuInstall()
        {
            InitializeComponent();
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
            NewArch windowArch = new NewArch();
            windowArch.Show();
        }

        private void zPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "zip Files (*.zip)|*.zip|" + "All files (*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("wybrano plik: " + openFileDialog1.FileName);
            }
        }

        private void pomocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help aboutHelp = new Help();
            aboutHelp.Show();
        }


        private void ostatnioUżywaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dana funkcja nie została jeszcze zaimplementowana");
        }

        private void zamknijArchiwumToolStripMenuItem_Click(object sender, EventArgs e)
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
            if (MessageBox.Show("Czy napewno chcesz zamknąć program?", "userMenuInstall",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


    }
}
