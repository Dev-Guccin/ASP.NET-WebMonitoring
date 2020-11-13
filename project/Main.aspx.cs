using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Configuration;
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
            //일치하는 아이디와 salt와 passwd를 들고옴.
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string selectSql = "select * from tblUser where id='"+txtID.Text+"'";
            SqlCommand cmd = new SqlCommand(selectSql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            string salt="";
            string passwd="";
            while (rd.Read())
            {
                salt = rd["salt"].ToString();
                passwd = rd["passwd"].ToString().Trim();
            }
            conn.Close();

            SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(salt+txtPW.Text));
            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hash)
            {

                stringBuilder.AppendFormat("{0:x2}", b);

            }
            string makedpasswd = stringBuilder.ToString();


            if(passwd.Trim() == makedpasswd.Trim())
            {
                Response.Cookies["cookies"].Value = txtID.Text;
                Response.Cookies["cookies"].Expires = DateTime.Now.AddMinutes(30);// 30분 쿠키만료
                Response.Redirect("MasterPage/FrmFirebaseChart.aspx", true);
            }
            else
            {
                lblDisp.Text = "Something Wrong";
            }
        }
    }
}