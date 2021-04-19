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

        public static string UserName;
        public static string Uname
        {
            set { UserName = value; }
            get { return UserName; }
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
                Uname = UsernamelogintextBox.Text;
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

           



             
        }
    }
}
