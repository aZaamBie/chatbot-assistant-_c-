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
            //this.Size = new System.Drawing.Size(400, 73);
        }

        public void textOnLbl(string message)
        {
            lbl_Text.Text = message;
            if ((lbl_Text.Text.Length >= 10) & (lbl_Text.Text.Length < 50))
            {
                this.Size = new System.Drawing.Size(300, 73);
            }
            if ((lbl_Text.Text.Length >= 50) & (lbl_Text.Text.Length < 80))
            {
                this.Size = new System.Drawing.Size(430, 73);
            }
            if (lbl_Text.Text.Length >= 80 & (lbl_Text.Text.Length < 120))
            {
                this.Size = new System.Drawing.Size(430, 83); // y =83
            }
            if (lbl_Text.Text.Length >= 120 & (lbl_Text.Text.Length < 150) )
            {
                this.Size = new System.Drawing.Size(430, 93); // y = 93
            }
            if (lbl_Text.Text.Length >= 150 & (lbl_Text.Text.Length < 180))
            {
                this.Size = new System.Drawing.Size(430, 103);
            }
            if (lbl_Text.Text.Length >= 180 & (lbl_Text.Text.Length < 210))
            {
                this.Size = new System.Drawing.Size(430, 113);
            }
            if (lbl_Text.Text.Length >= 210)
            {
                this.Size = new System.Drawing.Size(430, 133);
            }



            return;
        }
    }
}
