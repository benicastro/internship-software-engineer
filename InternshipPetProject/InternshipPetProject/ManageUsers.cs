﻿using System;
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
    public partial class ManageUsers : Form
    {
        private readonly ProjectUsersEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new ProjectUsersEntities();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            // Design
            dgvUsersList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvUsersList.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUsersList.SelectedRows[0].Cells["Id"].Value;
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                var addEditUsers = new AddEditUsers(user);
                addEditUsers.Show();
                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show($"Please select an entry to be edited.", 
                    "Attention!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                    );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUsersList.SelectedRows[0].Cells["Id"].Value;
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                _db.Users.Remove(user);
                _db.SaveChanges();

                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show($"Please select an entry to be deleted.", 
                    "Attention!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                var addEditUsers = new AddEditUsers();
                //addEditUsers.MdiParent = this.MdiParent;
                addEditUsers.Show();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        public void PopulateGrid()
        {
            var users = _db.Users.
                Select(q => new
                {
                    Email = q.emailAddress,
                    Id = q.id,
                })
                .ToList();

            dgvUsersList.DataSource = users;
            dgvUsersList.Columns[0].HeaderText = "Email Address";
            dgvUsersList.Columns[1].Visible = false;
        }
    }
}