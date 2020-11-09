using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class FrmPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Account account = new Account();

            string trialUsername = null;
            string trialPassword = null;
            HttpCookie objectUsername = null;
            HttpCookie objectPassword = null;

            account.set_auth(false);

            if (Request.Form["trialUsername"] != null)
            {
                trialUsername = Request.Form["trialUsername"];
                if (Request.Form["trialPassword"] != null)
                {
                    trialPassword = Request.Form["trialPassword"];
                    account.set_auth(account.authorizeMembership(trialUsername, trialPassword));
                }

            }
            if (account.get_auth())
            {
                objectUsername = new HttpCookie("membershipUsername");
                objectUsername.Value = trialUsername;
                objectUsername.Expires = DateTime.Now.AddHours(12.0);

                objectPassword = new HttpCookie("membershipUserPassword");
                objectPassword.Value = trialPassword;
                objectPassword.Expires = DateTime.Now.AddHours(12.0);

                Response.Cookies.Add(objectUsername);
                Response.Cookies.Add(objectPassword);
            }
        }
    }
    class Account
    {
        private const string login_id = "admin";
        private const string login_pw = "admin";
        protected bool authorStatus = false;

        public void set_auth(bool b)
        {
            authorStatus = b;
        }
        public bool get_auth()
        {
            return authorStatus;
        }
        public bool authorizeMembership(string trialUsername, string trialPassword)
        {
            if (string.Equals(login_id, trialUsername))
            {
                if (string.Equals(login_pw, trialPassword))
                {
                    //로그인 성공
                    return true;
                }
            }
            return false;
        }
    }
}