namespace ChatBotJARVIS
{
    partial class msgBox_incoming
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Text = new System.Windows.Forms.Label();
            this.pBox_User = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Text
            // 
            this.lbl_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Text.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Text.Location = new System.Drawing.Point(72, 0);
            this.lbl_Text.MinimumSize = new System.Drawing.Size(328, 70);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Text.Size = new System.Drawing.Size(328, 70);
            this.lbl_Text.TabIndex = 0;
            this.lbl_Text.Text = "Hello there. I\'m Jarvis";
            // 
            // pBox_User
            // 
            this.pBox_User.Image = global::ChatBotJARVIS.Properties.Resources.robotIcon_1;
            this.pBox_User.Location = new System.Drawing.Point(1, 0);
            this.pBox_User.Name = "pBox_User";
            this.pBox_User.Size = new System.Drawing.Size(70, 70);
            this.pBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_User.TabIndex = 1;
            this.pBox_User.TabStop = false;
            // 
            // msgBox_incoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbl_Text);
            this.Controls.Add(this.pBox_User);
            this.Name = "msgBox_incoming";
            this.Size = new System.Drawing.Size(400, 73);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.PictureBox pBox_User;
    }
}
