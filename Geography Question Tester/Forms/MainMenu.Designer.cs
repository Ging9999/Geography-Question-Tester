namespace Geography_Question_Tester
{
    partial class MainMenu
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
            this.BtnReviseTopics = new System.Windows.Forms.Button();
            this.BtnReviseDecks = new System.Windows.Forms.Button();
            this.BtnViewStats = new System.Windows.Forms.Button();
            this.BtnAddFlashCard = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.LoggedInAs = new System.Windows.Forms.Label();
            this.LoggedIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReviseTopics
            // 
            this.BtnReviseTopics.Location = new System.Drawing.Point(322, 160);
            this.BtnReviseTopics.Name = "BtnReviseTopics";
            this.BtnReviseTopics.Size = new System.Drawing.Size(142, 32);
            this.BtnReviseTopics.TabIndex = 0;
            this.BtnReviseTopics.Text = "Revise Topics";
            this.BtnReviseTopics.UseVisualStyleBackColor = true;
            this.BtnReviseTopics.Click += new System.EventHandler(this.BtnReviseTopics_Click);
            // 
            // BtnReviseDecks
            // 
            this.BtnReviseDecks.Location = new System.Drawing.Point(322, 198);
            this.BtnReviseDecks.Name = "BtnReviseDecks";
            this.BtnReviseDecks.Size = new System.Drawing.Size(142, 32);
            this.BtnReviseDecks.TabIndex = 1;
            this.BtnReviseDecks.Text = "Revise Decks";
            this.BtnReviseDecks.UseVisualStyleBackColor = true;
            this.BtnReviseDecks.Click += new System.EventHandler(this.BtnReviseDecks_Click);
            // 
            // BtnViewStats
            // 
            this.BtnViewStats.Location = new System.Drawing.Point(322, 236);
            this.BtnViewStats.Name = "BtnViewStats";
            this.BtnViewStats.Size = new System.Drawing.Size(142, 32);
            this.BtnViewStats.TabIndex = 2;
            this.BtnViewStats.Text = "View Stats";
            this.BtnViewStats.UseVisualStyleBackColor = true;
            this.BtnViewStats.Click += new System.EventHandler(this.BtnViewStats_Click);
            // 
            // BtnAddFlashCard
            // 
            this.BtnAddFlashCard.Location = new System.Drawing.Point(322, 274);
            this.BtnAddFlashCard.Name = "BtnAddFlashCard";
            this.BtnAddFlashCard.Size = new System.Drawing.Size(142, 32);
            this.BtnAddFlashCard.TabIndex = 3;
            this.BtnAddFlashCard.Text = "Add Flashcard";
            this.BtnAddFlashCard.UseVisualStyleBackColor = true;
            this.BtnAddFlashCard.Click += new System.EventHandler(this.BtnAddFlashCard_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LogoutBtn.Location = new System.Drawing.Point(0, 0);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(129, 60);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // LoggedInAs
            // 
            this.LoggedInAs.AutoSize = true;
            this.LoggedInAs.Location = new System.Drawing.Point(633, 45);
            this.LoggedInAs.Name = "LoggedInAs";
            this.LoggedInAs.Size = new System.Drawing.Size(0, 13);
            this.LoggedInAs.TabIndex = 5;
            // 
            // LoggedIn
            // 
            this.LoggedIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LoggedIn.ForeColor = System.Drawing.Color.Black;
            this.LoggedIn.Location = new System.Drawing.Point(681, 0);
            this.LoggedIn.Name = "LoggedIn";
            this.LoggedIn.Size = new System.Drawing.Size(120, 58);
            this.LoggedIn.TabIndex = 6;
            this.LoggedIn.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoggedIn);
            this.Controls.Add(this.LoggedInAs);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.BtnAddFlashCard);
            this.Controls.Add(this.BtnViewStats);
            this.Controls.Add(this.BtnReviseDecks);
            this.Controls.Add(this.BtnReviseTopics);
            this.Name = "MainMenu";
            this.Text = "Geography Question Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReviseTopics;
        private System.Windows.Forms.Button BtnReviseDecks;
        private System.Windows.Forms.Button BtnViewStats;
        private System.Windows.Forms.Button BtnAddFlashCard;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label LoggedInAs;
        private System.Windows.Forms.Button LoggedIn;
    }
}