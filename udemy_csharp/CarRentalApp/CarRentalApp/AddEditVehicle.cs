﻿using System;
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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private ManageVehicleListing _manageVehicleListing;
        private readonly CarRentalEntities _db;
        public AddEditVehicle(ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";
            this.Text = "Add New Vehicle";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalEntities();
        }

        public AddEditVehicle(TypesOfCar carToEdit, ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vehicle";
            this.Text = "Edit Vehicle";
            _manageVehicleListing = manageVehicleListing;
            if (carToEdit == null ) 
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit.");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities();
                PopulateFields(carToEdit);
            }
        }

        private void PopulateFields(TypesOfCar car)
        {
            lblId.Text = car.Id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVin.Text = car.VIN;
            tbYear.Text = car.Year.ToString();
            tbLicensePlateNumber.Text = car.LicensePlateNumber;

        }

        private void AddEditVehicle_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                // Edit code here
                try
                {
                    var id = int.Parse(lblId.Text);
                    var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                    car.Make = tbMake.Text;
                    car.Model = tbModel.Text;

                    if ((string.IsNullOrWhiteSpace(car.Make)) || (string.IsNullOrEmpty(car.Model)))
                    {
                        throw new ArgumentNullException();
                    }

                    car.VIN = tbVin.Text;
                    car.Year = int.Parse(tbYear.Text);
                    car.LicensePlateNumber = tbLicensePlateNumber.Text;

                    _db.SaveChanges();
                    _manageVehicleListing.PopulateGrid();

                    MessageBox.Show("Car record edited! Please refresh grid to view changes.");
                    this.Close();
                }
                catch (ArgumentNullException)
                {   
                    MessageBox.Show("Please provide valid inputs for Car Make and Model.");
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                // Add code here
                var newCar = new TypesOfCar();
                try
                {
                    newCar.Make = tbMake.Text;
                    newCar.Model = tbModel.Text;

                    if ((string.IsNullOrWhiteSpace(newCar.Make)) || (string.IsNullOrEmpty(newCar.Model)))
                    {
                        throw new ArgumentNullException();
                    }

                    newCar.VIN = tbVin.Text;
                    newCar.Year = int.Parse(tbYear.Text);
                    newCar.LicensePlateNumber = tbLicensePlateNumber.Text;

                    _db.TypesOfCars.Add(newCar);
                    _db.SaveChanges();
                    _manageVehicleListing.PopulateGrid();

                    MessageBox.Show("Car record added! Please refresh grid to view changes.");
                    this.Close();
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Please provide valid inputs for Car Make and Model.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
