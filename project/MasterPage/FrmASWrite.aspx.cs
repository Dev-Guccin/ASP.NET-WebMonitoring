using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.MasterPage
{
    public partial class FrmASWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string insertSql = "insert into tblBrd(name, pass, email, title, contents, writedate, readcnt) values(@name,  @pass, @email, @title, @contents, @writedate, @readcnt)";

            SqlCommand cmd = new SqlCommand(insertSql, conn);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@title", txttitle.Text);
            cmd.Parameters.AddWithValue("@contents", txtcontents.Text);
            cmd.Parameters.AddWithValue("@writedate", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@readcnt", "0");

            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("SiteAS.aspx");
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("SiteAS.aspx", true);
        }
    }
}