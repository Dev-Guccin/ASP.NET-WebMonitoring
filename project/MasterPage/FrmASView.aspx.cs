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
    public partial class FrmASView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string selectSql = "select * from tblBrd where num=" + Request["No"];
            SqlCommand cmd = new SqlCommand(selectSql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblName.Text = rd["name"].ToString();
                lblDate.Text = rd["writedate"].ToString();
                lblTitle.Text = rd["title"].ToString(); 
                txtContents.Text = rd["contents"].ToString();
            }


        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("SiteAS.aspx", true);
        }
    }
}