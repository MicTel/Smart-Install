namespace Smart_install
{
    partial class Help2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Autorzy");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Wymagania");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Strona programu online");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help2));
            this.ctrLV_options = new System.Windows.Forms.TreeView();
            this.ctrRTB_description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrLV_options
            // 
            this.ctrLV_options.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrLV_options.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctrLV_options.Location = new System.Drawing.Point(18, 152);
            this.ctrLV_options.Name = "ctrLV_options";
            treeNode1.Name = "autors";
            treeNode1.NodeFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode1.Text = "Autorzy";
            treeNode2.Name = "Node0";
            treeNode2.NodeFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode2.Text = "Wymagania";
            treeNode3.Name = "Node1";
            treeNode3.NodeFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode3.Text = "Strona programu online";
            this.ctrLV_options.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.ctrLV_options.Size = new System.Drawing.Size(215, 329);
            this.ctrLV_options.TabIndex = 0;
            this.ctrLV_options.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ctrLV_options_clicked);
            // 
            // ctrRTB_description
            // 
            this.ctrRTB_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrRTB_description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctrRTB_description.Location = new System.Drawing.Point(255, 152);
            this.ctrRTB_description.Name = "ctrRTB_description";
            this.ctrRTB_description.ReadOnly = true;
            this.ctrRTB_description.Size = new System.Drawing.Size(432, 329);
            this.ctrRTB_description.TabIndex = 1;
            this.ctrRTB_description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "Smart Install \r\nVersion 1.0 (alfa)\r\nUMK 2014";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(12, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(390, 88);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Help2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 490);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrRTB_description);
            this.Controls.Add(this.ctrLV_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomoc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ctrLV_options;
        private System.Windows.Forms.RichTextBox ctrRTB_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}