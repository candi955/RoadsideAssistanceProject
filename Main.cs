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
    public partial class roadsideAssistanceForm : Form

    {
        String[] instructions = new string[4];
        public roadsideAssistanceForm()
        {
            
            InitializeComponent();
        }
        // Today, 3/17/2019, I started at about 15:45pm on this project.  It took me only about 15
        // minutes to set up the build and layout of the list portion.  I was also able to set
        // up files which I planned to pull information from for those ListBoxes.  Unfortunately,
        // I was having trouble figuring out the proper coding.  At 5pm I decided to take a break
        // and regroup.  At approximately 7pm, I worked at it for about another hour, and was
        // able to find the proper setup.  It ended up being simple things.  The txt. file would not
        // allow for the first line to be read.  I entered down one line, and everything read
        // in the ListBoxes perfectly.  I began to tackle the next project of setting up the 
        // Tow calculator, of which I planned to show the loop.  Unfortunately, despite a few hours
        // of work, I have not been able to debug it.  This has left me no time to begin my 
        // Marketing Lottery section.  I will have to continue the Lottery section, and the debugging,
        // tomorrow. 
        // 3/23/2019@11am; Started watching debugging video to try and assess bug within code for
        // Tow Amount block
        // 11:40am; Began trying to debug
        // 12:29pm; I think I've narrowed it down to the beginning If statement; trying to debug it
        // 12:37 I decided to go back to square-one; I wrote a hand-drawn map with the Textbox and Labe
        // names written in. As I went through my code entries one-by-one, I noticed I had misnamed a
        // few of the boxes; specifically the howManyAnswerTextBox and answerWhatTowLabel.  I must
        // have been tired when I had initially written the code, because I had made the simple mistake 
        // of replacing these in my code with the instruction label howManyInCarLabel
        // 13:20 Began making plans for what type of loop going to use
        // 13:39 Created a While Loop at end of Tow Count portion of program.  Used Try, Catch, 
        // with Clear and Focus so User could continue entering answers repeatedly, infinitely.
        // I also made further attempt to practice saving programs to GitHub.  Not sure if successful
        // yet but plan to check this later.
        // 13:40 Beginning to add a Random # creator, and brainstorm on how to do this.  I believe
        // I will create a lottery for Roadside Assistance episodes
        // 14:25 Have created a lottery for Roadside Assistance episodes.  Am going to start finishing
        // touches on the labels for the lottery.
        // 14:51 I have just finished trying to make the program look more appearling to the eye.  
        // I think next time I work on code I will make sure I have a written list in front of me
        // of each entry box's title.  I have noticed small errors such as having the wrong box title
        // name seems to occur more than I thought they would, and have huge consequences.
        // 4/3/2019 @ 15:20pm began to look into how I was going to put together arrays, lists, and strings
        // and began to draw out a handwritten diagram with buttons, labels, and names.  I am going to try
        // to use and Array to pull up strings from my list originally created to document the different tows 
        // that have taken place.  
        // 17:15 I became stumped on how to transfer text to a label, and after a lot of research I realized
        // that it appears most training shows transfer to consoles or listboxes.  I decided to abort
        // transferring the text to a label, and instead switched to a listbox.  The problem that had taken
        // me a few hours to figure out was suddenly resolved, and the text transferred smoothly to a listbox.
        // I am now attempting to create another array, and will try to pull strings into it.  I am not sure
        // what I am pulling over yet, as it is an experimental creative process at this point, so have named my
        // button clickHerForButton.  I have no idea what this button will be clicked for yet.  
        // 4/4/2019 8:30 Attempted to create a vehicle exchange instruction array with all of the instructions appearing in a listbox.  
        // The ForEach portion seemed to be stumping me.  
        // 10:00am I began to research arrays again, and came across the book example of 'Colonies' (Chapter 7.5), where arrays are listed and 
        // Sequential Search is utilized to display a certain message list when certain arrays are chosen.  According to the book,
        // the Sequential Search "uses a loop to step through an array, starting at the first element. It compares each element with the 
        // value being searched and stops when value is found or end of array encountered"
        // I began practicing with the Colonies program to make sure I understood how it worked first.  I had a little trouble figuring out
        // the initial array set-up at the beginning of the program, and where it was supposed to start.  I eventually figured out it is supposed
        // to be placed after Initialize Component
        // 11:00am I began to implement the ideas from Colony array into the Final project vehicle exchange array
        // 12:00pm  I had trouble getting array MessageBox's to pop up.  After a little research in the program, I caught where I had put the 
        // incorrect ListBox name in the program.  Once I fixed it, everything worked perfectly.  However, at that point, I realized the instructions
        // in my MessageBox's were all listed as a single instruction.  I did a little more research, and found that "\n" could separate them into separate
        // lines.  
        // 13:00pm  The form was looking disorganized.  I decided to create a separate panel and move the Vehicle Exchange form to it, and then also moved
        // the Tow Stats form to the bottom of the app.  I added colors to the new panel and button, and also updated some of the wording and 
        // formatting of labels and buttons.
        // 13:30 I decided a scrollbar would be neat, as the form was getting big.  I did a lot of research, and never could figure out how to 
        // properly implement the scrollbar.  It is on my form now, but I decided I'd come back to it later.  My work ended at 14:30pm, approximately
        // 6 hours of work today. 
        // 4/8/2019 Have begun work at 18:20 pm to attempt adding menus.  I have run out of room on the first form, and do not think I can 
        // organize it any further to make it visually palatable.  Hopefully new forms will give me room to be more creative on my future projects. 
        // 20:09 pm I added 5 menus that are now successfully linkable from the original home form.  I was interrupted several times
        // during my session, which accounts for the lengthy amount of time it took to do so.  In order to document for the scrum project
        // portion, it was one of my children's tests he needed help with, then helping another one get set up to go somewhere and grab a 
        // bite to eat, and then my husband came home and we talked for a few minutes.  I would veer to say it actually only took me an 
        // hour to perform the actual research and build of the menus. 
        // 12:32 am  Night has turned into day, and it is now 4/9/2019.  I have completed quite a bit of work since my last documentation.  
        // Six menus have been created from the main page.  Due to this, my main page will be revamped. I had to move and copy all of the panels
        // buttons, labels, listboxes, etc, to the other pages.  Simultaneously I had to change to code over to those pages.  Then I had to delete the old 
        // code from the main page while simultaneously deleting those displays.  It took a little finagling, but eventually this portion of the project was successful.
        // I did get stuck for about an hour and a half on my vehicle exchange instructions.  I am still stuck while writing this actually, as I 
        // eventually decided to come back to it later.  When attempting to move it from the main page, I used the exact same code/programming that had
        // worked on the other page.  However, on this page it gave me an error code "SequentialSearch: not all code paths return a value."  
        // Many attempts later, I decided that maybe the answer would come to me later, and that I was preventing myself from further progress 
        // in other areas of the project.  
        // 4/9/2019 @ 12:42 am I am going to attempt to move the vehicle exchange instructions again, and change the title of the main page on the project. 
        // 12:57 am I am not sure why it worked this time, but I re-typed all fo the vehicle exchange programming into the new Vehicle Exchange form, and 
        // it worked perfectly.  I then began to meticulously delete the code from the main page, as well as displays.  I ran into a few errors, but was
        // very careful and able to do it without causing the program to shut down.  
        // 1:21 am I dded a National Tow and Lottery to mimic the Enterprise one, onto the National form.
        // 1:52 am I added a picture from Creative Commons to the main page.  I am planning
        // to add icons and make the other pages nicer looking later.  However my goal tonight
        // was to set a baseline for future work by cleaning the project up a bit, and giving it
        // some more room to work.  Basically, I wanted to get organized.  I feel like I have accomplished
        // my goal, and am ready to work on some more tomorrow.
        // 4/11/2019 @ 18:30 Have begun mapping out what type of program I will build for Final Project Week 4.  
        // 18:45 I started looking through AAA documents and found SIPP code forms organizing different types of cars.
        // I think that organizing some of these vehicular properties would be good to add to the Final Project to
        // show UML properties.  
        // 20:00 It took me a little while to research and organize different vehicular properties onto a Word 
        // document.  I did so in an outline format.  
        // 22:00 I have researched the requirements for the Final project in Week 4, and added these into my outline.
        // I now have Base classes and derived classes listed, with Polymorphism included. I have attempted to define
        // what all three of the methods will be.  I believe I am ready to begin my programming.  
        // 22:15 I have completed setting up the inital design with two title/instruction labels, and four "vehicle
        // choice buttons.
        // 23:45 I took a break to be with my family for about an hour and a half (despite the late hours, it so 
        // happened the house was still bustling).  I am now back and have begun to create my classes, and fill out
        // the programming to fulfill all requirements.
        // 4/12/2019
        // 02:00 From approximately 13:00 until now, the teenager in the house was behind on his college work, and 
        // needed my guidance to make sure his assignments were turned in properly.  I am behind on where I want 
        // to be in the programming, but getting started again. 
        // It's 3:04am.  I am getting tired, although on a role and want to continue.  However at this point I believe
        // I will only make mistakes due to fatigue.  I am finished with my Base Class, three Derived Classes, and
        // Design, except for the Encapsulation portion.  I plan to finish Encapsulation and filling out my Form1 (Main Form)
        // in the morning.
        // 7:45am I am going to begin adding my encapsulation code. I am going to add pictures to my buttons on the Vehicle Exchange page.
        // 8:49 I have added the encapsulation code to the Vehicle class form.  I also have successfully researched 
        // and then added pictures for each of my vehicle choice buttons to go onto a picture box.  Now I am going to begin
        // writing code for the vehicle description to show up in the labelbox.
        // 10:30 I have set the code for the vehicle description labels.  I want to practice with more constructors
        // and virtual so am going to try to set Vehicle color and Vehicle Speed Limiter settings.
        // Noon  I have completed my goal.  Now I am going to begin setting up another program under
        // stats to practice Encapsulation.
        // 12:20 I began by setting up my idea, handwritten on a piece of paper, then organizing my variables I'm 
        // planning on using on a Word file.  I am now going to begin setting up my Stat file with a new
        // panel to track the vehicle accidents
        // 13:00 I got my variables and method names mixed up, and decided to study the class videos again
        // to see where I went wrong
        // 14:00 I have a family committment, so will have to pick up again this evening.
        // 23:00 I am very fatigued. I have decided to continue my research and finish the vehicle accident tracker
        // tomorrow.
        // 4/13/2019  at 10:30, I am attempting to pick up where I left off yesterday. Currently I am researching
        // the class instruction on UML, inheritance, and encapsulation. 
        // Noon I feel confident to continue my attempts.  I have begun to create two new classes, Vehicle Style as 
        // the base class, with Damage as the Derived class. 
        // 12:30 There were a few interruptions helping the children with house/homework, but have gotten very far.
        // I also took a break to eat.  
        // 13:45 I ran into a few bumps with messageboxes not displaying when I wanted them to, but was able to 
        // figure that out.  The way my program is supposed to work, I only want certain entries able to be entered,
        // and then recorded into a txt file.  I am going to begin setting up that file and the StreamWriter transfer,
        // and also if/else and try/catches for entries and exceptions. 
        // 16:00 I have finished my coding for Week 4, and am going to now work on my presentations as required. 
        // 16:50 I renamed my Form1 to MainForm.  I have also submitted my Scrum for week 4. In calculation of how 
        // many hours the project this week has taken me, it appears to be. Including research time while coding, it
        // appears it took me approximatly 22 hours to build more onto my project this week. 
       
       
        private int SequentialSearch (string[] sArray, string value)
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
        private void enterpriseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void nationalButton_Click(object sender, EventArgs e)
        {
            
        }

        private void safetyButton_Click(object sender, EventArgs e)
        {
           
        }

        private void generalQuestionButton_Click(object sender, EventArgs e)
        {
            
        }

        private void whatKindTowButton_Click(object sender, EventArgs e)
        {
      
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Making and Exit for the form
            this.Close();
        }

        private void randomLotteryAnswer_Click(object sender, EventArgs e)
        {

        }

        private void lotteryButton_Click(object sender, EventArgs e)
        {

        }

        private void towListButton_Click(object sender, EventArgs e)
        {
           

        }

        private void clickHereForButton_Click(object sender, EventArgs e)
        {

           
   




            


        }

        private void exchangeAvailBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearTowListButton_Click(object sender, EventArgs e)
        {
           
        }

        private void roadsideAssistanceForm_Load(object sender, EventArgs e)
        {
            
            

            

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

          

        }

        private void enterpriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // The first form contans a menu strop that you can label quite easily. To evoke an event from the
            // form the label all you need to do is double click it
            EnterpriseForm2 Enterprise = new EnterpriseForm2(); // this creates an instance of the child form
            Enterprise.Show(); // this shows the form
        }

        private void nationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NationalForm National = new NationalForm();
            National.Show();
        }

        private void safetyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SafetyForm Safety = new SafetyForm();
            Safety.Show();
        }

        private void vehicleExchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleExchangeForm Vehicle_Exchange = new VehicleExchangeForm();
            Vehicle_Exchange.Show();
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatsForm Stats = new StatsForm();
            Stats.Show();
        }

        private void howManyAnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void generalQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralQuestionForm General_Questions = new GeneralQuestionForm();
            General_Questions.Show();

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void memberDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
