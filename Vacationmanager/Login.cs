using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace Vacationmanager
{
    public partial class Login : Form
    {
        private string Benutzer;
        public Login()
        {
            InitializeComponent();
            Token.Text = WindowsIdentity.GetCurrent().Token.ToString();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Ch_WinAuth.Checked = true;

        }

        private void Ch_WinAuth_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nutzername.Enabled = false;
            txt_Passwort.Enabled = false;
        }

        private void Ch_ManLog_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nutzername.Enabled = true;
            txt_Passwort.Enabled = true;
        }


    }
}
