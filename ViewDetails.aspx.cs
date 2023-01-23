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

public partial class ViewDetails : System.Web.UI.Page
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
            getDetail();
        }
           
     
        
    }

    public void getDetail()
    {
        cn.Open();
        da = new SqlDataAdapter("Select*from Studentreg order by id Desc",cn);

        DataTable dt = new DataTable();

        da.Fill(dt);
        if (dt.Rows.Count == 0)
        {
            rptProduct.Visible = false;
        }
        else
        {
            rptProduct.Visible = true;
            rptProduct.DataSource = dt;
            rptProduct.DataBind();

        }
        cn.Close();
    }

}