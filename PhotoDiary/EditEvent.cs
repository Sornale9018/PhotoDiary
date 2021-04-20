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
using System.IO;

namespace PhotoDiary
{
    public partial class EditEvent : Form
    {
        public EditEvent()
        {
            InitializeComponent();
        }

        private void EditEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void EditEvent_Load(object sender, EventArgs e)
        {
            /*SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDiary"].ConnectionString);
            connection.Open();
            string sql = "SELECT *FROM Diary WHERE userName='" + LoginFrom.UserName + "'";
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
                
                MessageBox.Show("No Event Exist");
            }
            connection.Close();*/
        }

        private void svaebutton_Click(object sender, EventArgs e)
        {
            File.Copy(UploadimageedittextBox.Text, Path.Combine(@"F:\AIUB\7th SEMESTER\OOP2\GitHub Project\PhotoDiary\PhotoDiary\Images\", Path.GetFileName(UploadimageedittextBox.Text)), true);
            //label1.Text = "Image added Successfully!";
            CreateEvent.ImagePath = Path.Combine(@"F:\AIUB\7th SEMESTER\OOP2\GitHub Project\PhotoDiary\PhotoDiary\Images\", Path.GetFileName(UploadimageedittextBox.Text));


            if (EventeditnametextBox.Text == "")
            { MessageBox.Show("Event Name can not be empty"); }

            else if (StoryedittextBox.Text == "")
            { MessageBox.Show("Story can not be empty"); }

            else if (LesseditradioButton.Text == "" && ModerateeditradioButton.Text == "" && HigheditradioButton.Text == "")
            { MessageBox.Show("Importance can not be empty"); }

            else if (UploadimageedittextBox.Text == "")
            { MessageBox.Show("Image can not be empty"); }

            else
            {

                //Database Logic
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDiary"].ConnectionString);

                connection.Open();

                string Importance = "";

                if (LesseditradioButton.Checked)
                { Importance = "Less"; }
                else if (ModerateeditradioButton.Checked) { Importance = "Moderate"; }
                else
                {
                    Importance = "High";
                }


                string sql = "UPDATE Diary SET eventName='" + EventeditnametextBox.Text + "',story='" + StoryedittextBox.Text + "',modifyDate='" + ModifydateTimePicker.Text + "'," +
                "importance='" + Importance + "',filename='" + CreateEvent.ImagePath + "' Where userName='" + LoginFrom.UserName + "'";


                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();






                if (result > 0)
                {
                    MessageBox.Show("User Updated");
                    connection.Close();
                    Dashboard dashBoard = new Dashboard();
                    this.Hide();
                    dashBoard.Show();
                }
                else

                {
                    MessageBox.Show("User do not Updated");
                    connection.Close();
                }
            }
        }

        private void Uploadimagebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.jpg;*.gif;*bmp;)|*.jpeg;*.jpg;*.gif;*bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                UploadimageedittextBox.Text = open.FileName;
                pictureeditBox.Image = new Bitmap(open.FileName);
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDiary"].ConnectionString);
            connection.Open();
            string sql = "SELECT *FROM Diary WHERE userName='" + LoginFrom.UserName + "' and eventName='"+EventeditnametextBox.Text+"'";
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

                MessageBox.Show("No Event Exist");
            }
            connection.Close();
        }

        private void Backeditbutton_Click(object sender, EventArgs e)
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
    }
}
