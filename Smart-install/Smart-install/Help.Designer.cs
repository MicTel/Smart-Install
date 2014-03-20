namespace Smart_install
{
    partial class Help
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Autorzy = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(194, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 304);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Michał Telus\nMateusz Tweester\nPatryk Kosiorek\nNatalia Rybarczyk";
            // 
            // Autorzy
            // 
            this.Autorzy.FormattingEnabled = true;
            this.Autorzy.Items.AddRange(new object[] {
            "Autorzy"});
            this.Autorzy.Location = new System.Drawing.Point(12, 12);
            this.Autorzy.Name = "Autorzy";
            this.Autorzy.Size = new System.Drawing.Size(160, 304);
            this.Autorzy.TabIndex = 3;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 336);
            this.Controls.Add(this.Autorzy);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckedListBox Autorzy;


    }
}