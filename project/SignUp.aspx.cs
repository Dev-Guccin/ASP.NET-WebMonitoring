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
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string insertSql = "insert into tblUser(id, salt, passwd, name, deviceid) values(@id,  @salt, @passwd, @name, @deviceid)";

            SqlCommand cmd = new SqlCommand(insertSql, conn);
            
            //salt를 이용하여 비밀번호 해쉬화함.
            int salt = new Random().Next(1, 100);
            SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(salt.ToString()+pw1.Text));
            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hash)
            {

                stringBuilder.AppendFormat("{0:x2}", b);

            }
            var passwd = stringBuilder.ToString();
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@salt", salt);
            cmd.Parameters.AddWithValue("@passwd", passwd);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@deviceid", deviceid.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx", true);
        }
    }
}