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
    }
}
