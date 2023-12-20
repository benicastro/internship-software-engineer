using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
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
            try
            {
                var email = getUser();
                var password = tbPassword.Text;
                var hashedPassword = Utils.HashPassword(password);

                var user = _db.Users.FirstOrDefault(q => q.emailAddress == email && q.password == hashedPassword);
                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials.",
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                            );
                }
                else 
                {
                    var mainWindow = new MainWindow(this);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }
        public string getUser()
        {
            var email = tbEmail.Text.Trim();
            return email;
        }
    }
}
