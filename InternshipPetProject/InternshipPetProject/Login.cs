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
            bool alreadyLoggedIn = _db.Users.Any(q => q.isLoggedIn == true);
            //bool alreadyLoggedIn = false;
            if (alreadyLoggedIn)
            {
                MessageBox.Show("Someone is still logged in.",
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                            );
            }
            else
            {
                try
                {
                    var email = tbEmail.Text.Trim();
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
                        user.isLoggedIn = true;
                        lblId.Text = user.id.ToString();
                        _db.SaveChanges();
                        var mainWindow = new MainWindow(this);
                        mainWindow.Show();
                        Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong {ex.Message}. Please try again.");
                }
            }
        }
        public int getUserId()
        {
            //int userId = int.Parse(lblId.Text);
            //var userLogged = _db.Users.FirstOrDefault(q => q.id == userId);
            return int.Parse(lblId.Text);
        }
    }
}
