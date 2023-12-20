using System;
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
            lblUser.Text = $"{_login.getUser()} !";
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
            _login.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageUsers"))
            {
                this.ActiveMdiChild.Close();
                var manageUsers = new ManageUsers();
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
    }
}
