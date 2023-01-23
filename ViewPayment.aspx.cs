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

public partial class ViewPayment : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("data source=MISBAH\\SQLEXPRESS;initial catalog=my_1st_Project;integrated security=true;");
    SqlCommand com = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            getdetails();
        }
        else {
            getdetails1();
        }
      
    }

    public void getdetails()
    {
        cn.Open();

        string sql="select*from Studentfee order by id desc";
        SqlDataAdapter cmd = new SqlDataAdapter(sql,cn);

        DataTable dt = new DataTable();
        cmd.Fill(dt);
        if (dt.Rows.Count == 0)
        {
            rptProduct.Visible = false;
        }
        else {
            rptProduct.Visible = true;
            rptProduct.DataSource = dt;
            rptProduct.DataBind();
        }
        cn.Close();

    }

    public void getdetails1()
    {
        cn.Open();

        string sql = "select*from Studentfee where Regdate '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000") + "' and '"+DateTime.Now.ToString("yyyy-MM-dd 23:59:59.000")+"' order by id Desc";
        SqlDataAdapter ad = new SqlDataAdapter(sql,cn);

        DataTable dt = new DataTable();
        ad.Fill(dt);
        if (dt.Rows.Count == 0) 
        {
            rptProduct.Visible = false;


        }
        else{
         rptProduct.Visible = true;
        rptProduct.DataSource = dt;
        rptProduct.DataBind();
        }
        cn.Close();


    }
  
}