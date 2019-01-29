using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Assignment21_WCF_Client
{
    public partial class Question1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                drpRoles.DataSource = Enum.GetNames(typeof(Q1T2Service.RoleType));
                drpRoles.DataBind();
            }
        }

        protected void SayHelloTCPButton_Click(object sender, EventArgs e)
        {
            Q1T1_Tcp.Q1Task1Client client = new Q1T1_Tcp.Q1Task1Client("NetTcpBinding_IQ1Task11");
            lblTcpMsg.Text = client.SayHello(TbxName.Text);
        }

        protected void SayHelloHttpButton_Click(object sender, EventArgs e)
        {
            Q1T1_Http.Q1Task1Client client = new Q1T1_Http.Q1Task1Client("BasicHttpBinding_IQ1Task1");
            lblHttpMsg.Text = client.SayHello(TbxName.Text);
        }

        protected void AllOpnBtn_Click(object sender, EventArgs e)
        {
            Q1T2Service.Q1T2Client client = new Q1T2Service.Q1T2Client();
            GridView1.DataSource =  client.OpeningsJobs();
            GridView1.DataBind();            
        }

        protected void OpnByRolesBtn_Click(object sender, EventArgs e)
        {
            Q1T2Service.Q1T2Client client = new Q1T2Service.Q1T2Client();
            GridView1.DataSource = client.OpeningJobsByRole((Q1T2Service.RoleType) Enum.Parse(typeof(Q1T2Service.RoleType),drpRoles.SelectedValue));
            GridView1.DataBind();
        }
    }
}