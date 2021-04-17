
namespace PhotoDiary
{
    partial class LoginFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernamelogintextBox = new System.Windows.Forms.TextBox();
            this.PasswordlogintextBox = new System.Windows.Forms.TextBox();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // UsernamelogintextBox
            // 
            this.UsernamelogintextBox.Location = new System.Drawing.Point(227, 97);
            this.UsernamelogintextBox.Name = "UsernamelogintextBox";
            this.UsernamelogintextBox.Size = new System.Drawing.Size(100, 20);
            this.UsernamelogintextBox.TabIndex = 2;
            // 
            // PasswordlogintextBox
            // 
            this.PasswordlogintextBox.Location = new System.Drawing.Point(227, 149);
            this.PasswordlogintextBox.Name = "PasswordlogintextBox";
            this.PasswordlogintextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordlogintextBox.TabIndex = 3;
            // 
            // Registerbutton
            // 
            this.Registerbutton.Location = new System.Drawing.Point(117, 372);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(75, 23);
            this.Registerbutton.TabIndex = 4;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.UseVisualStyleBackColor = true;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(317, 210);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 23);
            this.Loginbutton.TabIndex = 5;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Don\'t Have An Account?";
            // 
            // LoginFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.PasswordlogintextBox);
            this.Controls.Add(this.UsernamelogintextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFrom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernamelogintextBox;
        private System.Windows.Forms.TextBox PasswordlogintextBox;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label label3;
    }
}

