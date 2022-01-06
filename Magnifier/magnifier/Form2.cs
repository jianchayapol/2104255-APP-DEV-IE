using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magnifier
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void showZoom(Bitmap picture)
        {
            Bitmap x = new Bitmap(picture, pictureBox2.Size);
            pictureBox2.Image = x;
        }
    }
}
