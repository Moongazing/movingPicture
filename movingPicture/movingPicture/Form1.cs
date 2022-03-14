using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movingPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x, y;
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Left) { x = x - 10; }
            else if (e.KeyCode == Keys.Right) { x = x + 10; }
            else if (e.KeyCode == Keys.Up) { y = y - 10; }
            else if (e.KeyCode == Keys.Down) { y = y + 10; }
            pictureBox1.Location = new Point(x, y);
        }
    }
}
