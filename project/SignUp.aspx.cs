using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Page.Header.DataBind();
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Type cstype = this.GetType();
            ClientScriptManager cs = Page.ClientScript;

            //여기서 id검증, pw검증
            if (pw1.Text.Count() < 5)
            {
                String cstext = "alert('password is too short');";
                cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);
                
            }
            else //패스워드 길이가 적절한경우
            {
                if (pw1.Text != pw2.Text)
                {
                    String cstext = "alert('confirm password is not same');";
                    cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);
                }
            }
        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx", true);
        }
    }
}