namespace Geography_Question_Tester.Forms
{
    partial class ViewStats
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
            this.Loggedinas = new System.Windows.Forms.Button();
            this.StudentStatsBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackBtn.Location = new System.Drawing.Point(0, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(113, 51);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loggedinas
            // 
            this.Loggedinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Loggedinas.Location = new System.Drawing.Point(686, 0);
            this.Loggedinas.Name = "Loggedinas";
            this.Loggedinas.Size = new System.Drawing.Size(113, 51);
            this.Loggedinas.TabIndex = 1;
            this.Loggedinas.UseVisualStyleBackColor = false;
            // 
            // StudentStatsBox
            // 
            this.StudentStatsBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentStatsBox.Location = new System.Drawing.Point(47, 70);
            this.StudentStatsBox.Name = "StudentStatsBox";
            this.StudentStatsBox.Size = new System.Drawing.Size(320, 325);
            this.StudentStatsBox.TabIndex = 2;
            this.StudentStatsBox.TabStop = false;
            // 
            // ViewStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentStatsBox);
            this.Controls.Add(this.Loggedinas);
            this.Controls.Add(this.BackBtn);
            this.Name = "ViewStats";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button Loggedinas;
        private System.Windows.Forms.GroupBox StudentStatsBox;
    }
}