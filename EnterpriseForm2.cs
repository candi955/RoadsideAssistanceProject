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
    public partial class EnterpriseForm2 : Form
    {
        public EnterpriseForm2()
        {
            InitializeComponent();
        }

        private void enterpriseButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold item read from file
                string enterpriseInput;

                // Declare a StreamReader variable
                StreamReader inputfile;

                // Open the file and get a StreamReader object
                inputfile = File.OpenText(@"enterpriseList.txt");


                // Read and display the first name.
                enterpriseInput = inputfile.ReadLine();
                enterpriseListBox.Items.Clear();

                // Read the file's contents.
                while (!inputfile.EndOfStream)
                {
                    // Get the txt ino
                    enterpriseInput = inputfile.ReadLine();

                    // Add the information to the ListBox

                    enterpriseListBox.Items.Add(enterpriseInput);


                }
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void whatKindTowButton_Click(object sender, EventArgs e)
        {
            

            // Define the variable of how many persons are in the car howManyInCarLabel
            int howMany;

            // Define answer of what type of tow, answerWhatTowLabel
            int answerTow;

            // Adding If Else Statment for exceptions
            bool parsed = int.TryParse(answerWhatTowLabel.Text, out howMany);

            // Get the howMany and assign it to the howMany variable

            if (int.TryParse(howManyAnswerTextBox.Text, out howMany))
            {

            }
            else
            {
                MessageBox.Show("Thank you for your entry.  Please make sure answer is in numeric format");
            }
            try
            {
                howMany = Convert.ToInt32(howMany);
            }
            catch
            {
                MessageBox.Show("Please make sure there is a number format submitted");
            }

            // Calculate answerTow
            answerTow = (howMany + 0);

            // Display answerTow in the answerWhatTowLabel
            answerWhatTowLabel.Text = answerTow.ToString();

            //if, else if, else

            if (answerTow == 0)
            {
                answerWhatTowLabel.Text = ("There has to be at least one person entered for calculator to function properly");
            }

            else if (howMany > 0 && howMany <= 2)
            {
                answerWhatTowLabel.Text = ("Member can ride with the Tow Truck to the facility.");
            }
            else if (howMany > 2 && howMany < 6)
            {
                answerWhatTowLabel.Text = ("For that many people, it might be best to take taxi to the facility. Make sure receipt is saved");
            }
            else
            {
                answerWhatTowLabel.Text = ("It is best that we seek a rental van to bring all passengers to the facility.");
            }

            // Attempting to create a while loop

            while (int.TryParse(howManyAnswerTextBox.Text, out howMany))

                try
                {

                    // Declare a StreamWriter variable
                    StreamWriter outputFile;

                    // Open the answerTowFile.txt file for appending and get a StreamWriter object
                    outputFile = File.AppendText("answerTowFile.txt");

                    outputFile.WriteLine(answerWhatTowLabel.Text);

                    // Close the file
                    outputFile.Close();

                    // Let the user know the text was written.

                    MessageBox.Show("This answer was written to answerTowFile.txt");

                    // Clear the profit answer label control
                    answerWhatTowLabel.Text = "";

                    // Clear howManyInCarLabel.Text 
                    howManyAnswerTextBox.Text = "";

                    // Give focus to howManyInCarLabel
                    howManyAnswerTextBox.Focus();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            int random_num = 0;

            Random rand = new Random();
            int[] Lottery = new int[1];

            for (int i = 0; i < Lottery.Length;)
            {
                random_num = rand.Next(0, 100);
                Lottery[i] = random_num;
                i++;
            }
            if (howMany >= 0)
            {
                randomLotteryAnswer.Text = random_num.ToString();
            }
        }

        private void lotteryTowTitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

