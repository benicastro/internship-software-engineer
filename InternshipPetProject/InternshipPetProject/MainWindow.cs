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
    public partial class MainWindow : Form
    {
        private readonly ProjectUsersEntities _db;
        public MainWindow()
        {
            InitializeComponent();
            
            _db = new ProjectUsersEntities();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //var login = new Login();
            //login.Show();

            var manageUsers = new ManageUsers();
            manageUsers.MdiParent = this;
            manageUsers.Show();
        }

    }
}
