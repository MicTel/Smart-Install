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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctr_ListInstalationProgram1 = new System.Windows.Forms.DataGridView();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_ListInstalationProgram1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctr_ListInstalationProgram1
            // 
            this.ctr_ListInstalationProgram1.AllowUserToAddRows = false;
            this.ctr_ListInstalationProgram1.AllowUserToOrderColumns = true;
            this.ctr_ListInstalationProgram1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctr_ListInstalationProgram1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ctr_ListInstalationProgram1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ctr_ListInstalationProgram1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctr_ListInstalationProgram1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ctr_ListInstalationProgram1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctr_ListInstalationProgram1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ctr_ListInstalationProgram1.ColumnHeadersHeight = 33;
            this.ctr_ListInstalationProgram1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ctr_ListInstalationProgram1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgramName,
            this.ProgramStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ctr_ListInstalationProgram1.DefaultCellStyle = dataGridViewCellStyle2;
            this.ctr_ListInstalationProgram1.Location = new System.Drawing.Point(2, 1);
            this.ctr_ListInstalationProgram1.Name = "ctr_ListInstalationProgram1";
            this.ctr_ListInstalationProgram1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctr_ListInstalationProgram1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ctr_ListInstalationProgram1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctr_ListInstalationProgram1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ctr_ListInstalationProgram1.Size = new System.Drawing.Size(569, 381);
            this.ctr_ListInstalationProgram1.TabIndex = 12;
            // 
            // ProgramName
            // 
            this.ProgramName.HeaderText = "Nazwa programu";
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.ReadOnly = true;
            // 
            // ProgramStatus
            // 
            this.ProgramStatus.HeaderText = "Status";
            this.ProgramStatus.Name = "ProgramStatus";
            this.ProgramStatus.ReadOnly = true;
            // 
            // MenuInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(570, 389);
            this.Controls.Add(this.ctr_ListInstalationProgram1);
            this.Name = "MenuInstall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuInstall";
            ((System.ComponentModel.ISupportInitialize)(this.ctr_ListInstalationProgram1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ctr_ListInstalationProgram1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramStatus;
    }
}