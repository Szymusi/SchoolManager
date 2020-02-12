namespace SchoolManager.Desktop.Forms
{
    partial class FrmMain
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
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.TabMain = new System.Windows.Forms.TabControl();
            this.PageGrades = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PlnButton = new System.Windows.Forms.TableLayoutPanel();
            this.LblAccountInfo = new System.Windows.Forms.Label();
            this.PnlMain.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.PlnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlMain.Controls.Add(this.TabMain, 0, 0);
            this.PnlMain.Controls.Add(this.PlnButton, 0, 1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.RowCount = 2;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PnlMain.Size = new System.Drawing.Size(800, 450);
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
            this.TabMain.Size = new System.Drawing.Size(800, 360);
            this.TabMain.TabIndex = 0;
            // 
            // PageGrades
            // 
            this.PageGrades.Location = new System.Drawing.Point(4, 22);
            this.PageGrades.Name = "PageGrades";
            this.PageGrades.Padding = new System.Windows.Forms.Padding(3);
            this.PageGrades.Size = new System.Drawing.Size(792, 334);
            this.PageGrades.TabIndex = 0;
            this.PageGrades.Text = "Grades";
            this.PageGrades.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PlnButton
            // 
            this.PlnButton.ColumnCount = 2;
            this.PlnButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlnButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlnButton.Controls.Add(this.LblAccountInfo, 1, 1);
            this.PlnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlnButton.Location = new System.Drawing.Point(3, 363);
            this.PlnButton.Name = "PlnButton";
            this.PlnButton.RowCount = 2;
            this.PlnButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PlnButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PlnButton.Size = new System.Drawing.Size(794, 84);
            this.PlnButton.TabIndex = 1;
            // 
            // LblAccountInfo
            // 
            this.LblAccountInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAccountInfo.AutoSize = true;
            this.LblAccountInfo.Location = new System.Drawing.Point(791, 71);
            this.LblAccountInfo.Name = "LblAccountInfo";
            this.LblAccountInfo.Size = new System.Drawing.Size(0, 13);
            this.LblAccountInfo.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlMain);
            this.Name = "FrmMain";
            this.Text = "School Manager";
            this.PnlMain.ResumeLayout(false);
            this.TabMain.ResumeLayout(false);
            this.PlnButton.ResumeLayout(false);
            this.PlnButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage PageGrades;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel PlnButton;
        private System.Windows.Forms.Label LblAccountInfo;
    }
}