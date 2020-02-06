namespace SchoolManager.Desktop.Forms
{
    partial class FrmSignIn
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
            this.PlnMain = new System.Windows.Forms.TableLayoutPanel();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.PlnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlnMain
            // 
            this.PlnMain.ColumnCount = 2;
            this.PlnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PlnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PlnMain.Controls.Add(this.TbxPassword, 1, 2);
            this.PlnMain.Controls.Add(this.LblPassword, 0, 2);
            this.PlnMain.Controls.Add(this.LblTitle, 0, 0);
            this.PlnMain.Controls.Add(this.LblEmail, 0, 1);
            this.PlnMain.Controls.Add(this.TbxEmail, 1, 1);
            this.PlnMain.Controls.Add(this.BtnSignIn, 0, 3);
            this.PlnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlnMain.Location = new System.Drawing.Point(0, 0);
            this.PlnMain.Name = "PlnMain";
            this.PlnMain.RowCount = 4;
            this.PlnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.PlnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.PlnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.PlnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.PlnMain.Size = new System.Drawing.Size(410, 218);
            this.PlnMain.TabIndex = 0;
            // 
            // TbxPassword
            // 
            this.TbxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbxPassword.Location = new System.Drawing.Point(126, 125);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(198, 20);
            this.TbxPassword.TabIndex = 4;
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPassword.Location = new System.Drawing.Point(49, 124);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(74, 21);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Password";
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitle.AutoSize = true;
            this.PlnMain.SetColumnSpan(this.LblTitle, 2);
            this.LblTitle.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(154, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(101, 35);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Sign In";
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblEmail.Location = new System.Drawing.Point(67, 70);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(56, 21);
            this.LblEmail.TabIndex = 1;
            this.LblEmail.Text = "E-mail";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxEmail
            // 
            this.TbxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbxEmail.Location = new System.Drawing.Point(126, 71);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(198, 20);
            this.TbxEmail.TabIndex = 2;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlnMain.SetColumnSpan(this.BtnSignIn, 2);
            this.BtnSignIn.Location = new System.Drawing.Point(167, 178);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(75, 23);
            this.BtnSignIn.TabIndex = 5;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = true;
            this.BtnSignIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnSignIn_MouseClick);
            // 
            // FrmSignIn
            // 
            this.AcceptButton = this.BtnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 218);
            this.Controls.Add(this.PlnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.PlnMain.ResumeLayout(false);
            this.PlnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PlnMain;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Button BtnSignIn;
    }
}