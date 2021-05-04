using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5.Forms
{
    public partial class Authentication : System.Web.UI.Page
    {
        String name;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            HttpCookie userInfo = new HttpCookie("userInfo");
            userInfo["name"] = TextBox1.Text;

            userInfo.Expires.Add(new TimeSpan(0, 1, 0));
            Response.Cookies.Add(userInfo);

        }

        protected void click(object sender, EventArgs e)
        {
            string name = string.Empty;

            HttpCookie reqCookies = Request.Cookies["userInfo"];
            if (reqCookies != null)
            {
                Label2.Text = reqCookies["name"].ToString();

            }
            else
            {
                Label2.Text = "aaa";
            }
           
        }

        protected void lien(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:57705/Forms/Dashboard");
        }
    }
}