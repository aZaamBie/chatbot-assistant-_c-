namespace ChatBotJARVIS
{
    partial class frm_ChatBot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChatBot));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pBox_Icon = new System.Windows.Forms.PictureBox();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.lbl_Jarvis = new System.Windows.Forms.Label();
            this.tmr_DateTimeUPDATE = new System.Windows.Forms.Timer(this.components);
            this.txtBox_UserInput = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.pnl_BODY = new System.Windows.Forms.Panel();
            this.msgBox_incoming1 = new ChatBotJARVIS.msgBox_incoming();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Icon)).BeginInit();
            this.pnl_BODY.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Header.Controls.Add(this.pBox_Icon);
            this.pnl_Header.Controls.Add(this.lbl_DateTime);
            this.pnl_Header.Controls.Add(this.lbl_Jarvis);
            this.pnl_Header.Location = new System.Drawing.Point(0, -4);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(721, 106);
            this.pnl_Header.TabIndex = 0;
            // 
            // pBox_Icon
            // 
            this.pBox_Icon.BackColor = System.Drawing.Color.Transparent;
            this.pBox_Icon.Image = global::ChatBotJARVIS.Properties.Resources.jarvisICON;
            this.pBox_Icon.Location = new System.Drawing.Point(7, 6);
            this.pBox_Icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBox_Icon.Name = "pBox_Icon";
            this.pBox_Icon.Size = new System.Drawing.Size(105, 98);
            this.pBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_Icon.TabIndex = 4;
            this.pBox_Icon.TabStop = false;
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lbl_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DateTime.Location = new System.Drawing.Point(496, 7);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(71, 29);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "00:00";
            // 
            // lbl_Jarvis
            // 
            this.lbl_Jarvis.AutoSize = true;
            this.lbl_Jarvis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Jarvis.Font = new System.Drawing.Font("Franklin Gothic Medium", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jarvis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Jarvis.Location = new System.Drawing.Point(118, 61);
            this.lbl_Jarvis.Name = "lbl_Jarvis";
            this.lbl_Jarvis.Size = new System.Drawing.Size(113, 37);
            this.lbl_Jarvis.TabIndex = 2;
            this.lbl_Jarvis.Text = "JARVIS";
            // 
            // tmr_DateTimeUPDATE
            // 
            this.tmr_DateTimeUPDATE.Enabled = true;
            this.tmr_DateTimeUPDATE.Interval = 1000;
            this.tmr_DateTimeUPDATE.Tick += new System.EventHandler(this.tmr_DateTimeUPDATE_Tick);
            // 
            // txtBox_UserInput
            // 
            this.txtBox_UserInput.AcceptsReturn = true;
            this.txtBox_UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_UserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBox_UserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_UserInput.Location = new System.Drawing.Point(5, 750);
            this.txtBox_UserInput.Name = "txtBox_UserInput";
            this.txtBox_UserInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_UserInput.Size = new System.Drawing.Size(623, 30);
            this.txtBox_UserInput.TabIndex = 1;
            this.txtBox_UserInput.Text = "ENTER COMMAND HERE\r\n";
            this.txtBox_UserInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_UserInput_MouseClick);
            this.txtBox_UserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_UserInput_KeyPress);
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.BackColor = System.Drawing.Color.Transparent;
            this.btn_Send.BackgroundImage = global::ChatBotJARVIS.Properties.Resources.send_icon_64x64_;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Send.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Send.Location = new System.Drawing.Point(650, 733);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(60, 81);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // pnl_BODY
            // 
            this.pnl_BODY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BODY.AutoScroll = true;
            this.pnl_BODY.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_BODY.BackgroundImage = global::ChatBotJARVIS.Properties.Resources._1_jpg;
            this.pnl_BODY.Controls.Add(this.msgBox_incoming1);
            this.pnl_BODY.Location = new System.Drawing.Point(0, 98);
            this.pnl_BODY.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_BODY.Name = "pnl_BODY";
            this.pnl_BODY.Size = new System.Drawing.Size(730, 634);
            this.pnl_BODY.TabIndex = 5;
            // 
            // msgBox_incoming1
            // 
            this.msgBox_incoming1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msgBox_incoming1.Location = new System.Drawing.Point(5, 10);
            this.msgBox_incoming1.Name = "msgBox_incoming1";
            this.msgBox_incoming1.Size = new System.Drawing.Size(400, 85);
            this.msgBox_incoming1.TabIndex = 0;
            this.msgBox_incoming1.Visible = false;
            // 
            // frm_ChatBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(722, 816);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txtBox_UserInput);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_BODY);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ChatBot";
            this.Text = "ChatBot";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Icon)).EndInit();
            this.pnl_BODY.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Timer tmr_DateTimeUPDATE;
        private System.Windows.Forms.TextBox txtBox_UserInput;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Label lbl_Jarvis;
        private System.Windows.Forms.PictureBox pBox_Icon;
        private System.Windows.Forms.Panel pnl_BODY;
        private System.Windows.Forms.Button btn_Send;
        private msgBox_incoming msgBox_incoming1;
    }
}

