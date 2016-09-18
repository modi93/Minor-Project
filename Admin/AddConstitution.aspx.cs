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
public partial class Admin_AddConstitution : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=ABC-PC;Initial Catalog=online;user id=sa;password=123");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    SqlDataReader dr;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("select Did from District", con);
        dr = cmd.ExecuteReader();
        DropDownList1.DataSource = dr;
        DropDownList1.DataTextField = "Did";
        DropDownList1.DataBind();
        dr.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("insert Constitution values('" +DropDownList1.SelectedItem.ToString()+ "','" + TextBox1.Text + "')", con);
        da.SelectCommand.ExecuteNonQuery();
        Label2.Visible = true;
        Label2.Text = "Successfully Added";
    }
}
