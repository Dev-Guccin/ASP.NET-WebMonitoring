using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class FrmChart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*DataTable table = new DataTable();
            DataRow row = null;
            table.Columns.Add(new DataColumn("NAME", typeof(string)));
            table.Columns.Add(new DataColumn("AGE", typeof(int)));

            row = table.NewRow();
            row["NAME"] = "홍길동";
            row["AGE"] = 10;

            table.Rows.Add(row);

            row = table.NewRow();
            row["NAME"] = "둘리";
            row["AGE"] = 300;

            table.Rows.Add(row);

            DataSet ds = new DataSet();
            ds.Tables.Add(table);
            */
            List<string> x = new List<string> { "철수", "영희", "길동", "재동", "민희" };
            List<int> y = new List<int> { 80, 90, 85, 70, 95 };
            Chart1.Series[0].Points.DataBindXY(x, y);
        }
    }
}