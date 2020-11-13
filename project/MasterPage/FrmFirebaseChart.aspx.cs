using FirebaseSharp.Portable;
using FirebaseSharp.Portable.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.MasterPage
{
    public partial class FrmFirebaseChart : System.Web.UI.Page
    {
        public List<string> x = new List<string>();
        public List<int> y = new List<int>();
        public List<int> y2 = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // 첫번째 호출에만 선언
            {
                FirebaseApp app = new FirebaseApp(new Uri("https://pipi-39a83.firebaseio.com/") /*, <auth token> */);
                var scoresRef = app.Child("LogList");
                scoresRef.OrderByKey().On("value", (snapshot, child, context) =>
                {
                    x.Clear();
                    y.Clear();
                    y2.Clear();
                    foreach (var date in snapshot.Children)
                    {
                        Debug.WriteLine("key is {0} ", date.Key);
                        foreach (var time in date.Children)
                        {
                            Debug.WriteLine("key is {0} ", time.Key);
                            //시간 값을 저장해야함. 이건 x값임.
                            var Xtime = time.Key;
                            x.Add(Xtime);
                            foreach (var item in time.Children)
                            {
                                Debug.WriteLine(item.Value(), "아이템의 값");
                                if (item.Key == "Humidity")
                                {
                                    var humid = item.Value();
                                    y2.Add(Int32.Parse(humid));
                                }
                                else if (item.Key == "Light status")
                                {
                                    var light = item.Value();
                                }
                                else if (item.Key == "Temp")
                                {
                                    var temp = item.Value();
                                    y.Add(Int32.Parse(temp));
                                }
                            }
                        }

                    }
                    Global.ChartX = x;
                    Global.ChartY = y;
                    Global.ChartY2 = y2;
                });
            }
            else
            {
                if (Global.ChartX == null || Global.ChartY == null || Global.ChartY2 == null)
                {
                    Debug.WriteLine("global 변수가 비어있음");
                    return;
                }
                Chart1.Series[0].Points.DataBindXY(Global.ChartX, Global.ChartY);
                Chart1.Series[1].Points.DataBindXY(Global.ChartX, Global.ChartY2);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Global.ChartX == null || Global.ChartY == null || Global.ChartY2 == null)
            {
                Debug.WriteLine("global 변수가 비어있음");
                return;
            }

            int sumTemp = 0 ;
            int biggestTemp = 0;
            int sumHumid = 0;
            int biggestHumid = 0;

            for (int i = 0; i < Global.ChartY.Count; i++)
            {
                sumTemp += Global.ChartY[i];
                if (biggestTemp < Global.ChartY[i])
                    biggestTemp = Global.ChartY[i];
            }
            for (int i = 0; i < Global.ChartY2.Count; i++)
            {
                sumHumid += Global.ChartY2[i];
                if (biggestHumid< Global.ChartY2[i])
                    biggestHumid = Global.ChartY2[i];
            }
            lblTemp.Text = (sumTemp/Global.ChartY.Count).ToString();
            lblHumid.Text = (sumHumid/Global.ChartY2.Count).ToString();
            lblBigTemp.Text = biggestTemp.ToString();
            lblBigHumid.Text = biggestHumid.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("SiteAS.aspx", false);
        }
    }
}