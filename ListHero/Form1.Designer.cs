﻿namespace ListHero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            button1 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(14, 15);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(427, 427);
            treeView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(525, 367);
            button1.Name = "button1";
            button1.Size = new Size(204, 67);
            button1.TabIndex = 1;
            button1.Text = "List Hero";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private Button button1;
    }
}
