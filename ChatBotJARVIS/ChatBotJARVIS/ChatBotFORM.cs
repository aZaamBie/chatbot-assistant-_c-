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
        public string Message = "";
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
            string[] secondWord = userCommand.Split(' ');

            //- case statment -//
            switch (userC_UPPER) // (userCommand)
            {
                // GREETINGS
                case "HELLO": // hello
                    if (greeted == false) // (greeted == false)
                    {
                        newMessageLOAD("Hello there. I'm JARVIS.", false, true); // bot message
                        greeted = true;
                        break;
                    }
                    else
                    {
                        newMessageLOAD("I already said Hello.", false, true); // bot message
                        break;
                    }
                case "YO": // yo
                    if (lastMessage != Message)
                    {
                        newMessageLOAD("Yo yo, what's up?", false, true); // bot message      !!!## ORIGINAL METHOD
                    }

                    else if (lastMessage == Message)
                    {
                        newMessageLOAD("Yo?", false, true); // bot message
                    }
                    break;
                case "EXIT":
                    if (MessageBox.Show("Are you sure?", "Quitting app", MessageBoxButtons.YesNo, MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    { this.Close(); }
                    break;

                //
                case "WHO ARE YOU":
                    if (lastMessage != Message)
                    { newMessageLOAD("I'm JARVIS", false, true); } // bot message        !!!## ORIGINAL METHOD
                    else
                    { newMessageLOAD("I said I'm Jarvis.", false, true); }
                    break;
                case "WHO ARE YOU?":
                    if (lastMessage != Message)
                    { newMessageLOAD("I'm JARVIS", false, true); } // bot message        !!!## ORIGINAL METHOD 
                    else
                    { newMessageLOAD("I said I'm Jarvis.", false, true); }
                    break;

                case "WHAT ARE YOU":
                    if (lastMessage != Message)
                    { newMessageLOAD("I'm a chatbot/virtual assistant like Alexa or Siri.", false, true); } // !!!## ORIGINAL METHOD
                    else
                    { newMessageLOAD("Once again, I'm a chatbot / virtual assistant.", false, true); }
                    break;
                case "WHAT ARE YOU?":
                    if (lastMessage != Message)
                    { newMessageLOAD("I'm a chatbot/virtual assistant like Alexa or Siri.", false, true); } // !!!## ORIGINAL METHOD
                    else
                    { newMessageLOAD("Once again, I'm a chatbot / virtual assistant.", false, true); }
                    break;

                case "HELP":
                    newMessageLOAD("What do you need help with?", false, true);
                    newMessageLOAD("P.S. If it's something medical, then I'm sorry but I can't help. ", false, true);
                    newMessageLOAD("buut I can  give you direction to find your solution!", false, true);
                    break;

                // TIME
                case "TIME":
                    TimeGlobalFORM newFrm = new TimeGlobalFORM();
                    newFrm.ShowDialog();
                    break;

                // LIST
                case "LIST":
                    newMessageLOAD("List of commands:" +
                        "\n" + "- time (a window with timezones will be displayed)" +
                        "\n" + "- search (you can type anything after this and it will be searched on a browser)" +
                        "\n" + "- tell me a (you can type either: joke or quote and I will respond with one of those)",
                        false, true); // bot message
                    break;

                // blank response
                case "":
                    newMessageLOAD("I can't respond to a blank command", false, true); // bot message
                    break;

            }

            // CONFUSED?
            if ((Message.ToUpper() == "IM CONFUSED") || (Message.ToUpper() == "I'M CONFUSED"))
            {
                newMessageLOAD("I can give you a list of commands, that I can respond to", false, true);
            }
            else { return; }

            //-- 'SEARCH' COMMAND
            string google;

            // SOLUTION 2 \\
            if ( (firstWord[0].ToUpper()== "SEARCH")) // checks whether 1st element has the word "Search"
            {
                secondWord = secondWord.Skip(1).ToArray();  // skips the 1st word (SEARCH)
                string newWord = string.Join(" ", secondWord); // creates a new string, that joins the elements in the array

                //- google search
                google = "https://www.google.com/search?q=" + newWord; // concatenates the 2 strings
                Process.Start(google); // searches the input on google
            }


            //-- 'TELL ME' COMMAND
            if (firstWord.Length > 3)
            {

                if ((firstWord[0].ToUpper() == "TELL") & (firstWord[1].ToUpper() == "ME") & (firstWord[2].ToUpper() == "A"))
                {
                    // Console.WriteLine("it's a tell me function");
                    switch (firstWord[3].ToUpper())
                    {
                        case "JOKE":
                            jokeResponse();
                            break;

                        case "QUOTE":
                            break;
                    }
                }
                else
                { return; }
            }

            //- TIME COMMAND

        }

        string[] jokes = new string[] { "Why did the chicken cross the road? To get to the other side",
            "What does a liar do when they're dead? They lie still", "What kind of tea is hard to swallow? Reality",
            "What's the difference between 100 dead babies and a Ferrarri? I don't keep a ferrarri in my garage",
            "Dark humor is like water, not everyone gets it", 
            "Today I learned all about the orbicularis oculi muscles. Quite the eye opener I tell ya"};

        private void jokeResponse() // MANAGES THE JOKES TO TELL
        {
            Random randomChoice = new Random();
            int numberOfJokes = jokes.Length; // gets the total number of all elements
            int jokeChoice = randomChoice.Next(numberOfJokes); // sets the joke choice to a number between 1 and numberOfJokes

            newMessageLOAD(jokes[jokeChoice], false, true); // bot message
        }

        // LOADING LABELS 

        int user_locX = 250; // 250 or 150
        int bot_locX = 5; // 5
        int locY = (10-70); // 10 or 50
        int count = 0;

        private void newMessageLOAD(string newMessage,bool userResponse,bool botResponse)
        {

            if (userResponse==true && botResponse == false) //  USER RESPONSE
            {
                count++;
                for (int i = 0; i < count; i++)
                {
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
            if (Message != "")
            {
                lastMessage = Message;
                Console.WriteLine(lastMessage + " is last message");
            }
            Message = txtBox_UserInput.Text; // gets user text
            Console.WriteLine(Message + " is current message");
            botRespond(Message);
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
