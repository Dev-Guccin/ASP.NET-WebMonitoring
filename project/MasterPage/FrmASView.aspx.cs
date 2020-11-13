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
            int cnt=0;
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
                cnt = Int32.Parse(rd["readcnt"].ToString());
            }
            conn.Close();
            conn.Open();
            // readcnt를 하나 증가해야함
            cnt++;
            string updateSql = "update tblBrd set readcnt =" + cnt + " where num=" + Request["No"];
            cmd = new SqlCommand(updateSql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("SiteAS.aspx", true);
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            //비밀번호 검사후에 페이지 넘김
            //비밀번호 가져옴.
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string selectSql = "select * from tblBrd where num =" + Request["No"];
            SqlCommand cmd = new SqlCommand(selectSql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            string strPass = "";
            dr.Read();  //  if(dr.Read()) { strPass = dr["pass"].ToString(); };
            strPass = dr["pass"].ToString();
            if (strPass.CompareTo(txtpass.Text) == 0)
            {
                Response.Redirect("FrmASModify.aspx?Action=Modify&No=" + Request["No"]);
            }
            else
                lblDisp.Text = "비밀번호가 틀렸습니다.";
            conn.Close();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            //비밀번호 검사한후 삭제
            //비밀번호 가져옴.
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string selectSql = "select * from tblBrd where num =" + Request["No"];
            SqlCommand cmd = new SqlCommand(selectSql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            string strPass = "";
            dr.Read();  //  if(dr.Read()) { strPass = dr["pass"].ToString(); };
            strPass = dr["pass"].ToString();
            conn.Close();
            if (strPass.CompareTo(txtpass.Text) == 0)
            {
                conn.Open();
                string deleteSql = "delete from tblBrd where num =" + Request["No"];
                SqlCommand delcmd = new SqlCommand(deleteSql, conn);
                delcmd.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("SiteAS.aspx");
            }
            else
                lblDisp.Text = "비밀번호가 틀렸습니다.";
            conn.Close();
        }
    }
}