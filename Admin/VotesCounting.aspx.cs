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

public partial class Admin_VotesCounting : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=ABC-PC;Initial Catalog=online;user id=sa;password=123");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        da = new SqlDataAdapter("select * from Partyvote", con);
        da.SelectCommand.ExecuteNonQuery();
        ds = new DataSet();
        da.Fill(ds);
        TextBox1.Text = ds.Tables[0].Rows[0][0].ToString();
        TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
        TextBox3.Text = ds.Tables[0].Rows[0][2].ToString();
        TextBox4.Text = ds.Tables[0].Rows[0][3].ToString();
        TextBox5.Text = ds.Tables[0].Rows[0][4].ToString();
        
    }
}
