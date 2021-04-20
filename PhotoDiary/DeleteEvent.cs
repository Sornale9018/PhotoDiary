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
    public partial class DeleteEvent : Form
    {
        public DeleteEvent()
        {
            InitializeComponent();
        }

        private void DeleteEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDiary"].ConnectionString);
            connection.Open();
            string sql = "SELECT *FROM Diary WHERE userName='" + LoginFrom.UserName + "' and eventName='" + EventeditnametextBox.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {


                EventeditnametextBox.Text = Convert.ToString(reader["eventName"]);
                StoryedittextBox.Text = Convert.ToString(reader["story"]);
                UploadimageedittextBox.Text = Convert.ToString(reader["filename"]);



                string Importance = reader["importance"].ToString();
                if (Importance == "Less")
                {
                    LesseditradioButton.Checked = true;
                }
                else if (Importance == "Moderate")
                {
                    ModerateeditradioButton.Checked = true;

                }
                else
                    HigheditradioButton.Checked = true;

                pictureeditBox.Image = new Bitmap(UploadimageedittextBox.Text);

            }

            else
            {
                EventeditnametextBox.Text = StoryedittextBox.Text = UploadimageedittextBox.Text = pictureeditBox.Text = "";
                HigheditradioButton.Checked = LesseditradioButton.Checked = ModerateeditradioButton.Checked = false;

                MessageBox.Show("No Event Exist");
            }
            connection.Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {




            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDiary"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM Diary WHERE userName='" + LoginFrom.UserName + "' and eventName='" + EventeditnametextBox.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {


                EventeditnametextBox.Text = Convert.ToString(reader["eventName"]);
                StoryedittextBox.Text = Convert.ToString(reader["story"]);
                UploadimageedittextBox.Text = Convert.ToString(reader["filename"]);



                string Importance = reader["importance"].ToString();
                if (Importance == "Less")
                {
                    LesseditradioButton.Checked = true;
                }
                else if (Importance == "Moderate")
                {
                    ModerateeditradioButton.Checked = true;
                }
                else
                    HigheditradioButton.Checked = true;

                pictureeditBox.Image = new Bitmap(UploadimageedittextBox.Text);

            }

            else
            {
                EventeditnametextBox.Text = StoryedittextBox.Text = UploadimageedittextBox.Text = pictureeditBox.Text = "";
                HigheditradioButton.Checked = LesseditradioButton.Checked = ModerateeditradioButton.Checked = false;

                MessageBox.Show("Event Deleted!!");
            }
            connection.Close();






        }

        private void Backdeletebutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();



            DialogResult d;

            d = MessageBox.Show("Do you want to Go Back?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                dashboard.Show();
            }
            else if (d == DialogResult.No)
            {
                this.Show();
            }
            else
                Close();
        }

        private void DeleteEvent_Load(object sender, EventArgs e)
        {
            ModifydatedateTimePicker.Text = DateTime.Now.ToLongDateString();
        }
    }
}
