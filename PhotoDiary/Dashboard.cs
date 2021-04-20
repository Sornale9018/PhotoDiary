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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label2.Text = LoginFrom.Uname;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDiary"].ConnectionString);
            connection.Open();
            string sql = "SELECT *FROM Diary WHERE userName= '" + LoginFrom.UserName + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Users> users = new List<Users>();
            while (reader.Read())
            {
                Users user = new Users();
                user.Id = (int)reader["id"];
                user.EventName = Convert.ToString(reader["eventName"]);
                user.Story = Convert.ToString(reader["story"]);
                user.CreateDate = Convert.ToString(reader["createDate"]);
                user.ModifyDate = Convert.ToString(reader["modifyDate"]);
                user.Importance = reader["importance"].ToString();
                user.Path = Convert.ToString(reader["filename"]);
                users.Add(user);
            }
            EventlistdataGridView.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateEvent createevent = new CreateEvent();
            this.Hide();
            createevent.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            this.Hide();
            
            LoginFrom loginform = new LoginFrom();
            this.Hide();

            DialogResult d;

            d = MessageBox.Show("Do you want to Logout?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

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

        private void button2_Click(object sender, EventArgs e)
        {
            EditEvent editEvent = new EditEvent();
            this.Hide();
            editEvent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEvent = new DeleteEvent();
            this.Hide();
            deleteEvent.Show();
        }
    }
}
