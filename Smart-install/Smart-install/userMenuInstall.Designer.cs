namespace Smart_install
{
    partial class userMenuInstall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userMenuInstall));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noweArchiwumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ostatnioUżywaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrujWgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.skórkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stronaProgramuOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctr_RB_descriptionProgArch = new System.Windows.Forms.RichTextBox();
            this.label5_listchoicePrograms = new System.Windows.Forms.Label();
            this.label6_decriptionPrograms = new System.Windows.Forms.Label();
            this.ctrLT_arch = new System.Windows.Forms.TreeView();
            this.ctr_categoriesProgram = new System.Windows.Forms.DataGridView();
            this.Name_program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionProgram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCreatedProgram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ctr_RB_searchProgramInList = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctr_install = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_categoriesProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.ustawieniaToolStripMenuItem1,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noweArchiwumToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.ostatnioUżywaneToolStripMenuItem,
            this.zamknijProgramToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // noweArchiwumToolStripMenuItem
            // 
            this.noweArchiwumToolStripMenuItem.Name = "noweArchiwumToolStripMenuItem";
            this.noweArchiwumToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.noweArchiwumToolStripMenuItem.Text = "Nowe archiwum";
            this.noweArchiwumToolStripMenuItem.Click += new System.EventHandler(this.noweArchiwumToolStripMenuItem_Click_1);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zPlikuToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dodajToolStripMenuItem.Text = "Otwórz archiwum";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // zPlikuToolStripMenuItem
            // 
            this.zPlikuToolStripMenuItem.Name = "zPlikuToolStripMenuItem";
            this.zPlikuToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zPlikuToolStripMenuItem.Text = "z pliku...";
            this.zPlikuToolStripMenuItem.Click += new System.EventHandler(this.zPlikuToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // ostatnioUżywaneToolStripMenuItem
            // 
            this.ostatnioUżywaneToolStripMenuItem.Name = "ostatnioUżywaneToolStripMenuItem";
            this.ostatnioUżywaneToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ostatnioUżywaneToolStripMenuItem.Text = "Ostatnio używane";
            this.ostatnioUżywaneToolStripMenuItem.Click += new System.EventHandler(this.ostatnioUżywaneToolStripMenuItem_Click);
            // 
            // zamknijProgramToolStripMenuItem
            // 
            this.zamknijProgramToolStripMenuItem.Name = "zamknijProgramToolStripMenuItem";
            this.zamknijProgramToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.zamknijProgramToolStripMenuItem.Text = "Zamknij program";
            this.zamknijProgramToolStripMenuItem.Click += new System.EventHandler(this.zamknijProgramToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrujWgToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // filtrujWgToolStripMenuItem
            // 
            this.filtrujWgToolStripMenuItem.Name = "filtrujWgToolStripMenuItem";
            this.filtrujWgToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.filtrujWgToolStripMenuItem.Text = "filtruj wg...";
            this.filtrujWgToolStripMenuItem.Click += new System.EventHandler(this.filtrujWgToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorieToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ustawieniaToolStripMenuItem.Text = "Widok";
            // 
            // kategorieToolStripMenuItem
            // 
            this.kategorieToolStripMenuItem.Name = "kategorieToolStripMenuItem";
            this.kategorieToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kategorieToolStripMenuItem.Text = "Kategorie";
            this.kategorieToolStripMenuItem.Click += new System.EventHandler(this.kategorieToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem1
            // 
            this.ustawieniaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skórkiToolStripMenuItem,
            this.czcionkaToolStripMenuItem});
            this.ustawieniaToolStripMenuItem1.Name = "ustawieniaToolStripMenuItem1";
            this.ustawieniaToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem1.Text = "Ustawienia";
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
            // ctr_RB_descriptionProgArch
            // 
            this.ctr_RB_descriptionProgArch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctr_RB_descriptionProgArch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_RB_descriptionProgArch.Location = new System.Drawing.Point(258, 69);
            this.ctr_RB_descriptionProgArch.Name = "ctr_RB_descriptionProgArch";
            this.ctr_RB_descriptionProgArch.Size = new System.Drawing.Size(303, 285);
            this.ctr_RB_descriptionProgArch.TabIndex = 4;
            this.ctr_RB_descriptionProgArch.Text = "";
            // 
            // label5_listchoicePrograms
            // 
            this.label5_listchoicePrograms.AutoSize = true;
            this.label5_listchoicePrograms.BackColor = System.Drawing.Color.Transparent;
            this.label5_listchoicePrograms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_listchoicePrograms.Location = new System.Drawing.Point(12, 49);
            this.label5_listchoicePrograms.Name = "label5_listchoicePrograms";
            this.label5_listchoicePrograms.Size = new System.Drawing.Size(98, 15);
            this.label5_listchoicePrograms.TabIndex = 5;
            this.label5_listchoicePrograms.Text = "Wybrane archiwa";
            // 
            // label6_decriptionPrograms
            // 
            this.label6_decriptionPrograms.AutoSize = true;
            this.label6_decriptionPrograms.BackColor = System.Drawing.Color.Transparent;
            this.label6_decriptionPrograms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_decriptionPrograms.Location = new System.Drawing.Point(255, 49);
            this.label6_decriptionPrograms.Name = "label6_decriptionPrograms";
            this.label6_decriptionPrograms.Size = new System.Drawing.Size(213, 15);
            this.label6_decriptionPrograms.TabIndex = 6;
            this.label6_decriptionPrograms.Text = "Szczegółowy opis programu/archiwum";
            // 
            // ctrLT_arch
            // 
            this.ctrLT_arch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrLT_arch.CheckBoxes = true;
            this.ctrLT_arch.Location = new System.Drawing.Point(12, 69);
            this.ctrLT_arch.Name = "ctrLT_arch";
            this.ctrLT_arch.Size = new System.Drawing.Size(230, 424);
            this.ctrLT_arch.TabIndex = 7;
            this.ctrLT_arch.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.ctrLT_arch_IsChecked);
            this.ctrLT_arch.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ctrLT_arch_NodeClicked);
            // 
            // ctr_categoriesProgram
            // 
            this.ctr_categoriesProgram.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.ctr_categoriesProgram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctr_categoriesProgram.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.ctr_categoriesProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctr_categoriesProgram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_program,
            this.VersionProgram,
            this.DataCreatedProgram});
            this.ctr_categoriesProgram.Location = new System.Drawing.Point(586, 67);
            this.ctr_categoriesProgram.Name = "ctr_categoriesProgram";
            this.ctr_categoriesProgram.Size = new System.Drawing.Size(358, 358);
            this.ctr_categoriesProgram.TabIndex = 10;
            // 
            // Name_program
            // 
            this.Name_program.HeaderText = "Nazwa programu";
            this.Name_program.Name = "Name_program";
            // 
            // VersionProgram
            // 
            this.VersionProgram.HeaderText = "Wersja programu";
            this.VersionProgram.Name = "VersionProgram";
            // 
            // DataCreatedProgram
            // 
            this.DataCreatedProgram.HeaderText = "Data utworzenia";
            this.DataCreatedProgram.Name = "DataCreatedProgram";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(583, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista zainstalowanych programów";
            // 
            // ctr_RB_searchProgramInList
            // 
            this.ctr_RB_searchProgramInList.Location = new System.Drawing.Point(586, 459);
            this.ctr_RB_searchProgramInList.Name = "ctr_RB_searchProgramInList";
            this.ctr_RB_searchProgramInList.Size = new System.Drawing.Size(358, 32);
            this.ctr_RB_searchProgramInList.TabIndex = 12;
            this.ctr_RB_searchProgramInList.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(583, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Wyszukaj program";
            // 
            // ctr_install
            // 
            this.ctr_install.BackColor = System.Drawing.Color.Lavender;
            this.ctr_install.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ctr_install.FlatAppearance.BorderSize = 0;
            this.ctr_install.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ctr_install.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_install.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctr_install.Image = ((System.Drawing.Image)(resources.GetObject("ctr_install.Image")));
            this.ctr_install.Location = new System.Drawing.Point(258, 440);
            this.ctr_install.Name = "ctr_install";
            this.ctr_install.Size = new System.Drawing.Size(303, 51);
            this.ctr_install.TabIndex = 14;
            this.ctr_install.Text = "Instaluj";
            this.ctr_install.UseVisualStyleBackColor = true;
            this.ctr_install.Click += new System.EventHandler(this.ctr_install_Click);
            // 
            // userMenuInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(956, 505);
            this.Controls.Add(this.ctr_install);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctr_RB_searchProgramInList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctr_categoriesProgram);
            this.Controls.Add(this.ctrLT_arch);
            this.Controls.Add(this.label6_decriptionPrograms);
            this.Controls.Add(this.label5_listchoicePrograms);
            this.Controls.Add(this.ctr_RB_descriptionProgArch);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 500);
            this.Name = "userMenuInstall";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartInstall";
            this.Load += new System.EventHandler(this.userMenuInstall_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_categoriesProgram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noweArchiwumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ostatnioUżywaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrujWgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem skórkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stronaProgramuOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox ctr_RB_descriptionProgArch;
        private System.Windows.Forms.Label label5_listchoicePrograms;
        private System.Windows.Forms.Label label6_decriptionPrograms;
        private System.Windows.Forms.ToolStripMenuItem zamknijProgramToolStripMenuItem;
        private System.Windows.Forms.TreeView ctrLT_arch;
        private System.Windows.Forms.DataGridView ctr_categoriesProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_program;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCreatedProgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ctr_RB_searchProgramInList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ctr_install;
    }
}