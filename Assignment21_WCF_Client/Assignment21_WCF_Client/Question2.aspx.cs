using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Assignment21_WCF_Client
{
    public partial class Question2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            Q2CalcService.Q2_CalcClient client = new Q2CalcService.Q2_CalcClient();
            lblAddVal.Text =  client.Add2Num(Convert.ToInt32(TbxNum1.Text), Convert.ToInt32(TbxNum2.Text)).ToString();
        }

        protected void SubBtn_Click(object sender, EventArgs e)
        {
            Q2CalcService.Q2_CalcClient client = new Q2CalcService.Q2_CalcClient();
            lblSubVal.Text = client.Sub2Num(Convert.ToInt32(TbxNum1.Text), Convert.ToInt32(TbxNum2.Text)).ToString();
        }
    }
}