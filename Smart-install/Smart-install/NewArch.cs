﻿using System;
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

    public partial class NewArch : Form
    {
        /// <summary>
        /// zmienna wybierania poszczegolnych kategorii 
        /// </summary>
        private List<string> _selectedTag;
 

        public NewArch()
        {
            InitializeComponent();
            control.addTags("Edukacja");
            control.addTags("Muzyka");
            control.addTags("Grafika");
            add_to_lis_tag();



            //foreach (string tag in control.getTags())
            //{
            //    ctr_Tag.Items.Add((Object)tag); 
            //}
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// sprawdzam czy zostało zaznaczony jakis tak , jeśli tak to dodaje go do _selecttag
        /// a w przeciwnym wypadku to usuwam go z _selecttag
        /// zapyta o programy z tagow (string)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             //_selectedTag
            List<string> listNameTag = new List<string>();
            CheckedListBox.CheckedItemCollection checkedTag = ctr_Tag.CheckedItems;
            foreach (var tag in checkedTag)
            {
                listNameTag.Add(tag.ToString());
                              
            }

            List<string> returnListNameTag = new List<string>(); //control.getPrograms(listNameTag);
           ctr_ProgramsList.Items.AddRange(returnListNameTag.ToArray<object>());
        }

        private void add_to_list_program()
        { 
            foreach (string tag in control.getPrograms(_selectedTag))
            {
                ctr_ProgramsList.Items.Add((Object)tag); 
            }
        
        }

        private void add_to_lis_tag()
        {
            foreach (string tag in control.getTags())
            {
                ctr_Tag.Items.Add((Object)tag);
            }

        }


        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        private void zPlikuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "tar Files (*.tar)|*.tar|zip Files (*.zip)|*.zip|" + "All files (*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("wybrano plik: " + openFileDialog1.FileName);
            }
        }

        private void noweArchiwumToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "tar Files (*.tar)|*.tar|zip Files (*.zip)|*.zip|" + "All files (*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "zip files (*.zip)|*.zip|" + "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
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

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog okienkoCzcionki = new FontDialog();
            
        }

        private void pomocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help aboutHelp = new Help();
            aboutHelp.Show();
        }

        private void ostatnioUżywaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Otwórz okno wyboru by użytkownik mógł wybrać plik
            //StorageFile pickedFile = await openPicker.PickSingleFileAsync();
            // Dodaj wybrany plik do listy MRU
        //    String mruToken = Windows.Storage.AccessCache.StorageApplicationPermissions.MostRecentlyUsedList.Add(pickedFile, pickedFile.Name);   
        }

        private void clickButton_addProgram_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "misc Files (*.misc)|*.misc|exe Files (*.exe)|*.exe|" + "All files (*.*)|*.*";;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            AddPrograms addProgram2 = new AddPrograms();
                            addProgram2.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void ctr_ProgramsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ctr_ProgramsList. 
            string curItem = ctr_ProgramsList.SelectedItem.ToString();
            
            // Find the string in ctr_programsList. 
            int index = ctr_ProgramsList.FindString(curItem);
            
            // If the item was not found in ctr_ProgramsList display a message box, 
            //otherwise select it in ctr_ProgramList. 
            //if(index == -1)
            //    MessageBox.Show("Programu nie ma na liście programów");
            //else
            //    ctr_ProgramsList.SetSelected(index,true);
            if (((CheckBox)ctr_ProgramsList.Items[index]).Checked)
                ctr_checkedPrograms.Items.Add(curItem);
            else
                ctr_checkedPrograms.Items.Remove(curItem);
        }

        private void ctr_refillAll_Click(object sender, EventArgs e)
        {
            
        }

    }
}
