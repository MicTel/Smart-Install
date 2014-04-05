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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Autorzy");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Wymagania");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Jak korzystać z programu");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Strona programu online");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.ctrRTB_description = new System.Windows.Forms.RichTextBox();
            this.ctrLT_descriptionHelp = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ctrRTB_description
            // 
            this.ctrRTB_description.Location = new System.Drawing.Point(283, 25);
            this.ctrRTB_description.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ctrRTB_description.Name = "ctrRTB_description";
            this.ctrRTB_description.Size = new System.Drawing.Size(430, 339);
            this.ctrRTB_description.TabIndex = 2;
            this.ctrRTB_description.Text = "";
            // 
            // ctrLT_descriptionHelp
            // 
            this.ctrLT_descriptionHelp.Location = new System.Drawing.Point(22, 25);
            this.ctrLT_descriptionHelp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ctrLT_descriptionHelp.Name = "ctrLT_descriptionHelp";
            treeNode1.BackColor = System.Drawing.Color.White;
            treeNode1.Name = "N_Autors";
            treeNode1.NodeFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode1.Text = "Autorzy";
            treeNode2.Name = "N_wym";
            treeNode2.NodeFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode2.Text = "Wymagania";
            treeNode3.Name = "N_HowToUseProg";
            treeNode3.NodeFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode3.Text = "Jak korzystać z programu";
            treeNode4.Name = "N_web";
            treeNode4.NodeFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode4.Text = "Strona programu online";
            this.ctrLT_descriptionHelp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.ctrLT_descriptionHelp.Size = new System.Drawing.Size(231, 339);
            this.ctrLT_descriptionHelp.TabIndex = 4;
            this.ctrLT_descriptionHelp.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ctrLT_descriptionHelp_clicked);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 385);
            this.Controls.Add(this.ctrLT_descriptionHelp);
            this.Controls.Add(this.ctrRTB_description);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ctrRTB_description;
        private System.Windows.Forms.TreeView ctrLT_descriptionHelp;


    }
}