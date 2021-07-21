using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Baku : Form
    {
        Timer Timer = new Timer();
        public Baku()
        {
            InitializeComponent();
            Timer.Tick += label1_Click;

            Timer.Interval = 1000;

            Timer.Start();
        }

        private void TextBaku_Click(object sender, EventArgs e)
        {
            //TextBaku.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
