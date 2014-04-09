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
            this.SuspendLayout();
            // 
            // ctrLV_options
            // 
            this.ctrLV_options.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctrLV_options.Location = new System.Drawing.Point(24, 34);
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
            this.ctrLV_options.Size = new System.Drawing.Size(209, 327);
            this.ctrLV_options.TabIndex = 0;
            this.ctrLV_options.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ctrLV_options_clicked);
            // 
            // ctrRTB_description
            // 
            this.ctrRTB_description.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrRTB_description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctrRTB_description.Location = new System.Drawing.Point(254, 34);
            this.ctrRTB_description.Name = "ctrRTB_description";
            this.ctrRTB_description.ReadOnly = true;
            this.ctrRTB_description.Size = new System.Drawing.Size(364, 327);
            this.ctrRTB_description.TabIndex = 1;
            this.ctrRTB_description.Text = "";
            // 
            // Help2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 387);
            this.Controls.Add(this.ctrRTB_description);
            this.Controls.Add(this.ctrLV_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help2";
            this.Text = "Help2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ctrLV_options;
        private System.Windows.Forms.RichTextBox ctrRTB_description;
    }
}