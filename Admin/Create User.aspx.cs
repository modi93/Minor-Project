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

public partial class Admin_Create_User : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=ABC-PC;Initial Catalog=online;user id=sa;password=123");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {        
        con.Open();        
        Grid();

    }
    private void Grid()
    {
        //da = new SqlDataAdapter("select VoterId,VoterName,Utype,Status,Email from voterRegistration where Utype='Voter' ", con);
        da = new SqlDataAdapter("select VoterId,VoterName,Utype,Status,Email from voterRegistration ", con);
        ds = new DataSet();
        da.Fill(ds, "voterRegistration");
        GridView1.DataSource = ds.Tables["voterRegistration"].DefaultView;
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Grid();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       
            da = new SqlDataAdapter("select Status from voterRegistration where VoterId=" + Convert.ToInt32(e.CommandArgument.ToString()) + " ", con);
            ds = new DataSet();
            da.Fill(ds, "voterRegistration");
            if (ds.Tables.Count > 0 && ds.Tables["voterRegistration"].Rows.Count > 0)
            {
                if (ds.Tables["voterRegistration"].Rows[0][0].ToString() == "Activate")
                {
                    da = new SqlDataAdapter("update voterRegistration set Status='Deactivate' where VoterId=" + Convert.ToInt32(e.CommandArgument.ToString()) + " ", con);
                    int n = da.SelectCommand.ExecuteNonQuery();
                    if (n == 1)
                    {
                        Grid();
                    }
                }
                else if (ds.Tables["voterRegistration"].Rows[0][0].ToString() == "Deactivate")
                {
                    da = new SqlDataAdapter("update voterRegistration set Status='Activate' where VoterId=" + Convert.ToInt32(e.CommandArgument.ToString()) + " ", con);
                    int n = da.SelectCommand.ExecuteNonQuery();
                    if (n == 1)
                    {
                        Grid();
                    }
                }
            }

        }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

    //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}
//}