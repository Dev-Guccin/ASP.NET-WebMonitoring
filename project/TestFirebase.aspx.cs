using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using FirebaseSharp.Portable;
using System.Diagnostics;
using System.Configuration;

namespace project
{
    public partial class TestFirebase : System.Web.UI.Page
    {
        public List<string> x = new List<string>();
        public List<int> y = new List<int>(); 
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // 첫번째 호출에만 선언
            {
                FirebaseApp app = new FirebaseApp(new Uri("https://pipi-39a83.firebaseio.com/") /*, <auth token> */);
                var scoresRef = app.Child("LogList");
                scoresRef.OrderByKey().Once("value", (snapshot, child, context) =>
                {
                    x.Clear();
                    y.Clear();
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
                                }
                                else if (item.Key == "Light status")
                                {
                                    var light = item.Value();
                                }
                                else if (item.Key == "Temp")
                                {
                                    var temp = item.Value();
                                    y.Add(Int32.Parse(temp));
                                    Label1.Text = temp;
                                }
                            }
                        }
                        
                    }
                    Global.ChartX = x;
                    Global.ChartY = y;
                });
            }
            else
            {
                if(Global.ChartX == null || Global.ChartY == null)
                {
                    Debug.WriteLine("global 변수가 비어있음");
                    return;
                }
                Chart1.Series[0].Points.DataBindXY(Global.ChartX, Global.ChartY);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}