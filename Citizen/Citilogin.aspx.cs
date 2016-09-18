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
public partial class Citizen_offlogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=ABC-PC;Initial Catalog=online;user id=sa;password=123");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string s = TextBox4.Text;
        string s1 = TextBox5.Text;
        if (TextBox4.Text != "" && TextBox5.Text != "")
        {

            da = new SqlDataAdapter("select * from voterRegistration", con);
            da.Fill(dt);
            for (int i = 0; i <= dt.Rows.Count; i++)
            {
                if (s == dt.Rows[i][15].ToString() && s1 == dt.Rows[i][16].ToString())
                {
                    Session["VoterId"] = dt.Rows[i][1];
                    Response.Redirect("~/Citizen/Vote.aspx");
                }
                else
                {
                    Label1.Text = "Invalid userid and password.";
                }

            }

            //da = new SqlDataAdapter("select count(*) from voterRegistration where Uname='" + TextBox4.Text + "' and Password='" + TextBox5.Text + "' and Status='Activate' ", con);
            //int n = Convert.ToInt32(da.SelectCommand.ExecuteScalar());
            //if (n == 1)
            //{
            //    da = new SqlDataAdapter("select VoterId,Utype from voterRegistration where Uname='" + TextBox4.Text + "' and Password='" + TextBox5.Text + "' ", con);
            //    ds = new DataSet();
            //    da.Fill(ds, "voterRegistration");
            //    if (ds.Tables["voterRegistration"].Rows[0][1].ToString() == "Voter")
            //    {
            //        Session.Add("VoterId", ds.Tables["voterRegistration"].Rows[0][0].ToString());
            //        Response.Redirect("~/Citizen/Vote.aspx");
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
        }
        else
        {
            Label1.Text = "Invalid userid and password.Its Deactivated by Admin.Try Agian!.";
            TextBox5.Text = "";
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox4.Text = TextBox5.Text = "";
    }
}
