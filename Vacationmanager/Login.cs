﻿using System;
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
            IntPtr Benutzer = WindowsIdentity.GetCurrent().Token;
            label3.Text = Benutzer.ToString();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            //public static WindowsIdentity getCurrent();

        }
    }
}
