using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAlleryView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int imagenumber = 1;
        private void loadNextImage()
        {
            if (imagenumber == 10)
            {
                imagenumber = 1;
                SlidePic.ImageLocation = string.Format(@"Images\{0}.jpg",imagenumber);
                imagenumber++;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }
    }
}
