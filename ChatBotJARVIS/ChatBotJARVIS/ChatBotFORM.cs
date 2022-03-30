using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers; // using this, to dynamically create timers (in-code)

namespace ChatBotJARVIS
{
    public partial class frm_ChatBot : Form
    {
        //## VARIABLES ##\\
        public bool inputTouched = false;
        public bool timerDone = true;
        public bool greeted = false;
        public string lastMessage = "";

        public static System.Windows.Forms.Timer newTimer;



        //## METHODS ##\\

        // INITIALIZE \\
        public frm_ChatBot()
        {
            InitializeComponent();
            lbl_DateTime.Text = DateTime.Now.ToString();
            //botRespond("HELLO");
        }

        private void botRespond(string userCommand) // this method chooses how bot responds
        {
            //- variables -//

            newMessageLOAD(userCommand, true, false); // user message

            string userC_UPPER = userCommand.ToUpper();

            string[] firstWord = userCommand.Split(' '); // splits the string into substring in an array
            string[] secondWord = userCommand.Split(' '); // string[] secondWord = userCommand.Split(' ');

            //- case statment -//
            switch (userC_UPPER) // (userCommand 
            {
                // GREETINGS
                case "HELLO": // hello
                    if (greeted == false) // (greeted == false)
                    {
                        newMessageLOAD("Hello there. I'm Jarvis.", false, true); // bot message
                        greeted = true;
                        break;
                    }
                    else
                    {
                        newMessageLOAD("I already said Hello.", false, true); // bot message
                        break;
                    }
                case "YO": // yo
                    newMessageLOAD("Yo yo, what's up", false, true); // bot message
                    break;
                case "EXIT":
                    if (MessageBox.Show("Are you sure?", "Quitting app", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    break;

                //
                case "WHO ARE YOU":
                    newMessageLOAD("I'm JARVIS", false, true); // bot message
                    break;
                case "WHO ARE YOU?":
                    newMessageLOAD("I'm JARVIS", false, true); // bot message
                    break;
                case "WHAT ARE YOU?":
                    newMessageLOAD("I'm a chatbot/virtual assistant like Alexa or Siri.", false, true); // bot message
                    break;

                case " ":
                    newMessageLOAD("I can't respond to a blank command", false, true); // bot message
                    break;

            }

            //## 'SEARCH' COMMAND ##\\
            string google;

            //__ SOLUTION 1 __\\
/*            foreach (string word in firstWord) // iteration
            {

                if (word == "search" || word == "google")
                {
                    google = "https://www.google.com/search?q=";

*//*                    foreach (string word2 in secondWord)
                    {
                        if (word2 != "search") // disregards
                        {
                            //string strWord = new string(word2);
                            //string strWord = string.Join("", word2);
                            //string strWord = string.Concat(word2);
                            string strWord = word2.ToString();

                            //Console.WriteLine(strWord);
                            //Console.WriteLine(word2);

*//*                          
                            google = "https://www.google.com/search?q=" + word2;
                            Process.Start(google); *//*
                        }
                    }*//*

                    Console.WriteLine(word, " is word");
                }

*//*              google = "https://www.google.com/search?q=" + secondWord;
                Process.Start(google);*//*
            }*/

            //__ SOLUTION 2 __\\
            if ( (firstWord[0].ToUpper()== "SEARCH")) // checks whether 1st element has the word "Search"
            {
                secondWord = secondWord.Skip(1).ToArray();  // skips the 1st word (SEARCH)
                string newWord = string.Join(" ", secondWord); // creates a new string, that joins the elements in the array

                //- google search
                google = "https://www.google.com/search?q=" + newWord; // concatenates the 2 strings
                Process.Start(google); // searches the input on google
            }

        }

        // LOADING LABELS 

        int user_locX = 250; // 250 or 150
        int bot_locX = 5; // 5
        int locY = (10-70); // 10 or 50
        int count = 0;

        private void newMessageLOAD(string newMessage,bool userResponse,bool botResponse)
        {
            //Console.WriteLine(newMessage + " from func newMessageLOAD");

            if (userResponse==true && botResponse == false) //  USER RESPONSE
            {
                count++;
                for (int i = 0; i < count; i++)
                {
                    // DYNAMIC LABELS
/*                    locY += 30;

                    Label newLabel = new Label();
                    this.Controls.Add(newLabel); // adds label to form
                    //pnl_BODY.Controls.Add(new Label()); // adds label to panel

                    newLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    newLabel.BackColor = Color.Brown; // back color   / Color.BlueViolet;
                    newLabel.ForeColor = Color.White; // text color
                    newLabel.Location = new Point(locX, locY); // adds to location
                    newLabel.Padding = new Padding(4);
                    // newLabel.Dock = DockStyle.Right;
                    newLabel.TextAlign = ContentAlignment.MiddleCenter;

                    newLabel.Font = new Font("Arial", 18f, FontStyle.Regular, GraphicsUnit.Point); // sets up font
                    newLabel.Visible = true;
                    newLabel.AutoSize = true; // true
                    newLabel.Text = newMessage; // sets the label text
                    newLabel.BringToFront();*/

                    // USER FORM
                    locY += 70; // 10

                    msgBox_outgoing newMsgBox = new msgBox_outgoing();
                    pnl_BODY.Controls.Add(newMsgBox);
                    newMsgBox.BringToFront();
                    newMsgBox.textOnLbl(newMessage);
                    newMsgBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    newMsgBox.Location = new Point(user_locX, locY);

                    count--;
                }
            }

            if (botResponse == true && userResponse == false) // BOT RESPONSE
            {
                count++;
                for (int i = 0; i < count; i++)
                {
                    // DYNAMIC LABELS
/*                    locY += 30;

                    Label newLabel = new Label();
                    this.Controls.Add(newLabel); // adds label to form
                    //pnl_BODY.Controls.Add(new Label()); // adds label to panel

                    newLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    newLabel.BackColor = Color.DarkRed; // back color   / Color.BlueViolet;
                    newLabel.ForeColor = Color.White; // text color
                    newLabel.Location = new Point(bot_locX, locY); // adds to location
                    newLabel.Padding = new Padding(4);
                    newLabel.TextAlign = ContentAlignment.MiddleCenter;

                    newLabel.Font = new Font("Arial", 18f, FontStyle.Regular, GraphicsUnit.Point); // sets up font
                    newLabel.Visible = true;
                    newLabel.AutoSize = true;
                    newLabel.Text = newMessage; // sets the label text
                    newLabel.BringToFront();*/

                    // USER FORM
                    locY += 70; // 10

                    msgBox_incoming newMsgBox = new msgBox_incoming();
                    pnl_BODY.Controls.Add(newMsgBox);
                    newMsgBox.BringToFront();
                    newMsgBox.textOnLbl(newMessage);
                    newMsgBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    newMsgBox.Location = new Point(bot_locX,locY);

                    count--;
                }
            }
        }


        // SENDS MESSAGE

        public void sendMessage()
        {
            lastMessage = txtBox_UserInput.Text; // gets user text
            botRespond(lastMessage);
            clearTextBox();
        }

        private void txtBox_UserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the text box is not empty AND the enter key is pressed:
            if ((txtBox_UserInput.Text != "") & (e.KeyChar == (char)Keys.Enter))
            {
                sendMessage();
            }
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        // CLEARS TEXT BOX
        private void clearTextBox()
        {
            txtBox_UserInput.Text = "";
        }

        private void txtBox_UserInput_MouseClick(object sender, MouseEventArgs e)
        {
            if (inputTouched == false) // at the start, if mouse click the box, the default text disappears
            {
                inputTouched = true;
                clearTextBox();
            }

            else
            { //
            }
        }

        // MANAGES THE CURRENT TIME
        private void tmr_DateTimeUPDATE_Tick(object sender, EventArgs e)
        {
            lbl_DateTime.Text = DateTime.Now.ToString();
        }

    }
}
