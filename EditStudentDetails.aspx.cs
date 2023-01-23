using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;

public partial class EditStudentDetails : System.Web.UI.Page
{
    string fileName_n;
    SqlConnection cn = new SqlConnection("data source=MISBAH\\SQLEXPRESS;initial catalog=my_1st_Project;integrated security=true;");
    SqlCommand com = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HiddenField1.Value = Request.QueryString["id"];
            bind();
        }
       
    }

    public void bind()
    {
        string query = "select*from Studentreg where id='" + HiddenField1.Value + "'";
           
           SqlCommand cmd=new SqlCommand(query,cn);

           SqlDataAdapter mcom= new SqlDataAdapter(cmd);
           DataTable dt=new DataTable();
           mcom.Fill(dt);
           if(dt.Rows.Count > 0)
           {
               txtcourse.Text = dt.Rows[0]["Course"].ToString();
               txttotalfee.Text = dt.Rows[0]["TotalFee"].ToString();
               Label1.Text = dt.Rows[0]["Picture"].ToString();
               HiddenField1.Value = dt.Rows[0]["Id"].ToString();
               txtapplicationno.Text = dt.Rows[0]["ApplicationNo"].ToString();
               txtname.Text = dt.Rows[0]["Name"].ToString();
               txtfathername.Text = dt.Rows[0]["FatherName"].ToString();
               txtdob.Text = dt.Rows[0]["DOB"].ToString();
               ddlgender.Text = dt.Rows[0]["Gender"].ToString();
               ddloccupation.Text = dt.Rows[0]["FatherOccupation"].ToString();
               txtaddress.Text = dt.Rows[0]["Address"].ToString();
               txtstate.Text = dt.Rows[0]["State"].ToString();
               txtemailid.Text = dt.Rows[0]["EmailId"].ToString();
               txtcity.Text = dt.Rows[0]["City"].ToString();
               txtpincode.Text = dt.Rows[0]["Pincode"].ToString();
               txtmobileno.Text = dt.Rows[0]["Mobileno"].ToString();
           }

          
    }

    public string UploadRC1()
    {
        string s = "./productpic/";
        DateTime dtNow = DateTime.Now;
        Random r = new Random();
        string n = r.Next(1, 1000).ToString();
        string path = s;
        HttpFileCollection uploadFileCol = Request.Files;
        HttpPostedFile file = uploadFileCol[0];
        string fileExt = Path.GetExtension(file.FileName);
        string fileName = n + Path.GetFileName(file.FileName);
        file.SaveAs(Server.MapPath("./productpic/") + fileName);
        fileName_n = ("/productpic/") + fileName;
        return fileName_n;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string PP = Label1.Text;
        if (FileUpload1.HasFile == true)
        {
            PP = UploadRC1();
        }
        string sql = "Update Studentreg set Name=@Name,FatherName=@FatherName,DOB=@DOB,Gender=@Gender,Address=@Address,State=@State,City=@City,Pincode=@Pincode,Mobileno=@Mobileno,EmailId=@EmailId,FatherOccupation=@FatherOccupation,Course=@Course,TotalFee=@TotalFee,Picture=@Picture where Id='" + HiddenField1.Value + "'";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@Id", HiddenField1.Value);
        cmd.Parameters.AddWithValue("@Name", txtname.Text);
        cmd.Parameters.AddWithValue("@FatherName", txtfathername.Text);
        cmd.Parameters.AddWithValue("@DOB", txtdob.Text);
        cmd.Parameters.AddWithValue("@Gender", ddlgender.Text);
        cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
        cmd.Parameters.AddWithValue("@State", txtstate.Text);
        cmd.Parameters.AddWithValue("@City", txtcity.Text);
        cmd.Parameters.AddWithValue("@Pincode", txtpincode.Text);
        cmd.Parameters.AddWithValue("@Mobileno", txtmobileno.Text);
        cmd.Parameters.AddWithValue("@EmailId", txtemailid.Text);
        cmd.Parameters.AddWithValue("@FatherOccupation", ddloccupation.Text);
        cmd.Parameters.AddWithValue("@Course", txtcourse.Text);
        cmd.Parameters.AddWithValue("@TotalFee", txttotalfee.Text);
        cmd.Parameters.AddWithValue("@Picture", PP);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
        Response.Redirect("ViewDetails.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (HiddenField1.Value == "")
        {
            string strscript = "<script language='javascript'>alert('Please Enter ID')</script>";
            Page.RegisterStartupScript("popup", strscript);
        }
        else
        {
            cn.Open();

            string delete = "delete from Studentreg where id='"+HiddenField1.Value+"'";
            SqlCommand sc = new SqlCommand(delete,cn);
            sc.ExecuteNonQuery();
            cn.Close();
            Response.Redirect("ViewDetails.aspx");
        }
    }
}