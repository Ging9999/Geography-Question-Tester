﻿namespace Geography_Question_Tester.Forms
{
    partial class CreateDeck
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameOfdeck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CrtDeckBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(524, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameOfdeck
            // 
            this.nameOfdeck.Location = new System.Drawing.Point(55, 132);
            this.nameOfdeck.Name = "nameOfdeck";
            this.nameOfdeck.Size = new System.Drawing.Size(141, 20);
            this.nameOfdeck.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "insert name of deck";
            // 
            // CrtDeckBtn
            // 
            this.CrtDeckBtn.Location = new System.Drawing.Point(88, 186);
            this.CrtDeckBtn.Name = "CrtDeckBtn";
            this.CrtDeckBtn.Size = new System.Drawing.Size(75, 23);
            this.CrtDeckBtn.TabIndex = 6;
            this.CrtDeckBtn.Text = "Create Deck";
            this.CrtDeckBtn.UseVisualStyleBackColor = true;
            this.CrtDeckBtn.Click += new System.EventHandler(this.CrtDeckBtn_Click);
            // 
            // CreateDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CrtDeckBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameOfdeck);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CreateDeck";
            this.Text = "CreateDeck";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nameOfdeck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CrtDeckBtn;
    }
}