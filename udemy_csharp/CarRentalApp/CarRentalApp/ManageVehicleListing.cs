using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            // SELECT * FROM TypesOfCars
            // var cars = _db.TypesOfCars.ToList()

            // SELECT id AS CarId, name AS CarName FROM TypesOfCars
            //var cars = _db.TypesOfCars
            //    .Select(q => new { CarId = q.Id, CarName = q.Make })
            //    .ToList();
            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    q.Id,
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[5].HeaderText = "License Plate Number";
            gvVehicleList.Columns[0].Visible = false;
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1].HeaderText = "NAME";

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                // Get ID of selected row
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

                // Query database for record
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                // Launch AddEditVehicle window with data
                var OpenForms = Application.OpenForms.Cast<Form>();
                var isOpen = OpenForms.Any(q => q.Name == "AddEditVehicle");
                if (!isOpen)
                {
                    var addEditVehicle = new AddEditVehicle(car, this);
                    addEditVehicle.MdiParent = this.MdiParent;
                    addEditVehicle.Show();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                // Get ID of selected row
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

                // Query database for record
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                // Create dialog to ask user to confirm deletion of record
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes) 
                {
                    // Delete vehicle from table
                    _db.TypesOfCars.Remove(car);
                    _db.SaveChanges();
                }

                PopulateGrid();
                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Simple Refresh Option
            PopulateGrid();
        }

        // New Function to PopulateGrid. Can be called anytime we need a grid refresh
        public void PopulateGrid()
        {
            // Select a custom model collection of cars from database
            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    q.Id
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            // Hide the column for ID. Changed from the hard coded column value to the name, to make it more dynamic. 
            gvVehicleList.Columns["Id"].Visible = false;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
