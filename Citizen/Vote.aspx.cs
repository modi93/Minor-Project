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

public partial class Citizen_Vote : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=ABC-PC;Initial Catalog=online;user id=sa;password=123");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    DataTable dt;
    SqlDataReader dr;
   public  static int c=0;
   public  static int t=0,trs=0,p=0,b=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        con.Open();
        TextBox2.Text = Session["VoterId"].ToString();
        //da = new SqlDataAdapter("select VoterId from voterRegistration", con);
        //dt = new DataTable();
        //da.Fill(dt);
        //for (int i = 0; i <= dt[0].Rows.Count(); i++)
        //{
        //    DropDownList1.Items.Add();
        //}
        
       ////// ds = new DataSet();
       ////// da.Fill(ds);
       ////// foreach (DataColumn col in ds.Tables[0].Columns[0])
       ////// {
       //////     DropDownList1.Items.Add(col.ColumnName);
       //////         DropDownList1.DataTextField="VoterId";
       //////     DropDownList1.DataBind();
       ////// }
        //cmd = new SqlCommand("select VoterId from voterRegistration", con);
        //dr = cmd.ExecuteReader();
        //DropDownList3.DataSource = dr;
        //DropDownList3.DataTextField = "VoterId";
        //DropDownList3.DataBind();
        //dr.Close();

    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            da = new SqlDataAdapter("insert into Vote values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + DropDownList2.SelectedItem.ToString() + "')", con);
            da.SelectCommand.ExecuteNonQuery();
            Label2.Text = DropDownList2.SelectedItem.ToString();
            if (Label2.Text == "Congress")
            {
              c= c+1;
             
            }
            else if (Label2.Text == "bjp")
            {
              b=  b+1;
            }
            else if (Label2.Text == "Tdp")
            {
               t= t+1;
            }
            else if (Label2.Text == "prp")
            {
               p= p+1;
            }
            else if (Label2.Text == "trs") 
            {
              trs=  trs+1;
            }
            //da = new SqlDataAdapter("update Partyvote set Cong='+c+',Bjp='+b+',Tdp='+t+',Prp='+p+',Trs='+trs+' where ID='1')", con);
            //da.SelectCommand.ExecuteNonQuery();
        }
        catch(Exception )
            {
                Label3.Visible = true;
                Label3.Text=" ur voting is not saved";
            }
        try
        {
            int i = 1;
            da = new SqlDataAdapter("update Partyvote set Cong='" + c + "',Bjp='" + b + "',Tdp='" + t + "',Prp='" + p + "',Trs='" + trs + "' where ID='"+i+"'", con);
            da.SelectCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Label3.Visible = true;
            Label3.Text = "Ur voting is already completed";
        }
    }
   
}
