namespace SchoolManager.Desktop.Forms
{
    partial class FrmMainTeacher
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
            this.TblMain = new System.Windows.Forms.TableLayoutPanel();
            this.LblAccountInfo = new System.Windows.Forms.Label();
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TabGradeAdministration = new System.Windows.Forms.TabPage();
            this.TblAdministrateGradesMain = new System.Windows.Forms.TableLayoutPanel();
            this.CmbClasses = new System.Windows.Forms.ComboBox();
            this.CmbStudents = new System.Windows.Forms.ComboBox();
            this.TblGradesAdministration = new System.Windows.Forms.TableLayoutPanel();
            this.GridGradeInfo = new System.Windows.Forms.DataGridView();
            this.TblModifyGrade = new System.Windows.Forms.TableLayoutPanel();
            this.LblComment = new System.Windows.Forms.Label();
            this.LblTask = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.LblValue = new System.Windows.Forms.Label();
            this.LblWeight = new System.Windows.Forms.Label();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.TxtTask = new System.Windows.Forms.TextBox();
            this.TxtComment = new System.Windows.Forms.TextBox();
            this.TblOptionSelect = new System.Windows.Forms.TableLayoutPanel();
            this.RadDelete = new System.Windows.Forms.RadioButton();
            this.RadAdd = new System.Windows.Forms.RadioButton();
            this.RadEdit = new System.Windows.Forms.RadioButton();
            this.BtnOperation = new System.Windows.Forms.Button();
            this.ColumnGradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGradeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGradeWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGradeTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGradeComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblMain.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabGradeAdministration.SuspendLayout();
            this.TblAdministrateGradesMain.SuspendLayout();
            this.TblGradesAdministration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGradeInfo)).BeginInit();
            this.TblModifyGrade.SuspendLayout();
            this.TblOptionSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblMain
            // 
            this.TblMain.BackColor = System.Drawing.Color.White;
            this.TblMain.ColumnCount = 2;
            this.TblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblMain.Controls.Add(this.LblAccountInfo, 1, 1);
            this.TblMain.Controls.Add(this.TabMain, 0, 0);
            this.TblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblMain.Location = new System.Drawing.Point(0, 0);
            this.TblMain.Name = "TblMain";
            this.TblMain.RowCount = 2;
            this.TblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblMain.Size = new System.Drawing.Size(800, 450);
            this.TblMain.TabIndex = 0;
            // 
            // LblAccountInfo
            // 
            this.LblAccountInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAccountInfo.AutoSize = true;
            this.LblAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblAccountInfo.Location = new System.Drawing.Point(797, 433);
            this.LblAccountInfo.Name = "LblAccountInfo";
            this.LblAccountInfo.Size = new System.Drawing.Size(0, 17);
            this.LblAccountInfo.TabIndex = 0;
            // 
            // TabMain
            // 
            this.TblMain.SetColumnSpan(this.TabMain, 2);
            this.TabMain.Controls.Add(this.TabGradeAdministration);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMain.Location = new System.Drawing.Point(3, 3);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(794, 399);
            this.TabMain.TabIndex = 1;
            // 
            // TabGradeAdministration
            // 
            this.TabGradeAdministration.Controls.Add(this.TblAdministrateGradesMain);
            this.TabGradeAdministration.Location = new System.Drawing.Point(4, 22);
            this.TabGradeAdministration.Name = "TabGradeAdministration";
            this.TabGradeAdministration.Padding = new System.Windows.Forms.Padding(3);
            this.TabGradeAdministration.Size = new System.Drawing.Size(786, 373);
            this.TabGradeAdministration.TabIndex = 0;
            this.TabGradeAdministration.Text = "Administrate Grades";
            this.TabGradeAdministration.UseVisualStyleBackColor = true;
            // 
            // TblAdministrateGradesMain
            // 
            this.TblAdministrateGradesMain.ColumnCount = 2;
            this.TblAdministrateGradesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblAdministrateGradesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblAdministrateGradesMain.Controls.Add(this.CmbClasses, 0, 0);
            this.TblAdministrateGradesMain.Controls.Add(this.CmbStudents, 1, 0);
            this.TblAdministrateGradesMain.Controls.Add(this.TblGradesAdministration, 0, 1);
            this.TblAdministrateGradesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblAdministrateGradesMain.Location = new System.Drawing.Point(3, 3);
            this.TblAdministrateGradesMain.Name = "TblAdministrateGradesMain";
            this.TblAdministrateGradesMain.RowCount = 2;
            this.TblAdministrateGradesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.TblAdministrateGradesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.TblAdministrateGradesMain.Size = new System.Drawing.Size(780, 367);
            this.TblAdministrateGradesMain.TabIndex = 0;
            // 
            // CmbClasses
            // 
            this.CmbClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClasses.Location = new System.Drawing.Point(3, 3);
            this.CmbClasses.Name = "CmbClasses";
            this.CmbClasses.Size = new System.Drawing.Size(384, 21);
            this.CmbClasses.TabIndex = 0;
            this.CmbClasses.SelectedIndexChanged += new System.EventHandler(this.CmbClasses_SelectedIndexChanged);
            // 
            // CmbStudents
            // 
            this.CmbStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStudents.Location = new System.Drawing.Point(393, 3);
            this.CmbStudents.Name = "CmbStudents";
            this.CmbStudents.Size = new System.Drawing.Size(384, 21);
            this.CmbStudents.TabIndex = 1;
            this.CmbStudents.SelectedIndexChanged += new System.EventHandler(this.CmbStudents_SelectedIndexChanged);
            // 
            // TblGradesAdministration
            // 
            this.TblGradesAdministration.ColumnCount = 2;
            this.TblAdministrateGradesMain.SetColumnSpan(this.TblGradesAdministration, 2);
            this.TblGradesAdministration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TblGradesAdministration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TblGradesAdministration.Controls.Add(this.GridGradeInfo, 0, 0);
            this.TblGradesAdministration.Controls.Add(this.TblModifyGrade, 1, 0);
            this.TblGradesAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblGradesAdministration.Location = new System.Drawing.Point(3, 32);
            this.TblGradesAdministration.Name = "TblGradesAdministration";
            this.TblGradesAdministration.RowCount = 2;
            this.TblGradesAdministration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblGradesAdministration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblGradesAdministration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblGradesAdministration.Size = new System.Drawing.Size(774, 332);
            this.TblGradesAdministration.TabIndex = 2;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridGradeInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridGradeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGradeId,
            this.ColumnGradeValue,
            this.ColumnGradeWeight,
            this.ColumnGradeTask,
            this.ColumnGradeComment});
            this.GridGradeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridGradeInfo.Location = new System.Drawing.Point(3, 3);
            this.GridGradeInfo.MultiSelect = false;
            this.GridGradeInfo.Name = "GridGradeInfo";
            this.GridGradeInfo.ReadOnly = true;
            this.GridGradeInfo.RowHeadersVisible = false;
            this.TblGradesAdministration.SetRowSpan(this.GridGradeInfo, 2);
            this.GridGradeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridGradeInfo.Size = new System.Drawing.Size(458, 326);
            this.GridGradeInfo.TabIndex = 3;
            this.GridGradeInfo.SelectionChanged += new System.EventHandler(this.GridGradeInfo_SelectionChanged);
            // 
            // TblModifyGrade
            // 
            this.TblModifyGrade.ColumnCount = 2;
            this.TblModifyGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblModifyGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblModifyGrade.Controls.Add(this.LblComment, 1, 3);
            this.TblModifyGrade.Controls.Add(this.LblTask, 0, 3);
            this.TblModifyGrade.Controls.Add(this.TxtValue, 0, 2);
            this.TblModifyGrade.Controls.Add(this.LblValue, 0, 1);
            this.TblModifyGrade.Controls.Add(this.LblWeight, 1, 1);
            this.TblModifyGrade.Controls.Add(this.TxtWeight, 1, 2);
            this.TblModifyGrade.Controls.Add(this.TxtTask, 0, 4);
            this.TblModifyGrade.Controls.Add(this.TxtComment, 1, 4);
            this.TblModifyGrade.Controls.Add(this.TblOptionSelect, 0, 0);
            this.TblModifyGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblModifyGrade.Location = new System.Drawing.Point(467, 3);
            this.TblModifyGrade.Name = "TblModifyGrade";
            this.TblModifyGrade.RowCount = 5;
            this.TblGradesAdministration.SetRowSpan(this.TblModifyGrade, 2);
            this.TblModifyGrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblModifyGrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.TblModifyGrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.TblModifyGrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.TblModifyGrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.TblModifyGrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblModifyGrade.Size = new System.Drawing.Size(304, 326);
            this.TblModifyGrade.TabIndex = 4;
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblComment.Location = new System.Drawing.Point(155, 178);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(146, 73);
            this.LblComment.TabIndex = 7;
            this.LblComment.Text = "Comment";
            this.LblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTask
            // 
            this.LblTask.AutoSize = true;
            this.LblTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTask.Location = new System.Drawing.Point(3, 178);
            this.LblTask.Name = "LblTask";
            this.LblTask.Size = new System.Drawing.Size(146, 73);
            this.LblTask.TabIndex = 6;
            this.LblTask.Text = "Task";
            this.LblTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtValue
            // 
            this.TxtValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtValue.Location = new System.Drawing.Point(26, 131);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(100, 20);
            this.TxtValue.TabIndex = 1;
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblValue.Location = new System.Drawing.Point(3, 32);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(146, 73);
            this.LblValue.TabIndex = 0;
            this.LblValue.Text = "Value";
            this.LblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblWeight.Location = new System.Drawing.Point(155, 32);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(146, 73);
            this.LblWeight.TabIndex = 2;
            this.LblWeight.Text = "Weight";
            this.LblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtWeight
            // 
            this.TxtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtWeight.Location = new System.Drawing.Point(178, 131);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(100, 20);
            this.TxtWeight.TabIndex = 3;
            // 
            // TxtTask
            // 
            this.TxtTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTask.Location = new System.Drawing.Point(26, 278);
            this.TxtTask.Name = "TxtTask";
            this.TxtTask.Size = new System.Drawing.Size(100, 20);
            this.TxtTask.TabIndex = 4;
            // 
            // TxtComment
            // 
            this.TxtComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtComment.Location = new System.Drawing.Point(178, 278);
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(100, 20);
            this.TxtComment.TabIndex = 5;
            // 
            // TblOptionSelect
            // 
            this.TblOptionSelect.ColumnCount = 4;
            this.TblModifyGrade.SetColumnSpan(this.TblOptionSelect, 2);
            this.TblOptionSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblOptionSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblOptionSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblOptionSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblOptionSelect.Controls.Add(this.RadDelete, 0, 0);
            this.TblOptionSelect.Controls.Add(this.RadAdd, 1, 0);
            this.TblOptionSelect.Controls.Add(this.RadEdit, 2, 0);
            this.TblOptionSelect.Controls.Add(this.BtnOperation, 3, 0);
            this.TblOptionSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.TblOptionSelect.Location = new System.Drawing.Point(3, 3);
            this.TblOptionSelect.Name = "TblOptionSelect";
            this.TblOptionSelect.RowCount = 1;
            this.TblOptionSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblOptionSelect.Size = new System.Drawing.Size(298, 26);
            this.TblOptionSelect.TabIndex = 8;
            // 
            // RadDelete
            // 
            this.RadDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadDelete.Location = new System.Drawing.Point(3, 3);
            this.RadDelete.Name = "RadDelete";
            this.RadDelete.Size = new System.Drawing.Size(68, 20);
            this.RadDelete.TabIndex = 0;
            this.RadDelete.TabStop = true;
            this.RadDelete.Text = "Delete";
            this.RadDelete.UseVisualStyleBackColor = true;
            // 
            // RadAdd
            // 
            this.RadAdd.AutoSize = true;
            this.RadAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadAdd.Location = new System.Drawing.Point(77, 3);
            this.RadAdd.Name = "RadAdd";
            this.RadAdd.Size = new System.Drawing.Size(68, 20);
            this.RadAdd.TabIndex = 1;
            this.RadAdd.TabStop = true;
            this.RadAdd.Text = " Add";
            this.RadAdd.UseVisualStyleBackColor = true;
            // 
            // RadEdit
            // 
            this.RadEdit.AutoSize = true;
            this.RadEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadEdit.Location = new System.Drawing.Point(151, 3);
            this.RadEdit.Name = "RadEdit";
            this.RadEdit.Size = new System.Drawing.Size(68, 20);
            this.RadEdit.TabIndex = 2;
            this.RadEdit.TabStop = true;
            this.RadEdit.Text = "Edit";
            this.RadEdit.UseVisualStyleBackColor = true;
            // 
            // BtnOperation
            // 
            this.BtnOperation.Location = new System.Drawing.Point(225, 3);
            this.BtnOperation.Name = "BtnOperation";
            this.BtnOperation.Size = new System.Drawing.Size(70, 20);
            this.BtnOperation.TabIndex = 3;
            this.BtnOperation.Text = "DUPA";
            this.BtnOperation.UseVisualStyleBackColor = true;
            // 
            // ColumnGradeId
            // 
            this.ColumnGradeId.HeaderText = "Id";
            this.ColumnGradeId.Name = "ColumnGradeId";
            this.ColumnGradeId.ReadOnly = true;
            this.ColumnGradeId.Visible = false;
            // 
            // ColumnGradeValue
            // 
            this.ColumnGradeValue.FillWeight = 30F;
            this.ColumnGradeValue.HeaderText = "Grade";
            this.ColumnGradeValue.Name = "ColumnGradeValue";
            this.ColumnGradeValue.ReadOnly = true;
            // 
            // ColumnGradeWeight
            // 
            this.ColumnGradeWeight.FillWeight = 35F;
            this.ColumnGradeWeight.HeaderText = "Weight";
            this.ColumnGradeWeight.Name = "ColumnGradeWeight";
            this.ColumnGradeWeight.ReadOnly = true;
            // 
            // ColumnGradeTask
            // 
            this.ColumnGradeTask.HeaderText = "Task";
            this.ColumnGradeTask.Name = "ColumnGradeTask";
            this.ColumnGradeTask.ReadOnly = true;
            // 
            // ColumnGradeComment
            // 
            this.ColumnGradeComment.HeaderText = "Comment";
            this.ColumnGradeComment.Name = "ColumnGradeComment";
            this.ColumnGradeComment.ReadOnly = true;
            // 
            // FrmMainTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TblMain);
            this.Name = "FrmMainTeacher";
            this.Text = "School Manager";
            this.TblMain.ResumeLayout(false);
            this.TblMain.PerformLayout();
            this.TabMain.ResumeLayout(false);
            this.TabGradeAdministration.ResumeLayout(false);
            this.TblAdministrateGradesMain.ResumeLayout(false);
            this.TblGradesAdministration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridGradeInfo)).EndInit();
            this.TblModifyGrade.ResumeLayout(false);
            this.TblModifyGrade.PerformLayout();
            this.TblOptionSelect.ResumeLayout(false);
            this.TblOptionSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblMain;
        private System.Windows.Forms.Label LblAccountInfo;
        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage TabGradeAdministration;
        private System.Windows.Forms.TableLayoutPanel TblAdministrateGradesMain;
        private System.Windows.Forms.ComboBox CmbClasses;
        private System.Windows.Forms.ComboBox CmbStudents;
        private System.Windows.Forms.TableLayoutPanel TblGradesAdministration;
        private System.Windows.Forms.TableLayoutPanel TblModifyGrade;
        private System.Windows.Forms.Label LblValue;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.TextBox TxtWeight;
        private System.Windows.Forms.TextBox TxtTask;
        private System.Windows.Forms.TextBox TxtComment;
        private System.Windows.Forms.Label LblComment;
        private System.Windows.Forms.Label LblTask;
        private System.Windows.Forms.TableLayoutPanel TblOptionSelect;
        private System.Windows.Forms.RadioButton RadDelete;
        private System.Windows.Forms.RadioButton RadAdd;
        private System.Windows.Forms.RadioButton RadEdit;
        private System.Windows.Forms.Button BtnOperation;
        private System.Windows.Forms.DataGridView GridGradeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradeWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradeTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradeComment;
    }
}