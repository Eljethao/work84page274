using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace work84page274
{
    public partial class Form1 : Form
    {
        SoundPlayer p1 = new SoundPlayer("without.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1.Stop();
        }
    }
}
