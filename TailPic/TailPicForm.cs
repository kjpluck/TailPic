using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TailPic
{
    public partial class TailPicForm : Form
    {

        public TailPicForm()
        {
            InitializeComponent();
        }

        private void TailPicForm_Shown(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                tailPictureBox1.Watch(file.FileName);
            }
        }
    }
}
