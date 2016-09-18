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

public partial class Officer_VoterInfo : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=ABC-PC;Initial Catalog=online;user id=sa;password=123");
        con.Open();
        da = new SqlDataAdapter("select * from voterRegistration ", con);
        ds = new DataSet();
        da.Fill(ds, "voterRegistration");
        GridView1.DataSource = ds.Tables["voterRegistration"].DefaultView;
        GridView1.DataBind();
        con.Close();

    }
}
