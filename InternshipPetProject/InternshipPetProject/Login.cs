﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipPetProject
{
    public partial class Login : Form
    {
        private readonly ProjectUsersEntities _db;
        public Login()
        {
            InitializeComponent();
            _db = new ProjectUsersEntities();
        }

        private void ServingIntel_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            var users = _db.Users.ToList();
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            if (Utils.IsValidEmail(email) && Utils.IsValidEmailDomain(email))
            {
                MessageBox.Show($"Ok!\n\r" +
                $"Thanks for logging in {email}.");
            }
            else
            {
                MessageBox.Show("Please provide a valid email address.");
            }

            
        }

        
    }
}
