namespace SchoolManager.Desktop.Forms
{
    partial class FrmMainStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.TabMain = new System.Windows.Forms.TabControl();
            this.PageGrades = new System.Windows.Forms.TabPage();
            this.TblLayoutPages = new System.Windows.Forms.TableLayoutPanel();
            this.GridGrades = new System.Windows.Forms.DataGridView();
            this.ColumnSubjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblGradeInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PlnButton = new System.Windows.Forms.TableLayoutPanel();
            this.LblAccountInfo = new System.Windows.Forms.Label();
            this.ColumnGradeComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGradeTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGradeWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGradeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridGradeInfo = new System.Windows.Forms.DataGridView();
            this.LblGradeInfoSubjectName = new System.Windows.Forms.Label();
            this.PnlMain.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.PageGrades.SuspendLayout();
            this.TblLayoutPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrades)).BeginInit();
            this.TblGradeInfo.SuspendLayout();
            this.PlnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGradeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.TabMain, 0, 0);
            this.PnlMain.Controls.Add(this.PlnButton, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.RowCount = 2;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PnlMain.Size = new System.Drawing.Size(796, 422);
            this.PnlMain.TabIndex = 0;
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.PageGrades);
            this.TabMain.Controls.Add(this.tabPage2);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMain.Location = new System.Drawing.Point(0, 0);
            this.TabMain.Margin = new System.Windows.Forms.Padding(0);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(796, 379);
            this.TabMain.TabIndex = 0;
            // 
            // PageGrades
            // 
            this.PageGrades.Controls.Add(this.TblLayoutPages);
            this.PageGrades.Location = new System.Drawing.Point(4, 22);
            this.PageGrades.Name = "PageGrades";
            this.PageGrades.Padding = new System.Windows.Forms.Padding(3);
            this.PageGrades.Size = new System.Drawing.Size(788, 353);
            this.PageGrades.TabIndex = 0;
            this.PageGrades.Text = "Grades";
            this.PageGrades.UseVisualStyleBackColor = true;
            // 
            // TblLayoutPages
            // 
            this.TblLayoutPages.ColumnCount = 2;
            this.TblLayoutPages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLayoutPages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLayoutPages.Controls.Add(this.GridGrades, 0, 0);
            this.TblLayoutPages.Controls.Add(this.TblGradeInfo, 1, 0);
            this.TblLayoutPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLayoutPages.Location = new System.Drawing.Point(3, 3);
            this.TblLayoutPages.Name = "TblLayoutPages";
            this.TblLayoutPages.RowCount = 1;
            this.TblLayoutPages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLayoutPages.Size = new System.Drawing.Size(782, 347);
            this.TblLayoutPages.TabIndex = 0;
            // 
            // GridGrades
            // 
            this.GridGrades.AllowUserToAddRows = false;
            this.GridGrades.AllowUserToDeleteRows = false;
            this.GridGrades.AllowUserToResizeColumns = false;
            this.GridGrades.AllowUserToResizeRows = false;
            this.GridGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridGrades.BackgroundColor = System.Drawing.Color.White;
            this.GridGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubjects,
            this.ColumnGrades,
            this.ColumnAverage});
            this.GridGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridGrades.Location = new System.Drawing.Point(3, 3);
            this.GridGrades.Name = "GridGrades";
            this.GridGrades.ReadOnly = true;
            this.GridGrades.RowHeadersVisible = false;
            this.GridGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridGrades.Size = new System.Drawing.Size(385, 299);
            this.GridGrades.TabIndex = 0;
            this.GridGrades.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridGrades_CellMouseClick);
            // 
            // ColumnSubjects
            // 
            this.ColumnSubjects.HeaderText = "Subjects";
            this.ColumnSubjects.Name = "ColumnSubjects";
            this.ColumnSubjects.ReadOnly = true;
            // 
            // ColumnGrades
            // 
            this.ColumnGrades.HeaderText = "Grades";
            this.ColumnGrades.Name = "ColumnGrades";
            this.ColumnGrades.ReadOnly = true;
            // 
            // ColumnAverage
            // 
            this.ColumnAverage.HeaderText = "Average";
            this.ColumnAverage.Name = "ColumnAverage";
            this.ColumnAverage.ReadOnly = true;
            // 
            // TblGradeInfo
            // 
            this.TblGradeInfo.ColumnCount = 1;
            this.TblGradeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblGradeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblGradeInfo.Controls.Add(this.GridGradeInfo, 0, 1);
            this.TblGradeInfo.Controls.Add(this.LblGradeInfoSubjectName, 0, 0);
            this.TblGradeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblGradeInfo.Location = new System.Drawing.Point(394, 3);
            this.TblGradeInfo.Name = "TblGradeInfo";
            this.TblGradeInfo.RowCount = 2;
            this.TblGradeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblGradeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TblGradeInfo.Size = new System.Drawing.Size(385, 299);
            this.TblGradeInfo.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PlnButton
            // 
            this.PlnButton.ColumnCount = 2;
            this.PlnButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlnButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlnButton.Controls.Add(this.LblAccountInfo, 1, 0);
            this.PlnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlnButton.Location = new System.Drawing.Point(3, 382);
            this.PlnButton.Name = "PlnButton";
            this.PlnButton.RowCount = 1;
            this.PlnButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlnButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PlnButton.Size = new System.Drawing.Size(790, 37);
            this.PlnButton.TabIndex = 1;
            // 
            // LblAccountInfo
            // 
            this.LblAccountInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAccountInfo.AutoSize = true;
            this.LblAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblAccountInfo.Location = new System.Drawing.Point(787, 21);
            this.LblAccountInfo.Name = "LblAccountInfo";
            this.LblAccountInfo.Size = new System.Drawing.Size(0, 16);
            this.LblAccountInfo.TabIndex = 0;
            // 
            // ColumnGradeComment
            // 
            this.ColumnGradeComment.HeaderText = "Comment";
            this.ColumnGradeComment.Name = "ColumnGradeComment";
            this.ColumnGradeComment.ReadOnly = true;
            // 
            // ColumnGradeTask
            // 
            this.ColumnGradeTask.HeaderText = "Task";
            this.ColumnGradeTask.Name = "ColumnGradeTask";
            this.ColumnGradeTask.ReadOnly = true;
            // 
            // ColumnGradeWeight
            // 
            this.ColumnGradeWeight.FillWeight = 35F;
            this.ColumnGradeWeight.HeaderText = "Weight";
            this.ColumnGradeWeight.Name = "ColumnGradeWeight";
            this.ColumnGradeWeight.ReadOnly = true;
            // 
            // ColumnGradeValue
            // 
            this.ColumnGradeValue.FillWeight = 30F;
            this.ColumnGradeValue.HeaderText = "Grade";
            this.ColumnGradeValue.Name = "ColumnGradeValue";
            this.ColumnGradeValue.ReadOnly = true;
            // 
            // GridGradeInfo
            // 
            this.GridGradeInfo.AllowUserToAddRows = false;
            this.GridGradeInfo.AllowUserToDeleteRows = false;
            this.GridGradeInfo.AllowUserToResizeColumns = false;
            this.GridGradeInfo.AllowUserToResizeRows = false;
            this.GridGradeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridGradeInfo.BackgroundColor = System.Drawing.Color.White;
            this.GridGradeInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridGradeInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridGradeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGradeValue,
            this.ColumnGradeWeight,
            this.ColumnGradeTask,
            this.ColumnGradeComment});
            this.GridGradeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridGradeInfo.Location = new System.Drawing.Point(3, 32);
            this.GridGradeInfo.Name = "GridGradeInfo";
            this.GridGradeInfo.ReadOnly = true;
            this.GridGradeInfo.RowHeadersVisible = false;
            this.GridGradeInfo.Size = new System.Drawing.Size(379, 264);
            this.GridGradeInfo.TabIndex = 1;
            // 
            // LblGradeInfoSubjectName
            // 
            this.LblGradeInfoSubjectName.AutoSize = true;
            this.LblGradeInfoSubjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGradeInfoSubjectName.Location = new System.Drawing.Point(3, 0);
            this.LblGradeInfoSubjectName.Name = "LblGradeInfoSubjectName";
            this.LblGradeInfoSubjectName.Size = new System.Drawing.Size(379, 29);
            this.LblGradeInfoSubjectName.TabIndex = 2;
            this.LblGradeInfoSubjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 422);
            this.Controls.Add(this.PnlMain);
            this.Name = "FrmMainStudent";
            this.Text = "School Manager";
            this.PnlMain.ResumeLayout(false);
            this.TabMain.ResumeLayout(false);
            this.PageGrades.ResumeLayout(false);
            this.TblLayoutPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridGrades)).EndInit();
            this.TblGradeInfo.ResumeLayout(false);
            this.TblGradeInfo.PerformLayout();
            this.PlnButton.ResumeLayout(false);
            this.PlnButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGradeInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage PageGrades;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel PlnButton;
        private System.Windows.Forms.Label LblAccountInfo;
        private System.Windows.Forms.TableLayoutPanel TblLayoutPages;
        private System.Windows.Forms.DataGridView GridGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAverage;
        private System.Windows.Forms.TableLayoutPanel TblGradeInfo;
        private System.Windows.Forms.DataGridView GridGradeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradeWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradeTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradeComment;
        private System.Windows.Forms.Label LblGradeInfoSubjectName;
    }
}