namespace Smart_install
{
    partial class MenuInstall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInstall));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijOknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.językToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skórkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stronaProgramuOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctr_ListInstalationProgram1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionProgram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_ListInstalationProgram1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaToolStripMenuItem1,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijOknoToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijOknoToolStripMenuItem
            // 
            this.zamknijOknoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.zamknijOknoToolStripMenuItem.Name = "zamknijOknoToolStripMenuItem";
            this.zamknijOknoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.zamknijOknoToolStripMenuItem.Text = "Zamknij okno";
            this.zamknijOknoToolStripMenuItem.Click += new System.EventHandler(this.zamknijOknoToolStripMenuItem_Click);
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
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
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
            // ctr_ListInstalationProgram1
            // 
            this.ctr_ListInstalationProgram1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ctr_ListInstalationProgram1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctr_ListInstalationProgram1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.ctr_ListInstalationProgram1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctr_ListInstalationProgram1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.VersionProgram});
            this.ctr_ListInstalationProgram1.Location = new System.Drawing.Point(35, 52);
            this.ctr_ListInstalationProgram1.Name = "ctr_ListInstalationProgram1";
            this.ctr_ListInstalationProgram1.Size = new System.Drawing.Size(302, 454);
            this.ctr_ListInstalationProgram1.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nazwa programu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // VersionProgram
            // 
            this.VersionProgram.HeaderText = "Status";
            this.VersionProgram.Name = "VersionProgram";
            // 
            // MenuInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(463, 531);
            this.Controls.Add(this.ctr_ListInstalationProgram1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuInstall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuInstall";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_ListInstalationProgram1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijOknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem językToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skórkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stronaProgramuOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.DataGridView ctr_ListInstalationProgram1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionProgram;
    }
}