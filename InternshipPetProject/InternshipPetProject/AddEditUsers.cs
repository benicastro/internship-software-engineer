using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InternshipPetProject
{
    public partial class AddEditUsers : Form
    {
        private ManageUsers _manageUsers;
        private readonly ProjectUsersEntities _db;
        private bool isEditMode;
        public AddEditUsers(ManageUsers manageUsers)
        {
            InitializeComponent();
            this.Text = "Add User Record";
            btnManage.Text = "ADD";
            isEditMode = false;
            _db = new ProjectUsersEntities();
            this._manageUsers = manageUsers;
        }

        public AddEditUsers(ManageUsers manageUsers, User userToEdit)
        {
            InitializeComponent();
            this.Text = "Edit User Record";
            btnManage.Text = "EDIT";
            isEditMode = true;
            PopulateFields(userToEdit);
            _db = new ProjectUsersEntities();
            this._manageUsers = manageUsers;
        }

        private void PopulateFields(User user)
        {
            lblId.Text = user.id.ToString();
            tbEmail.Text = user.emailAddress;
            //tbPassword.Text = user.password;
            //tbPassword2.Text = user.password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {

            if (tbPassword.Text != tbPassword2.Text || String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please provide MATCHING passwords.",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                        );
            }
            else
            {
                if (Utils.IsValidEmail(tbEmail.Text) && Utils.IsValidEmailDomain(tbEmail.Text))
                {
                    bool alreadyExists = _db.Users.Any(q => q.emailAddress == tbEmail.Text.Trim());
                    if (isEditMode)
                    {
                        var id = int.Parse(lblId.Text);
                        var user = _db.Users.FirstOrDefault(q => q.id == id);
                        

                        if (alreadyExists && user.emailAddress != tbEmail.Text.Trim())
                        {
                            MessageBox.Show("Email address already in use. Please provide a new one.",
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                            );
                        }
                        else
                        {
                            user.emailAddress = tbEmail.Text.Trim();
                            user.password = Utils.HashPassword(tbPassword.Text);

                            _db.SaveChanges();

                            MessageBox.Show($"User [{tbEmail.Text}] edited successfully!",
                            "Success!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

                            this.Close();
                        }
                    }
                    else
                    {
                        if (alreadyExists)
                        {
                            MessageBox.Show("Email address already in use. Please provide a new one.",
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                            );
                        }
                        else
                        {
                            var newUser = new User
                            {
                                emailAddress = tbEmail.Text.Trim(),
                                password = Utils.HashPassword(tbPassword.Text),
                                isLoggedIn = false
                            };

                            _db.Users.Add(newUser);
                            _db.SaveChanges();

                            MessageBox.Show($"New user [{tbEmail.Text}] added successfully!",
                            "Success!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

                            this.Close();
                        }
                    }
                    _manageUsers.PopulateGrid();
                }
                else
                {
                    MessageBox.Show("Please provide a valid email address.",
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                            );
                    tbEmail.Focus();
                }
            }
        }
    }
}
