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

public partial class Registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=ABC-PC;Initial Catalog=online;user id=sa;password=123");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    DataTable dt;
    string imgpath;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand();
        cmd.CommandText = ("select max(VoterId)+1 from voterregistration");
        cmd.Connection = con;
        TextBox8.Text = cmd.ExecuteScalar().ToString();
        //con.Close();
        Label5.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Upload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.PostedFile.ContentLength > 0 && FileUpload1.HasFile == true)
        {


            string filename = Guid.NewGuid().ToString().Substring(0, 10) + "" + FileUpload1.PostedFile.FileName.Remove(0, FileUpload1.PostedFile.FileName.LastIndexOf("."));


            FileUpload1.SaveAs(Server.MapPath("~/Photos/" + filename.ToString()));
            imgpath = "~/Photos/" + filename.ToString();            
            Image3.ImageUrl = "~/Photos/" + filename.ToString();
            Label5.Text = imgpath;

            //if (res == 1)
            //{
            //    GetArts(Convert.ToInt32(Session["uid"].ToString()));
            //}
        }
        else
        {
            Label3.Text = "To Upload Your Art is Compulsory.";
        }       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
     da=new SqlDataAdapter ("insert into voterRegistration(Utype,VoterId,VoterName,VoterFatherName,Children,Adults,Phone,Email,District,Constitution,Village,Pin,ElectionId,Rationcardtype,Age,Uname,Password,Photo,Status)values('"+DropDownList6.SelectedItem.ToString ()+"','"+TextBox8.Text+"','"+TextBox1.Text +"','"+TextBox2.Text +"','"+TextBox3 .Text +"','"+TextBox4 .Text +"','"+TextBox10 .Text +"','"+TextBox11 .Text +"','"+DropDownList3 .SelectedItem .ToString ()+"','"+DropDownList4 .SelectedItem .ToString ()+"','"+TextBox5 .Text +"','"+TextBox6 .Text +"','"+TextBox7 .Text +"','"+DropDownList5 .SelectedItem .ToString ()+"','"+TextBox9 .Text +"','"+TextBox12 .Text +"','"+TextBox13 .Text +"','"+Label5.Text +"','"+Label4.Text+"')",con);
     da.SelectCommand.ExecuteNonQuery();
     //dt = new DataTable();
     //da.Fill(dt);
     //da.Update(dt);
     //int uid = GetVoterId(TextBox9.Text);
     string Utype = DropDownList6.SelectedItem.ToString();
     Label5.Visible = true;
         if (Utype  == "Voter")
         {
             Label5.Text = "Your Voter Registration is successfully completed.";
             Response.Redirect("~/Home.aspx");
         }
         else if (Utype == "Officer")
         {
             Label5.Text = "Your Officer Registration is successfully completed.";
             Response.Redirect("~/Home.aspx");
         }
         else if (Utype == "Admin")
         {
             Label5.Text = "Your Admin Registration is successfully completed.";
             Response.Redirect("~/Home.aspx");
         }
     

    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select count(ElectionId) from election where ElectionId='" + TextBox7.Text + "' ", con);
        ds = new DataSet();
        da.Fill(ds, "election");

        if (ds.Tables["election"].Rows.Count == 1 && ds.Tables["election"].Rows[0][0].ToString() == "1")
        {
            Label6 .Text = "id is not Available.";
            Label6.BackColor = System.Drawing.Color.Red;
            TextBox7.Focus();
        }
        else
        {
            Label6.Text = "id is Available.";
            Label6.BackColor = System.Drawing.Color.Green;
            TextBox7.Focus();
        }

    }
}
