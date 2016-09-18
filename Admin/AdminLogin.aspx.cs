using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Admin_AdminLogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=ABC-PC;Initial Catalog=online;user id=sa;password=123");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (TextBox4.Text != "" && TextBox5.Text != "")
        {
            if (TextBox4.Text == "Admin" && TextBox5.Text == "Admin")
            {
                Response.Redirect("~/Admin/Create User.aspx");
            }
            //da = new SqlDataAdapter("select count(*) from voterRegistration where Uname='" + TextBox4.Text + "' and Password='" + TextBox5.Text + "' and Status='Activate' ", con);
            //int n = Convert.ToInt32(da.SelectCommand.ExecuteScalar());
            //if (n == 1)
            //{
            //    da = new SqlDataAdapter("select VoterId,Utype from voterRegistration where Uname='" + TextBox4.Text + "' and Password='" + TextBox5.Text + "' ", con);
            //    ds = new DataSet();
            //    da.Fill(ds, "voterRegistration");
            //    if (ds.Tables["voterRegistration"].Rows[0][1].ToString() == "Admin")
            //    {
            //        Session.Add("VoterId", ds.Tables["voterRegistration"].Rows[0][0].ToString());
            //        Response.Redirect("~/Officer/AdminDetail's.aspx");
            //    }
            //    else
            //    {
            //        Label1.Text = "Invalid userid and password.";
            //    }
            //    //else if (ds.Tables["voterRegistration"].Rows[0][1].ToString() == "Collector")
            //    //{
            //    //    Session.Add("uid", ds.Tables["voterRegistration"].Rows[0][0].ToString());
            //    //    Response.Redirect("~/user/userprofile.aspx");
            //    //}
            //}
            else
            {
                Label1.Text = "Invalid userid and password.Its Deactivated by Admin.Try Agian!.";
                TextBox5.Text = "";
            }
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox4.Text = TextBox5.Text = "";
    }
}
