using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBotJARVIS
{
    public partial class msgBox_incoming : UserControl
    {
        public msgBox_incoming()
        {
            InitializeComponent();
        }

        public void textOnLbl(string message)
        {
            lbl_Text.Text = message;
            return;
        }
    }
}
