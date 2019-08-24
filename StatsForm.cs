using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace finalProjectAAAGuide
{
    public partial class StatsForm : Form 
    
    {
        // Set up Classes, methods, and constructors for Accident reports
        class VehicleStyle
        {
            private string vehicleType;
            public VehicleStyle(string typeOfVehicle)
            {
                vehicleType = typeOfVehicle;
            }
            public string getVehicleType()
            { return vehicleType; }
        }

        class Damage : VehicleStyle // Add Damage as inheritance for Vehicle
        {
            private string amountOfDamage;
            public Damage(string percentDamage, string vehicleString) : base(vehicleString)
            {
                amountOfDamage = percentDamage;
            }
            public string getVehicleDamage()
            { return amountOfDamage; }   // Don't enter Set so that file is 'Read-Only'

        }
        public StatsForm()
        {
            InitializeComponent();
        }

       

        private void towInstructListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void towListButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold item read from file
                string towInput;

                // Declare a StreamReader variable
                StreamReader inputfile;

                // Open the answerTowFile.txt file for appending and get StreamReader object

                inputfile = File.OpenText(@"answerTowFile.txt");

                //Read and display 
                towInput = inputfile.ReadLine();




                // Read the file's contents

                while (!inputfile.EndOfStream)

                {
                    // Get the text info
                    towInput = inputfile.ReadLine();


                    towInstructListBox.Items.Add(towInput);


                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void clearTowListButton_Click(object sender, EventArgs e)
        {
            towInstructListBox.Items.Clear();
        }

        private void nationalTowStatButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold item read from file
                string nationalInput;

                // Declare a StreamReader variable
                StreamReader inputfile;

                // Open the file and get a StreamReader object
                inputfile = File.OpenText(@"nationalTowAnswer.txt");


                // Read and display the first name.
                nationalInput = inputfile.ReadLine();
                nationalTowStatListBox.Items.Clear();

                // Read the file's contents.
                while (!inputfile.EndOfStream)
                {
                    // Get the txt ino
                    nationalInput = inputfile.ReadLine();

                    // Add the information to the ListBox

                    nationalTowStatListBox.Items.Add(nationalInput);


                }
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string economy1;
            string intermediate1;
            string fullSize1;
            string luxury1;
            string nonDriveable;
            string driveable;
            string noDamage;
            
            
            economy1 = "Economy";
            intermediate1 = "Intermediate";
            fullSize1 = "Full Size";
            luxury1 = "Luxury";
            nonDriveable = "Non-driveable";
            driveable = "Driveable";
            noDamage = "No Damage";
            
            
            // Create Vehicle entry Instance

            VehicleStyle VehicleEntry = new VehicleStyle(vehicleTypeTextBox.Text);
            string typeOfVehicle = VehicleEntry.getVehicleType();
           

            // Create Damage Instance

            Damage EnterDamage = new Damage(vehicleTypeTextBox.Text, percentDamageTextBox.Text);
            string vehicleString = EnterDamage.getVehicleType();
            string percentDamage = EnterDamage.getVehicleDamage();


            if (vehicleTypeTextBox.Text == economy1 && percentDamageTextBox.Text == nonDriveable)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == economy1 && percentDamageTextBox.Text == driveable)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == economy1 && percentDamageTextBox.Text == noDamage)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == intermediate1 && percentDamageTextBox.Text == nonDriveable)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == intermediate1 && percentDamageTextBox.Text == driveable)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == intermediate1 && percentDamageTextBox.Text == noDamage)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == fullSize1 && percentDamageTextBox.Text == nonDriveable)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == fullSize1 && percentDamageTextBox.Text == driveable)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == fullSize1 && percentDamageTextBox.Text == noDamage)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == luxury1 && percentDamageTextBox.Text == nonDriveable)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == luxury1 && percentDamageTextBox.Text == driveable)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else if (vehicleTypeTextBox.Text == luxury1 && percentDamageTextBox.Text == noDamage)
            {
                MessageBox.Show("Thank you for your submission.");
            }
            else
            {
                MessageBox.Show("Please submit answers in requested format. Thank you.");
            }
                                                         
            try
            {


                // Declare StreamWriter variable
                StreamWriter outputFile;

                // Open the AccidentFile.txt file for appending and get a StreamWriter object
                outputFile = File.AppendText("AccidentFile.txt");

                outputFile.WriteLine(vehicleTypeTextBox.Text + ", " + percentDamageTextBox.Text);
            

                // Close the file
                outputFile.Close();

                // Clear the profit answer label control
               vehicleTypeTextBox.Text = "";

                // Clear howManyInCarLabel.Text 
                percentDamageTextBox.Text = "";

                // Give focus to howManyInCarLabel
                vehicleTypeTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void vehicleTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

