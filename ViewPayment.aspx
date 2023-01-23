<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewPayment.aspx.cs" Inherits="ViewPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="page-wrapper">
            <div class="content">
                <div class="row">
                    <div class="col-sm-12">
                        <h4 class="page-title">Data Tables</h4>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-12">
                        <div class="card-box">
                            <div class="card-block">
                                <h6 class="card-title text-bold">View Detail</h6>
                                <p class="content-group">
                                    This is the most basic example of the datatables with zero configuration. Use the <code>.datatable</code> class to initialize datatables.
                                </p>
								<div class="table-responsive">
									<table class="datatable table table-stripped ">
                                    <thead>
                                        <tr>
                                            <th>#</th> 
                                            <th>ApplicationNo</th> 
                                            <th>Name</th> 
                                            <th>Amount</th> 
                                            <th>Payment Mode</th> 
                                            <th>BalanceFee</th> 
                                            <th>RegisterDate</th> 
                                            <th>Action</th> 
                                        </tr>
                                    </thead>
                                    <tbody>
                                      <asp:Repeater runat="server" ID="rptProduct">
                                      <ItemTemplate>
                                        <tr>
                                           <td><%# Eval("Id") %></td>
                                           <td><%# Eval("ApplicationNo")%></td>
                                           <td><%# Eval("Name")%></td>
                                           <td><%# Eval("Amount")%></td>
                                           <td><%# Eval("PaymentMode")%></td>
                                           <td><%# Eval("BalanceFee")%></td>
                                           <td><%# Eval("Regdate")%></td>
                                           <td><a href="Print.aspx?id=<%# Eval("Id") %>" class="btn btn-outline-primary take-btn" target="_blank">View</a></td>
                                           </tr>
                                     </ItemTemplate>
                                     </asp:Repeater>
                                     
                                    </tbody>
                                </table>
								</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           
        </div>
</asp:Content>

