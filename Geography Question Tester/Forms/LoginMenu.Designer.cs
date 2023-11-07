namespace Geography_Question_Tester
{
    partial class LoginMenu
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
            this.GeographyQuestionTesterLbl = new System.Windows.Forms.Button();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.CreateAccountbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GeographyQuestionTesterLbl
            // 
            this.GeographyQuestionTesterLbl.BackColor = System.Drawing.Color.Orange;
            this.GeographyQuestionTesterLbl.Location = new System.Drawing.Point(82, 73);
            this.GeographyQuestionTesterLbl.Name = "GeographyQuestionTesterLbl";
            this.GeographyQuestionTesterLbl.Size = new System.Drawing.Size(141, 59);
            this.GeographyQuestionTesterLbl.TabIndex = 0;
            this.GeographyQuestionTesterLbl.Text = "Geography Question Tester";
            this.GeographyQuestionTesterLbl.UseVisualStyleBackColor = false;
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UsernameTxtBox.ForeColor = System.Drawing.Color.Gray;
            this.UsernameTxtBox.Location = new System.Drawing.Point(143, 178);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTxtBox.TabIndex = 1;
            this.UsernameTxtBox.Text = "John Doe";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTxtBox.Location = new System.Drawing.Point(143, 223);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxtBox.TabIndex = 2;
            this.PasswordTxtBox.Text = "12345";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(64, 181);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(55, 13);
            this.UsernameLbl.TabIndex = 3;
            this.UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(64, 226);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.PasswordLbl.TabIndex = 4;
            this.PasswordLbl.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(82, 270);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(125, 59);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // CreateAccountbtn
            // 
            this.CreateAccountbtn.Location = new System.Drawing.Point(104, 352);
            this.CreateAccountbtn.Name = "CreateAccountbtn";
            this.CreateAccountbtn.Size = new System.Drawing.Size(92, 34);
            this.CreateAccountbtn.TabIndex = 6;
            this.CreateAccountbtn.Text = "Dont have an account ?";
            this.CreateAccountbtn.UseVisualStyleBackColor = true;
            this.CreateAccountbtn.Click += new System.EventHandler(this.CreateAccountbtn_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 388);
            this.Controls.Add(this.CreateAccountbtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UsernameTxtBox);
            this.Controls.Add(this.GeographyQuestionTesterLbl);
            this.Name = "LoginMenu";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeographyQuestionTesterLbl;
        private System.Windows.Forms.TextBox UsernameTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button CreateAccountbtn;
    }
}