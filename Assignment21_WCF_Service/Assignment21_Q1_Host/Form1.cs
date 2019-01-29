using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Assignment21_WCF_Service;

namespace Assignment21_Q1_Host
{
    public partial class Form1 : Form
    {
        ServiceHost host;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(host == null)
            {
                host = new ServiceHost(typeof(Q1Task1));
                host.Open();
                label1.Text = "Host Started Successfully";
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (host != null)
            {
                host.Close();
                host = null;
                label1.Text = "Host Stoped Successfully";
            }
        }

        
    }
}
