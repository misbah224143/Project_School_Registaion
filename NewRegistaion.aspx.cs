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

public partial class NewRegistaion : System.Web.UI.Page
{
    string fileName_n;
    SqlConnection cn = new SqlConnection("data source=MISBAH\\SQLEXPRESS;initial catalog=my_1st_Project;integrated security=true;");
    SqlCommand com = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

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
        string PP = "NA";
        if (FileUpload1.HasFile == true)
        {
            PP = UploadRC1();
        }
        string sql = "insert into Studentreg(ApplicationNo,Name,FatherName,DOB,Gender,Address,State,City,Pincode,Mobileno,EmailId,FatherOccupation,Course,TotalFee,Receivedfee,Balancefee,Picture,Regdate,Status)values(@ApplicationNo,@Name,@FatherName,@DOB,@Gender,@Address,@State,@City,@Pincode,@Mobileno,@EmailId,@FatherOccupation,@Course,@TotalFee,@Receivedfee,@Balancefee,@Picture,@Regdate,@Status)";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@ApplicationNo", txtapplicationno.Text);
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
        cmd.Parameters.AddWithValue("@TotalFee", txttotalfee. Text);
        cmd.Parameters.AddWithValue("@Receivedfee", "0.00");
        cmd.Parameters.AddWithValue("@Balancefee", txttotalfee.Text);
        cmd.Parameters.AddWithValue("@Picture", PP);
        cmd.Parameters.AddWithValue("@Status", "Active");
        cmd.Parameters.AddWithValue("@Regdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
        Response.Redirect("NewRegistaion.aspx");
    }
}