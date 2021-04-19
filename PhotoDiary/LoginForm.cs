using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDiary
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            RegisterForm registerform = new RegisterForm();
            this.Hide();
            registerform.Show();

        }

        private void LoginFrom_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDiary"].ConnectionString);
            connection.Open();

            string sql = "SELECT *FROM Users WHERE userName= '" + UsernamelogintextBox.Text + "' and password='"+PasswordlogintextBox.Text+"'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {

                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();

                

                
            }

            else
            {
                 UsernamelogintextBox.Text = PasswordlogintextBox.Text  = "";
         
                MessageBox.Show("User Doesn't Exist");
            }
            connection.Close();

            /* SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["userDBConnection"].ConnectionString);
             connection.Open();



             string sql = "SELECT *FROM registrations WHERE userName='" + usernameTextBox.Text + "'";
             SqlCommand command = new SqlCommand(sql, connection);
             SqlDataReader reader = command.ExecuteReader();



             if (reader.Read())
             {
                 string passwordtext = Convert.ToString(reader["password"]);
                 if (passwordtext == Convert.ToString(passwordTextBox.Text))
                 {
                     UserName = usernameTextBox.Text;
                     DashBoard dashboard = new DashBoard();
                     this.Hide();
                     dashboard.Show();
                 }
             }
                   else
             {
                  MessageBox.Show("Wrong Username or Password...!!");
            }

                connection.Close();

         }*/
        }
    }
}
