using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Clock : Form
    {

        Timer T = new Timer();
        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            T.Interval = 1000;
            T.Tick += new EventHandler(this.T_Tick);
            T.Start();
        }

        private void T_Tick(object sender, EventArgs e) 
        {

            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else { time += hh; }
            time += ":";


            if (mm < 10)
            {
                time += "0" + mm;
            }
            else { time += mm; }
            time += ":";



            if (ss < 10)
            {
                time += "0" + ss;
            }
            else { time += ss; }

            label1.Text = time;

        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

    }
}
