
namespace PhotoDiary
{
    partial class EditEvent
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
            this.ModifydateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.pictureeditBox = new System.Windows.Forms.PictureBox();
            this.UploadimageedittextBox = new System.Windows.Forms.TextBox();
            this.Uploadimagebutton = new System.Windows.Forms.Button();
            this.HigheditradioButton = new System.Windows.Forms.RadioButton();
            this.ModerateeditradioButton = new System.Windows.Forms.RadioButton();
            this.LesseditradioButton = new System.Windows.Forms.RadioButton();
            this.StoryedittextBox = new System.Windows.Forms.TextBox();
            this.EventeditnametextBox = new System.Windows.Forms.TextBox();
            this.Importancelabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Storylabel = new System.Windows.Forms.Label();
            this.Eventnamelabel = new System.Windows.Forms.Label();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Backeditbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureeditBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifydateTimePicker
            // 
            this.ModifydateTimePicker.Enabled = false;
            this.ModifydateTimePicker.Location = new System.Drawing.Point(122, 177);
            this.ModifydateTimePicker.MaxDate = new System.DateTime(2021, 4, 20, 0, 0, 0, 0);
            this.ModifydateTimePicker.MinDate = new System.DateTime(2021, 4, 20, 0, 0, 0, 0);
            this.ModifydateTimePicker.Name = "ModifydateTimePicker";
            this.ModifydateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.ModifydateTimePicker.TabIndex = 28;
            this.ModifydateTimePicker.Value = new System.DateTime(2021, 4, 20, 0, 0, 0, 0);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Updatebutton.Location = new System.Drawing.Point(572, 372);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(105, 43);
            this.Updatebutton.TabIndex = 27;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.svaebutton_Click);
            // 
            // pictureeditBox
            // 
            this.pictureeditBox.Location = new System.Drawing.Point(624, 127);
            this.pictureeditBox.Name = "pictureeditBox";
            this.pictureeditBox.Size = new System.Drawing.Size(267, 194);
            this.pictureeditBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureeditBox.TabIndex = 26;
            this.pictureeditBox.TabStop = false;
            this.pictureeditBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // UploadimageedittextBox
            // 
            this.UploadimageedittextBox.Location = new System.Drawing.Point(154, 298);
            this.UploadimageedittextBox.Name = "UploadimageedittextBox";
            this.UploadimageedittextBox.Size = new System.Drawing.Size(382, 20);
            this.UploadimageedittextBox.TabIndex = 25;
            // 
            // Uploadimagebutton
            // 
            this.Uploadimagebutton.Location = new System.Drawing.Point(8, 298);
            this.Uploadimagebutton.Name = "Uploadimagebutton";
            this.Uploadimagebutton.Size = new System.Drawing.Size(109, 23);
            this.Uploadimagebutton.TabIndex = 24;
            this.Uploadimagebutton.Text = "Upload Your Image";
            this.Uploadimagebutton.UseVisualStyleBackColor = true;
            this.Uploadimagebutton.Click += new System.EventHandler(this.Uploadimagebutton_Click);
            // 
            // HigheditradioButton
            // 
            this.HigheditradioButton.AutoSize = true;
            this.HigheditradioButton.Location = new System.Drawing.Point(341, 226);
            this.HigheditradioButton.Name = "HigheditradioButton";
            this.HigheditradioButton.Size = new System.Drawing.Size(47, 17);
            this.HigheditradioButton.TabIndex = 23;
            this.HigheditradioButton.TabStop = true;
            this.HigheditradioButton.Text = "High";
            this.HigheditradioButton.UseVisualStyleBackColor = true;
            // 
            // ModerateeditradioButton
            // 
            this.ModerateeditradioButton.AutoSize = true;
            this.ModerateeditradioButton.Location = new System.Drawing.Point(212, 226);
            this.ModerateeditradioButton.Name = "ModerateeditradioButton";
            this.ModerateeditradioButton.Size = new System.Drawing.Size(70, 17);
            this.ModerateeditradioButton.TabIndex = 22;
            this.ModerateeditradioButton.TabStop = true;
            this.ModerateeditradioButton.Text = "Moderate";
            this.ModerateeditradioButton.UseVisualStyleBackColor = true;
            // 
            // LesseditradioButton
            // 
            this.LesseditradioButton.AutoSize = true;
            this.LesseditradioButton.Location = new System.Drawing.Point(122, 226);
            this.LesseditradioButton.Name = "LesseditradioButton";
            this.LesseditradioButton.Size = new System.Drawing.Size(47, 17);
            this.LesseditradioButton.TabIndex = 21;
            this.LesseditradioButton.TabStop = true;
            this.LesseditradioButton.Text = "Less";
            this.LesseditradioButton.UseVisualStyleBackColor = true;
            // 
            // StoryedittextBox
            // 
            this.StoryedittextBox.Location = new System.Drawing.Point(122, 66);
            this.StoryedittextBox.Multiline = true;
            this.StoryedittextBox.Name = "StoryedittextBox";
            this.StoryedittextBox.Size = new System.Drawing.Size(408, 94);
            this.StoryedittextBox.TabIndex = 20;
            // 
            // EventeditnametextBox
            // 
            this.EventeditnametextBox.Location = new System.Drawing.Point(122, 32);
            this.EventeditnametextBox.Name = "EventeditnametextBox";
            this.EventeditnametextBox.Size = new System.Drawing.Size(229, 20);
            this.EventeditnametextBox.TabIndex = 19;
            // 
            // Importancelabel
            // 
            this.Importancelabel.AutoSize = true;
            this.Importancelabel.Location = new System.Drawing.Point(5, 230);
            this.Importancelabel.Name = "Importancelabel";
            this.Importancelabel.Size = new System.Drawing.Size(60, 13);
            this.Importancelabel.TabIndex = 18;
            this.Importancelabel.Text = "Importance";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Location = new System.Drawing.Point(5, 177);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(64, 13);
            this.Datelabel.TabIndex = 17;
            this.Datelabel.Text = "Modify Date";
            // 
            // Storylabel
            // 
            this.Storylabel.AutoSize = true;
            this.Storylabel.Location = new System.Drawing.Point(5, 69);
            this.Storylabel.Name = "Storylabel";
            this.Storylabel.Size = new System.Drawing.Size(105, 13);
            this.Storylabel.TabIndex = 16;
            this.Storylabel.Text = "Give Your Story here";
            // 
            // Eventnamelabel
            // 
            this.Eventnamelabel.AutoSize = true;
            this.Eventnamelabel.Location = new System.Drawing.Point(5, 35);
            this.Eventnamelabel.Name = "Eventnamelabel";
            this.Eventnamelabel.Size = new System.Drawing.Size(66, 13);
            this.Eventnamelabel.TabIndex = 15;
            this.Eventnamelabel.Text = "Event Name";
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Searchbutton.Location = new System.Drawing.Point(401, 32);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(116, 23);
            this.Searchbutton.TabIndex = 29;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Backeditbutton
            // 
            this.Backeditbutton.Location = new System.Drawing.Point(725, 372);
            this.Backeditbutton.Name = "Backeditbutton";
            this.Backeditbutton.Size = new System.Drawing.Size(117, 43);
            this.Backeditbutton.TabIndex = 30;
            this.Backeditbutton.Text = "Back";
            this.Backeditbutton.UseVisualStyleBackColor = true;
            this.Backeditbutton.Click += new System.EventHandler(this.Backeditbutton_Click);
            // 
            // EditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.Backeditbutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.ModifydateTimePicker);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.pictureeditBox);
            this.Controls.Add(this.UploadimageedittextBox);
            this.Controls.Add(this.Uploadimagebutton);
            this.Controls.Add(this.HigheditradioButton);
            this.Controls.Add(this.ModerateeditradioButton);
            this.Controls.Add(this.LesseditradioButton);
            this.Controls.Add(this.StoryedittextBox);
            this.Controls.Add(this.EventeditnametextBox);
            this.Controls.Add(this.Importancelabel);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.Storylabel);
            this.Controls.Add(this.Eventnamelabel);
            this.Name = "EditEvent";
            this.Text = "EditEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditEvent_FormClosing);
            this.Load += new System.EventHandler(this.EditEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureeditBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ModifydateTimePicker;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.PictureBox pictureeditBox;
        private System.Windows.Forms.TextBox UploadimageedittextBox;
        private System.Windows.Forms.Button Uploadimagebutton;
        private System.Windows.Forms.RadioButton HigheditradioButton;
        private System.Windows.Forms.RadioButton ModerateeditradioButton;
        private System.Windows.Forms.RadioButton LesseditradioButton;
        private System.Windows.Forms.TextBox StoryedittextBox;
        private System.Windows.Forms.TextBox EventeditnametextBox;
        private System.Windows.Forms.Label Importancelabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Storylabel;
        private System.Windows.Forms.Label Eventnamelabel;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Backeditbutton;
    }
}