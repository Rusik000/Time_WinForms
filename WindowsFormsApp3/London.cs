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
    public partial class London : Form
    {
        Timer Timer = new Timer();
        public London()
        {
            InitializeComponent();
            Timer.Tick += LondonTm_Click;
            Timer.Interval = 1000;
            Timer.Start();
        }

        private void LondonTm_Click(object sender, EventArgs e)
        {
            LondonTm.Text = DateTime.Now.AddHours(-3).ToLongTimeString();
        }
    }
}
