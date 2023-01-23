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

public partial class FeeSubmit : System.Web.UI.Page
{
    //string fileName_n;
    SqlConnection cn = new SqlConnection("data source=MISBAH\\SQLEXPRESS;initial catalog=my_1st_Project;integrated security=true;");
    SqlCommand com = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtapplicationno_TextChanged(object sender, EventArgs e) 
    {
        if (txtapplicationno.Text != "")
        {
            bind();
        }
    }

    public void bind()
    {
        string ProductId = txtapplicationno.Text;

        string query = "select*from Studentreg where ApplicationNo=@ProductId";

        SqlCommand cmd = new SqlCommand(query,cn);
        cmd.Parameters.AddWithValue("@ProductId", ProductId);
        SqlDataAdapter mda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        mda.Fill(dt);

        if (dt.Rows.Count > 0)
        {
            txtname.Text = dt.Rows[0]["Name"].ToString();
            txtfathername.Text = dt.Rows[0]["FatherName"].ToString();
            hdfcField.Value =dt.Rows[0]["id"].ToString();
            txttotalamt.Text = dt.Rows[0]["TotalFee"].ToString();
            txtreceivedamt.Text = dt.Rows[0]["Receivedfee"].ToString();
            txtbalanceamt.Text = dt.Rows[0]["Balancefee"].ToString();
            
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        decimal Totalfee = Convert.ToDecimal(txttotalamt.Text);
        decimal Ramt = Convert.ToDecimal(txtreceivedamt.Text);
        decimal balanceamt = Convert.ToDecimal(txtbalanceamt.Text);
        decimal paidamt = Convert.ToDecimal(txtamount.Text);
        decimal newreceivedamt = Ramt + paidamt;
        decimal newbalanceamt = Totalfee - newreceivedamt;
        string Recivedfee = newreceivedamt.ToString();
        string Balancefee = newbalanceamt.ToString();

        string insert = "insert into Studentfee(UserId,ApplicationNo,Name,Amount,PaymentMode,InstallmentNo,TotalFee,Receivedfee,Balancefee,Regdate,remarks)values(@UserId,@ApplicationNo,@Name,@Amount,@PaymentMode,@InstallmentNo,@TotalFee,@Receivedfee,@Balancefee,@Regdate,@remarks)";

        SqlCommand cmd = new SqlCommand(insert,cn);
        cmd.Parameters.AddWithValue("@remarks",txtremarks.Text);
        cmd.Parameters.AddWithValue("@UserId", hdfcField.Value);
        cmd.Parameters.AddWithValue("@ApplicationNo", txtapplicationno.Text);
        cmd.Parameters.AddWithValue("@Name",txtname.Text);
        cmd.Parameters.AddWithValue("@Amount",txtamount.Text);
        cmd.Parameters.AddWithValue("@PaymentMode",ddlpaymentmode.Text);
        cmd.Parameters.AddWithValue("@InstallmentNo", txtinstallment.Text);
        cmd.Parameters.AddWithValue("@TotalFee", txttotalamt.Text);
        cmd.Parameters.AddWithValue("@Receivedfee", Recivedfee);
        cmd.Parameters.AddWithValue("@Balancefee", Balancefee);
        cmd.Parameters.AddWithValue("@Regdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));

      
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();

       string aa=updatedetails(Recivedfee, Balancefee);
        Response.Redirect("FeeSubmit.aspx");
      
    }

     

    public string updatedetails(string Receivedfee, string Balancefee)
    {
        string sql = "Update Studentreg set  Receivedfee=@Receivedfee,Balancefee=@Balancefee Where id=@UserId and ApplicationNo=@ApplicationNo";
        SqlCommand cmd = new SqlCommand(sql,cn);
        cmd.Parameters.AddWithValue("@UserId", hdfcField.Value);
        cmd.Parameters.AddWithValue("@ApplicationNo", txtapplicationno.Text);
        cmd.Parameters.AddWithValue("@Receivedfee", Receivedfee);
        cmd.Parameters.AddWithValue("@Balancefee", Balancefee);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();

        return "1";
    }
}