using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDiary
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Registerformbutton_Click(object sender, EventArgs e)
        {
            if (AgreeregistercheckBox.Text == "")
            {
                MessageBox.Show("agree can not be empty");
            }

            else if (NameregistertextBox.Text == "")
            { MessageBox.Show("Name can not be empty"); }

            else if (UsernameregistertextBox.Text == "")
            { MessageBox.Show("usename can not be empty"); }

            else if (PasswordregistertextBox.Text == "")
            { MessageBox.Show("password can not be empty"); }

            else if (ConfirmpasswordregistertextBox.Text == "")
            { MessageBox.Show("confrim password can not be empty"); }

            else if (EmailregistertextBox.Text == "")
            { MessageBox.Show("email can not be empty"); }

            else if (DateofbirthregisterdateTimePicker.Text == "")
            { MessageBox.Show("dateofbirth can not be empty"); }

            else if (MaleregisterradioButton.Text == "" && FemaleregisterradioButton.Text == "")
            { MessageBox.Show("gender can not be empty"); }

            else if (CountryregistercomboBox.Text == "")
            { MessageBox.Show("blood can not be empty"); }




            else
            {
                //Print print = new Print(this);
                //print.Show();
                //this.Hide();
            }
        }


        private void EmailregistertextBox_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if(!rEmail.IsMatch(EmailregistertextBox.Text))
            {
                MessageBox.Show("invalid email address", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailregistertextBox.SelectAll();
                e.Cancel = true;
            }
        }
    }
}
