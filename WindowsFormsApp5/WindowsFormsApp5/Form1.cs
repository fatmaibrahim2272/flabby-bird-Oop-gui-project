using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int gravity = 20;
        int speed = 15;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += gravity;
            pictureBox3.Left -= speed;
            pictureBox2.Left -= speed;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter) { timer1.Start(); }
            if (e.KeyCode==Keys.Space) { gravity = -15; } 
            if (pictureBox1.Top < 2) { pictureBox1.Top = 15; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { gravity = 15; }


        }
    }
}
