using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipPetProject
{
    public partial class ServingIntel : Form
    {
        public ServingIntel()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void ServingIntel_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            if (IsValidEmail(email))
            {
                MessageBox.Show($"Ok!\n\r" +
                $"Thanks for logging in {email}.");
            }
            else
            {
                MessageBox.Show("Invalid email address, please modify.");
            }

            
        }

        // Verify email //////////////////////////////////////////////////////////////////////////////////////////////////////
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
