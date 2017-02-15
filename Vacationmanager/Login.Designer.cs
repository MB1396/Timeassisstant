namespace Vacationmanager
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Token = new System.Windows.Forms.Label();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.txt_Nutzername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ch_WinAuth = new System.Windows.Forms.RadioButton();
            this.Ch_ManLog = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Token);
            this.panel1.Controls.Add(this.txt_Passwort);
            this.panel1.Controls.Add(this.txt_Nutzername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 121);
            this.panel1.TabIndex = 5;
            // 
            // Token
            // 
            this.Token.Location = new System.Drawing.Point(123, 96);
            this.Token.Name = "Token";
            this.Token.Size = new System.Drawing.Size(46, 16);
            this.Token.TabIndex = 0;
            this.Token.Text = "Token";
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Location = new System.Drawing.Point(115, 59);
            this.txt_Passwort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(155, 20);
            this.txt_Passwort.TabIndex = 4;
            // 
            // txt_Nutzername
            // 
            this.txt_Nutzername.Location = new System.Drawing.Point(115, 25);
            this.txt_Nutzername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Nutzername.Name = "txt_Nutzername";
            this.txt_Nutzername.Size = new System.Drawing.Size(155, 20);
            this.txt_Nutzername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benutzername";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Ch_ManLog);
            this.panel2.Controls.Add(this.Ch_WinAuth);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(56, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 216);
            this.panel2.TabIndex = 6;
            // 
            // Ch_WinAuth
            // 
            this.Ch_WinAuth.AutoSize = true;
            this.Ch_WinAuth.Location = new System.Drawing.Point(37, 13);
            this.Ch_WinAuth.Name = "Ch_WinAuth";
            this.Ch_WinAuth.Size = new System.Drawing.Size(198, 20);
            this.Ch_WinAuth.TabIndex = 6;
            this.Ch_WinAuth.TabStop = true;
            this.Ch_WinAuth.Text = "Windows Authentifizierung nutzen";
            this.Ch_WinAuth.UseVisualStyleBackColor = true;
            this.Ch_WinAuth.CheckedChanged += new System.EventHandler(this.Ch_WinAuth_CheckedChanged);
            // 
            // Ch_ManLog
            // 
            this.Ch_ManLog.AutoSize = true;
            this.Ch_ManLog.Location = new System.Drawing.Point(37, 39);
            this.Ch_ManLog.Name = "Ch_ManLog";
            this.Ch_ManLog.Size = new System.Drawing.Size(130, 20);
            this.Ch_ManLog.TabIndex = 7;
            this.Ch_ManLog.TabStop = true;
            this.Ch_ManLog.Text = "Logindaten eingeben";
            this.Ch_ManLog.UseVisualStyleBackColor = true;
            this.Ch_ManLog.CheckedChanged += new System.EventHandler(this.Ch_ManLog_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.TextBox txt_Nutzername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Token;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Ch_ManLog;
        private System.Windows.Forms.RadioButton Ch_WinAuth;
    }
}