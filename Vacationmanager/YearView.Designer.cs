﻿namespace Vacationmanager
{
    partial class YearView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(21, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(785, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // YearView
            // 
            this.ClientSize = new System.Drawing.Size(831, 606);
            this.Controls.Add(this.listView1);
            this.Name = "YearView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;

    }
}