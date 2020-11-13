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
    public partial class FrmASModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                conn.Open();

                string selectSql = "select * from tblBrd where num =" + Request["No"];
                SqlCommand cmd = new SqlCommand(selectSql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblname.Text = dr["name"].ToString();
                    txttitle.Text = dr["title"].ToString();
                    txtcontents.Text = dr["contents"].ToString();
                }
                dr.Close();
                conn.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string insertSql = "update tblBrd set title=@title, contents=@contents where num="+Request["No"];
            SqlCommand cmd = new SqlCommand(insertSql, conn);
            cmd.Parameters.AddWithValue("@title", txttitle.Text);
            cmd.Parameters.AddWithValue("@contents", txtcontents.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("SiteAS.aspx", true);
        }

        protected void btnCncel_Click(object sender, EventArgs e)
        {
            Response.Redirect("SiteAS.aspx", true);
        }
    }
}