namespace Geography_Question_Tester.Forms
{
    partial class ReviseDecks
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
            this.Backbtn = new System.Windows.Forms.Button();
            this.loggedinbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectDeck = new System.Windows.Forms.GroupBox();
            this.FlashcardBox = new System.Windows.Forms.GroupBox();
            this.Flashcardterm = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.FlashcardBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Backbtn.Location = new System.Drawing.Point(0, -2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(110, 51);
            this.Backbtn.TabIndex = 0;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // loggedinbtn
            // 
            this.loggedinbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loggedinbtn.Location = new System.Drawing.Point(697, -2);
            this.loggedinbtn.Name = "loggedinbtn";
            this.loggedinbtn.Size = new System.Drawing.Size(102, 51);
            this.loggedinbtn.TabIndex = 1;
            this.loggedinbtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.SelectDeck);
            this.groupBox1.Location = new System.Drawing.Point(45, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 383);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deck Information";
            // 
            // SelectDeck
            // 
            this.SelectDeck.BackColor = System.Drawing.Color.White;
            this.SelectDeck.Location = new System.Drawing.Point(52, 69);
            this.SelectDeck.Name = "SelectDeck";
            this.SelectDeck.Size = new System.Drawing.Size(161, 120);
            this.SelectDeck.TabIndex = 3;
            this.SelectDeck.TabStop = false;
            this.SelectDeck.Text = "Select Deck";
            // 
            // FlashcardBox
            // 
            this.FlashcardBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FlashcardBox.Controls.Add(this.Flashcardterm);
            this.FlashcardBox.Location = new System.Drawing.Point(376, 55);
            this.FlashcardBox.Name = "FlashcardBox";
            this.FlashcardBox.Size = new System.Drawing.Size(377, 359);
            this.FlashcardBox.TabIndex = 4;
            this.FlashcardBox.TabStop = false;
            this.FlashcardBox.Text = "Flashcards";
            // 
            // Flashcardterm
            // 
            this.Flashcardterm.BackColor = System.Drawing.Color.White;
            this.Flashcardterm.Location = new System.Drawing.Point(47, 42);
            this.Flashcardterm.Name = "Flashcardterm";
            this.Flashcardterm.Size = new System.Drawing.Size(274, 129);
            this.Flashcardterm.TabIndex = 0;
            this.Flashcardterm.UseVisualStyleBackColor = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Changing Places",
            "Water and Carbon",
            "Hazards",
            "Hot Deserts"});
            this.checkedListBox1.Location = new System.Drawing.Point(64, 236);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 4;
            // 
            // ReviseDecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlashcardBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loggedinbtn);
            this.Controls.Add(this.Backbtn);
            this.Name = "ReviseDecks";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.FlashcardBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button loggedinbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox SelectDeck;
        private System.Windows.Forms.GroupBox FlashcardBox;
        private System.Windows.Forms.Button Flashcardterm;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}