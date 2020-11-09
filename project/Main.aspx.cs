using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class Main : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Page.Header.DataBind();
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx",true);
            //Response.Redirect(string.Format("test.aspx?testValue=" + gridView1.SelectedValue));
        }
        protected void LogIn_Click(object sender, EventArgs e)
        {
            //아이디와 패스워드를 검증함.
            if(txtID.Text == "admin" && txtPW.Text == "admin")
            {
                Response.Redirect("MasterPage/FrmFirebaseChart.aspx", true);
            }
            else
            {
                lblDisp.Text = "Something Wrong";
            }
        }
    }
}