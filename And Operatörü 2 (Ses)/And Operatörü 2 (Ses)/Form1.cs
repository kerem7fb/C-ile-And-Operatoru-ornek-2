using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace And_Operatörü_2__Ses_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;
            label3.Text = ses.ToString();
            if (ses == 0) 
            {
                label1.Text = ("Ses Yok");
                label1.ForeColor = Color.Black;
            }
            else if (ses > 0 && ses <= 10) 
            {
                label1.Text = ("Normal Ses Seviyesi");
                label1.ForeColor = Color.Green;
            }
            else if (ses > 10 && ses < 15) 
            {
                label1.Text = ("Yüksek Ses Seviyesi");
                label1.ForeColor = Color.Pink;
            }
            else if (ses == 15) 
            {
                label1.Text = ("Yüksek Ses Seviyesi");
                label1.ForeColor = Color.Purple;
            }
        }
    }
}
