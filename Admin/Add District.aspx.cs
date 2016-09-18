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

public partial class Admin_Add_District : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=ABC-PC;Initial Catalog=online;user id=sa;password=123");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand();
        cmd.CommandText = ("select max(Did)+1 from District");
        cmd.Connection = con;
        TextBox2.Text = cmd.ExecuteScalar().ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("insert District values('" + TextBox2.Text + "','" + TextBox1.Text + "')", con);
        da.SelectCommand.ExecuteNonQuery();
        Label2.Visible = true;
        Label2.Text = "Successfully Added";

    }
}
