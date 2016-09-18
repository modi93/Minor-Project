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

public partial class Officer_Result : System.Web.UI.Page
{
    SqlDataAdapter da = new SqlDataAdapter();
    SqlConnection con = new SqlConnection("Data Source=ABC-PC;Initial Catalog=online;user id=sa;password=123");
    protected void Page_Load(object sender, EventArgs e)
    {
       
        DataSet ds = new DataSet();
        
        con.Open();
        da = new SqlDataAdapter("select * from AdminCredential ", con);
        ds = new DataSet();
        da.Fill(ds, "AdminCredential");
        GridView1.DataSource = ds.Tables["AdminCredential"].DefaultView;
        GridView1.DataBind();
      

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("insert Officerreports values('" + TextBox1.Text + "','" + TextBox2.Text + "')", con);
        da.SelectCommand.ExecuteNonQuery();
        Label3.Visible = true;
        Label2.Text = "Successfully Added";
    }
}
