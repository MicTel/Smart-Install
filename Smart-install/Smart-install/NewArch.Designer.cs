﻿namespace Smart_install
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
            this.ustawieniaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.językToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skórkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stronaProgramuOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctr_addProgram = new System.Windows.Forms.Button();
            this.ctr_createArch = new System.Windows.Forms.Button();
            this.ctr_textDescription = new System.Windows.Forms.RichTextBox();
            this.label_tag = new System.Windows.Forms.Label();
            this.label3_descriptionProgram = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctrLTree_tagProg = new System.Windows.Forms.TreeView();
            this.ctrTB_DescriptionArch = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem1,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // ctr_addProgram
            // 
            this.ctr_addProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_addProgram.Location = new System.Drawing.Point(541, 380);
            this.ctr_addProgram.Name = "ctr_addProgram";
            this.ctr_addProgram.Size = new System.Drawing.Size(200, 52);
            this.ctr_addProgram.TabIndex = 3;
            this.ctr_addProgram.Text = "Dodaj program";
            this.ctr_addProgram.UseVisualStyleBackColor = true;
            this.ctr_addProgram.Click += new System.EventHandler(this.clickButton_addProgram_Click);
            // 
            // ctr_createArch
            // 
            this.ctr_createArch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_createArch.Location = new System.Drawing.Point(306, 380);
            this.ctr_createArch.Name = "ctr_createArch";
            this.ctr_createArch.Size = new System.Drawing.Size(202, 51);
            this.ctr_createArch.TabIndex = 5;
            this.ctr_createArch.Text = "Utwórz archiwum";
            this.ctr_createArch.UseVisualStyleBackColor = true;
            this.ctr_createArch.Click += new System.EventHandler(this.ctr_createArch_Click);
            // 
            // ctr_textDescription
            // 
            this.ctr_textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_textDescription.Location = new System.Drawing.Point(306, 52);
            this.ctr_textDescription.Name = "ctr_textDescription";
            this.ctr_textDescription.Size = new System.Drawing.Size(435, 253);
            this.ctr_textDescription.TabIndex = 6;
            this.ctr_textDescription.Text = "";
            // 
            // label_tag
            // 
            this.label_tag.AutoSize = true;
            this.label_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_tag.Location = new System.Drawing.Point(12, 33);
            this.label_tag.Name = "label_tag";
            this.label_tag.Size = new System.Drawing.Size(99, 15);
            this.label_tag.TabIndex = 10;
            this.label_tag.Text = "Lista programów";
            // 
            // label3_descriptionProgram
            // 
            this.label3_descriptionProgram.AutoSize = true;
            this.label3_descriptionProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3_descriptionProgram.Location = new System.Drawing.Point(303, 33);
            this.label3_descriptionProgram.Name = "label3_descriptionProgram";
            this.label3_descriptionProgram.Size = new System.Drawing.Size(161, 15);
            this.label3_descriptionProgram.TabIndex = 12;
            this.label3_descriptionProgram.Text = "Szczegółowy opis programu";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ctrLTree_tagProg
            // 
            this.ctrLTree_tagProg.CheckBoxes = true;
            this.ctrLTree_tagProg.Location = new System.Drawing.Point(15, 52);
            this.ctrLTree_tagProg.Name = "ctrLTree_tagProg";
            this.ctrLTree_tagProg.Size = new System.Drawing.Size(263, 379);
            this.ctrLTree_tagProg.TabIndex = 17;
            this.ctrLTree_tagProg.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.ctrLTree_tagProgIsChecked);
            // 
            // ctrTB_DescriptionArch
            // 
            this.ctrTB_DescriptionArch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctrTB_DescriptionArch.Location = new System.Drawing.Point(306, 337);
            this.ctrTB_DescriptionArch.Name = "ctrTB_DescriptionArch";
            this.ctrTB_DescriptionArch.Size = new System.Drawing.Size(435, 25);
            this.ctrTB_DescriptionArch.TabIndex = 18;
            this.ctrTB_DescriptionArch.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(303, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Opis tworzonego archiwum";
            // 
            // NewArch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(771, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrTB_DescriptionArch);
            this.Controls.Add(this.ctrLTree_tagProg);
            this.Controls.Add(this.label3_descriptionProgram);
            this.Controls.Add(this.label_tag);
            this.Controls.Add(this.ctr_textDescription);
            this.Controls.Add(this.ctr_createArch);
            this.Controls.Add(this.ctr_addProgram);
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
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem językToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skórkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stronaProgramuOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.Button ctr_addProgram;
        private System.Windows.Forms.Button ctr_createArch;
        private System.Windows.Forms.RichTextBox ctr_textDescription;
        private System.Windows.Forms.Label label_tag;
        private System.Windows.Forms.Label label3_descriptionProgram;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TreeView ctrLTree_tagProg;
        private System.Windows.Forms.RichTextBox ctrTB_DescriptionArch;
        private System.Windows.Forms.Label label1;
    }
}

