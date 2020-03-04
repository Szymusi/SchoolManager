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
            this.TblMain = new System.Windows.Forms.TableLayoutPanel();
            this.LblAccountInfo = new System.Windows.Forms.Label();
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TabGradeAdministration = new System.Windows.Forms.TabPage();
            this.TblAdministrateGradesMain = new System.Windows.Forms.TableLayoutPanel();
            this.CmbClasses = new System.Windows.Forms.ComboBox();
            this.CmbStudents = new System.Windows.Forms.ComboBox();
            this.TblGradesAdministration = new System.Windows.Forms.TableLayoutPanel();
            this.TblMain.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabGradeAdministration.SuspendLayout();
            this.TblAdministrateGradesMain.SuspendLayout();
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
            // 
            // TblGradesAdministration
            // 
            this.TblGradesAdministration.ColumnCount = 2;
            this.TblAdministrateGradesMain.SetColumnSpan(this.TblGradesAdministration, 2);
            this.TblGradesAdministration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblGradesAdministration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblGradesAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblGradesAdministration.Location = new System.Drawing.Point(3, 32);
            this.TblGradesAdministration.Name = "TblGradesAdministration";
            this.TblGradesAdministration.RowCount = 2;
            this.TblGradesAdministration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblGradesAdministration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblGradesAdministration.Size = new System.Drawing.Size(774, 332);
            this.TblGradesAdministration.TabIndex = 2;
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
    }
}