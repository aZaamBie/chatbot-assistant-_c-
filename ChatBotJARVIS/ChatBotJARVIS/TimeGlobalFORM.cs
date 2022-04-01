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
    public partial class TimeGlobalFORM : Form
    {
        public TimeGlobalFORM()
        {
            InitializeComponent();
        }

        private void updateTime()
        {
            lbl_CT.Text = ("Cape Town: " + DateTime.Now.ToLongTimeString() + " [GMT +2]");
            lbl_Dubai.Text = ("Dubai: " + DateTime.Now.AddHours(2).ToLongTimeString() + " [GMT +4]");
            lbl_Ghana.Text = ("Ghana: " + DateTime.Now.ToUniversalTime().ToLongTimeString() + " [GMT +0]"); //  + DateTime.Now.AddHours(-2).ToLongTimeString() +
        }

        private void tmr_Update_Tick(object sender, EventArgs e)
        {
            updateTime();
        }
    }
}
