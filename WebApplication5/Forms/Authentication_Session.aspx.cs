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
    public partial class Authentication_Session : System.Web.UI.Page
    {
        private static String connetionString = @"Data Source=DESKTOP-RK64H1O\MSSQLSERVER01;Initial Catalog=users;Trusted_Connection=True;";
       List<User> users = new List<User>();
        SqlDataReader datareader;
        SqlConnection macn = new SqlConnection(connetionString);
        String email, password;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand req = new SqlCommand();
            email = TextBox1.Text;
            password = TextBox2.Text;
            macn.Open();

            req.Connection = macn;
            req.CommandType = CommandType.Text; // Changer le type de la requete en text (non pas procedure)
            req.CommandText = "select * from _User where Email ='" + email + "' And Pasword='" + password + "'";
            req.Parameters.Clear();
            datareader = req.ExecuteReader();
            while (datareader.Read())
            {
                Session["name"] = (string)datareader.GetValue(1);
                Session["password"] = (string)datareader.GetValue(2);
                Response.Redirect("Users.aspx");
            }


        }
    }
}