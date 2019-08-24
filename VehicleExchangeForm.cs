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
    public partial class VehicleExchangeForm : Form
    {
        public VehicleExchangeForm()
        {
            InitializeComponent();
        }          

        private void ShowSpeedInfo(Vehicle speed)
        {
            speed.vehicleTypeNoises();
        }
    
        
        private int SequentialSearch(string[] sArray, string value)
        {
            bool found = false;
            int index = 0;
            int position = -1;

        while (!found && index < sArray.Length)
            {
                if(sArray[index] == value)
                {
                    found = true;
                    position = index;
                }

                index++;

            }

            return position;
        }




        private void clickHereForButton_Click(object sender, EventArgs e)
        {
            string selection; // To hold the user's selection

            // Create an array with the choices

            string[] instructions = { "To Call and Verify Availability for Exchange" };

            if (exchangeAvailBox.SelectedIndex != -1)
            {
                // Get the selected item
                selection = exchangeAvailBox.SelectedItem.ToString();

                // Determine if the item is in the array
                if (SequentialSearch(instructions, selection) != -1)
                {
                    MessageBox.Show("1) Place the customer on hold " + "\n" + "2) Call the rental location " + "\n" + "3) Note the answering party's name " + "\n" + "4) Let the rental location know you are setting up a vehicle delivery for the customer");
                }
                else
                {
                    MessageBox.Show("1) Ask for and note his or her E-ID " + "\n" + "2) Complete a tow exchange failure form in Call Logger if NatRes 3.0 shows vehicle availability but rental counter is refusing vehicle delivery" + "\n" + "3) If applicable, mention the customer's membership level " + "\n" + "4) Return to the customer");
                }
            }
        }

        private void economyButton_Click(object sender, EventArgs e)
        {

            // Website picture found for picturebox: https://www.bing.com/images/search?view=detailV2&id=1A800D7AEF018D356B6A378ADA72E54F9D739426&thid=OIP.oEJntjM01RjjikxeXlfxuAHaFj&mediaurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2F1%2F11%2F2013_Chevrolet_Aveo%252C_Malang.jpg%2F1200px-2013_Chevrolet_Aveo%252C_Malang.jpg&exph=900&expw=1200&q=picture+of+aveo&selectedindex=4&ajaxhist=0&vt=0&ccid=oEJntjM0&simid=607997720949162515
            vehiclePictureBox.ImageLocation = "Economy_Aveo.JPG";

            Economy myEconomy = new Economy();
            myEconomy.Doors = 2;
            myEconomy.Seating = 4;
            myEconomy.Fuel = 35;
            myEconomy.RentalCost = 55;
            myEconomy.HatchBack = "Special feature: Hatchback";
            

            vehicleDescriptionLabel.Text = ("Economy" + "\n" + "Doors: " + myEconomy.Doors +
                "\n" + "Seats: " + myEconomy.Seating + "\n" + "Fuel: " + myEconomy.Fuel + " mpg" + "\n" +
                "Rental Cost: " + "$" + myEconomy.RentalCost + " per day" + "\n" + myEconomy.HatchBack + "\n" +
                myEconomy.Color);

            Economy createColor = new Economy("White");
            colorLabel.Text = (createColor.Color);

            Economy mySpeed = new Economy(65);
            speedLimitLabel.Text = (mySpeed.Speed + " mph");
            ShowSpeedInfo(mySpeed);
           
        }

       


       
        

        private void intermediateButton_Click(object sender, EventArgs e)
        {
            // Website picture found for picturebox: https://www.bing.com/images/search?view=detailV2&id=83DE5B046E1628D5FE6A3BB02D12509636F2DB04&thid=OIP.d0B877chBykRR7QYKiN94wHaEc&mediaurl=http%3A%2F%2Fwww.mightycampers.com.au%2FSiteCollectionImages%2Fcars%2Fauacy.IDAR%2Fclearcut.png&exph=600&expw=1000&q=intermediate+vehicle&selectedindex=3&ajaxhist=0&vt=0
            vehiclePictureBox.ImageLocation = "Intermediate.JPG";

            Intermediate myIntermediate = new Intermediate();
            myIntermediate.Doors = 4;
            myIntermediate.Seating = 5;
            myIntermediate.Fuel = 30;
            myIntermediate.RentalCost = 65;
            myIntermediate.HonkInKeysFAD = "Special feature: Honks in the musical tones of F, A, and D.";


            vehicleDescriptionLabel.Text = ("Intermediate" + "\n" + "Doors: " + myIntermediate.Doors +
                "\n" + "Seats: " + myIntermediate.Seating + "\n" + "Fuel: " + myIntermediate.Fuel + " mpg" + "\n" +
                "Rental Cost: " + "$" + myIntermediate.RentalCost + " per day" + "\n" + myIntermediate.HonkInKeysFAD);

            Intermediate createColor = new Intermediate("Silver");
            colorLabel.Text = (createColor.Color);

            Intermediate mySpeed = new Intermediate(68);
            speedLimitLabel.Text = (mySpeed.Speed + " mph");
            ShowSpeedInfo(mySpeed);
        }

        private void fullSizeButton_Click(object sender, EventArgs e)
        {
            // Website picture found for picturebox: https://www.bing.com/images/search?view=detailV2&id=6EC02A1F5ED353838CC5D1E302AE13508C2915EE&thid=OIP.bBi2KJqMyLHGupX6RyFpgwHaFj&mediaurl=http%3A%2F%2Fwww.sunwing.ca%2Faaa_images%2FAlamoCars%2FZL_CA_FCAR-full-size-car.png&exph=576&expw=768&q=full+size+vehicle&selectedindex=0&ajaxhist=0&vt=0
            vehiclePictureBox.ImageLocation = "FullSize.JPG";

            FullSize myFullSize = new FullSize();
            myFullSize.Doors = 4;
            myFullSize.Seating = 5;
            myFullSize.Fuel = 26;
            myFullSize.RentalCost = 70;
            myFullSize.CustomCarSpeaker = "Special feature: Customized Speaker System";


            vehicleDescriptionLabel.Text = ("Full Size" + "\n" + "Doors: " + myFullSize.Doors +
                "\n" + "Seats: " + myFullSize.Seating + "\n" + "Fuel: " + myFullSize.Fuel + " mpg" + "\n" +
                "Rental Cost: " + "$" + myFullSize.RentalCost + " per day" + "\n" + myFullSize.CustomCarSpeaker + "\n" +
                myFullSize.Color);

            FullSize createColor = new FullSize("Red");
            colorLabel.Text = (createColor.Color);

            FullSize mySpeed = new FullSize(72);
            speedLimitLabel.Text = (mySpeed.Speed + " mph");
            ShowSpeedInfo(mySpeed);
        }

        private void luxuryButton_Click(object sender, EventArgs e)
        {
            vehiclePictureBox.ImageLocation = "Luxury.JPG";

            Luxury myLuxury = new Luxury();
            myLuxury.Doors = 4;
            myLuxury.Seating = 7;
            myLuxury.Fuel = 28;
            myLuxury.RentalCost = 100;
            myLuxury.BackUpCamera = "Special feature: Backup Camera";


            vehicleDescriptionLabel.Text = ("Luxury" + "\n" + "Doors: " + myLuxury.Doors +
                "\n" + "Seats: " + myLuxury.Seating + "\n" + "Fuel: " + myLuxury.Fuel + " mpg" + "\n" +
                "Rental Cost: " + "$" + myLuxury.RentalCost + " per day" + "\n" + myLuxury.BackUpCamera + "\n" +
                myLuxury.Color);

            Luxury createColor = new Luxury("Black");
            colorLabel.Text = (createColor.Color);

            Luxury mySpeed = new Luxury(90);
            speedLimitLabel.Text = (mySpeed.Speed + " mph");
            ShowSpeedInfo(mySpeed);
        }
    }
}


