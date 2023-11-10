namespace Geography_Question_Tester
{
    partial class CreateAccountMenu
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.CreateAccountLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.TutorGroupLbl = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.TutorGroupBox = new System.Windows.Forms.TextBox();
            this.CreateAccountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackBtn.Location = new System.Drawing.Point(0, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(83, 41);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateAccountLbl
            // 
            this.CreateAccountLbl.AutoSize = true;
            this.CreateAccountLbl.Location = new System.Drawing.Point(114, 111);
            this.CreateAccountLbl.Name = "CreateAccountLbl";
            this.CreateAccountLbl.Size = new System.Drawing.Size(80, 13);
            this.CreateAccountLbl.TabIndex = 1;
            this.CreateAccountLbl.Text = "Create account";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(26, 163);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLbl.TabIndex = 2;
            this.FirstNameLbl.Text = "First Name";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(25, 215);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.LastNameLbl.TabIndex = 3;
            this.LastNameLbl.Text = "Last Name";
            // 
            // TutorGroupLbl
            // 
            this.TutorGroupLbl.AutoSize = true;
            this.TutorGroupLbl.Location = new System.Drawing.Point(26, 266);
            this.TutorGroupLbl.Name = "TutorGroupLbl";
            this.TutorGroupLbl.Size = new System.Drawing.Size(64, 13);
            this.TutorGroupLbl.TabIndex = 4;
            this.TutorGroupLbl.Text = "Tutor Group";
            this.TutorGroupLbl.Click += new System.EventHandler(this.TutorGroupLbl_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(161, 156);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 5;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(161, 208);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameBox.TabIndex = 6;
            // 
            // TutorGroupBox
            // 
            this.TutorGroupBox.Location = new System.Drawing.Point(161, 263);
            this.TutorGroupBox.Name = "TutorGroupBox";
            this.TutorGroupBox.Size = new System.Drawing.Size(100, 20);
            this.TutorGroupBox.TabIndex = 7;
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.Location = new System.Drawing.Point(107, 334);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(98, 53);
            this.CreateAccountBtn.TabIndex = 8;
            this.CreateAccountBtn.Text = "Create Account";
            this.CreateAccountBtn.UseVisualStyleBackColor = true;
            this.CreateAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // CreateAccountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 444);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.TutorGroupBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.TutorGroupLbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.CreateAccountLbl);
            this.Controls.Add(this.BackBtn);
            this.Name = "CreateAccountMenu";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label CreateAccountLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label TutorGroupLbl;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox TutorGroupBox;
        private System.Windows.Forms.Button CreateAccountBtn;
    }
}