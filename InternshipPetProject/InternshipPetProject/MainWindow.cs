using System;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace InternshipPetProject
{
    public partial class MainWindow : Form
    {
        private readonly ProjectUsersEntities _db;
        private Login _login;
        public MainWindow()
        {
            InitializeComponent();
            _db = new ProjectUsersEntities();
        }
        public MainWindow(Login login)
        {
            InitializeComponent();
            _login = login;
            _db = new ProjectUsersEntities();
            UpdateUser();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var home = new Home();
            home.MdiParent = this;
            home.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Home"))
            {
                this.ActiveMdiChild.Close();
                var home = new Home();
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogOffUser();
            _db.SaveChanges();

            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            thread.Start();
            this.Close();
        }

        public static void OpenLoginForm()
        {
            Application.Run(new Login());
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogOffUser();
            _login.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageUsers"))
            {
                this.ActiveMdiChild.Close();
                var manageUsers = new ManageUsers(_login, this);
                manageUsers.MdiParent = this;
                manageUsers.Dock = DockStyle.Fill;
                manageUsers.Show();
            }
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Home"))
            {
                this.ActiveMdiChild.Close();
                var home = new Home();
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
        }

        public void UpdateUser()
        {
            this.Refresh();
            var userId = _login.getUserId();
            //var user = _db.Users.FirstOrDefault(q => q.id == userId);
            var users = _db.Users.
                Select(q => new
                {
                    Email = q.emailAddress,
                    Id = q.id,
                })
                .ToList();
            var user = users.FirstOrDefault(q => q.Id == userId);
            var email = user.Email;
            lblUser.Text = $"{email} !";
            this.Refresh();
        }

        private void LogOffUser()
        {
            try
            {
                var userId = _login.getUserId();
                var user = _db.Users.FirstOrDefault(q => q.id == userId);
                user.isLoggedIn = false;
                _db.SaveChanges();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
