namespace Smart_install
{
    partial class NewArch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.językToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skórkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stronaProgramuOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctr_Tag = new System.Windows.Forms.CheckedListBox();
            this.ctr_ProgramsList = new System.Windows.Forms.CheckedListBox();
            this.ctr_addProgram = new System.Windows.Forms.Button();
            this.ctr_checkedPrograms = new System.Windows.Forms.CheckedListBox();
            this.ctr_createArch = new System.Windows.Forms.Button();
            this.ctr_textDescription = new System.Windows.Forms.RichTextBox();
            this.label_tag = new System.Windows.Forms.Label();
            this.label2_listprogram = new System.Windows.Forms.Label();
            this.label3_descriptionProgram = new System.Windows.Forms.Label();
            this.label4_choiceProgram = new System.Windows.Forms.Label();
            this.ctr_clickAll = new System.Windows.Forms.Button();
            this.ctr_refillAll = new System.Windows.Forms.Button();
            this.dodajKatekorięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaToolStripMenuItem1,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKatekorięToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // ustawieniaToolStripMenuItem1
            // 
            this.ustawieniaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.językToolStripMenuItem,
            this.skórkiToolStripMenuItem,
            this.czcionkaToolStripMenuItem});
            this.ustawieniaToolStripMenuItem1.Name = "ustawieniaToolStripMenuItem1";
            this.ustawieniaToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem1.Text = "Ustawienia";
            // 
            // językToolStripMenuItem
            // 
            this.językToolStripMenuItem.Name = "językToolStripMenuItem";
            this.językToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.językToolStripMenuItem.Text = "Język";
            // 
            // skórkiToolStripMenuItem
            // 
            this.skórkiToolStripMenuItem.Name = "skórkiToolStripMenuItem";
            this.skórkiToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.skórkiToolStripMenuItem.Text = "Kolor tła";
            this.skórkiToolStripMenuItem.Click += new System.EventHandler(this.skórkiToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stronaProgramuOnlineToolStripMenuItem,
            this.pomocToolStripMenuItem1});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // stronaProgramuOnlineToolStripMenuItem
            // 
            this.stronaProgramuOnlineToolStripMenuItem.Name = "stronaProgramuOnlineToolStripMenuItem";
            this.stronaProgramuOnlineToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.stronaProgramuOnlineToolStripMenuItem.Text = "Strona programu online";
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            this.pomocToolStripMenuItem1.Click += new System.EventHandler(this.pomocToolStripMenuItem1_Click);
            // 
            // ctr_Tag
            // 
            this.ctr_Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_Tag.FormattingEnabled = true;
            this.ctr_Tag.Location = new System.Drawing.Point(12, 52);
            this.ctr_Tag.Name = "ctr_Tag";
            this.ctr_Tag.Size = new System.Drawing.Size(217, 174);
            this.ctr_Tag.Sorted = true;
            this.ctr_Tag.TabIndex = 1;
            this.ctr_Tag.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // ctr_ProgramsList
            // 
            this.ctr_ProgramsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_ProgramsList.FormattingEnabled = true;
            this.ctr_ProgramsList.Location = new System.Drawing.Point(235, 51);
            this.ctr_ProgramsList.Name = "ctr_ProgramsList";
            this.ctr_ProgramsList.Size = new System.Drawing.Size(208, 174);
            this.ctr_ProgramsList.Sorted = true;
            this.ctr_ProgramsList.TabIndex = 2;
            this.ctr_ProgramsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ctr_ProgramsList_SelectedIndexChanged);
            // 
            // ctr_addProgram
            // 
            this.ctr_addProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_addProgram.Location = new System.Drawing.Point(655, 368);
            this.ctr_addProgram.Name = "ctr_addProgram";
            this.ctr_addProgram.Size = new System.Drawing.Size(169, 61);
            this.ctr_addProgram.TabIndex = 3;
            this.ctr_addProgram.Text = "Dodaj program";
            this.ctr_addProgram.UseVisualStyleBackColor = true;
            this.ctr_addProgram.Click += new System.EventHandler(this.clickButton_addProgram_Click);
            // 
            // ctr_checkedPrograms
            // 
            this.ctr_checkedPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_checkedPrograms.FormattingEnabled = true;
            this.ctr_checkedPrograms.Location = new System.Drawing.Point(12, 289);
            this.ctr_checkedPrograms.Name = "ctr_checkedPrograms";
            this.ctr_checkedPrograms.Size = new System.Drawing.Size(431, 140);
            this.ctr_checkedPrograms.TabIndex = 4;
            // 
            // ctr_createArch
            // 
            this.ctr_createArch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_createArch.Location = new System.Drawing.Point(462, 368);
            this.ctr_createArch.Name = "ctr_createArch";
            this.ctr_createArch.Size = new System.Drawing.Size(169, 61);
            this.ctr_createArch.TabIndex = 5;
            this.ctr_createArch.Text = "Utwórz archiwum";
            this.ctr_createArch.UseVisualStyleBackColor = true;
            // 
            // ctr_textDescription
            // 
            this.ctr_textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_textDescription.Location = new System.Drawing.Point(462, 52);
            this.ctr_textDescription.Name = "ctr_textDescription";
            this.ctr_textDescription.Size = new System.Drawing.Size(362, 300);
            this.ctr_textDescription.TabIndex = 6;
            this.ctr_textDescription.Text = "";
            // 
            // label_tag
            // 
            this.label_tag.AutoSize = true;
            this.label_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_tag.Location = new System.Drawing.Point(9, 33);
            this.label_tag.Name = "label_tag";
            this.label_tag.Size = new System.Drawing.Size(126, 15);
            this.label_tag.TabIndex = 10;
            this.label_tag.Text = "Kategorie programów";
            // 
            // label2_listprogram
            // 
            this.label2_listprogram.AutoSize = true;
            this.label2_listprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2_listprogram.Location = new System.Drawing.Point(232, 33);
            this.label2_listprogram.Name = "label2_listprogram";
            this.label2_listprogram.Size = new System.Drawing.Size(99, 15);
            this.label2_listprogram.TabIndex = 11;
            this.label2_listprogram.Text = "Lista programów";
            // 
            // label3_descriptionProgram
            // 
            this.label3_descriptionProgram.AutoSize = true;
            this.label3_descriptionProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3_descriptionProgram.Location = new System.Drawing.Point(459, 33);
            this.label3_descriptionProgram.Name = "label3_descriptionProgram";
            this.label3_descriptionProgram.Size = new System.Drawing.Size(161, 15);
            this.label3_descriptionProgram.TabIndex = 12;
            this.label3_descriptionProgram.Text = "Szczegółowy opis programu";
            // 
            // label4_choiceProgram
            // 
            this.label4_choiceProgram.AutoSize = true;
            this.label4_choiceProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4_choiceProgram.Location = new System.Drawing.Point(12, 271);
            this.label4_choiceProgram.Name = "label4_choiceProgram";
            this.label4_choiceProgram.Size = new System.Drawing.Size(246, 15);
            this.label4_choiceProgram.TabIndex = 13;
            this.label4_choiceProgram.Text = "Wybrane programy do stworzenia archiwum";
            // 
            // ctr_clickAll
            // 
            this.ctr_clickAll.Location = new System.Drawing.Point(12, 232);
            this.ctr_clickAll.Name = "ctr_clickAll";
            this.ctr_clickAll.Size = new System.Drawing.Size(104, 25);
            this.ctr_clickAll.TabIndex = 14;
            this.ctr_clickAll.Text = "Zaznacz wszystko";
            this.ctr_clickAll.UseVisualStyleBackColor = true;
            this.ctr_clickAll.Click += new System.EventHandler(this.ctr_clickAll_Click);
            // 
            // ctr_refillAll
            // 
            this.ctr_refillAll.Location = new System.Drawing.Point(122, 233);
            this.ctr_refillAll.Name = "ctr_refillAll";
            this.ctr_refillAll.Size = new System.Drawing.Size(107, 24);
            this.ctr_refillAll.TabIndex = 15;
            this.ctr_refillAll.Text = "Odznacz wszytsko";
            this.ctr_refillAll.UseVisualStyleBackColor = true;
            this.ctr_refillAll.Click += new System.EventHandler(this.ctr_refillAll_Click);
            // 
            // dodajKatekorięToolStripMenuItem
            // 
            this.dodajKatekorięToolStripMenuItem.Name = "dodajKatekorięToolStripMenuItem";
            this.dodajKatekorięToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dodajKatekorięToolStripMenuItem.Text = "Dodaj kategorię";
            this.dodajKatekorięToolStripMenuItem.Click += new System.EventHandler(this.dodajKatekorięToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NewArch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(850, 443);
            this.Controls.Add(this.ctr_refillAll);
            this.Controls.Add(this.ctr_clickAll);
            this.Controls.Add(this.label4_choiceProgram);
            this.Controls.Add(this.label3_descriptionProgram);
            this.Controls.Add(this.label2_listprogram);
            this.Controls.Add(this.label_tag);
            this.Controls.Add(this.ctr_textDescription);
            this.Controls.Add(this.ctr_createArch);
            this.Controls.Add(this.ctr_checkedPrograms);
            this.Controls.Add(this.ctr_addProgram);
            this.Controls.Add(this.ctr_ProgramsList);
            this.Controls.Add(this.ctr_Tag);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewArch";
            this.Text = "UserMenu";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem językToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skórkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stronaProgramuOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.CheckedListBox ctr_Tag;
        private System.Windows.Forms.CheckedListBox ctr_ProgramsList;
        private System.Windows.Forms.Button ctr_addProgram;
        private System.Windows.Forms.CheckedListBox ctr_checkedPrograms;
        private System.Windows.Forms.Button ctr_createArch;
        private System.Windows.Forms.RichTextBox ctr_textDescription;
        private System.Windows.Forms.Label label_tag;
        private System.Windows.Forms.Label label2_listprogram;
        private System.Windows.Forms.Label label3_descriptionProgram;
        private System.Windows.Forms.Label label4_choiceProgram;
        private System.Windows.Forms.Button ctr_clickAll;
        private System.Windows.Forms.Button ctr_refillAll;
        private System.Windows.Forms.ToolStripMenuItem dodajKatekorięToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

