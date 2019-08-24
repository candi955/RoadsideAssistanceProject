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
    public partial class SafetyForm : Form
    {
        public SafetyForm()
        {
            InitializeComponent();
        }

        private void safetyButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold item read from file
                string safetyInput;

                // Declare a StreamReader variable
                StreamReader inputfile;

                // Open the file and get a StreamReader object
                inputfile = File.OpenText(@"safetyList.txt");


                // Read and display the first name.
                safetyInput = inputfile.ReadLine();
                safetyListBox.Items.Clear();

                // Read the file's contents.
                while (!inputfile.EndOfStream)
                {
                    // Get the txt ino
                    safetyInput = inputfile.ReadLine();

                    // Add the information to the ListBox

                    safetyListBox.Items.Add(safetyInput);


                }
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
