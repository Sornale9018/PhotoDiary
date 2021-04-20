using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

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

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDiary"].ConnectionString);
            connection.Open();

            string sql = "SELECT *FROM Users WHERE userName= '" + UsernameregistertextBox.Text + "' ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();


            if (reader.Read())
            {
                MessageBox.Show("User Name Already Exist!!!!!!!!!!Give Another User Name.....");
                RegisterForm registerForm = new RegisterForm();

                this.Hide();
                registerForm.Show();





            }

            else
            {

                if (AgreeregistercheckBox.Text == "")
                {
                    MessageBox.Show("agree can not be empty");
                }

                else if (NameregistertextBox.Text == "")
                { MessageBox.Show("Name can not be empty"); }

                else if (UsernameregistertextBox.Text == "")
                { MessageBox.Show("User Name can not be empty"); }

                else if (PasswordregistertextBox.Text == "")
                { MessageBox.Show("Password can not be empty"); }

                else if (ConfirmpasswordregistertextBox.Text == "")
                { MessageBox.Show("Confrim Password can not be empty"); }

                else if (EmailregistertextBox.Text == "")
                { MessageBox.Show("Email can not be empty"); }

                else if (DateofbirthregisterdateTimePicker.Text == "")
                { MessageBox.Show("Date of Birth can not be empty"); }

                else if (MaleregisterradioButton.Text == "" && FemaleregisterradioButton.Text == "")
                { MessageBox.Show("Gender can not be empty"); }

                else if (CountryregistercomboBox.Text == "")
                { MessageBox.Show("Blood Group can not be empty"); }




                else
                {
                    //Database
                    SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDiary"].ConnectionString);

                    connection1.Open();

                    string gender = "";
                    if (MaleregisterradioButton.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    string sql1 = "INSERT INTO USERS(userName,password,name,email,mobileNumber,dateofBirth,gender,country)VALUES('" + UsernameregistertextBox.Text + "','" + PasswordregistertextBox.Text + "','" + NameregistertextBox.Text + "','" + EmailregistertextBox.Text + "','" + MobilenumberregistertextBox.Text + "','" + DateofbirthregisterdateTimePicker.Text + "','" + gender + "','" + CountryregistercomboBox.Text + "')";
                    SqlCommand command1 = new SqlCommand(sql, connection1);
                    int result = command1.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("User Added");
                        connection1.Close();
                        LoginFrom login = new LoginFrom();
                        this.Hide();
                        login.Show();
                        connection1.Close();
                    }
                    else

                    {
                        MessageBox.Show("User Not Added");
                        connection1.Close();
                    }

                }

            }
            connection.Close();


            /*
             
             */

        }


















            

                
        


        private void EmailregistertextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex rEmail = new Regex(@"[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]");
            if (!rEmail.IsMatch(EmailregistertextBox.Text))
            {
                MessageBox.Show("invalid email address", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailregistertextBox.SelectAll();
                //e.Cancel = true;
            }
        }

        private void UsernameregistertextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex rUsername = new Regex("[a-z]{4,15}");
            if (!rUsername.IsMatch(UsernameregistertextBox.Text))
            {
                MessageBox.Show("invalid User Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameregistertextBox.SelectAll();
                //e.Cancel = true;


            }
        }

        /*private void PasswordregistertextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex rPassword = new Regex(@"[a-zA-Z]{4,15}$");
            if (!rPassword.IsMatch(PasswordregistertextBox.Text))
            {
                MessageBox.Show("invalid User Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordregistertextBox.SelectAll();
                //e.Cancel = true;


            }

        }*/

        private void AgreeregistercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AgreeregistercheckBox.Checked)
            {
                Registerformbutton.Enabled = true;
            }
            else Registerformbutton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginFrom loginform = new LoginFrom();
            this.Hide();

            DialogResult d;

            d = MessageBox.Show("Do you want to Login?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                loginform.Show();
            }
            else if (d == DialogResult.No)
            {
                this.Show();
            }
            else
                Close();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
