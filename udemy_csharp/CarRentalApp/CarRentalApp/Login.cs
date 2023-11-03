using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
            
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //// Declare a new object
                //SHA256 sha = SHA256.Create();

                // get values from textboxes
                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text;

                //// Convert the input string to a byte array and compute the hash
                //byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                //// Create a new StringBuilder to collect the bytes and create a string
                //StringBuilder sBuilder = new StringBuilder();

                //// Loop through each byte of the hashed data and format each one as a hexadecimal string
                //for (int i = 0; i < data.Length; i++)
                //{
                //    sBuilder.Append(data[i].ToString("x2"));
                //}

                var hashed_password = Utils.HashPassword(password);

                // Compare with existing values in the database
                var user = _db.Users.FirstOrDefault(q => q.username == username && q.password == hashed_password
                            && q.isActive == true);

                if (user == null) 
                {
                    MessageBox.Show("Please provide valid credentials.");
                }
                else
                {
                    //var role = user.UserRoles.FirstOrDefault();
                    //var roleShortName = role.Role.shortName;
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }
    }
}
