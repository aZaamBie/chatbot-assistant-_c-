namespace ChatBotJARVIS
{
    partial class TimeGlobalFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeGlobalFORM));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pBox_Earth = new System.Windows.Forms.PictureBox();
            this.lbl_CT = new System.Windows.Forms.Label();
            this.tmr_Update = new System.Windows.Forms.Timer(this.components);
            this.lbl_Ghana = new System.Windows.Forms.Label();
            this.lbl_Dubai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Earth)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.lbl_Header.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_Header.Location = new System.Drawing.Point(238, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Header.Size = new System.Drawing.Size(282, 39);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Time around the World";
            // 
            // pBox_Earth
            // 
            this.pBox_Earth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBox_Earth.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Earth.Image")));
            this.pBox_Earth.Location = new System.Drawing.Point(-13, 91);
            this.pBox_Earth.Name = "pBox_Earth";
            this.pBox_Earth.Size = new System.Drawing.Size(780, 380);
            this.pBox_Earth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_Earth.TabIndex = 0;
            this.pBox_Earth.TabStop = false;
            // 
            // lbl_CT
            // 
            this.lbl_CT.AutoSize = true;
            this.lbl_CT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_CT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_CT.Location = new System.Drawing.Point(0, 503);
            this.lbl_CT.Name = "lbl_CT";
            this.lbl_CT.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_CT.Size = new System.Drawing.Size(129, 29);
            this.lbl_CT.TabIndex = 2;
            this.lbl_CT.Text = "Cape Town: ";
            // 
            // tmr_Update
            // 
            this.tmr_Update.Enabled = true;
            this.tmr_Update.Interval = 1000;
            this.tmr_Update.Tick += new System.EventHandler(this.tmr_Update_Tick);
            // 
            // lbl_Ghana
            // 
            this.lbl_Ghana.AutoSize = true;
            this.lbl_Ghana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Ghana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ghana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Ghana.Location = new System.Drawing.Point(0, 573);
            this.lbl_Ghana.Name = "lbl_Ghana";
            this.lbl_Ghana.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Ghana.Size = new System.Drawing.Size(81, 29);
            this.lbl_Ghana.TabIndex = 3;
            this.lbl_Ghana.Text = "Ghana:";
            // 
            // lbl_Dubai
            // 
            this.lbl_Dubai.AutoSize = true;
            this.lbl_Dubai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Dubai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dubai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Dubai.Location = new System.Drawing.Point(400, 503);
            this.lbl_Dubai.Name = "lbl_Dubai";
            this.lbl_Dubai.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Dubai.Size = new System.Drawing.Size(73, 29);
            this.lbl_Dubai.TabIndex = 4;
            this.lbl_Dubai.Text = "Dubai:";
            // 
            // TimeGlobalFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(742, 756);
            this.Controls.Add(this.lbl_Dubai);
            this.Controls.Add(this.lbl_Ghana);
            this.Controls.Add(this.lbl_CT);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.pBox_Earth);
            this.Name = "TimeGlobalFORM";
            this.Text = "GlobalTimes Window";
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Earth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_Earth;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_CT;
        private System.Windows.Forms.Timer tmr_Update;
        private System.Windows.Forms.Label lbl_Ghana;
        private System.Windows.Forms.Label lbl_Dubai;
    }
}