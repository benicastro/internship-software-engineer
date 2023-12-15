using System;
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
    public partial class ServingIntel : Form
    {
        private readonly ProjectUsersEntities projectUsersEntities;
        public ServingIntel()
        {
            InitializeComponent();
            projectUsersEntities = new ProjectUsersEntities();
        }

        private void ServingIntel_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            var users = projectUsersEntities.Users.ToList();
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            if (isValidEmail(email) && isValidEmailDomain(email))
            {
                MessageBox.Show($"Ok!\n\r" +
                $"Thanks for logging in {email}.");
            }
            else
            {
                MessageBox.Show("Please provide a valid email address.");
            }

            
        }

        // Verify email //////////////////////////////////////////////////////////////////////////////////////////////////////
        public static bool isValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        public static bool isValidEmailDomain(string email)
        {
            if (!isValidEmail(email))
            {
                return false;
            }

            string[] parts = email.Split('@');
            string localPart = parts[0];
            string domainPart = parts[1];

            try
            {
                // check if domain name has a valid MX record
                var hostEntry = Dns.GetHostEntry(domainPart);
                return hostEntry.HostName.Length > 0;
            }
            catch
            {
                return false; // domain name is invalid or does not have a valid MX record
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
