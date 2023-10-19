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
    public partial class AddRentalRecord : Form
    {
        private readonly CarRentalEntities carRentalEntities;

        public AddRentalRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = dtpRentDate.Value;
                var dateIn = dtpReturnDate.Value;
                double cost = Convert.ToDouble(tbCost.Text);

                var carType = cbCarType.Text;
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n\r";
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal date selection.\n\r";
                }

                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal) cost;
                    rentalRecord.TypeOfCarId = (int) cbCarType.SelectedValue;

                    carRentalEntities.CarRentalRecords.Add(rentalRecord);
                    carRentalEntities.SaveChanges();

                    MessageBox.Show($"Thank you for renting, {customerName}.\n\r" +
                        $"You have rented a {carType} car on {dateIn}.\n\r" +
                        $"It was returned on {dateOut}.\n\r" +
                        $"The total cost was {cost}.");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblCost_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // SELECT * FROM TypesOfCars
            var cars = carRentalEntities.TypesOfCars.ToList();
            cbCarType.DisplayMember = "name";
            cbCarType.ValueMember = "id";
            cbCarType.DataSource = cars;
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
