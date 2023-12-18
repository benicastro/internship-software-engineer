using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipPetProject
{
    public partial class AddEditUsers : Form
    {
        private readonly ProjectUsersEntities _db;
        private bool isEditMode;
        public AddEditUsers()
        {
            InitializeComponent();
            btnManage.Text = "ADD";
            isEditMode = false;
            _db = new ProjectUsersEntities();
        }

        public AddEditUsers(User userToEdit)
        {
            InitializeComponent();
            btnManage.Text = "EDIT";
            isEditMode = true;
            PopulateFields(userToEdit);
        }

        private void PopulateFields(User user)
        {
            lblId.Text = user.id.ToString();
            tbEmail.Text = user.emailAddress;
            tbPassword.Text = user.password;
            tbPassword2.Text = user.password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                var id = int.Parse(lblId.Text);
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                user.emailAddress = tbEmail.Text;
                user.password = tbPassword.Text;

                _db.SaveChanges();
                this.Close();
            }
            else
            {
                var newUser = new User
                {
                    emailAddress = tbEmail.Text,
                    password = tbPassword.Text,
                };

                _db.Users.Add(newUser);
                _db.SaveChanges();
                this.Close();
            }
        }
    }
}
