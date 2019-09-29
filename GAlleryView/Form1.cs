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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select multiple images";
            ofd.Multiselect = true;
            ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr==System.Windows.Forms.DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                int x = 20;
                int y = 20;
                int maxHeigth = -1;
                foreach (string img in files)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(img);
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    x += pic.Width + 10;
                    maxHeigth = Math.Max(pic.Height, maxHeigth);
                    if (x > this.ClientSize.Width -100)
                    {
                        x = 20;
                        y += maxHeigth + 10;

                    }
                    this.panelImages.Controls.Add(pic);

                }
            }
        }
    }
}
