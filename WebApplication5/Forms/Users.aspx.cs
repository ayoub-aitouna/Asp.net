using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication5.user__models;

namespace WebApplication5.Forms
{
    public partial class Users : System.Web.UI.Page
    {

        private static String connetionString = @"Data Source=DESKTOP-RK64H1O\MSSQLSERVER01;Initial Catalog=users;Trusted_Connection=True;";
        List<User> users = new List<User>();
        SqlDataReader datareader;
        SqlConnection macn = new SqlConnection(connetionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null || Session["UserName"] == "")
            {
                Response.Redirect("Authentication_Session.aspx");
            }
            SqlCommand req = new SqlCommand();

            macn.Open();

            req.Connection = macn;
            req.CommandType = CommandType.Text; // Changer le type de la requete en text (non pas procedure)
            req.CommandText = "select * from _User";
            req.Parameters.Clear();
            datareader = req.ExecuteReader();
            while (datareader.Read())
            {
                User user = new User();
                user.Email = (string)datareader.GetValue(1);
                user.Password = (string)datareader.GetValue(2);
                users.Add(user);
                
            }
          
            GridView1.DataSource = users;
            GridView1.DataBind();





        }
    }
}