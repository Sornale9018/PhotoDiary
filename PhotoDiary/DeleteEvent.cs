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
    }
}
