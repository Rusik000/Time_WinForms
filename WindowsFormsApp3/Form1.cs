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
    public partial class Form1 : Form
    {
        Timer Timer = new Timer();
        public Form1()
        {
            InitializeComponent();        

        }

        private void Baku_Click(object sender, EventArgs e)
        {
           
        }

        private void Mouse_Click(object sender, MouseEventArgs e)
        {
           
        }




        private void Mouse_click(object sender, MouseEventArgs e)
        {
            Baku baku = new Baku();
            baku.Show();
        }

        private void England_Click(object sender, EventArgs e)
        {
            London london = new London();
            london.Show();
        }
    }
}
