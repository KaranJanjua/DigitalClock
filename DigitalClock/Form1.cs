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
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
