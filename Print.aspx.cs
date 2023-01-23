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

public partial class Print : System.Web.UI.Page
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
            bind();
        }
    }
 

    public void bind()
    {

        string ProductId = Request.QueryString["id"];

        string query = "select * from  Studentfee where Id=@ProductId ";

        SqlCommand mcom = new SqlCommand(query, cn);
        mcom.Parameters.AddWithValue("@ProductId", ProductId);
        SqlDataAdapter mda = new SqlDataAdapter(mcom);
        DataTable dt = new DataTable();
        mda.Fill(dt);

        if (dt.Rows.Count > 0)
        {
            Label12.Text = dt.Rows[0]["ApplicationNo"].ToString();
            Label10.Text = dt.Rows[0]["Id"].ToString();


            Label1.Text = dt.Rows[0]["Name"].ToString();


            Label2.Text = dt.Rows[0]["Amount"].ToString();
            Label9.Text = dt.Rows[0]["Remarks"].ToString();
            //hfuserid.Value = dt.Rows[0]["Id"].ToString();
            Label3.Text = dt.Rows[0]["PaymentMode"].ToString();
            Label4.Text = dt.Rows[0]["InstallmentNo"].ToString();
            // Label5.Text = dt.Rows[0]["TotalFee"].ToString();
            Label6.Text = dt.Rows[0]["Regdate"].ToString();
            Label7.Text = dt.Rows[0]["Amount"].ToString();
            //Label8.Text = dt.Rows[0]["Balancefee"].ToString();
        }


    }
}