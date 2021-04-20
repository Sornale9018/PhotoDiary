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
    public partial class ShowEvent : Form
    {
        public ShowEvent()
        {
            InitializeComponent();
        }

        private void ShowEvent_Load(object sender, EventArgs e)
        {
            
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
            ShoweventdataGridView.DataSource = users;
        }

        private void button_Click(object sender, EventArgs e)
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

        private void ShowEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShoweventdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EventnametextBox.Text = ShoweventdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            pictureBox.Image = new Bitmap(ShoweventdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());

            UploadimagetextBox.Text = ShoweventdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            StorytextBox.Text = ShoweventdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            CreatetextBox.Text = ShoweventdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            ModifytextBox.Text = ShoweventdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox.Text = ShoweventdataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
