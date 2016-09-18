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

public partial class AdminLogin2 : System.Web.UI.Page
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

            else
            {
                Label9.Text = "Invalid userid and password.Its Deactivated by Admin.Try Agian!.";
                TextBox5.Text = "";
            }
        }
    }

protected void  Button4_Click(object sender, EventArgs e)
{
    TextBox4.Text = TextBox5.Text = "";
}
protected void LinkButton1_Click(object sender, EventArgs e)
{
    Response.Redirect("Home.aspx");
}
}