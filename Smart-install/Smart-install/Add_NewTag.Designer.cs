namespace Smart_install
{
    partial class Add_NewTag
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
            this.ctr_add_newTag = new System.Windows.Forms.Button();
            this.ctrTB_NewTag = new System.Windows.Forms.TextBox();
            this.ctr_name_Tag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctr_add_newTag
            // 
            this.ctr_add_newTag.Location = new System.Drawing.Point(31, 149);
            this.ctr_add_newTag.Name = "ctr_add_newTag";
            this.ctr_add_newTag.Size = new System.Drawing.Size(132, 48);
            this.ctr_add_newTag.TabIndex = 0;
            this.ctr_add_newTag.Text = "Dodaj kategorię";
            this.ctr_add_newTag.UseVisualStyleBackColor = true;
            this.ctr_add_newTag.Click += new System.EventHandler(this.ctr_add_newTag_Click);
            // 
            // ctrTB_NewTag
            // 
            this.ctrTB_NewTag.Location = new System.Drawing.Point(31, 74);
            this.ctrTB_NewTag.Name = "ctrTB_NewTag";
            this.ctrTB_NewTag.Size = new System.Drawing.Size(135, 20);
            this.ctrTB_NewTag.TabIndex = 1;
            // 
            // ctr_name_Tag
            // 
            this.ctr_name_Tag.AutoSize = true;
            this.ctr_name_Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ctr_name_Tag.Location = new System.Drawing.Point(31, 45);
            this.ctr_name_Tag.Name = "ctr_name_Tag";
            this.ctr_name_Tag.Size = new System.Drawing.Size(95, 15);
            this.ctr_name_Tag.TabIndex = 13;
            this.ctr_name_Tag.Text = "Nazwa kategorii";
            // 
            // Add_NewTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 220);
            this.Controls.Add(this.ctr_name_Tag);
            this.Controls.Add(this.ctrTB_NewTag);
            this.Controls.Add(this.ctr_add_newTag);
            this.Name = "Add_NewTag";
            this.Text = "Dodaj kategorię";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctr_add_newTag;
        private System.Windows.Forms.TextBox ctrTB_NewTag;
        private System.Windows.Forms.Label ctr_name_Tag;
    }
}