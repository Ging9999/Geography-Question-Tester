namespace Geography_Question_Tester.Forms
{
    partial class AddFlashard
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
            this.button1 = new System.Windows.Forms.Button();
            this.Currentuserbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Keywordtxtbox = new System.Windows.Forms.TextBox();
            this.Definitiontxtbox = new System.Windows.Forms.TextBox();
            this.Topiccombobox = new System.Windows.Forms.ComboBox();
            this.Topiclbl = new System.Windows.Forms.Label();
            this.Definitionlbl = new System.Windows.Forms.Label();
            this.Keywordlbl = new System.Windows.Forms.Label();
            this.SubmitFlashcardBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Currentuserbtn
            // 
            this.Currentuserbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Currentuserbtn.ForeColor = System.Drawing.Color.Black;
            this.Currentuserbtn.Location = new System.Drawing.Point(690, 0);
            this.Currentuserbtn.Name = "Currentuserbtn";
            this.Currentuserbtn.Size = new System.Drawing.Size(110, 55);
            this.Currentuserbtn.TabIndex = 1;
            this.Currentuserbtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.SubmitFlashcardBtn);
            this.groupBox1.Controls.Add(this.Keywordtxtbox);
            this.groupBox1.Controls.Add(this.Definitiontxtbox);
            this.groupBox1.Controls.Add(this.Topiccombobox);
            this.groupBox1.Controls.Add(this.Topiclbl);
            this.groupBox1.Controls.Add(this.Definitionlbl);
            this.groupBox1.Controls.Add(this.Keywordlbl);
            this.groupBox1.Location = new System.Drawing.Point(141, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Flashcard";
            // 
            // Keywordtxtbox
            // 
            this.Keywordtxtbox.Location = new System.Drawing.Point(202, 98);
            this.Keywordtxtbox.Multiline = true;
            this.Keywordtxtbox.Name = "Keywordtxtbox";
            this.Keywordtxtbox.Size = new System.Drawing.Size(121, 20);
            this.Keywordtxtbox.TabIndex = 5;
            // 
            // Definitiontxtbox
            // 
            this.Definitiontxtbox.Location = new System.Drawing.Point(202, 155);
            this.Definitiontxtbox.Multiline = true;
            this.Definitiontxtbox.Name = "Definitiontxtbox";
            this.Definitiontxtbox.Size = new System.Drawing.Size(121, 20);
            this.Definitiontxtbox.TabIndex = 4;
            // 
            // Topiccombobox
            // 
            this.Topiccombobox.FormattingEnabled = true;
            this.Topiccombobox.Items.AddRange(new object[] {
            "Changing Places",
            "Water and Carbon",
            "Hazards",
            "Hot Deserts"});
            this.Topiccombobox.Location = new System.Drawing.Point(202, 205);
            this.Topiccombobox.Name = "Topiccombobox";
            this.Topiccombobox.Size = new System.Drawing.Size(121, 21);
            this.Topiccombobox.TabIndex = 3;
            // 
            // Topiclbl
            // 
            this.Topiclbl.AutoSize = true;
            this.Topiclbl.Location = new System.Drawing.Point(87, 208);
            this.Topiclbl.Name = "Topiclbl";
            this.Topiclbl.Size = new System.Drawing.Size(34, 13);
            this.Topiclbl.TabIndex = 2;
            this.Topiclbl.Text = "Topic";
            // 
            // Definitionlbl
            // 
            this.Definitionlbl.AutoSize = true;
            this.Definitionlbl.Location = new System.Drawing.Point(87, 155);
            this.Definitionlbl.Name = "Definitionlbl";
            this.Definitionlbl.Size = new System.Drawing.Size(51, 13);
            this.Definitionlbl.TabIndex = 1;
            this.Definitionlbl.Text = "Definition";
            // 
            // Keywordlbl
            // 
            this.Keywordlbl.AutoSize = true;
            this.Keywordlbl.BackColor = System.Drawing.Color.Transparent;
            this.Keywordlbl.Location = new System.Drawing.Point(87, 98);
            this.Keywordlbl.Name = "Keywordlbl";
            this.Keywordlbl.Size = new System.Drawing.Size(48, 13);
            this.Keywordlbl.TabIndex = 0;
            this.Keywordlbl.Text = "Keyword";
            // 
            // SubmitFlashcardBtn
            // 
            this.SubmitFlashcardBtn.Location = new System.Drawing.Point(202, 278);
            this.SubmitFlashcardBtn.Name = "SubmitFlashcardBtn";
            this.SubmitFlashcardBtn.Size = new System.Drawing.Size(108, 56);
            this.SubmitFlashcardBtn.TabIndex = 6;
            this.SubmitFlashcardBtn.Text = "Submit Flashcard";
            this.SubmitFlashcardBtn.UseVisualStyleBackColor = true;
            this.SubmitFlashcardBtn.Click += new System.EventHandler(this.SubmitFlashcardBtn_Click);
            // 
            // AddFlashard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Currentuserbtn);
            this.Controls.Add(this.button1);
            this.Name = "AddFlashard";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Currentuserbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Topiclbl;
        private System.Windows.Forms.Label Definitionlbl;
        private System.Windows.Forms.Label Keywordlbl;
        private System.Windows.Forms.ComboBox Topiccombobox;
        private System.Windows.Forms.TextBox Keywordtxtbox;
        private System.Windows.Forms.TextBox Definitiontxtbox;
        private System.Windows.Forms.Button SubmitFlashcardBtn;
    }
}