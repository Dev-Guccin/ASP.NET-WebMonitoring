using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.MasterPage
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username;
            try
            {
                username = Server.HtmlEncode(Request.Cookies["cookies"].Value);
            }
            catch (Exception)//쿠키가 없는경우임.
            {
                username = "";
            }
            if(username != "")
            {
                lblUsername.Text = username;
                lblDisp.Text = System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            }
            else
            {
                lblUsername.Text = "비회원";
                lblUsername.CssClass = "btn btn-outline-warning";
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Page.Header.DataBind();
        }
    }
}