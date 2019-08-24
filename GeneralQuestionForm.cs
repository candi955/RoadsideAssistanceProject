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
    public partial class GeneralQuestionForm : Form
    {
        public GeneralQuestionForm()
        {
            InitializeComponent();
        }

        private void generalQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold item read from file
                string generalQuestionInput;

                // Declare a StreamReader variable
                StreamReader inputfile;

                // Open the file and get a StreamReader object
                inputfile = File.OpenText(@"generalQuestionList.txt");


                // Read and display the first name.
                generalQuestionInput = inputfile.ReadLine();
                generalQuestionListBox.Items.Clear();

                // Read the file's contents.
                while (!inputfile.EndOfStream)
                {
                    // Get the txt ino
                    generalQuestionInput = inputfile.ReadLine();

                    // Add the information to the ListBox

                    generalQuestionListBox.Items.Add(generalQuestionInput);


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
