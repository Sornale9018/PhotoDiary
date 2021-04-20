using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace PhotoDiary
{
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void CreateEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Eventnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void Uploadimagebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.jpg;*.gif;*bmp;)|*.jpeg;*.jpg;*.gif;*bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                UploadimagetextBox.Text = open.FileName;
                pictureBox.Image = new Bitmap(open.FileName);
            }
        }

        public static string imagepath;
        public static string ImagePath
        {
            set { imagepath = value; }
            get { return imagepath; }
        }
      

        private void svaebutton_Click(object sender, EventArgs e)
        {

            File.Copy(UploadimagetextBox.Text, Path.Combine(@"F:\AIUB\7th SEMESTER\OOP2\GitHub Project\PhotoDiary\PhotoDiary\Images\", Path.GetFileName(UploadimagetextBox.Text)), true);
            //label1.Text = "Image added Successfully!";
            ImagePath = Path.Combine(@"F:\AIUB\7th SEMESTER\OOP2\GitHub Project\PhotoDiary\PhotoDiary\Images\", Path.GetFileName(UploadimagetextBox.Text));

            if (EventnametextBox.Text == "")
            {
                MessageBox.Show("Event Name can not be empty");
            }

            else if (LessradioButton.Checked == false && ModerateradioButton.Checked == false && HighradioButton.Checked == false)
            {
                MessageBox.Show("Please Select Importance");
            }

            else
            {



                SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDiary"].ConnectionString);
                connect.Open();
                string Importance = "";
                if (HighradioButton.Checked)
                {
                    Importance = "High";
                }
                else if (ModerateradioButton.Checked)
                {
                    Importance = "Moderate";
                }



                else
                {
                    Importance = "Less Important";
                }

                //StorytextBox.SelectAll();

                string sql = "INSERT INTO Diary(eventName,story,createDate,userName,importance,fileName) VALUES('" + EventnametextBox.Text + "','" + StorytextBox.Text + "','" + dateTimePicker.Text + "','" + LoginFrom.UserName + "','" + Importance + "','"+ImagePath+"')";

                

                SqlCommand command = new SqlCommand(sql, connect);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Event Create Sucessful....");

                    EventnametextBox.Text = StorytextBox.Text = UploadimagetextBox.Text = pictureBox.Text = "";
                    HighradioButton.Checked = LessradioButton.Checked = ModerateradioButton.Checked = false;



                    connect.Close();




                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.Show();






                }
                else
                {
                    MessageBox.Show("Error");
                    connect.Close();



                }




            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {
            dateTimePicker.Text = DateTime.Now.ToLongDateString();
        }

        private void Backcreatebutton_Click(object sender, EventArgs e)
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

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

