<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Print.aspx.cs" Inherits="Print" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0">
    <link rel="shortcut icon" type="image/x-icon" href="assets/img/favicon.ico">
    <title>Preclinic - Medical & Hospital - Bootstrap 4 Admin Template</title>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="assets/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="assets/css/font-awesome.min.css">
    <link rel="stylesheet" type="text/css" href="assets/css/style.css">
    <!--[if lt IE 9]>
		<script src="assets/js/html5shiv.min.js"></script>
		<script src="assets/js/respond.min.js"></script>
	<![endif]-->
</head>
<body>
    <form id="form1" runat="server">
<div class="page-wrapper">
            <div class="content">
                <div class="row">
                    <%--<div class="col-md-6 col-sm-6 col-lg-6 col-xl-3">
                        <div class="dash-widget">
							<span class="dash-widget-bg1"><i class="fa fa-stethoscope" aria-hidden="true"></i></span>
							<div class="dash-widget-info text-right">
								<h3>98</h3>
								<span class="widget-title1">Doctors <i class="fa fa-check" aria-hidden="true"></i></span>
							</div>
                        </div>
                    </div>--%>
                  
                </div>
				<div class="row">
					<div class="col-12 col-md-6 col-lg-6 col-xl-6">
						<div class="card">
							<div class="card-body">
								<div class="chart-title">
							    <br /> <br />
                                        <table  align=center style="border: medium solid #333333">
            
           
            <tr>
                <td width="700" style="width: 1000px; text-align: center" class="style1">
                    <img src="logopa.jfif"  style="width:150px;"/>				
</td>
            </tr>
            
           
            <tr>
                <td height="2px">
                    <hr style="border-bottom-color:#3333ff; height:2px" /></td>
            </tr>
            <tr>
                <td style="font-size:16pt; padding:10px">
                <table style="width:100%">
                     <tr>
                     <td> S.No: <b><asp:Label ID="Label10" runat="server"></asp:Label></b>
                      
                     </td>
                     <td style="text-align:right">ApplicationNo: <b><asp:Label ID="Label12" runat="server"></asp:Label></b>
                    </td>
                         
                    </tr>
                     </table>
                <br />
                    Received From Mr./Mrs./Ms/&nbsp;&nbsp &nbsp;&nbsp <b><asp:Label ID="Label1" runat="server"></asp:Label>
                    </b>&nbsp;&nbsp&nbsp;&nbsp an Amount of <b>Rs. &nbsp;&nbsp&nbsp;&nbsp<asp:Label ID="Label2" runat="server"></asp:Label>&nbsp;&nbsp&nbsp;&nbsp</b> 
                    Only vide &nbsp;&nbsp <b><asp:Label ID="Label3" runat="server"></asp:Label><br /></b> on Date <b><asp:Label ID="Label6" runat="server"></asp:Label></b>
                    <br /><br />
                     <table style="width:100%">
                     <tr>
                     <td> <%--Total Fee: <b>Rs.<asp:Label ID="Label5" runat="server"></asp:Label></b>
                      <br /><br />
                    Balance Fee: <b>Rs.<asp:Label ID="Label8" runat="server"></asp:Label></b>--%>
                    Received Fee: <b>Rs.<asp:Label ID="Label7" runat="server"></asp:Label>
                     </td>
                     <td></b>
                   
                    Installment No: <b><asp:Label ID="Label4" runat="server"></asp:Label></b></td></tr>
                     </table>
                   
                    
                    <br />
                  
                    <table style="width:100%">
                    <tr>
                    <td>Remarks : <b><asp:Label ID="Label9" runat="server"></asp:Label></b></td>
                    <td style="text-align:center">Seal</td>
                    <td style="text-align:right">Authorised Signatory</td>
                    </tr></table>
                    <br />
                    <b>All Fees Includes GST.</b>
                    


                </td>
            </tr>
           
            
           
             
           
            
            </table>


             <p style="text-align:center; font-size:16pt">Fees Ones Paid is no-refundable. Pay by 10th to avoid penalty @ Rs.20/-Per day.<br />
          NITS Computer Hub, Opp. S.D. Girls Collage, Backside Petrol Pump, Hansi (Hisar)</p>
            <p style="text-align:center">
            <button onclick="myFunction()">Print Bill</button></p>

<script>
    function myFunction() {
        window.print();
    }
</script>

								</div>	
								 
							</div>
						</div>
					</div>
				 
				</div>
				 
            </div>
          
        </div>
    
  <div class="sidebar-overlay" data-reff=""></div>
    <script src="assets/js/jquery-3.2.1.min.js"></script>
	<script src="assets/js/popper.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="assets/js/jquery.slimscroll.js"></script>
    <script src="assets/js/Chart.bundle.js"></script>
    <script src="assets/js/chart.js"></script>
    <script src="assets/js/app.js"></script>
    </form>
</body>
</html>
