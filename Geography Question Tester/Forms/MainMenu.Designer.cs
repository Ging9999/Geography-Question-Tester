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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddFlashCard);
            this.Controls.Add(this.BtnViewStats);
            this.Controls.Add(this.BtnReviseDecks);
            this.Controls.Add(this.BtnReviseTopics);
            this.Name = "MainMenu";
            this.Text = "Geography Question Tester";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnReviseTopics;
        private System.Windows.Forms.Button BtnReviseDecks;
        private System.Windows.Forms.Button BtnViewStats;
        private System.Windows.Forms.Button BtnAddFlashCard;
    }
}